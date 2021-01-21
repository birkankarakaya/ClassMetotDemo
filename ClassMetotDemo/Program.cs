using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            MusteriManager musteriManager = new MusteriManager();

            musteri.Id = 1;
            musteri.Ad = "Birkan";
            Console.WriteLine(musteri.Ad);
        }
    }
}
