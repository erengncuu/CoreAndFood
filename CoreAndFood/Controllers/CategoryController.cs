using CoreAndFood.Repositories;
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
	}
}
