using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        //Dependency Injection
        private ICourseDal _courseDal;

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void create(Course course)
        {
            _courseDal.create(course);
        }

        public void delete(Course course)
        {
            _courseDal.delete(course);
        }

        public List<Course> getAll()
        {
            return _courseDal.getAll(); 
        }

        public Course getById(int id)
        {
            return _courseDal.getById(id);
        }

        public void update(Course course)
        {
            _courseDal.update(course);
        }
    }
}
