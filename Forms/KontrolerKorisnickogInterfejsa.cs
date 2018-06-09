using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class KontrolerKorisnickogInterfejsa
    {
        public static void PrijaviSe(string korIme, string loz, LoginForm lf)
        {
            lf.Bibl = Komunikacija.Instance.PrijaviSe(korIme, loz);          
        }

        public static void Kraj()
        {
            Komunikacija.Instance.Kraj();
        }

        public static bool Razduzi(Zaduzenje z)
        {
            return Komunikacija.Instance.Razduzi(z);
        }


    }
}
