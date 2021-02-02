using SchoolAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPP.Controllers.Services
{
    public class AssignCourse
    {
        private ApplicationDBContext _applicationDbContext;
        public AssignCourse(ApplicationDBContext _context)
        {
            _applicationDbContext = _context;
        }
        public Student Student { get; set; }
        public StudentCourse StudentCourse { get; set; }
        public Course Course { get; set; }

        public void AssignStudentToCourse(int studentId, int courseId)
        {
            Student=_applicationDbContext.Students.Find(studentId);
            Course = _applicationDbContext.Courses.Find(courseId);
            StudentCourse = new StudentCourse
            {
                StudentId = studentId,
                Student = Student,
                CourseId = courseId,
                Course = Course
            };
            _applicationDbContext.Add(StudentCourse);
            _applicationDbContext.SaveChanges();
        }
    }
}
