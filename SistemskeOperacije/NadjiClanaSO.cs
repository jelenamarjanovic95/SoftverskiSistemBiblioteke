using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class NadjiClanaSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Clan clan = odo as Clan;
                string upit = $"Select * from Clan where ClanskiBroj = {clan.ClanskiBroj}";

                List<IOpstiDomenskiObjekat> clanovi = GenerickiBroker.Instanca.ExecuteReader(upit, odo);

                if (clanovi.Count == 0) return false;
                //foreach (IOpstiDomenskiObjekat o in clanovi)
                //{
                Clan c = clanovi[0] as Clan;
                upit = $"Select * from Zaduzenje where ClanskiBroj = {c.ClanskiBroj}";

                List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, new Zaduzenje());

                foreach (IOpstiDomenskiObjekat zaduzenje in listaZaduzenja)
                {
                    Zaduzenje z = zaduzenje as Zaduzenje;
                    z.Clan = c;

                    upit = $"Select * from KnjigaPrimerak where PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());

                    foreach (IOpstiDomenskiObjekat prim in listaPrimeraka)
                    {
                        KnjigaPrimerak kp = prim as KnjigaPrimerak;

                        upit = $"Select * from Knjiga where KnjigaID = {kp.Knjiga.KnjigaID}";
                        List<IOpstiDomenskiObjekat> knjiga = GenerickiBroker.Instanca.ExecuteReader(upit, kp.Knjiga);
                        kp.Knjiga = knjiga[0] as Knjiga;

                        upit = $"Select * from KnjigaPrimerak where KnjigaID = {kp.Knjiga.KnjigaID}";
                        List<IOpstiDomenskiObjekat> listaPrimerakaKnjiga = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());

                        foreach (IOpstiDomenskiObjekat lp in listaPrimerakaKnjiga)
                        {
                            kp.Knjiga.SpisakPrimeraka.Add(lp as KnjigaPrimerak);
                        }

                        upit = $"Select * from KnjigaAutor where KnjigaID = {kp.Knjiga.KnjigaID}";
                        List<IOpstiDomenskiObjekat> listaKnjigaAutor = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaAutor());

                        foreach (IOpstiDomenskiObjekat ka in listaKnjigaAutor)
                        {
                            KnjigaAutor kaa = ka as KnjigaAutor;

                            upit = $"Select * from Autor where AutorID = {kaa.AutorID}";

                            List<IOpstiDomenskiObjekat> autor = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());
                            kp.Knjiga.ListaAutora.Add(autor[0] as Autor);
                        }

                        z.KnjigaPrimerak = kp;
                    }

                    c.ListaZaduzenja.Add(z);
                }

            //}

                Rezultat = c;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
