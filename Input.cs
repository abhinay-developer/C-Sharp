using System;

namespace Helloworld
{
    class Program
    {
      

        //Taking Input From the user
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age::"+age);
        }
    }
}
