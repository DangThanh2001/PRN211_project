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

        public List<Product> getALlProduct(string s)
        {
            context.PublishingHouses.ToList();
            if (string.IsNullOrEmpty(s))
                return context.Products.ToList();
            else
                return context.Products.Where(x => x.ProductName.ToLower().Contains(s.ToLower())
                || x.Publishing.Name.ToLower().Contains(s.ToLower())
                ).ToList();
        }

        public Product updateProduct(int id)
        {
            try
            {
                return context.Products.FirstOrDefault(x => x.ProductId == id);
            }
            catch
            {
                return null;
            }
        }

        public List<Category> viewCategoryByPro(int id)
        {
            context.PublishingHouses.ToList();
            context.Categories.ToList();
            try
            {
                List<ProductCategory> list1 = context.ProductCategories.Where(x => x.ProId == id).ToList();
                List<Category> list2 = new List<Category>();
                foreach (ProductCategory cat in list1)
                {
                    Category c = context.Categories.FirstOrDefault(x => x.CatId == cat.CatId);
                    list2.Add(c);
                }
                return list2;
            }
            catch
            {
                return null;
            }
        }

        public List<Product> searchByName(string par1)
        {
            context.Products.ToList();
            context.PublishingHouses.ToList();
            List<Product> a =
            context.Products.Where(x => x.ProductName.ToLower().Contains(par1.ToLower())).ToList();

            return a;
        }
    }
}
