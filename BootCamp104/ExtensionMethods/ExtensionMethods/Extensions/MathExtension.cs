using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
   public static class MathExtension
    {
        public static int KaresiniAl(this int sayi)
        {
            return (int)Math.Pow(sayi, 2);
        }

        public static string RandomLetter(this Random random)
        {
            int asciiNumber = random.Next(65, 91);
            string result = ((char)asciiNumber).ToString();
            return result;
        }

        public static string RandomWord(this Random random, int wordLength)
        {
            string rastgeleOlusanKelime = string.Empty;
            while (rastgeleOlusanKelime.Length < wordLength)
            {
                rastgeleOlusanKelime += random.RandomLetter();
            }
            return rastgeleOlusanKelime;
        }

    }
}
