using System;
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

            
            //Product p3 = new Product();
            //p3.ProductId = "3";
            //p3.ProductName = "A";
            //p3.Price = "10";
            //p3.InStock = "true";

            //Product p4 = new Product();
            //p4.ProductId = "4";
            //p4.ProductName = "B";
            //p4.Price = "20";
            //p4.InStock = "true";

            Product p5 = new Product();
            Product p6 = new Product();
            

            //List<Product> ProductList = new List<Product>();
            //ProductList.Add(p3);
            //ProductList.Add(p4);
            //XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            //Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product1.xml", FileMode.OpenOrCreate);
            //xml.Serialize(stream, p3);
            //foreach(var x in ProductList)
            //{
            //    Console.WriteLine(x);
            //}











            //XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            //Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product1.xml", FileMode.OpenOrCreate);
            //xml.Serialize(stream, ProductList);

            List<Product>FinalProductList = new List<Product>();

            //DataContext d = new DataContext("Product.xml", @"C:\Users\nidmp\source\repos\iofileassigmnet\Product.xml");
            
            //d.AddProduct(p3);
            //d.AddProduct(p4);
           
            //FinalProductList = d.ReadProducts();
            //foreach (var x in FinalProductList)
            //{
            //    Console.WriteLine(x.ProductId + " " + x.ProductName + " " + x.Price + " " + x.InStock);
            //}
            //d.SaveChanges(FinalProductList);

            ProductRepository p1 = new ProductRepository(p5);
            p1.AddProduct(p5);
           FinalProductList= p1.GetAllProducts();

        

            DataContext d = new DataContext("Product.xml", @"C:\Users\nidmp\source\repos\iofileassigmnet\Product.xml");
            d.SaveChanges(FinalProductList);
          
            //p.AddProduct(p3);
            //p.AddProduct(ProductList[0]);
            //p.RemoveProduct(ProductList[1]);






        }
    }
}
