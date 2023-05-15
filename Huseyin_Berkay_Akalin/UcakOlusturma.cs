using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyin_Berkay_Akalin
{
    internal class UcakOlusturma : Ucak
    {
        public string Model { get; set; }

        public int YolcuKapasitesi { get; set; }

        public int SeriNo { get; set; }

        public int Durum { get; set; }

        private Random Random = new Random();

        public UcakOlusturma()
        {
            int random = Random.Next(0, 6);

            switch (random)
            {
                case 0:
                    Model = "ATR 42";
                    YolcuKapasitesi = 42-50;
                    SeriNo = 599;
                    Durumu = 1 ;
                    break;

                case 1:
                    Model = "Douglas MD-90";
                    YolcuKapasitesi = 153-158;
                    SeriNo = 9;
                    Durumu = 1 ;
                    break;

                case 2:
                    Model = "Tupolev Tu-334";
                    YolcuKapasitesi = 102;
                    SeriNo = 334;
                    Durumu = 1 ;
                    break;

                case 3:
                    Model = "Fokker 100";
                    YolcuKapasitesi = 97-122;
                    SeriNo = 100;
                    Durumu = 1 ;
                    break;
                default:
                    break;
            }
        }
    }
}
