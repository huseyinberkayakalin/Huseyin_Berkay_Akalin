using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyin_Berkay_Akalin
{
    internal class LokasyonOlusturma : Lokasyon
    {
        public string Ulke { get; set; }

        public string Sehir { get; set; }

        public string Havaalani { get; set; }
        public IEnumerable<object> YerList { get; internal set; }

        public List<string> LokasyonList = new List<string>();

        private string FilePath = @"Konum.txt";
        private string TLokasyon = string.Empty;

        public LokasyonOlusturma()
        {
            if (File.Exists(FilePath))
            {
                StreamReader reader = new StreamReader(FilePath);

                while (true)
                {
                    string[] Dlist;

                    string satir = reader.ReadLine();

                    if (satir != null)
                    {
                        Dlist = satir.Split(',');
                        Ulke = Dlist[0];
                        Sehir = Dlist[1];
                        Havaalani = Dlist[2];

                        TLokasyon = Ulke + " - " + Sehir + " - " + Havaalani;
                        LokasyonList.Add(TLokasyon);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Ulke = "Turkiye";
                Sehir = "İstanbul";
                Havaalani = "Sabiha Gökçen Havaalanı";

                TLokasyon = Ulke + " - " + Sehir + " - " + Havaalani;
                LokasyonList.Add(TLokasyon);
            }
        }
    }
}
