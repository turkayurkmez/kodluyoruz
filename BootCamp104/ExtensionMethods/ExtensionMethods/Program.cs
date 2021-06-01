using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using MyHappynessExtensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 8;
            string kelime = "kodluyoruz ";
            List<string> kelimeler = new List<string>();

            int sayininKaresi = sayi.KaresiniAl();
            double number = 8;
            double cube = number.Power(3);


            Random random = new Random();
            string rKelime = random.RandomWord(6);
           
            
            Console.WriteLine(rKelime);
        }
    }
}
