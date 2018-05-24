using Model;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerPoslovneLogike
{
    public class KontrolerPL_Generic
    {
        public static List<Clan> VratiSveClanove()
        {
            OpstaSistemskaOperacija vratiClanove = new VratiSveClanoveSO();
            vratiClanove.IzvrsiSO(new Clan());
            return vratiClanove.Rezultat as List<Clan>;
        }
    }
}
