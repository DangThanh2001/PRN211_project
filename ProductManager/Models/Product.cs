using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManager.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public double? OriginalPrice { get; set; }
        public double? SellPrice { get; set; }
        public byte? Status { get; set; }
        public string Notes { get; set; }
        public DateTime? ImportDate { get; set; }
        public int? CatId { get; set; }
        public int PublisherId { get; set; }

        public virtual PublishingHouse Publisher { get; set; }
    }
}
