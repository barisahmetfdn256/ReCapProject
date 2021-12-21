using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etities.Concrate
{
    public class Motorcycle:IEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public int WeeklyPrice { get; set; }
        public int MotorPrice { get; set; }
        public string Color { get; set; }
        public string Location { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }
}
