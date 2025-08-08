using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Product
    {
        private string productName;
        private double productPrice;
        private int productQuantity;
        public Product() { } //default constructor

        public Product(string name, double price, int quantity)//paramterised constructor or overloaded constructor
        {
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }
        //properties - similar to getter and setetr methods

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        
        public double ProductPrice
        {
            get { return productPrice;  }
            set { productPrice = value; }
        }
        public int ProductQuantity
        {
            get { return productQuantity;  }
            set { productQuantity = value; }
        }
        //busniess methods - for displaying prodct details
        public double CalculateToTalPrice()
        {
            return productPrice * productQuantity;
        }
        public double ApplyDiscount(double discountPercentage)
        {
            double dicounteAmount = (discountPercentage / 100) * productPrice;
            return productPrice - dicounteAmount;
        }
        public bool IsInStock()
        {
            return productQuantity > 0;
        }
        public void Restock(int additionalQuantity)
        {
            if(additionalQuantity > 0)
            {
                productQuantity += additionalQuantity;
                Console.WriteLine($"{additionalQuantity} units added to stock.");
            }
            else
            {
                Console.WriteLine("Invalid quantity for restocking.");
            }
        }
        public void Sell (int quantityToSell)
        {
            if (quantityToSell > 0 && quantityToSell <= productQuantity)
            {
                productQuantity -= quantityToSell;
                Console.WriteLine($"{quantityToSell} units sold");
            }
            else if (quantityToSell > productQuantity)
            {
                Console.WriteLine("Insufficient stock to sell the requested quantity.");
            }
            else
            {
                Console.WriteLine("Invalid quantity for selling.");
            }
        }
        public void UpdatePrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                productPrice = newPrice;
                Console.WriteLine($"Product price updated to {productPrice:C}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }

        }
    }
}   
