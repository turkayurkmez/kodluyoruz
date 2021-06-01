using System;
using System.Collections.Generic;
using System.Text;

namespace OOPOverview
{
    public class Personel
    {
       
        private int yas;
        public void SetYas(int yas)
        {
            if (yas < 0)
            {
                throw new Exception("Olmaz böyle yaş!!!");
            }
            this.yas = yas;
        }
        public int GetYas()
        {
            return yas;
        }
        private string ad;
        public string Ad
        {
            get { return ad; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ad boş olur mu hiç!!!");
                }
                ad = value;
            }
        }

        public bool EvliMi { get; set; }

        //Her personel nesnesinin ........................ vardır
        //Her personel .... yapar / ile ....... yapılır 
        public string Soyad { get; set; }
        public string Biografi { get; set; }
        public DateTime DogumTarihi {  get; set; }

        private decimal varsayilanSaatUcreti = 100;
        public void CalismaSaati(int toplamSaat)
        {
            Maas = varsayilanSaatUcreti * toplamSaat;
        }
        public decimal Maas { get; private set; }



    }
}
