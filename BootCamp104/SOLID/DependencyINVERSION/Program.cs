using System;

namespace DependencyINVERSION
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Büyük sistemler küçük sistemlere değil, küçük sistemler büyüklere bağlı olmalıdır.
             */
            Report report = new Report(new MailSender());
            Report wsReport = new Report(new WhatsappSender());
        }


    }

    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender; 
        }
        public void Send()
        {
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender :ISender
    {
        public void Send()
        {
            Console.WriteLine("Eposta gitti");
        }
    }
    public class WhatsappSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("WApp gitti");
        }
    }
}
