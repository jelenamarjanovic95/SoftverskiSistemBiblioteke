using Model;
using Session;
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
        public static List<IOpstiDomenskiObjekat> VratiSveClanove()
        {
            OpstaSistemskaOperacija vratiClanove = new VratiSveClanoveSO();
            bool rez = vratiClanove.IzvrsiSO(new Clan());
            if (rez)
                return vratiClanove.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }

        public static List<IOpstiDomenskiObjekat> VratiSveKnjige()
        {
            OpstaSistemskaOperacija vratiKnjige = new VratiSveKnjigeSO();
            bool rez = vratiKnjige.IzvrsiSO(new Knjiga());
            if (rez)
                return vratiKnjige.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }

        public static List<IOpstiDomenskiObjekat> VratiSveAutore()
        {
            OpstaSistemskaOperacija vratiAutore = new VratiSveAutoreSO();
            bool rez = vratiAutore.IzvrsiSO(new Autor());
            if (rez)
                return vratiAutore.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }

        public static bool SacuvajIzmeneClan(Clan novi)
        {
            OpstaSistemskaOperacija sacuvajIzmeneClan = new SacuvajIzmeneClanSO();

            bool rez = sacuvajIzmeneClan.IzvrsiSO(novi);

            return rez;
        }

        public static int UbaciClana(Clan c)
        {
            OpstaSistemskaOperacija ubaciClana = new UbaciClanaSO();

            ubaciClana.IzvrsiSO(c);
            return c.ClanskiBroj;
        }

        public static List<IOpstiDomenskiObjekat> PretraziClanove(Pretraga pretraga)
        {
            PretraziClanoveSO pretraziClanove;
            if (pretraga.Vrednost == "")
            {
                return VratiSveClanove();
            }

            pretraziClanove = new PretraziClanoveSO();
            pretraziClanove.Pretraga = pretraga;
            bool rez = pretraziClanove.IzvrsiSO(new Clan());

            if (rez)
                return pretraziClanove.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }

        public static Clan NadjiClana(int clanskiBroj)
        {
            Clan c = new Clan()
            {
                ClanskiBroj = clanskiBroj
            };
            OpstaSistemskaOperacija nadjiClana = new NadjiClanaSO();
            bool rez = nadjiClana.IzvrsiSO(c);

            if (rez)
                return nadjiClana.Rezultat as Clan;
            else throw new Exception();
        }

        public static void ObrisiClana(Clan c)
        {
            OpstaSistemskaOperacija obrisiClana = new ObrisiClanaSO();
            bool rez = obrisiClana.IzvrsiSO(c);
            if (!rez) throw new Exception();
        }
    }
}
