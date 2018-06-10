using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class NadjiKnjiguSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Knjiga knjiga = odo as Knjiga;

                string upit = $"Select * from Knjiga where KnjigaID = {knjiga.KnjigaID} order by Naziv ASC";
                List<IOpstiDomenskiObjekat> listaKnjiga = GenerickiBroker.Instanca.ExecuteReader(upit, odo);

                foreach(IOpstiDomenskiObjekat o in listaKnjiga)
                {
                    Knjiga k = o as Knjiga;
                    upit = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";

                    List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());
                    foreach (IOpstiDomenskiObjekat lp in listaPrimeraka)
                    {
                        k.SpisakPrimeraka.Add(lp as KnjigaPrimerak);
                    }

                    upit = $"Select * from KnjigaAutor where KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaKnjigaAutor = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaAutor());

                    foreach (IOpstiDomenskiObjekat ka in listaKnjigaAutor)
                    {
                        KnjigaAutor kaa = ka as KnjigaAutor;

                        upit = $"Select * from Autor where AutorID = {kaa.AutorID}";

                        List<IOpstiDomenskiObjekat> autor = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());
                        k.ListaAutora.Add(autor[0] as Autor);
                    }
                }

                if (listaKnjiga.Count == 0) return false;

                Rezultat = listaKnjiga[0];

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
