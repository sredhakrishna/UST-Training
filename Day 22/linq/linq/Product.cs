using System.Collections.Generic;
using System;

namespace linq
{
    public class Product
    {
        private int _UnitsInStock;
        public int UnitsInStock { get; set; }
        private string _ProductName;
        public object ProductName { get; internal set; }
        private int _cost;
        public int Cost { get { return _cost; } set { _cost = value; } }

        public Product() { }
        public Product(int unitsInStock, string name ,int cost)
        {
            UnitsInStock = unitsInStock;
            ProductName = name;
            Cost = cost;
            
        }
        
        public static List<Product> GetProductList()

        {
            List<Product> products = new List<Product>();
            products.Add(new Product(0, "Soap",20));
            products.Add(new Product(100, "Paste",100));
            products.Add(new Product(22, "dress", 100));
            products.Add(new Product(11, "pen", 20));
            products.Add(new Product(33,"plate",145));
            return products;
        }

    }
}