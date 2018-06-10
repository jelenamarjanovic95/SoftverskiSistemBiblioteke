using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Session;

namespace SistemskeOperacije
{
    public class UbaciKnjiguSO : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                Knjiga k = odo as Knjiga;
                k.KnjigaID = GenerickiBroker.Instanca.DajKnjigaID();

                int rez = GenerickiBroker.Instanca.Insert(k);

                if (rez > 0)
                {
                    foreach (KnjigaPrimerak kp in k.SpisakPrimeraka)
                    {
                        kp.Knjiga = k;
                        GenerickiBroker.Instanca.Insert(kp);
                    }

                    foreach(Autor a in k.ListaAutora)
                    {
                        KnjigaAutor ka = new KnjigaAutor()
                        {
                            AutorID = a.AutorID,
                            KnjigaID = k.KnjigaID
                        };
                        GenerickiBroker.Instanca.Insert(ka);
                    }
                }
                else return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
