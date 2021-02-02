using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPP.Models
{
    public class Course
    {
        //public Course()
        //{
        //    this.Students = new HashSet<Student>();
        //    this.Assignments = new HashSet<Assignment>();
        //}
        public int Id { get; set; }
        [Display(Name ="Course name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Assignment> Assignments { get; set; }
        public Teacher Teacher { get; set; }
    }
}
