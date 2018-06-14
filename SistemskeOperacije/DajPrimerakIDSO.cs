using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class DajPrimerakIDSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                int id = GenerickiBroker.Instanca.SelectMax(odo);

                Rezultat = id;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
