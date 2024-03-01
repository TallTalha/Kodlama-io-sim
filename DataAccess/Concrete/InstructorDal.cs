using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {   
        List<Instructor> _instructors;
        public InstructorDal()
        {
            //DB'ye eklenecek varsayılan bilgiler:
            Instructor instructor1 = new Instructor()
            {
                Id = 1,
                FirstName="Engin",
                LastName="Demiroğ",
                Introducing="Merhaba,..."

            };
            
            Instructor instructor2 = new Instructor()
            {
                Id = 2,
                FirstName = "Halit Enes",
                LastName = "Kalaycı",
                Introducing = "Ben,..."

            };
            //DB'ye erişim nesnesi yerine liste formatı kullandık
            _instructors = new List<Instructor> { instructor1, instructor2};
        }

        public void add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> getAll()
        {
            return _instructors;
        }

        public Instructor getById(int id)
        {
            Instructor existInstructor = _instructors.Find(x => x.Id == id);

            if (existInstructor is null) Console.WriteLine("Instructor Does Not Exist.");
 
            return existInstructor;
        }

        public void update(Instructor instructor)
        {
            Instructor existInstructor = _instructors.Find(x => x.Id == instructor.Id);
            if (existInstructor is null) 
            {
                Console.WriteLine("Instructor Does Not Exist.");
                return;
            }
            existInstructor.Introducing = instructor.Introducing;
            existInstructor.FirstName = instructor.FirstName;
            existInstructor.LastName = instructor.LastName;


        }
    }
}
