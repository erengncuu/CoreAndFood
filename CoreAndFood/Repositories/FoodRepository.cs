using CoreAndFood.Models;

namespace CoreAndFood.Repositories
{
	public class FoodRepository
	{
		Context c = new Context();
		
		public void FoodAdd(Food f)
		{
			c.Foods.Add(f);
			c.SaveChanges();
		}
		public void FoodRemove(Food f)
		{
			c.Foods.Remove(f);
			c.SaveChanges();
		}
		public void FoodUpdate(Food f)
		{
			c.Foods.Update(f);
			c.SaveChanges();
		}
		public List<Food> FoodList()
		{
			return c.Foods.ToList();
		}
		public void GetFood(int id)
		{
			c.Foods.Find(id);
			c.SaveChanges();
		}
	}
}
