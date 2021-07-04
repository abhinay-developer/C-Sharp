using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class Product1 : Product
    {

        public float size;
        public float weight;

        public override string ToString()
        {
            return "Product: " + productId + " " + name + " " + quantity + " " + " " + description + " " + price+" "+size+" "+weight;
        }
    }
}
