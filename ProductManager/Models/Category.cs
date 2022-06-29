using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManager.Models
{
    public partial class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatNote { get; set; }
    }
}
