using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ViewCRUD.Models;

namespace ViewCRUD.DAL
{
    public class Bookstore : DbContext
    {
        public Bookstore() : base("Bookstore")
        {
        }

        public DbSet<Category> Categoryts { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}