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
        //Nece da se konvertuje u listu!
        public static List<IOpstiDomenskiObjekat> VratiSveClanove()
        {
            OpstaSistemskaOperacija vratiClanove = new VratiSveClanoveSO();
            bool rez = vratiClanove.IzvrsiSO(new Clan());
            if (rez)
                return vratiClanove.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }


    }
}
