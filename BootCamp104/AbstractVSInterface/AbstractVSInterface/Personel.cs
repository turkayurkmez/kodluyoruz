using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVSInterface
{
   public class Personel
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public IAdres Adres { get; set; }
        //1. en düşük bağımlılık seviyesi interface'dir.

    }

    public interface IAdres
    {
         string Sehir { get; set; }
         string Ulke { get; set; }
         string Sokak { get; set; }
         string Mahalle { get; set; }

        void yap();

        string et();
    }
    public class EvAdresi : IAdres, IComparable, IDisposable
    {
        public string Sehir { get ; set ; }
        public string Ulke { get ; set ; }
        public string Sokak { get ; set ; }
        public string Mahalle { get ; set ; }
        public string PostaKodu { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string et()
        {
            throw new NotImplementedException();
        }

        public void yap()
        {
            throw new NotImplementedException();
        }
    }

    public class IsAdresi : IAdres
    {
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string Sokak { get; set; }
        public string Mahalle { get; set; }
        public double Enlem { get; set; }
        public double Boylam { get; set; }

        public string et()
        {
            throw new NotImplementedException();
        }

        public void yap()
        {
            throw new NotImplementedException();
        }
    }
}
