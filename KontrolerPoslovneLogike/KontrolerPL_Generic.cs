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

            pretraziClanove = new PretraziClanoveSO(pretraga);
            //pretraziClanove.Pretraga = pretraga;
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

        public static bool SacuvajIzmeneKnjiga(Knjiga novo)
        {
            OpstaSistemskaOperacija sacuvajIzmeneKnjiga = new SacuvajIzmeneKnjigaSO();

            bool rez = sacuvajIzmeneKnjiga.IzvrsiSO(novo);

            return rez;
        }

        public static int UbaciKnjigu(Knjiga k)
        {
            OpstaSistemskaOperacija ubaciKnjigu = new UbaciKnjiguSO();

            ubaciKnjigu.IzvrsiSO(k);
            return k.KnjigaID;
        }

        public static List<IOpstiDomenskiObjekat> PretraziKnjige(Pretraga pretraga)
        {
            if(pretraga.Vrednost == "")
            {
                return VratiSveKnjige();
            }
            OpstaSistemskaOperacija pretraziKnjige = new PretraziKnjigeSO(pretraga);

            bool rez = pretraziKnjige.IzvrsiSO(new Knjiga());
            if (rez)
                return pretraziKnjige.Rezultat as List<IOpstiDomenskiObjekat>;
            else throw new Exception();
        }

        public static Knjiga NadjiKnjigu(int brojKnjige)
        {
            Knjiga k = new Knjiga()
            {
                KnjigaID = brojKnjige
            };
            OpstaSistemskaOperacija nadjiKnjigu = new NadjiKnjiguSO();
            bool rez = nadjiKnjigu.IzvrsiSO(k);

            if (rez)
                return nadjiKnjigu.Rezultat as Knjiga;
            else throw new Exception();
        }

        public static void ObrisiKnjigu(Knjiga k)
        {
            OpstaSistemskaOperacija obrisiKnjigu = new ObrisiKnjiguSO();
            bool rez = obrisiKnjigu.IzvrsiSO(k);
            if (!rez) throw new Exception();
        }



    }
}
