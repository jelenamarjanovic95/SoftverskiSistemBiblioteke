﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class NadjiClanaSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Clan clan = odo as Clan;
                string upit = $"Select * from Clan where ClanskiBroj = {clan.ClanskiBroj}";

                List<IOpstiDomenskiObjekat> clanovi = GenerickiBroker.Instanca.ExecuteReader(upit, odo);

                foreach (IOpstiDomenskiObjekat o in clanovi)
                {
                    Clan c = o as Clan;
                    upit = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                    $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";

                    upit = $"Select * from Zaduzenje where ClanskiBroj = {c.ClanskiBroj}";

                    List<IOpstiDomenskiObjekat> listaZaduzenja = GenerickiBroker.Instanca.ExecuteReader(upit, new Zaduzenje());

                    foreach (IOpstiDomenskiObjekat zaduzenje in listaZaduzenja)
                    {
                        Zaduzenje z = zaduzenje as Zaduzenje;
                        z.Clan = c;

                        upit = $"Select * from KnjigaPrimerak where PrimerakID = {z.KnjigaPrimerak.PrimerakID}";

                        c.ListaZaduzenja.Add(z);
                    }

                }
                if (clanovi.Count == 0) return false;

                Rezultat = clanovi[0];
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
