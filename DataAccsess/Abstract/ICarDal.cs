using Core.DataAccess;
using Etities.Concrate;
using Etities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetail();
    }
}
