using Model;
using Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public object Rezultat { get; set; }

        public bool IzvrsiSO(IOpstiDomenskiObjekat odo)
        {
            bool rezultat = false;

            GenerickiBroker.Instanca.OtvoriKonekciju();
            GenerickiBroker.Instanca.PokreniTransakciju();
            rezultat = Izvrsi(odo);
            if (rezultat)
            {
                GenerickiBroker.Instanca.Commit();
            }
            else
            {
                GenerickiBroker.Instanca.Rollback();
            }
            GenerickiBroker.Instanca.ZatvoriKonekciju();
            return rezultat;
        }

        protected abstract bool Izvrsi(IOpstiDomenskiObjekat odo);

    }
}
