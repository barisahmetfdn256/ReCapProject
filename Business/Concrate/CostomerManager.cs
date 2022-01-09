using Business.Abstract;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CostomerManager : ICostomerService

    {
        ICostomerDal _costomerDal;
        public CostomerManager(ICostomerDal costomerDal)
        {
            _costomerDal = costomerDal;
        }
        public void Add(Costomer entity)
        {
            _costomerDal.Add(entity);
        }

        public void Delete(Costomer entity)
        {
            _costomerDal.Delete(entity);
        }

        public List<Costomer> GetAll()
        {
            return _costomerDal.GetAll();
        }


        public List<Costomer> GetById(int id)
        {
            return _costomerDal.GetAll(p=>p.Id==id);
        }

        public void Update(Costomer entity)
        {
            _costomerDal.Update(entity);
        }

        IResult ICostomerService.Add(Costomer entity)
        {
            throw new NotImplementedException();
        }

        IResult ICostomerService.Delete(Costomer entity)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Costomer>> ICostomerService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Costomer> ICostomerService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IResult ICostomerService.Update(Costomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
