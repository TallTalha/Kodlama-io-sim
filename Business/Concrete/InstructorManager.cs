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
    public class InstructorManager : IInstructorService
    {
        //Dependency Injection
        private  IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
                _instructorDal = instructorDal;
        }

        public void add(Instructor instructor)
        {
            _instructorDal.add(instructor);    
        }

        public void delete(Instructor instructor)
        {
            _instructorDal.delete(instructor);
        }

        public List<Instructor> getAll()
        {
            return _instructorDal.getAll();
        }

        public Instructor getById(int id)
        {
            return _instructorDal.getById(id);
        }

        public void update(Instructor instructor)
        {
           _instructorDal.update(instructor);
        }
    }
}
