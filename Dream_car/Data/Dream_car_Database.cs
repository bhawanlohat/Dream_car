using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dream_car.Models;

namespace Dream_car.Data
{
    public class Dream_car_Database : DbContext
    {
        public Dream_car_Database(DbContextOptions<Dream_car_Database> options)
            : base(options)
        {
        }

        public DbSet<Dream_car.Models.Company> Company { get; set; }

        public DbSet<Dream_car.Models.Dealer> Dealer { get; set; }

        public DbSet<Dream_car.Models.Model> Model { get; set; }

        public DbSet<Dream_car.Models.Specification> Specification { get; set; }
    }
}
