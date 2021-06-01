using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu = new Oyuncu();
            oyuncu.OyuncununSilahi = new Ak47();

            Asci asci = new Asci();
            asci.Pisir(new Kofte());
        }
    }

    public class Asci
    {
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
        }
    }

    public class Yemek
    {
        public void Pisir()
        {

        }
    }

    public class SebzeYemek:Yemek
    {

    }

    public class EtYemek:Yemek
    {

    }
    
    public class Tatli : Yemek
    {

    }

    public class Kofte:EtYemek
    {

    }


    public class Oyuncu
    {
        public Silah OyuncununSilahi { get; set; }
    }

    public class Silah
    {
        //Her silahın .................. vardır
        public int Agirlik { get; set; }
        public int VurusGucu { get; set; }

        public void Saldir()
        {

        }
    }

    public class AtesliSilah:Silah
    {

    }

    public class Tabanca:AtesliSilah
    {

    }
    public class Bicak:Silah
    {

    }

    public class Tufek:AtesliSilah
    {

    }

    public class Ak47:Tufek
    {

    }



}
