﻿using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			CategoryRepository categoryRepository = new CategoryRepository();
			return View(categoryRepository.TList());
		}
	}
}