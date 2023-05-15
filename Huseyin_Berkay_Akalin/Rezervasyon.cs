using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyin_Berkay_Akalin
{
    internal class Rezervasyon
    {
        public int ucret;

        Random random = new Random();

        public Rezervasyon()
        {
            ucret = Convert.ToInt32(random.Next(500, 5000));
        }
    }
}
