using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BuiltinInterfaces
{
   public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo([AllowNull] Student other)
        {
            if (this.Id > other.Id)
            {
                return 1;
            }
            else if (this.Id < other.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }



        }
    }
}
