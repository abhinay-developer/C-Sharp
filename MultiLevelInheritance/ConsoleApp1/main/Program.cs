using ConsoleApp1.model;
using System;//import statement

namespace ConsoleApp1
{
public class Program
{
       public static void displayProduct1Det()
        {
            Product1 p1 = new Product1();
            p1.productId=101;
            p1.name="I Phone";
            p1. quantity=2;
            p1.description="I Phone 11 Pro";
            p1.price=98000;
            p1.size = 12.5f;
            p1.weight = 150;

            Console.WriteLine("P1::"+p1);
  
    }
        public static void displayProduct2Det()
        {
            Product2 p2 = new Product2();
            p2.productId = 102;
            p2.name = "I Phone";
            p2.quantity = 2;
            p2.description = "I Phone 12 Pro";
            p2.price = 98000;
            p2.size = 12.5f;
            p2.weight = 150;
            p2.importedFrom = "Hyderbad";

            Console.WriteLine("P2::"+p2);

        }


        static void Main(string[] args){

            Program.displayProduct1Det();
            Program.displayProduct2Det();

   }//Main(-)

}// class
}//namespace


