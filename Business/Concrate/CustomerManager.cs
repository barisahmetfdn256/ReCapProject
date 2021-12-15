using Business.Abstract;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICostomerDal _costomerDal;
        public CustomerManager(ICostomerDal costomerDal)
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
            return _costomerDal.GetALL();
        }


        public List<Costomer> GetById(int id)
        {
            return _costomerDal.GetALL(p=>p.CustomerID==id);
        }

        public void Update(Costomer entity)
        {
            _costomerDal.Update(entity);
        }
    }
}
