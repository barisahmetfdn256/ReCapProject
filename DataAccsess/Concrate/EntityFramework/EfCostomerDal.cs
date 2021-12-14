using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrate.EntityFramework
{
    public class EfCostomerDal : ICostomerDal
    {
        public void Add(Costomer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Costomer entity)
        {
            throw new NotImplementedException();
        }

        public Costomer Get(Expression<Func<Costomer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Costomer> GetALL(Expression<Func<Costomer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Costomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
