using CoreAndFood.Models;

namespace CoreAndFood.Repositories
{
	public class GenericRepository<T> where T : class,new()
	{
		Context c = new Context();

		public List<T> TList()
		{
			return c.Set<T>().ToList();
		}
		public void TAdd(T ct)
		{
			c.Set<T>().Add(ct);
			c.SaveChanges();
		}
		public void TRemove(T ct)
		{
			c.Set<T>().Remove(ct);
			c.SaveChanges();
		}
		public void TUpdate(T ct)
		{
			c.Set<T>().Update(ct);
			c.SaveChanges();
		}
		public void getT(int id)
		{
			c.Set<T>().Find(id);
			c.SaveChanges();
		}
	}
}
