using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            //DB'ye eklenecek varsayılan bilgiler:
            Category category1 = new()
            {
                Id = 1,
                Name = "Web"
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Backend"
            };

            //DB'ye erişim nesnesi yerine liste formatı kullandık
            _categories = new List<Category> { category1, category2 };
        }
        public void create(Category category)
        {
            _categories.Add(category);
        }

        public void delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> getAll()
        {
            return _categories;
        }

        public Category getById(int id)
        {

            Category existCategory = _categories.Find(x => x.Id == id);

            if (existCategory is null) Console.WriteLine("Category Does Not Exist.");

            return existCategory;
        }

        public void update(Category category)
        {
            Category existCategory = _categories.Find(match: x => x.Id == category.Id);
            if (existCategory is null)
            {
                Console.WriteLine("Category Does Not Exist.");
                return;
            }
            existCategory.Name = category.Name;
        }
    }
}
