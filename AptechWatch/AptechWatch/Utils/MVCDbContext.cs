using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using AptechWatch.Entity;

namespace AptechWatch.Utils
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext() : base("DefaultConnectionString")
        {
        }


        public DbSet<Brand> Brands { get; set; }
        public DbSet<Watch> Watches { get; set; }

        public DbSet<T> GetRightDbSet<T>() where T : BaseEntity
        {
            if (typeof(T) == typeof(Brand))
            {
                return Brands as DbSet<T>;
            }
            if (typeof(T) == typeof(Watch))
            {
                return Watches as DbSet<T>;
            }
            return null;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}