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
            {
                s = s.Trim();
                return context.Products.Where(x => x.ProductName.ToLower().Contains(s.ToLower())
                || x.Publishing.Name.ToLower().Contains(s.ToLower())

                ).ToList();
            }
        }

        public List<Product> getPrdBystatus(int s)
        {
            context.PublishingHouses.ToList();

            if (s == 1 || s == 0)
                return
            context.Products.Where(x => x.Status == s).ToList();
            else
            {

                return context.Products.ToList();
            }
        }

        public Product viewProduct(int id)
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

        public List<PublishingHouse> showAllCompany(string par1)
        {
            context.Products.ToList();
            context.PublishingHouses.ToList();
            if (string.IsNullOrEmpty(par1))
                return context.PublishingHouses.ToList();
            else
            {
                par1 = par1.Trim();
                return context.PublishingHouses
                    .Where(x => x.Name.ToLower().Contains(par1.ToLower())
                    || x.Address.ToLower().Contains(par1.ToLower())
                    || x.Phone.ToLower().Contains(par1.ToLower())
                    || x.Url.ToLower().Contains(par1.ToLower())
                    ).ToList();
            }
        }

        public void changeStatus(int id)
        {
            Product p = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            if (p.Status == 0)
            {
                p.Status = 1;
            }
            else
            {
                p.Status = 0;
            }
            context.Products.Update(p);
            context.SaveChanges();
        }

        public void updateProduct(Product p)
        {
            int a = p.ProductId;
            int? b = p.Quantity;
            context.Products.Update(p);
            context.SaveChanges();
        }

        public PublishingHouse getCompany(int s)
        {
            try
            {
                return context.PublishingHouses.FirstOrDefault(x => x.PublisherId == s);
            }
            catch
            {
                return null;
            }
        }

        public void updateCom(PublishingHouse pub)
        {
            context.PublishingHouses.Update(pub);
            context.SaveChanges();
        }

        public bool isPhone(string s)
        {
            s = s.Trim();
            if (s.Length != 10)
                return false;
            if (context.PublishingHouses.FirstOrDefault(x => x.Phone.Equals(s)) is not null)
                return false;
            foreach(char a in s)
			{
				if (!char.IsDigit(a))
				{
                    return false;
                    break;
				}
			}
            return true;
        }

        public void addPro(Product pub)
        {
            context.Products.Add(pub);
            context.SaveChanges();
        }

        public Admin login(string u, string p)
		{
			try
			{
                return context.Admins.FirstOrDefault(x => x.UserName.Equals(u) && x.Password.Equals(p));
            }
			catch
			{
                return null;
			}
		}
    }
}
