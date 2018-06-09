using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class ObrisiClanaSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                GenerickiBroker.Instanca.Delete(odo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
