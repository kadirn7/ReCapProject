using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Framework
{
    internal class Rent_A_CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Rent_A_Car;Trusted_Connection=true");
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Colors>  Colors { get; set; }
    }
}
