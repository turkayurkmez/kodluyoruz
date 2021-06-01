using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltinInterfaces
{
    public class Class
    {
        //öğrenciler
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> SortStudents()
        {
            students.Sort();
            return students;
        }


    }
}
