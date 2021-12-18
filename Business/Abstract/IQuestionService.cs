using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetAll();
        
        IDataResult<List<QuestionDetailDTO>> GetQuestionDetails();
        IDataResult<Question> GetById(int questionId);
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
    }
}
