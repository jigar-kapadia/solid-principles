using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    public class Product
    {
        public Product()
        {
            Products = new List<Product>();
            //Products.Add(new Product() { Id = 1, Name = "Iphone 6", Price = 199, Brand = "Apple", Type = "Mobile", Color = "Black" });
            //Products.Add(new Product() { Id = 2, Name = "Iphone 7", Price = 229, Brand = "Apple", Type = "Mobile", Color = "Silver" });
            //Products.Add(new Product() { Id = 3, Name = "Oneplus 8", Price = 200, Brand = "Oneplus", Type = "Mobile", Color = "Black" });
            //Products.Add(new Product() { Id = 4, Name = "Oneplus 7t", Price = 179, Brand = "Oneplus", Type = "Mobile", Color = "Black" });
            //Products.Add(new Product() { Id = 5, Name = "Ipad 3", Price = 179, Brand = "Apple", Type = "Tablet", Color = "White" });
            //Products.Add(new Product() { Id = 6, Name = "Redmi Note 9", Price = 199, Brand = "MI", Type = "Mobile", Color = "Silver" });
            //Products.Add(new Product() { Id = 7, Name = "Samsung Galaxy Note 10", Price = 159, Brand = "Samsung", Type = "Mobile", Color = "White" });
            //Products.Add(new Product() { Id = 8, Name = "Samsung Galaxy S20 Ultra", Price = 219, Brand = "Samsung", Type = "Mobile", Color = "Blue" });
            //Products.Add(new Product() { Id = 9, Name = "Samsung Galaxy Tab S6", Price = 199, Brand = "Samsung", Type = "Tablet", Color = "Blue" });
            //Products.Add(new Product() { Id = 10, Name = "Lenovo Tab M10 HD", Price = 105, Brand = "Lenovo", Type = "Tablet", Color = "Silver" });
            //Products.Add(new Product() { Id = 11, Name = "Redmi K20 Pro", Price = 109, Brand = "MI", Type = "Mobile", Color = "Black" });
            //Products.Add(new Product() { Id = 12, Name = "Nokia 6.2", Price = 200, Brand = "Nokia", Type = "Mobile", Color = "White" });
            //Products.Add(new Product() { Id = 13, Name = "Nokia 4.2", Price = 160, Brand = "Nokia", Type = "Mobile", Color = "Blue" });
            //Products.Add(new Product() { Id = 13, Name = "Nokia 7.2", Price = 175, Brand = "Nokia", Type = "Mobile", Color = "Black" });
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        private List<Product> Products { get; set; }

        public List<Product> GetProducts()
        {
            //Products = new List<Product>();
            Products.Add(new Product() { Id = 1, Name = "Iphone 6", Price = 199, Brand = "Apple", Type = "Mobile", Color = "Black" });
            Products.Add(new Product() { Id = 2, Name = "Iphone 7", Price = 229, Brand = "Apple", Type = "Mobile", Color = "Silver" });
            Products.Add(new Product() { Id = 3, Name = "Oneplus 8", Price = 200, Brand = "Oneplus", Type = "Mobile", Color = "Black" });
            Products.Add(new Product() { Id = 4, Name = "Oneplus 7t", Price = 179, Brand = "Oneplus", Type = "Mobile", Color = "Black" });
            Products.Add(new Product() { Id = 5, Name = "Ipad 3", Price = 179, Brand = "Apple", Type = "Tablet", Color = "White" });
            Products.Add(new Product() { Id = 6, Name = "Redmi Note 9", Price = 199, Brand = "MI", Type = "Mobile", Color = "Silver" });
            Products.Add(new Product() { Id = 7, Name = "Samsung Galaxy Note 10", Price = 159, Brand = "Samsung", Type = "Mobile", Color = "White" });
            Products.Add(new Product() { Id = 8, Name = "Samsung Galaxy S20 Ultra", Price = 219, Brand = "Samsung", Type = "Mobile", Color = "Blue" });
            Products.Add(new Product() { Id = 9, Name = "Samsung Galaxy Tab S6", Price = 199, Brand = "Samsung", Type = "Tablet", Color = "Blue" });
            Products.Add(new Product() { Id = 10, Name = "Lenovo Tab M10 HD", Price = 105, Brand = "Lenovo", Type = "Tablet", Color = "Silver" });
            Products.Add(new Product() { Id = 11, Name = "Redmi K20 Pro", Price = 109, Brand = "MI", Type = "Mobile", Color = "Black" });
            Products.Add(new Product() { Id = 12, Name = "Nokia 6.2", Price = 200, Brand = "Nokia", Type = "Mobile", Color = "White" });
            Products.Add(new Product() { Id = 13, Name = "Nokia 4.2", Price = 160, Brand = "Nokia", Type = "Mobile", Color = "Blue" });
            Products.Add(new Product() { Id = 13, Name = "Nokia 7.2", Price = 175, Brand = "Nokia", Type = "Mobile", Color = "Black" });
            return Products;
        }
    }
}
