using CoreAndFood.Models;

namespace CoreAndFood.Repositories
{	
	public class CategoryRepository
	{
		Context c = new Context();

		public List<Category> CategoryList()
		{
			return c.Categories.ToList();
		}
		public void CategoryAdd(Category ct)
		{
			c.Categories.Add(ct);
			c.SaveChanges();
		}
		public void CategoryRemove(Category ct)
		{
			c.Categories.Remove(ct);
			c.SaveChanges();
		}
		public void CategoryUpdate(Category ct)
		{
			c.Categories.Update(ct);
			c.SaveChanges();
		}
		public void getCategory(int id)
		{
			c.Categories.Find(id);
			c.SaveChanges();
		}
	}
}
