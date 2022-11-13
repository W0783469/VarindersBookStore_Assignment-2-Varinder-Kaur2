﻿using System;
using System.Collections.Generic;
using System.Text;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.DataAccess.Repository;
using VarindersBook.Models;
using VarindersBook.DataAccess.Data;

namespace VarindersBook.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository :IRepository<Category>
    {
        void update(Category category);
        Category Get(object p);
    }
}
