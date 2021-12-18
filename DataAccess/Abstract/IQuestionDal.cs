using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IQuestionDal : IEntityRepository<Question>
    {
        List<QuestionDetailDTO> GetQuestionDetails();
    }
}
