using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etities.Concrate
{
    public class Costomer:IEntity
    {
        public int Id { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int Age { get; set; }


    }
}
