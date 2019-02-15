using System;
using System.Collections.Generic;
using System.Linq;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student[] studentArray = {
            //        new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
            //        new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
            //        new Student() { StudentID = 3, StudentName = "Bill",  age = 25 } ,
            //        new Student() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
            //        new Student() { StudentID = 5, StudentName = "Ron" , age = 31 } ,
            //        new Student() { StudentID = 6, StudentName = "Chris",  age = 17 } ,
            //        new Student() { StudentID = 7, StudentName = "Rob",age = 19  } ,
            //    };

            //Student[] teenAgerStudents = studentArray.Where(s => s.age > 12 && s.age < 20).ToArray();
            //foreach(var x in teenAgerStudents)
            //{
            //    Console.WriteLine("teenAgerStudents   :  " + x.StudentName);
            //}

            //var bill = studentArray.Where( _ => _.StudentName == "Bill").FirstOrDefault();
            //Console.WriteLine("NAME   :  " + bill.StudentName);

            //Student[] id = studentArray.Where(_=> _.StudentID < 5).ToArray();
            //foreach (var x in id)
            //{
            //    Console.WriteLine("Students id   :  " + x.StudentID);
            //}

            // USING LIST
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", age = 13} ,
            //    new Student() { StudentID = 2, StudentName = "Moin",  age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , age = 20} ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , age = 15 }
            //};
            //var teenAgerStudent = from s in studentList
            //                      where s.age > 12 && s.age < 20
            //                      select s;
            //foreach(var _ in teenAgerStudent)
            //{
            //    Console.WriteLine(_.age);
            //}
            Console.ReadKey();
        }
    }
}
