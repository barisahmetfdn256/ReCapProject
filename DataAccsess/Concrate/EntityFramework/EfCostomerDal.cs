using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using Etities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrate.EntityFramework
{
    public class EfCostomerDal : EfEntityRepositoryBase<Costomer, ReCapContext>, ICostomerDal
    {
      
    }
}
