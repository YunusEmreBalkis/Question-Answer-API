using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, QAContext>, IQuestionDal
    {
        public List<QuestionDetailDTO> GetQuestionDetails()
        {
            using (QAContext context = new QAContext())
            {
                var result = from q in context.Questions
                             join a in context.Answers
                             on q.Id equals a.QuestionId
                             select new QuestionDetailDTO
                             {
                                 QuestionId = q.Id,
                                 Content = a.Content,
                                 Title = q.Title
                             };
                return result.ToList();

            }
        }
    }
}
