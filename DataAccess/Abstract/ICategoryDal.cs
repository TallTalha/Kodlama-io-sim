﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
     public interface ICategoryDal
    {
        public void create(Category category);
        public List<Category> getAll();
        public Category getById(int id);
        public void update(Category category);
        public void delete(Category category);
    }
}
