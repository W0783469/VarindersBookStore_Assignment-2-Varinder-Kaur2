using System;
using System.Collections.Generic;
using System.Text;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.DataAccess.Repository;
using VarindersBook.Models;
using VarindersBook.DataAccess.Data;
using System.Linq;
using System.Linq.Expressions;

namespace VarindersBook.DataAccess.Repository
{
   public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) :base(db)
        {


            _db = db;
        }

        public Category Get(object p)
        {
            throw new NotImplementedException();
        }

        public void update(Category category)
        {

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {

                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }
    }
}
