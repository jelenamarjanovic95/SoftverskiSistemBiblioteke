using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Clan : IOpstiDomenskiObjekat
    {
        private int clanskiBroj;
        private string imePrezime;
        private string brojTelefona;
        private string adresa;

        private List<Zaduzenje> listaZaduzenja;


        public Clan()
        {
            listaZaduzenja = new List<Zaduzenje>();
        }

        public int ClanskiBroj { get => clanskiBroj; set => clanskiBroj = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public List<Zaduzenje> ListaZaduzenja { get => listaZaduzenja; set => listaZaduzenja = value; }

        public override string ToString()
        {
            return $"{clanskiBroj}: {imePrezime}";
        }

        public string VratiImeTabele()
        {
            return "Clan";
        }

        public string VratiKljucIUslov()
        {
            return $"ClanskiBroj = {clanskiBroj}";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            throw new NotImplementedException();
        }
    }
}
