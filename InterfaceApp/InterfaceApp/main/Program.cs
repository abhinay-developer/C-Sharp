using InterfaceApp.repository;
using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // cw+tab  to generte Console.WriteLine();
            IStudentRepository studentRepo = new StudentRepositoryImpl();
            Console.WriteLine(studentRepo.addStudent());
            Console.WriteLine(studentRepo.deleteStudent());
            Console.WriteLine(studentRepo.getAllStudents());
            Console.WriteLine(studentRepo.getStudentById());
        }
    }
}
