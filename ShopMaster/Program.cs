using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ShopMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Product Catalog

            List<Product> catalog = new()
             {
                 new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                 new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                 new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                 new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                 new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                 new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                 new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                 new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                 new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                 new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
             };

            #endregion
            #region Task 01 : Smart Product Search
            #region 1 - Electronics Products
            Console.WriteLine("--- Electronics ---");
            List<Product>Electronics= ProductOperation.SearchProduct(catalog, (Product product) => product.Category == "Electronics");
            ProductOperation.PrintReport(Electronics,(Product item) => Console.WriteLine($"{item.Name} - ${item.Price} - (Stock:{item.Stock})"));
            #endregion
            #region 2 - Products Under $50
            Console.WriteLine("\n--- Under $50 ---");
            List<Product> ProductsUnder50 = ProductOperation.SearchProduct(catalog, (Product product) => product.Price < 50);
            ProductOperation.PrintReport(ProductsUnder50, (Product item) => Console.WriteLine($"{item.Name} - ${item.Price} - (Stock:{item.Stock})"));
            #endregion
            #region 3 - Products In Stock

            Console.WriteLine("\n--- In Stock ---");
            List<Product> ProductsInStock = ProductOperation.SearchProduct(catalog, (Product product) => product.Stock>0);
            ProductOperation.PrintReport(ProductsInStock, (Product item) => Console.WriteLine($"{item.Name} - ${item.Price} - (Stock:{item.Stock})"));
            #endregion
            #region 4 - Clothing Under $100

            Console.WriteLine("\n--- Clothing Under $100 ---");
            List<Product> ClothingUnder100 = ProductOperation.SearchProduct(catalog, (Product product) => product.Price < 100 && product.Category == "Clothing");
            ProductOperation.PrintReport(ClothingUnder100, (Product item) => Console.WriteLine($"{item.Name} - ${item.Price} - (Stock:{item.Stock})"));
            #endregion
            #endregion
            #region Task03:Custom Report Generator
            #region Scenario 1 - Short Report
            Console.WriteLine("\n--- Short Report ---");
            ProductOperation.PrintReport(catalog, (Product item) => Console.WriteLine($"{item.Name} - ${item.Price}"));
            #endregion
            #region Scenario 2  Detailed Report
            Console.WriteLine("\n--- Detailed Report ---");
            ProductOperation.PrintReport(catalog, (Product item) => Console.WriteLine($"[{item.Category}] {item.Name} | Price: ${item.Price} | Stock: {item.Stock}"));
            #endregion
            #endregion
        }
    }
}