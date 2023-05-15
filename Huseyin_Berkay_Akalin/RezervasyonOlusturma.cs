using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyin_Berkay_Akalin
{
    internal class RezervasyonOlusturma
    {
        public string Musteri;
        public string Ucak;
        public string Lokasyon;
        public string Tarih;

        public RezervasyonOlusturma(string Ad, string Soyad)
        {
            Musteri = Ad + " " + Soyad;

            UcakOlusturma ucakOlusturma = new UcakOlusturma();
            Ucak = ucakOlusturma.Model;

            Console.WriteLine("\nEtkin Uçuşlar: ");
            LokasyonOlusturma lokasyonOlusturma = new LokasyonOlusturma();

            int LSayac = 1;
            foreach (var item in lokasyonOlusturma.LokasyonList)
            {
                Console.WriteLine(LSayac + ".Lokasyon =>" + item);
                LSayac++;
            }

            while (true)
            {
                Console.Write("Uçuş Lokasyonu Seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim >= 1 && secim <= LSayac - 1)
                {
                    Lokasyon = lokasyonOlusturma.LokasyonList[secim - 1];
                    break;
                }
            }

            Console.WriteLine("\nTarih Giriniz (gün/ay/yıl): ");
            Tarih = Console.ReadLine();

        }

        public string UcusDondur()
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            string Temp = "\nSayın: " + Musteri + "\nUçağınız: " + Ucak + "\nLokasyonunuz: " + Lokasyon + "\nUçuş Tarihiniz: " + Tarih + "\nBilet Tutarınız: " + rezervasyon.ucret;
            return Temp;
        }
    }
}
