using CoreAndFood.Models;
using Microsoft.EntityFrameworkCore;

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
		public T getT(int id)
		{
			return c.Set<T>().Find(id);
		}
		public List<T> TList(String p)
		{
			return c.Set<T>().Include(p).ToList();
			
		}
	}
}
