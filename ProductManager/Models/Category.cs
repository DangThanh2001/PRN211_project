using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManager.Models
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatNote { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
