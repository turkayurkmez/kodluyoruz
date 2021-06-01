using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Ekmek 
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this(1,"Beyaz Ekmek")
        {
            //Adet = 1;
            //Tur = "Beyaz Ekmek";
        }

        public Ekmek(int adet):this(adet,"Beyaz Ekmek")
        {
            //Adet = adet;
            //Tur = "Beyaz Ekmek";
        }

        public Ekmek(string tur):this(1,tur)
        {
            //Adet = 1;
            //Tur = tur;
        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
