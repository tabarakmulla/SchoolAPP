using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPP.Models
{
    public class Student
    {
        //public Student()
        //{
        //    this.Courses = new HashSet<Course>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }        
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
