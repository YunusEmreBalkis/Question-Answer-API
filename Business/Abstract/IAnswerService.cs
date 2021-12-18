using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<List<Answer>> GetAllByQuestionId(int id);
        IResult Add(Answer answer);
        IResult Update(Answer answer);
        IResult Delete(Answer answer);
    }
}
