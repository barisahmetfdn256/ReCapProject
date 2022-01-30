using Core.Entities.Concrate;
using System.Collections.Generic;

namespace Core.Utilites.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
