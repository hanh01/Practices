using System.Net.Http.Headers;
using System.Security.Policy;

namespace ViewCRUD.Models
{
    public enum Grade
    {
        A, B, C, D
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
        public Grade Grade { get; internal set; }
    }
}