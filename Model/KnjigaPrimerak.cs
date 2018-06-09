using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class KnjigaPrimerak : IOpstiDomenskiObjekat
    {
        private int primerakID;
        private bool raspoloziva;
        private Knjiga knjiga;

        public KnjigaPrimerak()
        {
            raspoloziva = true;
        }

        public int PrimerakID { get => primerakID; set => primerakID = value; }
        public bool Raspoloziva { get => raspoloziva; set => raspoloziva = value; }
        [Browsable(false)]
        public Knjiga Knjiga { get => knjiga; set => knjiga = value; }

        //TODO: Umesto true/false da pise raspoloziva ili zauzeta
        public override string ToString()
        {
            return $"{knjiga.Naziv}";
        }

        public string VratiImeTabele()
        {
            return "KnjigaPrimerak";
        }

        public string VratiKljucIUslov()
        {
            return $"KnjigaPrimerak.KnjigaID = {knjiga.KnjigaID} and PrimerakID = {PrimerakID}"; //Treba dodati i primerakID?
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();

            while (citac.Read())
            {
                KnjigaPrimerak kp = new KnjigaPrimerak()
                {
                    Knjiga = new Knjiga()
                    {
                        KnjigaID = Convert.ToInt32(citac["KnjigaID"])
                    },
                    PrimerakID = Convert.ToInt32(citac["PrimerakID"]),
                    Raspoloziva = Convert.ToBoolean(citac["Raspoloziva"])
                };
                lista.Add(kp);
            }

            return lista;
        }

        public string VratiVrednostiZaInsert()
        {
            return $"{PrimerakID}, {knjiga.KnjigaID}, {Raspoloziva}";
        }

        public string VratiVrednostZaUpdate()
        {
            return $"Raspoloziva = {!raspoloziva}";
        }
    }
}
