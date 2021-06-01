using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bir sınıftan miras alan iki sınıf birbirlerinin ve üst sınıftan oluşan nesnenin yerine İSTİSNASIZ kullanılabilmesi gerekir.
             *  
             *  Bir sınıftan miras alan her sınıfın nesnesine özel bir if ya da try catch yazıyorsanız bu prensibi ihlal ediyorsunuz demektir. 
             */

            DataWriter dataWriter = new DataWriter();
           // dataWriter.Write("deneme", new XMLDataSource());
            dataWriter.Write("deneme", new DBDataSource());
            dataWriter.Write("deneme", new ExcelDataSource());

        }

        public abstract class DataSource
        {
         
            public abstract string Read(string data);

        }

        public interface IDataWritable
        {
            void Write(string data);
        }

        public class XMLDataSource : DataSource
        {
            public override string Read(string data)
            {
                Console.WriteLine("veri XML'den okundu");
                return string.Empty;
            }

           
        }

        public class DBDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                Console.WriteLine("veri DB'den okundu");
                return string.Empty;
            }

            public  void Write(string data)
            {
                Console.WriteLine("veri DB'e yazıldı");
            }
        }

        public class ExcelDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                throw new NotImplementedException();
            }

            public void Write(string data)
            {
                throw new NotImplementedException();
            }
        }

        public class DataWriter
        {
            public void Write(string data, IDataWritable dataSource)
            {
                dataSource.Write("deneme");
            }
        }
    }
}
