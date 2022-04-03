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
        public string FullName { get; set; }

        [DisplayName("Course")]
        public string StudCourse { get; set; }

        [DisplayName("Year")]
        public int StudYear { get; set; }

        [DisplayName("Section")]
        public string StudSection { get; set; }

    }
}
