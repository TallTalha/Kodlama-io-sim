﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        public void add(Instructor instructor);
        public List<Instructor> getAll();
        public Instructor getById(int id);
        public void update(Instructor instructor);
        public void delete(Instructor instructor);
    }
}
