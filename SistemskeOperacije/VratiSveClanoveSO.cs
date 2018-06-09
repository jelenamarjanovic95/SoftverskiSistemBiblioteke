using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class VratiSveClanoveSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                List<IOpstiDomenskiObjekat> listaClanova = GenerickiBroker.Instanca.VratiSve(odo);
                foreach(IOpstiDomenskiObjekat o in listaClanova)
                {
                    Clan c = o as Clan;
                    string upit = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                    $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";

                    List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, new Zaduzenje());

                    foreach(IOpstiDomenskiObjekat zaduzenje in listaZaduzenja)
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
                Rezultat = listaClanova;
                
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
