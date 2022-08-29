using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iofileassigmnet
{
    public class DataContext
    {
        List<Product> ListOfProducts= new List<Product>();
        

        // the constructor should accept filename and path strings
        public DataContext(string filename,string path)
        {

            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product7.xml", FileMode.OpenOrCreate);
            ListOfProducts = (List<Product>)xml.Deserialize(stream);
            stream.Close();

            foreach (var x in ListOfProducts)
            {
                Console.WriteLine(x.ProductId + " " + x.ProductName + " " + x.Price + " " + x.InStock);
            }




        }
       

        // this method should add the product data passed as parameter to the list of products
        //public void  AddProduct(Product p)
        //{
        //    ListOfProducts.Add(p);

        //}
        public List<Product> ReadProducts()
        {
            // return data of the product list
            return ListOfProducts;
        }

        //// this method should write the data from list of products to file and make data persistent
        public void SaveChanges(List<Product> finallist)

        {
            ListOfProducts = finallist;
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product7.xml", FileMode.OpenOrCreate);
            xml.Serialize(stream, finallist);
            stream.Close();
        }


        public void CleanUp()
        {
            File.Delete(@"C:\Users\nidmp\source\repos\iofileassigmnet\Product7.xml");
        }

    }
}
