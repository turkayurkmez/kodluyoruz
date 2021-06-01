using System;

namespace BuiltinInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Class bootcampClass = new Class();
            bootcampClass.AddStudent(new Student { Name = "Bahar Yılmaz", Id = 1803, Age = 22 });
            bootcampClass.AddStudent(new Student { Name = "Büşra Altın", Id = 402, Age = 23 });
            bootcampClass.AddStudent(new Student { Name = "Türkay Ürkmez", Id = 2418, Age = 41 });

            var sortedStudents =  bootcampClass.SortStudents();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age  );
            }



        }
    }
}
