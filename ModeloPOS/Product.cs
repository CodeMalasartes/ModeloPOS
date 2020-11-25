using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    public class Product
    {
        private int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }

        //public List<Product> products = new List<Product>();

        public void ShowProducts(List<Product> products)
        {
            foreach (Product prod in products)
            {
                Console.WriteLine("ID: " + prod.ProductId + " Name: " + prod.ProductName
                                + " Brand: " + prod.ProductBrand + " Category: " + prod.ProductCategory);
            }
            
        }

        //public void AddProduct(Product product)
        //{
            // Exemplo: Name = "BLUSA", Brand = "ADIDAS", Category = "VESTUARIO"
        //    this.Id++;
        //    products.Add(product);
        //}
        public void RemoveProduct(Product product)
        {
           //products.Remove(product);
        }

        public void FindProdutoByName(List<Product> products, string Name) 
        {
            foreach(Product prod in products)
            {
                Console.WriteLine(prod.ToString().Equals(Name));
            }
         }

        public void FindProductByBrand(List<Product> products, string Brand)
        {
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.ToString().Equals(Brand));
            }
        }
        public void FindProductByCategory(List<Product> products, string Category)
        {
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.ToString().Equals(Category));
            }
        }
    }
}
