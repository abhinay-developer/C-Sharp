using ConsoleApp1.model;
using System;//import statement

namespace ConsoleApp1
{
public class Program
{
        public static void  displayDetails()
        {
            //Object creation
            Employee emp = new Employee();
            emp.id = 101;
            emp.mobileNumber = 9988998899;
            emp.name = "saitej";
            emp.salary = 785555;
            emp.employeeId = 456;

            Console.WriteLine("\nId:"+emp.id+"\nMobile Number::"+emp.mobileNumber+
                "\nName:"+emp.name+"\nSalary"+emp.salary+"\nEmployee Id:"+emp.employeeId);

        }//displayDetails()
        static void Main(string[] args){
            Program.displayDetails();
         }//Main(-)

}// class
}//namespace


