using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Price { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
