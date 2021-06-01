using System;

namespace AbstractionVEInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine("Copying...");
        }

        public void ChangeName()
        {

        }

        public int Size { get; set; }

        //PDF, Excel, Word
        public abstract void Save();
        public abstract void Load();
     

    }
    public interface IPrintable
    {
        void Print();
    }
    public class WordDocument : Document , IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}
