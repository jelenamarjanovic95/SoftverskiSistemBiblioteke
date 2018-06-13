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
                Zaduzenje zaduzenje = odo as Zaduzenje;

                string upit = $"Select * from Zaduzenje where ClanskiBroj = {zaduzenje.Clan.ClanskiBroj} and" +
                $" PrimerakID = {zaduzenje.KnjigaPrimerak.PrimerakID} and KnjigaID = {zaduzenje.KnjigaPrimerak.Knjiga.KnjigaID}" +
                $" and DatumDo is NULL";
                List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, zaduzenje);

                if (listaZaduzenja.Count == 0) return false;
                Zaduzenje z = listaZaduzenja[0] as Zaduzenje;

                upit = $"Select * from Clan where ClanskiBroj = {z.Clan.ClanskiBroj}";
                List<IOpstiDomenskiObjekat> listaClanova = GenerickiBroker.Instanca.ExecuteReader(upit, new Clan());
                if (listaClanova.Count == 0) return false;
                z.Clan = listaClanova[0] as Clan;

                upit = $"Select * from KnjigaPrimerak where PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                List<IOpstiDomenskiObjekat> listaPrimeraka = GenerickiBroker.Instanca.ExecuteReader(upit, new KnjigaPrimerak());
                if (listaPrimeraka.Count == 0) return false;
                z.KnjigaPrimerak = listaPrimeraka[0] as KnjigaPrimerak;
                
                Rezultat = z;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
