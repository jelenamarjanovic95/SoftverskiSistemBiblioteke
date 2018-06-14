using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KnjigaAutor:IOpstiDomenskiObjekat
    {
        public int KnjigaID { get; set; }
        public int AutorID { get; set; }

        public string VratiImeTabele()
        {
            return "KnjigaAutor";
        }

        public string VratiKljucIUslov()
        {
            return $"KnjigaID = {KnjigaID} and AutorID = {AutorID}";
        }

        public string VratiKljucZaMax()
        {
            return "";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();

            while (citac.Read())
            {
                KnjigaAutor ka = new KnjigaAutor()
                {
                    AutorID = Convert.ToInt32(citac["AutorID"]),
                    KnjigaID = Convert.ToInt32(citac["KnjigaID"])
                };
                lista.Add(ka);
            }

            return lista;
        }

        public string VratiVrednostiZaInsert()
        {
            return $"{KnjigaID}, {AutorID}";
        }

        public string VratiVrednostZaUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
