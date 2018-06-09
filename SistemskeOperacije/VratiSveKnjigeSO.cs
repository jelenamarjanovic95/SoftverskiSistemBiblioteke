using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class VratiSveKnjigeSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                List<IOpstiDomenskiObjekat> listaKnjiga = GenerickiBroker.Instanca.VratiSve(odo);
                string upit;

                foreach(IOpstiDomenskiObjekat knjiga in listaKnjiga)
                {
                    Knjiga k = knjiga as Knjiga;

                    upit = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                    List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());

                    foreach(IOpstiDomenskiObjekat lp in listaPrimeraka)
                    {
                        k.SpisakPrimeraka.Add(lp as KnjigaPrimerak);
                    }

                    //upit = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {k.KnjigaID}";

                    //List<IOpstiDomenskiObjekat> listaAutora = GenerickiBroker.Instanca.ExecuteReader(upit, new Autor());

                    //foreach (IOpstiDomenskiObjekat autor in listaAutora)
                    //{
                    //    Autor a = autor as Autor;
                    //    k.ListaAutora.Add(a);
                    //}

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
    }
}
