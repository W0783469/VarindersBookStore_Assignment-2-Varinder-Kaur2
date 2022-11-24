using System;
using System.Collections.Generic;
using System.Text;
using VarindersBook.DataAccess.Data;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.Models;

namespace VarindersBook.DataAccess.Repository
{
  public  class IUnitOfWork : IRepository.IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IUnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);

        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
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
