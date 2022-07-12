using System.ComponentModel.DataAnnotations;

namespace AbdullahMvcAssignment.Models
{
    public class Login
    {
        [Key]
        public string uname { get; set; }
        public string upass { get; set; }
    }
}
