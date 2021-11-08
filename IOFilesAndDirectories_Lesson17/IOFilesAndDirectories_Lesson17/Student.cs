using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFilesAndDirectories_Lesson17
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(int iD, string firstName, string lastName, int grade)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }


        public string ToCSV()
        {
            string myStr = "";
            myStr = string.Format("{0}, {1}, {2}, {3}", ID, FirstName, LastName, Grade);
            return myStr;
        }

        public string WriteStudentsFixedLength()
        {
            string str;
            str = string.Format("{0:9}{1:12}{2:20}{3:3}", ID.ToString(), FirstName, LastName, Grade.ToString());
            return str;
        }
    }
}
