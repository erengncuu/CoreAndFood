﻿using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Models;
namespace CoreAndFood.Controllers
{
	public class CategoryController : Controller
	{
		CategoryRepository categoryRepository = new CategoryRepository();
		public IActionResult Index()
		{	
			return View(categoryRepository.TList());
		}
		[HttpGet]
		public IActionResult CategoryAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CategoryAdd(Category cat)
		{
			if (!ModelState.IsValid)
			{
				return View("CategoryAdd");
			}
			categoryRepository.TAdd(cat);
			return RedirectToAction("Index");
		}
		public IActionResult CategoryGet(int id)
		{
			var x =categoryRepository.getT(id);
			Category ct = new Category()
			{
				CategoryName = x.CategoryName,
				CategoryDescription = x.CategoryDescription,
				CategoryId = x.CategoryId
			};
			return View(x);
		}
		[HttpPost]
		public IActionResult CategoryUpdate(Category ct)
		{	
			var x= categoryRepository.getT(ct.CategoryId);
			x.CategoryName = ct.CategoryName;
			x.CategoryDescription = ct.CategoryDescription;
			x.Status = true;
			categoryRepository.TUpdate(x);
			return RedirectToAction("Index");
		}
        public IActionResult CategoryDelete(int id)
		{
			var x = categoryRepository.getT(id);
			x.Status=false;
			categoryRepository.TUpdate(x);
			return RedirectToAction("Index");
		}

    }
}
