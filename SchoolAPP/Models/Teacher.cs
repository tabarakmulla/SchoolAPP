using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPP.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("Course")]
        //public int CourseId { get; set; }
        [Display(Name="Teacher Name")]
        public string Name { get; set; }
        public Course Course { get; set; }
    }
}
