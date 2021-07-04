using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.repository
{
    class StudentRepositoryImpl : IStudentRepository
    {
        public string addStudent()
        {
            return "Student Added Sucessfully";
        }

        public string deleteStudent()
        {
            return "Student deleted sucessfully";
        }

        public string getAllStudents()
        {
            return "Retrieved All Students";
        }

        public string getStudentById()
        {
            return "retrived Student By Id";
        }

        public string updateStudent()
        {
            return "Upadated Sucessfully";
        }
    }
}
