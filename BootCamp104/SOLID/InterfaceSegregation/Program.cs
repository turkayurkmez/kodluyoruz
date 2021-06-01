using System;
using System.Reflection.Metadata;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * Her fonksiyon kendi amacına göre bir arayüze sahip olmalı.
            * 
            * Bir interface'i implemente etmek zorundasınız fakat bu interface'in bir metodu sizin için anlamsız ise o metod o interface'e bağlı olmamalı.
            * 
            * 
            */

        }

        public interface IMessage
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Body { get; set; }           
         
    
           
        }

        public interface IVideoMessage : IMessage
        {
            public int Duration { get; set; }
        }

        public interface IImageMessage : IMessage
        {
            public string ImageFormat { get; set; }
            void SaveImage();
        }

        public interface IAudioMessage : IMessage
        {
            public byte[] SoundStream { get; set; }
        }

        public class VideoMessage : IVideoMessage
        {
            public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
