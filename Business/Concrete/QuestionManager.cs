using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Apects.Autofac.Caching;
using Core.Apects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        [ValidationAspect(typeof(QuestionValidator))]
        [CacheRemoveAspect("IQuestionService.GetAll")]
        public IResult Add(Question question)
        {
            

            _questionDal.Add(question);
            return new SuccessResult(Messages.QuestionAdded);
        }

        [CacheRemoveAspect("IQuestionService.Get")]
        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult(Messages.QuestionUpdated);
        }
        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult(Messages.QuestionDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Question>> GetAll()
        {
            //if (DateTime.Now.Hour==10)
            //{
            //    return new ErrorDataResult<List<Question>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(),Messages.QuestionListed);
        }


        public IDataResult<Question>GetById(int questionId)
        {
            return new SuccessDataResult<Question>( _questionDal.Get(q => q.Id == questionId));
        }

        public IDataResult<List<QuestionDetailDTO>> GetQuestionDetails()
        {
            if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<QuestionDetailDTO>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<QuestionDetailDTO>>(_questionDal.GetQuestionDetails());
        }
    }
}
