using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewCRUD.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}