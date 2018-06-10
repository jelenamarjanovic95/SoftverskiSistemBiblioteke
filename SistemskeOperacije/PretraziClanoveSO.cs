using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class PretraziClanoveSO : OpstaSistemskaOperacija
    {
        public Pretraga Pretraga { get; set; }

        public PretraziClanoveSO(Pretraga p)
        {
            this.Pretraga = p;
        }

        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "";

                switch (Pretraga.KriterijumPretrage)
                {
                    case KriterijumPretrage.ImePrezimeClan:
                        upit = $"Select * from Clan where ImePrezime like '%{Pretraga.Vrednost}%' order by ImePrezime";
                        break;
                    case KriterijumPretrage.ClanskiBroj:
                        upit = $"Select * from Clan where ClanskiBroj = {Convert.ToInt32(Pretraga.Vrednost)} order by ImePrezime";
                        break;
                }

                List<IOpstiDomenskiObjekat> listaPronadjeniClanovi = GenerickiBroker.Instanca.ExecuteReader(upit, odo);

                foreach (IOpstiDomenskiObjekat o in listaPronadjeniClanovi)
                {
                    Clan c = o as Clan;
                    upit = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                    $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";

                    List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, new Zaduzenje());

                    foreach (IOpstiDomenskiObjekat zaduzenje in listaZaduzenja)
                    {
                        Zaduzenje z = zaduzenje as Zaduzenje;
                        z.Clan = c;

                        //upit = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";

                        //List<IOpstiDomenskiObjekat> listaAutora = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());

                        //foreach(IOpstiDomenskiObjekat autor in listaAutora)
                        //{
                        //    Autor a = autor as Autor;
                        //    z.KnjigaPrimerak.Knjiga.ListaAutora.Add(a);

                        //}

                        c.ListaZaduzenja.Add(z);
                    }

                }

                Rezultat = listaPronadjeniClanovi;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
