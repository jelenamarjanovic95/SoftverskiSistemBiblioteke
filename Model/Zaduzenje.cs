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
    public class Zaduzenje : IOpstiDomenskiObjekat
    {
        private Clan clan;
        private KnjigaPrimerak knjigaPrimerak;
        private DateTime datumOd;
        private DateTime? datumDo;

        public Zaduzenje()
        {
            datumDo = null;
        }

        [DisplayName("Naziv knjige")]
        public KnjigaPrimerak KnjigaPrimerak { get => knjigaPrimerak; set => knjigaPrimerak = value; }
        [DisplayName("Datum zaduzenja")]
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        [DisplayName("Datum razduzenja")]
        public DateTime? DatumDo { get => datumDo; set => datumDo = value; }
        [Browsable(false)]
        public Clan Clan { get => clan; set => clan = value; }

        public override string ToString()
        {
            string datdo;
            if (datumDo == null)
            {
                datdo = "/";
            }
            else
            {
                datdo = datumDo.Value.ToString("dd.MM.yyyy");
            }
            return $"Zaduzenje: {clan.ClanskiBroj} - {knjigaPrimerak.Knjiga.ToString()}, od {DatumOd.ToString("dd.MM.yyyy")}\nVracena: {datdo}";
        }

        public string VratiImeTabele()
        {
            return "Zaduzenje";
        }

        public string VratiKljucIUslov()
        {
            return $"ClanskiBroj = {Clan.ClanskiBroj} and PrimerakID = {KnjigaPrimerak.PrimerakID} and KnjigaID = {KnjigaPrimerak.Knjiga.KnjigaID} and DatumOd = #{DatumOd.ToString("dd-MMM-yyyy")}#";
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
                Zaduzenje z = new Zaduzenje()
                {
                    DatumOd = Convert.ToDateTime(citac["DatumOd"]),
                    KnjigaPrimerak = new KnjigaPrimerak()
                    {
                        PrimerakID = Convert.ToInt32(citac["PrimerakID"]),
                        Knjiga = new Knjiga()
                        {
                            KnjigaID = Convert.ToInt32(citac["KnjigaID"])
                        }
                    },
                    Clan = new Clan()
                    {
                        ClanskiBroj = Convert.ToInt32(citac["ClanskiBroj"])
                    }
                };
                if (citac["DatumDo"] != DBNull.Value)
                {
                    z.DatumDo = Convert.ToDateTime(citac["DatumDo"]);
                }

                lista.Add(z);

            }
            return lista;
        }

        public string VratiVrednostiZaInsert()
        {
            return $"{Clan.ClanskiBroj}, {KnjigaPrimerak.Knjiga.KnjigaID}, {KnjigaPrimerak.PrimerakID}, '{DateTime.Now.ToShortDateString()}', NULL";
        }

        public string VratiVrednostZaUpdate()
        {
            return $"DatumDo = '{DateTime.Now.ToString("dd-MMM-yyyy")}'";
        }
    }
}
