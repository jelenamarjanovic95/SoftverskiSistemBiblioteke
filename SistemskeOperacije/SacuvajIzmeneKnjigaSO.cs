using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class SacuvajIzmeneKnjigaSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Knjiga novo = odo as Knjiga;
                GenerickiBroker.Instanca.Update(novo);

                string upit = $"Delete from KnjigaAutor where KnjigaID = {novo.KnjigaID}";
                GenerickiBroker.Instanca.ExecuteNonQuery(upit);

                foreach(Autor a in novo.ListaAutora)
                {
                    upit = $"Insert into KnjigaAutor values ({novo.KnjigaID}, {a.AutorID})";
                    GenerickiBroker.Instanca.ExecuteNonQuery(upit);
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
