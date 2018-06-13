using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class PretraziKnjigeSO : OpstaSistemskaOperacija
    {
        public Pretraga Pretraga { get; set; }

        public PretraziKnjigeSO(Pretraga p)
        {
            this.Pretraga = p;
        }

        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "";
                List<IOpstiDomenskiObjekat> listaKnjiga = new List<IOpstiDomenskiObjekat>();

                switch (Pretraga.KriterijumPretrage)
                {
                    case KriterijumPretrage.NazivKnjige:
                        upit = $"Select * from Knjiga where Naziv like '%{Pretraga.Vrednost}%' order by Naziv ASC";
                        break;
                    case KriterijumPretrage.ImePrezimeAutor:
                        return PretraziPoAutoru();
                    //OVAJ CASE PREBACITI U KONTROLERA?
                    case KriterijumPretrage.BrojKnjige:
                        upit = $"Select * from Knjiga where KnjigaID = {Convert.ToInt32(Pretraga.Vrednost)} order by Naziv ASC";
                        break;
                }

                listaKnjiga = GenerickiBroker.Instanca.ExecuteReader(upit, odo);

                foreach(IOpstiDomenskiObjekat o in listaKnjiga)
                {
                    Knjiga k = o as Knjiga;

                    upit = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());

                    foreach(IOpstiDomenskiObjekat kp in listaPrimeraka)
                    {
                        KnjigaPrimerak knjP = kp as KnjigaPrimerak;
                        knjP.Knjiga = k;

                        k.SpisakPrimeraka.Add(knjP);
                    }

                    upit = $"Select * from KnjigaAutor where KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaKnjigaAutor = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaAutor());

                    foreach(IOpstiDomenskiObjekat ka in listaKnjigaAutor)
                    {
                        KnjigaAutor kaa = ka as KnjigaAutor;

                        upit = $"Select * from Autor where AutorID = {kaa.AutorID}";

                        List<IOpstiDomenskiObjekat> autor = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());
                        k.ListaAutora.Add(autor[0] as Autor);
                    }
                }

                Rezultat = listaKnjiga;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        
        private bool PretraziPoAutoru()
        {
            try
            {
                List<IOpstiDomenskiObjekat> listaPronadjenihKnjiga = new List<IOpstiDomenskiObjekat>();

                List<IOpstiDomenskiObjekat> listaSvihKnjiga = GenerickiBroker.Instanca.SelectAll(new Knjiga());
                
                foreach(IOpstiDomenskiObjekat odo in listaSvihKnjiga)
                {
                    Knjiga k = odo as Knjiga;
                    
                    string upit = $"Select * from KnjigaAutor where KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaKnjigaAutor = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaAutor());

                    foreach (IOpstiDomenskiObjekat ka in listaKnjigaAutor)
                    {
                        KnjigaAutor kaa = ka as KnjigaAutor;

                        upit = $"Select * from Autor where AutorID = {kaa.AutorID}";

                        List<IOpstiDomenskiObjekat> autor = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());
                        k.ListaAutora.Add(autor[0] as Autor);
                    }

                    upit = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());

                    foreach (IOpstiDomenskiObjekat lp in listaPrimeraka)
                    {
                        k.SpisakPrimeraka.Add(lp as KnjigaPrimerak);
                    }

                    foreach (Autor a in k.ListaAutora)
                    {
                        if (a.ImePrezime.ToLower().Contains(Pretraga.Vrednost.ToLower()))
                        {
                            listaPronadjenihKnjiga.Add(k);
                            break;
                        }
                    }
                }
                Rezultat = listaPronadjenihKnjiga;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
