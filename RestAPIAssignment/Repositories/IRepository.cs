﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAssignment.Repositories
{
    interface IRepository<T> where T:class
    {
        List<T> GetAll();
        T GetCommentsByPostID(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
