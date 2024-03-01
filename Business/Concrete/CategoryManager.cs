using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {   
        //Dependency Injection
        private  ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }
        public void create(Category category)
        {
            _categoryDal.create(category);
        }

        public void delete(Category category)
        {
            _categoryDal.delete(category);
        }

        public List<Category> getAll()
        {
            return _categoryDal.getAll();
        }

        public Category getById(int id)
        {
            return _categoryDal.getById(id);
        }

        public void update(Category category)
        {
            _categoryDal.update(category);
        }
    }
}
