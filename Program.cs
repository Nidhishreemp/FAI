﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace iofileassigmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ProductId = 1;
            p1.ProductName = "A";
            p1.price = 10;
            p1.InStock = true;

            Product p2 = new Product();
            p2.ProductId = 2;
            p2.ProductName = "B";
            p2.price = 20;
            p2.InStock = true;



            List<Product> emp = new List<Product>();
            emp.Add(p1);
            emp.Add(p2);

            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product.xml", FileMode.OpenOrCreate);
            xml.Serialize(stream, emp);




        }
    }
}
