using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iofileassigmnet
{
    //this serializable class models product data that includes product id, product name, price and in-stock status
    public class Product
    {
        /*
         * define properties for Product model attributes 
         */
        public string ProductId;
        public string ProductName;
        public string Price;
        public string InStock;

        public override string ToString()
        {
            return $"ProductId:{ProductId},ProductName:{ProductName},Price:{Price},InStock:{InStock}";
        }
     



        /*
         * Override ToString() method to return string equivalent of product object containing product details
         */
    }
}
