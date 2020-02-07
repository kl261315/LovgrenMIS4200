using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using LovgrenMIS4200.Models;

namespace LovgrenMIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // add the SetInitializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, LovgrenMIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        // add this method - it will be used later

        // homework 2 
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<currentOwner> currentOwners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
            
        }
    }
    
}