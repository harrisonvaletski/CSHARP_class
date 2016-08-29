using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Student
    {

        int overallGPA;
        int studentNumber;
        string FirstName;
        string LastName;
        string Classification;
        string major;



        public Student() { 
        }


        public Student(String FirstName, String LastName, String Classification, String major, int studentNumber, int overallGPA) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Classification = Classification;
            this.major = major;
            this.studentNumber = studentNumber;
            this.overallGPA = overallGPA;
    }

        public void setStudentAttributes()
        {
            Console.WriteLine("Please provide all necessary Information:");
        }


        public string toString() {
            String FN = this.FirstName;
            string Togo = "Student: "+FirstName+" "+LastName+"\n\tSid#: "+studentNumber+"\n\tGPA: "+overallGPA;
            return Togo;
        }



    }
}
