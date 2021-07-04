using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class Product2:Product1
    {
        public  string importedFrom;
        public override string ToString()
        {
            return "Product: " + productId + " " + name + " " + quantity + " " + " " + description + " " + price + " " + size + " " + weight+" "+importedFrom;
        }

    }
}
