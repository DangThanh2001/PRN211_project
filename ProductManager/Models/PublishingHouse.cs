using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManager.Models
{
    public partial class PublishingHouse
    {
        public PublishingHouse()
        {
            Products = new HashSet<Product>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
