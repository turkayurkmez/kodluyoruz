using System;

namespace OOPOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            /*
             * 
             */
            Personel turko = new Personel();
            turko.Ad = "Türkay";
            turko.EvliMi = true;

            Personel user2 = turko;
            user2.Ad = "Mahmut Ş.";
            Console.WriteLine("Yaşınızı girin:");
            int yas = int.Parse(Console.ReadLine());
            user2.SetYas(14);
            user2.EvliMi = false;
            Console.WriteLine(user2.EvliMi);

            int userAge = user2.GetYas();
          
            Console.WriteLine(turko.Ad);
            Console.ReadLine();
        }
    }
}
