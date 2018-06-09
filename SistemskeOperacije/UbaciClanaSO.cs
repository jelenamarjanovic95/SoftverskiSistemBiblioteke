using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class UbaciClanaSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Clan c = odo as Clan;
                c.ClanskiBroj = GenerickiBroker.Instanca.DajClanskiBroj();

                int rez = GenerickiBroker.Instanca.Insert(c);

                if (rez > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
