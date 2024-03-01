using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            //DB'ye eklenecek varsayılan bilgiler:
            Course course1 = new Course()
            {
                Id = 1,
                Name = "JavaScript",
                CategoryId = 1,
                Description = "Web programlama öğrnenin.",
                InstructorId = 1,
                Price = 100  
            };
            Course course2 = new Course()
            {
                Id = 2,
                Name = "C#",
                CategoryId = 2,
                Description = ".Net backend geliştirme.",
                InstructorId = 1,
                Price = 200


            };
            Course course3 = new Course()
            {
                Id = 3,
                Name = "Python",
                CategoryId = 2,
                Description = "Python backend geliştirme.",
                InstructorId = 2,
                Price = 300


            };
            //DB'ye erişim nesnesi yerine liste formatı kullandık
            _courses = new List<Course> { course1, course2, course3 };
        }
        public void create(Course course)
        {
            _courses.Add(course);
        }

        public void delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> getAll()
        {
            return _courses;
        }

        public Course getById(int id)
        {

            Course existCourse = _courses.Find(x => x.Id == id);

            if (existCourse is null) Console.WriteLine("Course Does Not Exist.");

            return existCourse;
        }

        public void update(Course course)
        {
            Course existCourse = _courses.Find(match: x => x.Id == course.Id);
            if (existCourse is null) 
            {
                Console.WriteLine("Course Does Not Exist.");
                return;
            }
            
            existCourse.Name = course.Name;
            existCourse.Description = course.Description;
            existCourse.Price = course.Price;
            existCourse.CategoryId = course.CategoryId;
        }
    }
}
