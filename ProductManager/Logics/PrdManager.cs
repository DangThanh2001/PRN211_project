using ProductManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Logics
{
	public class PrdManager
	{
		PRN_projectContext context;

		public PrdManager()
		{
			context = new PRN_projectContext();
		}

		public List<Product> getALlProduct()
		{
			context.PublishingHouses.ToList();
			return context.Products.ToList();
		}
	}
}
