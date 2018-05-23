using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum KriterijumPretrageKnjiga
    {
        Naziv,
        ImePrezimeAutora,
        KnjigaID
    }
    [Serializable]
    public class Knjiga : IOpstiDomenskiObjekat
    {
        private int knjigaID;
        private string naziv;
        private string opis;
        private int godinaIzdanja;
        private int brojPrimeraka;
        private int raspolozivo;
        
        private List<Autor> listaAutora;
        private List<KnjigaPrimerak> spisakPrimeraka;

        public Knjiga()
        {
            listaAutora = new List<Autor>();
            spisakPrimeraka = new List<KnjigaPrimerak>();
            brojPrimeraka = 0;
            raspolozivo = 0;
        }

        [Browsable(false)]
        public int KnjigaID { get => knjigaID; set => knjigaID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        //TODO: Izbrisati poslednji zarez
        public string Autori
        {
            get
            {
                string rez = "";
                foreach (Autor a in listaAutora)
                {
                    rez += a.ImePrezime;
                    rez += "\t";
                }
                Console.WriteLine(rez);
                return rez;
            }
        }
        [Browsable(false)]
        public string Opis { get => opis; set => opis = value; }
        [Browsable(false)]
        public int GodinaIzdanja { get => godinaIzdanja; set => godinaIzdanja = value; }
        [Browsable(false)]
        public int BrojPrimeraka { get => brojPrimeraka; set => brojPrimeraka = value; }

        [DisplayName("Raspolozivo primeraka")]
        public int Raspolozivo { get => raspolozivo; set => raspolozivo = value; }

        public List<Autor> ListaAutora { get => listaAutora; set => listaAutora = value; }
        public List<KnjigaPrimerak> SpisakPrimeraka {
            get => spisakPrimeraka;
            set {
                spisakPrimeraka = value;
                brojPrimeraka = spisakPrimeraka.Count;
                raspolozivo = spisakPrimeraka.Count;
            }
        }
       
        //TODO: Ime i prezime autora
        public override string ToString()
        {
            return $"{naziv}";
        }

        public string VratiImeTabele()
        {
            return "Knjiga";
        }

        public string VratiKljucIUslov()
        {
            return $"KnjigaID = {KnjigaID}";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            return $"{knjigaID}, '{Naziv}', '{Opis}', {GodinaIzdanja}, {BrojPrimeraka}, {Raspolozivo}";
        }

        public string VratiVrednostZaUpdate()
        {
            return $"Naziv = '{Naziv}', Opis = '{Opis}', GodinaIzdanja = {GodinaIzdanja}";
        }
    }
}
