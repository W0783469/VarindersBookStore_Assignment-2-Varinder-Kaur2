﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarindersBook.DataAccess.Repository.IRepository;
using VarindersBook.DataAccess.Repository;
using VarindersBook.Models;

namespace VarindersBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public CategoryController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {

                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {

                return NotFound();
            }

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            //if (ModelState.IsValid)
            //{
                if (category.Id == 0)
                {

                    _unitOfWork.Category.Add(category);


                }
                else
                {
                    _unitOfWork.Category.update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            //}
            //return View(category);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {

            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }



        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = false, message = "Delete Successful" });

        }

        #endregion
    }
}
