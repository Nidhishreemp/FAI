﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iofileassigmnet
{
   

    public class ProductRepository
    {
        List<Product> ProductList2 = new List<Product>();

        public ProductRepository(Product p)
        {
            p.ProductId = Console.ReadLine();
            p.ProductName = Console.ReadLine();
            p.Price = Console.ReadLine();
            p.InStock = Console.ReadLine();
            

        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        //public void  AddProduct(params object[] value)

        //{
        //    List<string> Info = new List<string>();
        //    foreach (var x in value)
        //    {
        //        string y = Convert.ToString(x);
        //        Info.Add(y);
        //    }


        //    // code to add product to file, ensuring that product is not null

        //    XmlSerializer xml = new XmlSerializer(typeof(List<string>));
        //    Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product2.xml", FileMode.OpenOrCreate);
        //    xml.Serialize(stream, Info);

        //}
        public void AddProduct(Product p)

        {
            ProductList2.Add(p);
            
        }



        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public void RemoveProduct(Product p, int x)
        {
            ProductList2.Remove(p);

            


        }

        ///*
        // * this method should search and return product by product name from the file 
        // * 
        // * the search value should be passed as parameter
        // * 
        // * the method should return null for non-matching product name
        // */
        //public <return_type> GetProduct(<parameter>)
        //{

        //}

        ///*
        // * this method should search and return product by product id from the collection 
        // * 
        // * the search value should be passed as parameter
        // * 
        // * the method should return null for non-matching product id
        // */
        //public <return_type> GetProduct(<parameter>)
        //{

        //}


        ///*
        // * this method should return all items from the product collection
        // */
        public List<Product> GetAllProducts()
        {
            return ProductList2;


        }
    }
    
}
