using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUniversity.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Student LRN")]
        public string StudLRN { get; set; }
        
        [DisplayName("Full Name")]
        [Required]
        public string FullName { get; set; }

        [DisplayName("Course")]
        [Required]
        public string StudCourse { get; set; }

        [DisplayName("Year")]
        [Required]
        public int StudYear { get; set; }

        [DisplayName("Section")]
        [Required]
        public string StudSection { get; set; }

    }
}
