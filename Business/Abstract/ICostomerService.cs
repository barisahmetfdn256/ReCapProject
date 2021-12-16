using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICostomerService
    {
        List<Costomer> GetAll();

        void Add(Costomer entity);

        void Update(Costomer entity);

        void Delete(Costomer entity);

        List<Costomer> GetById(int id);

    }
}
