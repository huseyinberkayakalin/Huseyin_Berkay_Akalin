using System;
using System.Threading;

namespace Huseyin_Berkay_Akalin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uçak Rezervasyon Sistemi";

            Console.WriteLine("Uçak Rezervasyon Sistemine Hoşgeldiniz.\n");

            MusteriOlusturma musteriOLusturma = new MusteriOlusturma();
            Musteri musteri = musteriOLusturma.musteri();

            RezervasyonOlusturma rezervasyonOlusturma = new RezervasyonOlusturma(musteri.Ad, musteri.Soyad);
            Console.Write(rezervasyonOlusturma.UcusDondur());

            Console.Write("\n\n İyi Yolculuklar.");

            Thread.Sleep(1000);
        }
    }
}


