using Core.Entities;
using Core.Utilities.Results;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {

        IResult Rental(Rental rental);
        IResult Return(Rental rental);
        IResult Delivery(Rental rental);

        //IDataResult<List<Rental>> RentalList( );

    }
}
