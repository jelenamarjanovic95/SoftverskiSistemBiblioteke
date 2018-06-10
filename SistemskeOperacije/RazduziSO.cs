using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class RazduziSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Zaduzenje z = odo as Zaduzenje;

                string upit = $"Update Zaduzenje set DatumDo = '{DateTime.Now.ToString("dd-MMM-yyyy")}' where ClanskiBroj = {z.Clan.ClanskiBroj} and " +
                $"PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and DatumOd = #{z.DatumOd.ToString("dd-MMM-yyyy")}#";
                GenerickiBroker.Instanca.ExecuteNonQuery(upit);

                upit = $"Update KnjigaPrimerak set Raspoloziva = true where PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
                GenerickiBroker.Instanca.ExecuteNonQuery(upit);

                upit = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo + 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
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
