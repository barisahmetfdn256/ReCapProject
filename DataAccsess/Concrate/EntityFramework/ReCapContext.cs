using Entities.Concrete;
using Etities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrate.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB;Database=ReCap;Trusted_Connection;true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Costomer> Costoemers { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
