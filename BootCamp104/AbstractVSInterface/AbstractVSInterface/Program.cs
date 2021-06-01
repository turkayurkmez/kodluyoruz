using System;
using System.IO;

namespace AbstractVSInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Stream stream = 
            FileStream fileStream = new FileStream("", FileMode.Create);
            MemoryStream memoryStream = new MemoryStream();
            Stream stream = fileStream;


            Personel calisan= new Personel();
            calisan.Adres = new EvAdresi();
            calisan.Adres = new IsAdresi() { Boylam = 42, Enlem = 26 };

            
            Console.WriteLine(calisan.Adres.Sehir);




        }
    }


    public abstract class MyStream
    {
        //DosyaStream 
        //BellekStream 
        //NetworkStream

        //Bir stream'den veri okunabilmeli VE yazılabilmeli. Ancak, her stream'de bu işlemler farklı yapılıyor:
        public abstract void Write(byte[] data);
        public abstract byte[] Read();
        public void Copy(string from, string to)
        {
            Console.WriteLine("kopyalandı....");
        }

    }

    public class DosyaStream : MyStream
    {
        public override byte[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }

    public class BellekStream : MyStream
    {
        public override byte[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
