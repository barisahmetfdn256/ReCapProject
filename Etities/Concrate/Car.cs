using Etities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etities.Concrate
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public string WeeklyPrice { get; set; }
        public string CarPrice { get; set; }
        public string Color { get; set; }
        public string Location { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }
}
