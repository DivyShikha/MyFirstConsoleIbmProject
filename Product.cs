using System;
using System.Collections.Generic;
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
        //propertiesc - similar to getter and setetr methods
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductQuantity
        {
            get { return productQuantity;  }
            set { productQuantity = value; }
        }
    }
}   
