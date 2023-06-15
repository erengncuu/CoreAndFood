using CoreAndFood.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
	public class FoodController : Controller
	{
		Context c = new Context();
		FoodRepository foodRepository = new FoodRepository();
		public IActionResult Index(int page=1)
		{
			return View(foodRepository.TList("Category").ToPagedList(page,5));
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
		public IActionResult FoodDelete(int id)
		{
			foodRepository.TRemove(new Food { FoodId = id });
			return RedirectToAction("Index");
		}
		public IActionResult FoodGet(int id)
		{
			List<SelectListItem> values = (from y in c.Categories.ToList()
										   select new SelectListItem
										   {
											   Text = y.CategoryName,
											   Value = y.CategoryId.ToString()
										   }).ToList();
			ViewBag.V = values;

			var x = foodRepository.getT(id);
			
		Food f = new Food()
			{	
				FoodId = x.FoodId,
				CategoryId = x.CategoryId,
				Name = x.Name,
				Price = x.Price,
				Stock = x.Stock,
				Description = x.Description,
				ImageURL = x.ImageURL
			};
			return View(x);
		}
		public IActionResult FoodUpdate(Food f)
		{
			foodRepository.TUpdate(f);
			return RedirectToAction("Index");
		}

	}
}
