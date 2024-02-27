using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public decimal Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Category} Price = {Price} Count = {Count}";
        }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product {  Id = 1, Name = "Product 1",
                    Category = "Category 1", Count = 100, Price = 20 });
            products.Add(new Product
            {
                Id = 2,
                Name = "Product 2",
                Category = "Category 1",
                Count = 200,
                Price = 25
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Product 3",
                Category = "Category 1",
                Count = 300,
                Price = 80
            });
            products.Add(new Product
            {
                Id = 4,
                Name = "Product 4",
                Category = "Category 1",
                Count = 150,
                Price = 200
            });
            products.Add(new Product
            {
                Id = 5,
                Name = "Product 5",
                Category = "Category 2",
                Count = 110,
                Price = 210
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Product 6",
                Category = "Category 2",
                Count = 500,
                Price = 320
            });
            products.Add(new Product
            {
                Id = 7,
                Name = "Product 7",
                Category = "Category 2",
                Count = 700,
                Price = 500
            });
            return products;
        }
    }
}
