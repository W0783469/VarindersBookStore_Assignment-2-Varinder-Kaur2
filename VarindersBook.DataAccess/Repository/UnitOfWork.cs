using System;
using System.Collections.Generic;
using System.Text;
using VarindersBook.DataAccess.Data;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.Models;

namespace VarindersBook.DataAccess.Repository
{
  public  class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
                
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        //public void Dispoase()
        //{

        //    _db.Dispose();
        //}

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {

            _db.SaveChanges();
        }

    }
}
