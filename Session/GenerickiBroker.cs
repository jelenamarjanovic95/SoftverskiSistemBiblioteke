using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class GenerickiBroker
    {
        private OleDbConnection konekcija;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acoji\Desktop\Jelena\Softveri\SoftveriProjekat\Baza.accdb";
        //private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\gufs\Users$\marjanovic.jelena\Documents\Projekat\Baza.accdb";

        private OleDbCommand komanda;
        private OleDbTransaction transakcija;

        #region Singleton
        private static GenerickiBroker instanca;
        
        private GenerickiBroker()
        {
            KonektujSe();
        }

        public static GenerickiBroker Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new GenerickiBroker();
                return instanca;
            }
        }

        void KonektujSe()
        {
            konekcija = new OleDbConnection(connectionString);
            komanda = konekcija.CreateCommand();
        }
        #endregion

        #region OsnovneFje
        public void PokreniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
            komanda.Transaction = transakcija;
        }

        public void Commit()
        {
            transakcija.Commit();
        }

        public void Rollback()
        {
            transakcija.Rollback();
        }

        public void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        public void ZatvoriKonekciju()
        {
            if (konekcija != null)
                konekcija.Close();
        }
        #endregion

        #region ProsteGenericke
        public int Insert(IOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Insert into {odo.VratiImeTabele()} values ({odo.VratiVrednostiZaInsert()})";
            komanda.CommandType = System.Data.CommandType.Text;
            return komanda.ExecuteNonQuery();
        }
        
        public void Update(IOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Update {odo.VratiImeTabele()} set {odo.VratiVrednostZaUpdate()} where {odo.VratiKljucIUslov()}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
        }

        public void Delete(IOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Delete from {odo.VratiImeTabele()} where {odo.VratiKljucIUslov()}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
        }

        public List<IOpstiDomenskiObjekat> VratiSve(IOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Select * from {odo.VratiImeTabele()}";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();
            List<IOpstiDomenskiObjekat> lista =  odo.VratiListu(citac);
            citac.Close();
            return lista;
        }
        #endregion

       
        public void SlozenInsert(List<IOpstiDomenskiObjekat> odos)
        {
            foreach(IOpstiDomenskiObjekat odo in odos)
            {
                this.Insert(odo);
            }
        }

        public void SlozenUpdate(List<IOpstiDomenskiObjekat> odos)
        {
            foreach (IOpstiDomenskiObjekat odo in odos)
            {
                this.Update(odo);
            }
        }

        public void ExecuteNonQuery(string upit)
        {
            komanda.CommandText = upit;
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
        }

        public List<IOpstiDomenskiObjekat> ExecuteReader(string upit, IOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = upit;
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();
            List<IOpstiDomenskiObjekat> lista = odo.VratiListu(citac);
            citac.Close();
            return lista;
        }

        public int DajClanskiBroj()
        {
            komanda.CommandText = "Select Max(ClanskiBroj) from Clan";
            komanda.CommandType = System.Data.CommandType.Text;

            var res = komanda.ExecuteScalar();
            if (res != DBNull.Value)
            {
                return Convert.ToInt32(res) + 23;
            }
            else
            {
                return 1111;
            }
        }

        public int DajKnjigaID()
        {
            komanda.CommandText = "Select Max(KnjigaID) from Knjiga";
            komanda.CommandType = System.Data.CommandType.Text;

            var res = komanda.ExecuteScalar();
            if (res != DBNull.Value)
            {
                return Convert.ToInt32(res) + 1;
            }
            else
            {
                return 1111;
            }
        }

        public int DajPrimerakID()
        {
            komanda.CommandText = "Select Max(PrimerakID) from KnjigaPrimerak";
            komanda.CommandType = System.Data.CommandType.Text;

            var res = komanda.ExecuteScalar();
            if (res != DBNull.Value)
            {
                return Convert.ToInt32(res) + 1;
            }
            else
            {
                return 111;
            }

        }
    }
}
