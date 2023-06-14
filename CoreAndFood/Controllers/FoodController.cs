using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
	public class FoodController : Controller
	{
		FoodRepository foodRepository = new FoodRepository();
		public IActionResult Index()
		{		
			return View(foodRepository.TList("Category"));
		}
		[HttpGet]
        public IActionResult FoodAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult FoodAdd(Food f)
		{
			foodRepository.TAdd(f);
			return RedirectToAction("Index");
		}
    }
}
