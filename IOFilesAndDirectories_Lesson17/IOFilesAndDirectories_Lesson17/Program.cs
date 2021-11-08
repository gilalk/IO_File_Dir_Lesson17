using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace IOFilesAndDirectories_Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            
            var arr = Directory.GetLogicalDrives();
            var arr1 = Directory.GetDirectories(arr[0]);

            foreach (var item in arr1.Take(10))
            {
                Console.WriteLine(item);
            }


            // Question 2

            GetBiggestFiles(@"C:\Users\gilal");

            // Question 3

            List<Student> students = new List<Student>()
            {
                new Student(32, "gil", "alkobi", 98),
                new Student(14, "avia", "simhi", 100),
                new Student(76, "ziv", "zimra", 90),
                new Student(213, "eli", "ohana", 87),
                new Student(89, "david", "levi", 92),
                new Student(5, "ana", "miler", 71),
            };

            //var jsonStudents = JsonSerializer.Serialize(students);
            //File.WriteAllText(@"students.json", jsonStudents);

            // Question 4
            string myFixLength = "";
            foreach (var student in students)
            {
                myFixLength += student.WriteStudentsFixedLength() + "  ";
            }

            // Question 5

            var text = "";
            foreach (var student in students)
            {
                text += student.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"C:\Users\gilal\students.csv", text);

            // Question 6 

            var listFromCSV = File.ReadAllLines(@"C:\Users\gilal\students.csv").ToList();


            // Question 7
            // fixed length
            // ניתן לבחור באורך כל רשומה מראש כך שלא חייב לבזבז הרבה מידע לשווא

            // Question 8

            // אין גמישות ברגע שהגדרנו את טווח התוים ולכן יש מגבלות

            // Question 9

            // קובץ בינארי מדויק יותר וקל יותר, לא מוגבל לתיאור על ידי טקסט אלא גם בתצורה שהקורא לא בהכרח מבין מה הוא קורא.

        }


        /// <summary>
        /// 
        /// function for question 2
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void GetBiggestFiles(string path)
        {
            DirectoryInfo myDir = new DirectoryInfo(path);
            var myFiles = myDir.GetFiles();
            var fileList = myFiles.OrderByDescending(file => file.Length);

            foreach (var item in fileList.Take(3))
            {
                Console.WriteLine($"File Name: {item.Name}\nLast Change: {item.LastWriteTime}");
            }
        }
    }
}
