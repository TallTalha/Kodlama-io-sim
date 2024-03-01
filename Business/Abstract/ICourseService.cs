using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        public void create(Course course);
        public List<Course> getAll();
        public Course getById(int id);
        public void update(Course course);
        public void delete(Course course);
    }
}
