using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewCRUD.Models;

namespace ViewCRUD.DAL
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Bookstore>
    {
        protected override void Seed(Bookstore context)
        {
            var Categoryts = new List<Category>
            {
                new Category{Name="hi",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Category{Name="hi1",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Category{Name="hi2",EnrollmentDate=DateTime.Parse("2003-09-01")}
            };

            Categoryts.ForEach(s => context.Categoryts.Add(s));
            context.SaveChanges();
            var Products = new List<Product>
            {
                new Product{Name="hello",Price=3},
                new Product{Name="hello1",Price=3},
                new Product{Name="hello2",Price=3},
            };
            Products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment { ProductID = 1, CategoryID = 1050, Grade = Grade.A },
                new Enrollment { ProductID = 1, CategoryID = 4022, Grade = Grade.C },
                new Enrollment {ProductID = 1, CategoryID = 4041, Grade = Grade.B },
                new Enrollment { ProductID = 2, CategoryID = 1045, Grade = Grade.B },
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}