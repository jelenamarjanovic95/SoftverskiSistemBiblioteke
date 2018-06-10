using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class ZaduziSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Zaduzenje z = odo as Zaduzenje;
                GenerickiBroker.Instanca.Insert(z);

                string upit = $"update KnjigaPrimerak set Raspoloziva = false where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
                GenerickiBroker.Instanca.ExecuteNonQuery(upit);

                upit = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo - 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                GenerickiBroker.Instanca.ExecuteNonQuery(upit);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
