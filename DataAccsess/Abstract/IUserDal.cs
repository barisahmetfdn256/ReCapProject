using Core.DataAccess;
using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
        List<OperationClaim> GetClaim(User user);
    }
}
