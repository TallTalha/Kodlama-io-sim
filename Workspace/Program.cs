
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Security.Cryptography;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            CourseManager courseManager1 = new CourseManager(new CourseDal() );
            List<Course> courses1 = courseManager1.getAll();

            CategoryManager categoryManager1 = new CategoryManager(new CategoryDal());
            List<Category> categories1 = categoryManager1.getAll();

            InstructorManager instructorManager1 = new InstructorManager(new InstructorDal());
            List<Instructor> instructors1 = instructorManager1.getAll();

            for (int i = 0; i < courses1.Count; i++) 
            {
                Category category = categories1.Find(x => x.Id == courses1[i].CategoryId );
                
                Instructor instructor = instructors1.Find(x => x.Id == courses1[i].InstructorId); 
                
                Console.WriteLine("\n" + (i+1) +".kurs adı: "+courses1[i].Name + "\nKategorisi: " + category.Name + "\nEğitmeni: " + instructor.FirstName + " " + instructor.LastName );
            }


        }

    }
}
