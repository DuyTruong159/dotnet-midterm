using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _200574824.Models
{
    public class Student
    {
        [Key]
        public int StudenId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
    }
}
