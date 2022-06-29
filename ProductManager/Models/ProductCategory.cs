using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManager.Models
{
    public partial class ProductCategory
    {
        public int ProCatId { get; set; }
        public int ProId { get; set; }
        public int CatId { get; set; }

        public virtual Category Cat { get; set; }
        public virtual Product ProCat { get; set; }
    }
}
