using System;
using System.Collections.Generic;
using System.Linq;

namespace usingDelegates
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        static void Main(string[] args)
        {
            // var evenNumbers = Filter.FilterArray(numbers,getEvenNumbers);

            //NET 2.0:
            // var multiplierThree = Filter.FilterArray(numbers, 
            //     delegate (int number) 
            //    { 
            //       return number % 3 == 0; 
            //    });

            //.NET 3.5:


            var moreThanFive = Filter.FilterArray(numbers, x => x > 5);
            List<string> names = new List<string> { "Büşra", "Aydın Necmi", "Burak", "Türkay" };
            names = names.Where(name => name.StartsWith("B")).ToList();
            names.OrderBy(x => x);
            names.ForEach(name => Console.WriteLine(name));

            foreach (var item in moreThanFive)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

       

        static bool getEvenNumbers(int value)
        {
            return value % 2 == 0;
        }
    }
}
