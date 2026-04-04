using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Data
{
    public class UserList
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public int phoneNumber { get; set; }
        [Required]
        public string address { get; set; }
    }
}

