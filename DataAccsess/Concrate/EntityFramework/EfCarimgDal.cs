using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrate.EntityFramework
{
    public class EfCarimgDal: EfEntityRepositoryBase<Carimg, ReCapContext>, ICarimgDal
    {
    }
}
