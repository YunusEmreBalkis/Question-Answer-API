using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal : EfEntityRepositoryBase<Answer, QAContext>, IAnswerDal
    {
      
    }
}
