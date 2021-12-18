using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryQuestionDal : IQuestionDal
    {
        List<Question> _questions;
        public InMemoryQuestionDal()
        {
            _questions = new List<Question> { 
                new Question{Id=1,Title="Soru1", Content="Bu nasıl oldu", LikeCount=5},
                new Question{Id=2,Title="Soru2", Content="Bu böyle iyi mi oldu", LikeCount=7},
                new Question{Id=3,Title="Soru3", Content="Bu kötü mü oldu", LikeCount=3},
            };
        }
        public void Add(Question question)
        {
            _questions.Add(question);
        }

        public void Delete(Question question)
        {
            Question questionToDelete = _questions.SingleOrDefault(q => q.Id == question.Id);
            _questions.Remove(questionToDelete);
        }

        public Question Get()
        {
            throw new NotImplementedException();
        }

        public Question Get(Expression<Func<Question, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            return _questions;
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetByQuestionId(int questionId)
        {
            return _questions.Where(q => q.Id == questionId).ToList();
        }

        public List<QuestionDetailDTO> GetQuestionDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Question question)
        {
            Question questionToUpdate = _questions.SingleOrDefault(q => q.Id == question.Id);
            questionToUpdate.Title = question.Title;
        }
    }
}
