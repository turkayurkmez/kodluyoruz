using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Open / Closed Prensibi:
             *  
             *  Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
             *  
             *  Bir uygulamaya yeni bir özellik eklemek istediğinizde varolan nesneyi değiştirmek zorunda kalıyorsanız, bu prensibi ihlal ediyorsunuz demektir.
             *  
             */

            Musteri musteri = new Musteri { Kart = new PremiumKart() };
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi { SiparisiVeren = musteri };
            var odenecekTutar =  siparisYonetimi.OdemeYap(1000);
            Console.WriteLine(odenecekTutar.ToString("C2"));

        }

        public abstract class KartTipleri
        {
            public abstract decimal IndirimOrani(decimal tutar);
           
        }

        public class StandartKart : KartTipleri
        {
            public override decimal IndirimOrani(decimal tutar)
            {
                return tutar * 0.95M;
            }
        }

        public class SilverKart : KartTipleri
        {
            public override decimal IndirimOrani(decimal tutar)
            {
                return tutar * 0.9M;
            }
        }

        public class GoldKart : KartTipleri
        {
            public override decimal IndirimOrani(decimal tutar)
            {
                return tutar * 0.85M;
            }
        }

        public class PremiumKart : KartTipleri
        {
            public override decimal IndirimOrani(decimal tutar)
            {
                return tutar * 0.80M;
            }
        }

        public class Musteri
        {
            public KartTipleri Kart { get; set; }
        }

        public class SiparisYonetimi
        {
            public Musteri SiparisiVeren { get; set; }
            public decimal OdemeYap(decimal tutar)
            {
                return SiparisiVeren.Kart.IndirimOrani(tutar);
            }
        }

    }
}
