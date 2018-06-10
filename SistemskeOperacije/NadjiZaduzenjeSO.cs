using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class NadjiZaduzenjeSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Zaduzenje z = odo as Zaduzenje;

                string upit = $"Select * from Zaduzenje where ClanskiBroj = {z.Clan.ClanskiBroj} and" +
                $" PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}" +
                $" and DatumDo is NULL";
                List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, z);



                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
