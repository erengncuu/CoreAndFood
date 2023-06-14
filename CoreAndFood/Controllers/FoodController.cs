using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreAndFood.Controllers
{
	public class FoodController : Controller
	{
		Context c = new Context();
		FoodRepository foodRepository = new FoodRepository();
		public IActionResult Index()
		{		
			return View(foodRepository.TList("Category"));
		}
		[HttpGet]
        public IActionResult FoodAdd()
		{
			List<SelectListItem> values = (from x in c.Categories.ToList()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryId.ToString()
										   }).ToList();
			ViewBag.V = values;
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
