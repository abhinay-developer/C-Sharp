using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp{
   public  interface IStudentRepository{

        public string addStudent();

        public string getAllStudents();

        public string deleteStudent();

        public string getStudentById();

        public string updateStudent();

    }

}
