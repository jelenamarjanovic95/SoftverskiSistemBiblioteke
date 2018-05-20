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
    public class Autor : IOpstiDomenskiObjekat
    {
        private int autorID;
        private string imePrezime;
        private int godinaRodjenja;
        private string biografija;

        [Browsable(false)]
        public int AutorID { get => autorID; set => autorID = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public int GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
        [Browsable(false)]
        public string Biografija { get => biografija; set => biografija = value; }

        public override string ToString()
        {
            return imePrezime;
        }

        public string VratiImeTabele()
        {
            return "Autor";
        }

        public string VratiKljucIUslov()
        {
            return "";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> listaAutora = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Autor a = new Autor()
                {
                    AutorID = Convert.ToInt32(citac["AutorID"]),
                    Biografija = citac["Biografija"].ToString(),
                    GodinaRodjenja = Convert.ToInt32(citac["GodinaRodjenja"]),
                    ImePrezime = citac["ImePrezime"].ToString()
                };

                listaAutora.Add(a);
            }

            return listaAutora;
        }

        public string VratiVrednostiZaInsert()
        {
            return "";
        }
    }
}
