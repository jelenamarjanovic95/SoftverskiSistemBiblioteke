using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum KriterijumPretrageClan
    {
        ImePrezime,
        ClanskiBroj
    }
    [Serializable]
    public class Clan
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
    }
}
