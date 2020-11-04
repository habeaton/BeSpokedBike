using BeSpokedBike.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BeSpokedBike.DAL
{
    public class BikeSaleContext : DbContext
    {
        public BikeSaleContext() : base("BikeSalesContext")
        {
            
        }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Salesperson> Salesperson { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Commission> Commision { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}