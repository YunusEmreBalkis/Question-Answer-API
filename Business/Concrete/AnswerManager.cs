using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Apects.Autofac.Caching;
using Core.Apects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        IQuestionService _questionService;
        public AnswerManager(IAnswerDal answerDal, IQuestionService questionService)
        {
            _answerDal = answerDal;
            _questionService = questionService;
        }

        [CacheAspect]
        public IDataResult<List<Answer>> GetAll()
        {
           return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(), Messages.AnswerListed);
        }

        public IDataResult<List<Answer>> GetAllByQuestionId(int id)
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(a => a.QuestionId == id));
        }

        [ValidationAspect(typeof(AnswerValidator))]
        public IResult Add(Answer answer)
        {
            IResult result = BusinessRules.Run(CheckIfQuestionExists(answer.QuestionId));
            if (result != null)
            {
                return result;
            }
            _answerDal.Add(answer);
            return new SuccessResult(Messages.AnswerAdded);
        }
        public IResult Update(Answer answer)
        {
            _answerDal.Update(answer);
            return new SuccessResult(Messages.AnswerUpdated);
        }
        public IResult Delete(Answer answer)
        {
            _answerDal.Delete(answer);
            return new SuccessResult(Messages.AnswerDeleted);
        }

        private IResult CheckIfQuestionExists(int questionId)
        {
            var result = _questionService.GetById(questionId);
            if (result == null)
            {
                return new ErrorResult(Messages.QuestionNotFound);
            }

            return new SuccessResult();
        }
    }
}
