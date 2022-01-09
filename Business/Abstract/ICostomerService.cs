using Core.Utilities.Results;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICostomerService
    {
        IDataResult<List<Costomer>> GetAll();

        IResult Add(Costomer entity);

        IResult Update(Costomer entity);

        IResult Delete(Costomer entity);

        IDataResult<Costomer> GetById(int id);


    }
}
