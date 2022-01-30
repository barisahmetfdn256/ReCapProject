using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccsess.Concrate.EntityFramework;
using DataAccsess.Abstract;

namespace DataAccess.Cocrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<OperationClaim> GetClaim(User user)
        {
            using (var context = new ReCapContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id,Name=operationClaim.Name };
                return result.ToList();
            }
        }

       
        }
    }
