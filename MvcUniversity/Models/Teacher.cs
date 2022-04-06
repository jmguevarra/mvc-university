using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcUniversity.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Full Name")]
        [Required]
        public string Fullname { get; set; }

        [DisplayName("Current Address")]
        [Required]
        public string Address { get; set; }

        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public string Birthday { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string Level { get; set; }

        [DisplayName("Profile Picture")]
        [Required]
        public string ProfileImage { get; set; }
    }
}
