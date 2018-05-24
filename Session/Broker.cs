using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class Broker
    {
        #region singleton
        private static Broker instanca;

        OleDbConnection konekcija;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acoji\Desktop\Jelena\Softveri\Projekat\Baza.accdb";
        //private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\gufs\Users$\marjanovic.jelena\Documents\Projekat\Baza.accdb";

        OleDbCommand komanda;
        OleDbTransaction transakcija;

        private Broker()
        {
            KonektujSe();
        }

        public static Broker Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new Broker();
                return instanca;
            }
        }

        void KonektujSe()
        {
            konekcija = new OleDbConnection(connectionString);
            //konekcija = new OleDbConnection(connStrIrc);
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

        #region VRATISVE
        public List<Clan> VratiSveClanove()
        {
            List<Clan> listaClanova = new List<Clan>();

            komanda.CommandText = "Select * from Clan order by ImePrezime";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Clan c = new Clan()
                {
                    Adresa = citac["Adresa"].ToString(),
                    BrojTelefona = citac["BrojTelefona"].ToString(),
                    ImePrezime = citac["ImePrezime"].ToString(),
                    ClanskiBroj = Convert.ToInt32(citac["ClanskiBroj"])
                };

               OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                    $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";
                komanda2.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac2 = komanda2.ExecuteReader();
                
                #region zaduzenje
                while (citac2.Read())
                {
                    Zaduzenje z = new Zaduzenje()
                    {
                        Clan = c,
                        DatumOd = Convert.ToDateTime(citac2["DatumOd"]),
                        KnjigaPrimerak = new KnjigaPrimerak()
                        {
                            PrimerakID = Convert.ToInt32(citac2["Zaduzenje.PrimerakID"]),
                            Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"]),
                            Knjiga = new Knjiga()
                            {
                                GodinaIzdanja = Convert.ToInt32(citac2["GodinaIzdanja"]),
                                Naziv = citac2["Naziv"].ToString(),
                                Opis = citac2["Opis"].ToString(),
                                KnjigaID = Convert.ToInt32(citac2["Knjiga.KnjigaID"]),
                                BrojPrimeraka = Convert.ToInt32(citac2["BrojPrimeraka"]),
                                Raspolozivo = Convert.ToInt32(citac2["Raspolozivo"])
                            }
                        }
                    };
                    if (citac2["DatumDo"] != DBNull.Value)
                    {
                        z.DatumDo = Convert.ToDateTime(citac2["DatumDo"]);
                    }

                    OleDbCommand komanda3 = konekcija.CreateCommand();
                    komanda3.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                    komanda3.CommandType = System.Data.CommandType.Text;
                    OleDbDataReader citac3 = komanda3.ExecuteReader();

                    while (citac3.Read())
                    {
                        KnjigaPrimerak kp = new KnjigaPrimerak()
                        {
                            Knjiga = z.KnjigaPrimerak.Knjiga,
                            PrimerakID = Convert.ToInt32(citac3["PrimerakID"]),
                            Raspoloziva = Convert.ToBoolean(citac3["Raspoloziva"])
                        };
                        z.KnjigaPrimerak.Knjiga.SpisakPrimeraka.Add(kp);
                    }
                    OleDbCommand komanda4 = konekcija.CreateCommand();
                    komanda4.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                    komanda4.CommandType = System.Data.CommandType.Text;
                    OleDbDataReader citac4 = komanda4.ExecuteReader();

                    while (citac4.Read())
                    {
                        Autor a = new Autor()
                        {
                            AutorID = Convert.ToInt32(citac4["Autor.AutorID"]),
                            Biografija = citac4["Biografija"].ToString(),
                            ImePrezime = citac4["ImePrezime"].ToString(),
                            GodinaRodjenja = Convert.ToInt32(citac4["GodinaRodjenja"])
                        };
                        z.KnjigaPrimerak.Knjiga.ListaAutora.Add(a);
                    }

                    c.ListaZaduzenja.Add(z);
                }
                #endregion
                listaClanova.Add(c);
            }

            return listaClanova;
        }

        public List<Knjiga> VratiSveKnjige()
        {
            List<Knjiga> listaKnjiga = new List<Knjiga>();

            komanda.CommandText = "Select * from Knjiga order by Naziv ASC";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Knjiga k = new Knjiga()
                {
                    GodinaIzdanja = Convert.ToInt32(citac["GodinaIzdanja"]),
                    Naziv = citac["Naziv"].ToString(),
                    Opis = citac["Opis"].ToString(),
                    KnjigaID = Convert.ToInt32(citac["KnjigaID"]),
                    BrojPrimeraka = Convert.ToInt32(citac["BrojPrimeraka"]),
                    Raspolozivo = Convert.ToInt32(citac["Raspolozivo"])
                };
                OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                komanda2.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac2 = komanda2.ExecuteReader();

                while (citac2.Read())
                {
                    KnjigaPrimerak kp = new KnjigaPrimerak()
                    {
                        Knjiga = k,
                        PrimerakID = Convert.ToInt32(citac2["PrimerakID"]),
                        Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"])
                    };
                    k.SpisakPrimeraka.Add(kp);
                }
                OleDbCommand komanda3 = konekcija.CreateCommand();
                komanda3.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {k.KnjigaID}";
                komanda3.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac3 = komanda3.ExecuteReader();

                while (citac3.Read())
                {
                    Autor a = new Autor()
                    {
                        AutorID = Convert.ToInt32(citac3["Autor.AutorID"]),
                        Biografija = citac3["Biografija"].ToString(),
                        ImePrezime = citac3["ImePrezime"].ToString(),
                        GodinaRodjenja = Convert.ToInt32(citac3["GodinaRodjenja"])
                    };
                    k.ListaAutora.Add(a);
                }

                listaKnjiga.Add(k);
            }

            return listaKnjiga;
        }

        public List<Autor> VratiSveAutore()
        {
            List<Autor> listaAutora = new List<Autor>();

            komanda.CommandText = "Select * from Autor order by ImePrezime ASC";
            komanda.CommandType = System.Data.CommandType.Text;
            

            OleDbDataReader citac = komanda.ExecuteReader();
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
        #endregion

        #region KNJIGA
        private int DajKnjigaID()
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

        private List<Knjiga> NadjiKnjigePoAutoru(List<Knjiga> lista, string vrednostKriterijuma)
        {
            List<Knjiga> listaKnjiga = new List<Knjiga>();
            bool nasao;

            foreach(Knjiga k in lista)
            {
                nasao = false;
                foreach(Autor a in k.ListaAutora)
                {
                    if (a.ImePrezime.ToLower().Contains(vrednostKriterijuma.ToLower()))
                    {
                        listaKnjiga.Add(k);
                        break;
                    }
                    if (nasao)
                        break;
                }
            }
            return listaKnjiga;
        }

        public void SacuvajIzmeneKnjiga(Knjiga novo)
        {
            this.komanda.CommandText = $"update Knjiga set Naziv = '{novo.Naziv}', Opis = '{novo.Opis}', GodinaIzdanja = {novo.GodinaIzdanja} where KnjigaID = {novo.KnjigaID}";
            this.komanda.CommandType = System.Data.CommandType.Text;

            int res = this.komanda.ExecuteNonQuery();

            this.komanda.CommandText = $"Delete from KnjigaAutor where KnjigaID = {novo.KnjigaID}";
            this.komanda.CommandType = System.Data.CommandType.Text;
            this.komanda.ExecuteNonQuery();

            foreach (Autor a in novo.ListaAutora)
            {
                komanda.CommandText = $"Insert into KnjigaAutor values ({novo.KnjigaID}, {a.AutorID})";
                komanda.CommandType = System.Data.CommandType.Text;
                komanda.ExecuteNonQuery();
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
        
        public int UbaciKnjigu(Knjiga k)
        {
            int knjigaID = this.DajKnjigaID();
            komanda.CommandText = $"insert into Knjiga values ({knjigaID}, '{k.Naziv}', '{k.Opis}', {k.GodinaIzdanja}, {k.BrojPrimeraka}, {k.Raspolozivo})";
            komanda.CommandType = System.Data.CommandType.Text;

            int res = komanda.ExecuteNonQuery();

            if (res > 0)
            {
                foreach (KnjigaPrimerak kp in k.SpisakPrimeraka)
                {
                    komanda.CommandText = $"insert into KnjigaPrimerak values ({kp.PrimerakID}, {knjigaID}, {kp.Raspoloziva})";
                    komanda.CommandType = System.Data.CommandType.Text;
                    komanda.ExecuteNonQuery();
                }

                foreach (Autor a in k.ListaAutora)
                {
                    komanda.CommandText = $"insert into KnjigaAutor values ({knjigaID}, {a.AutorID})";
                    komanda.CommandType = System.Data.CommandType.Text;
                    komanda.ExecuteNonQuery();
                }
            }
            return knjigaID;
        }

        public List<Knjiga> PretraziKnjige(string vrednostKriterijuma, KriterijumPretrage kriterijum)
        {
            List<Knjiga> listaKnjiga = new List<Knjiga>();

            switch (kriterijum)
            {
                case KriterijumPretrage.NazivKnjige:
                    komanda.CommandText = $"Select * from Knjiga where Naziv like '%{vrednostKriterijuma}%' order by Naziv ASC";
                    break;
                case KriterijumPretrage.ImePrezimeAutor:
                    listaKnjiga = this.VratiSveKnjige();
                    return this.NadjiKnjigePoAutoru(listaKnjiga, vrednostKriterijuma);
                case KriterijumPretrage.BrojKnjige:
                    komanda.CommandText = $"Select * from Knjiga where KnjigaID = {Convert.ToInt32(vrednostKriterijuma)} order by Naziv ASC";
                    break;
            }
            
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Knjiga k = new Knjiga()
                {
                    GodinaIzdanja = Convert.ToInt32(citac["GodinaIzdanja"]),
                    Naziv = citac["Naziv"].ToString(),
                    Opis = citac["Opis"].ToString(),
                    KnjigaID = Convert.ToInt32(citac["KnjigaID"]),
                    BrojPrimeraka = Convert.ToInt32(citac["BrojPrimeraka"]),
                    Raspolozivo = Convert.ToInt32(citac["Raspolozivo"])
                };
                OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                komanda2.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac2 = komanda2.ExecuteReader();

                while (citac2.Read())
                {
                    KnjigaPrimerak kp = new KnjigaPrimerak()
                    {
                        Knjiga = k,
                        PrimerakID = Convert.ToInt32(citac2["PrimerakID"]),
                        Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"])
                    };
                    k.SpisakPrimeraka.Add(kp);
                }
                OleDbCommand komanda3 = konekcija.CreateCommand();
                komanda3.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {k.KnjigaID}";
                komanda3.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac3 = komanda3.ExecuteReader();

                while (citac3.Read())
                {
                    Autor a = new Autor()
                    {
                        AutorID = Convert.ToInt32(citac3["Autor.AutorID"]),
                        Biografija = citac3["Biografija"].ToString(),
                        ImePrezime = citac3["ImePrezime"].ToString(),
                        GodinaRodjenja = Convert.ToInt32(citac3["GodinaRodjenja"])
                    };
                    k.ListaAutora.Add(a);
                }

                listaKnjiga.Add(k);
            }

            return listaKnjiga;
        }

        public Knjiga NadjiKnjigu(int knjigaID)
        {
            List<Knjiga> listaKnjiga = new List<Knjiga>();

            komanda.CommandText = $"Select * from Knjiga where KnjigaID = {knjigaID} order by Naziv ASC";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Knjiga k = new Knjiga()
                {
                    GodinaIzdanja = Convert.ToInt32(citac["GodinaIzdanja"]),
                    Naziv = citac["Naziv"].ToString(),
                    Opis = citac["Opis"].ToString(),
                    KnjigaID = Convert.ToInt32(citac["KnjigaID"]),
                    BrojPrimeraka = Convert.ToInt32(citac["BrojPrimeraka"]),
                    Raspolozivo = Convert.ToInt32(citac["Raspolozivo"])
                };
                OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {k.KnjigaID}";
                komanda2.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac2 = komanda2.ExecuteReader();

                while (citac2.Read())
                {
                    KnjigaPrimerak kp = new KnjigaPrimerak()
                    {
                        Knjiga = k,
                        PrimerakID = Convert.ToInt32(citac2["PrimerakID"]),
                        Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"])
                    };
                    k.SpisakPrimeraka.Add(kp);
                }
                OleDbCommand komanda3 = konekcija.CreateCommand();
                komanda3.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {k.KnjigaID}";
                komanda3.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac3 = komanda3.ExecuteReader();

                while (citac3.Read())
                {
                    Autor a = new Autor()
                    {
                        AutorID = Convert.ToInt32(citac3["Autor.AutorID"]),
                        Biografija = citac3["Biografija"].ToString(),
                        ImePrezime = citac3["ImePrezime"].ToString(),
                        GodinaRodjenja = Convert.ToInt32(citac3["GodinaRodjenja"])
                    };
                    k.ListaAutora.Add(a);
                }

                listaKnjiga.Add(k);
            }
            if (listaKnjiga.Count == 0) return null;
            return listaKnjiga[0];
        }
        
        public void ObrisiKnjigu(Knjiga k) {
            komanda.CommandText = $"Delete from KnjigaPrimerak where KnjigaID = {k.KnjigaID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"Delete from KnjigaAutor where KnjigaID = {k.KnjigaID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"Delete from Knjiga where KnjigaID = {k.KnjigaID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
        }
        #endregion

        #region CLAN
        public void SacuvajIzmeneClan(Clan novi)
        {

            komanda.CommandText = $"update Clan set ImePrezime = '{novi.ImePrezime}', BrojTelefona = '{novi.BrojTelefona}', Adresa = '{novi.Adresa}' where ClanskiBroj = {novi.ClanskiBroj}";
            komanda.CommandType = System.Data.CommandType.Text;

            komanda.ExecuteNonQuery();

        }

        private int DajClanskiBroj()
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

        public int UbaciClana(Clan c)
        {
            int cb = this.DajClanskiBroj();
            komanda.CommandText = $"Insert into Clan values ({cb}, '{c.ImePrezime}', '{c.BrojTelefona}', '{c.Adresa}')";
            komanda.CommandType = System.Data.CommandType.Text;

            komanda.ExecuteNonQuery();
            return cb;
        }

        public List<Clan> PretraziClanove(string vrednostKriterijuma, KriterijumPretrage kriterijum)
        {
            List<Clan> listaClanova = new List<Clan>();

            switch (kriterijum)
            {
                case KriterijumPretrage.ImePrezimeClan:
                    komanda.CommandText = $"Select * from Clan where ImePrezime like '%{vrednostKriterijuma}%' order by ImePrezime";
                    break;
                case KriterijumPretrage.ClanskiBroj:
                    komanda.CommandText = $"Select * from Clan where ClanskiBroj = {Convert.ToInt32(vrednostKriterijuma)} order by ImePrezime";
                    break;
            }
            
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Clan c = new Clan()
                {
                    Adresa = citac["Adresa"].ToString(),
                    BrojTelefona = citac["BrojTelefona"].ToString(),
                    ImePrezime = citac["ImePrezime"].ToString(),
                    ClanskiBroj = Convert.ToInt32(citac["ClanskiBroj"])
                };

                c.ListaZaduzenja = VratiListuZaduzenjaClana(c);
                listaClanova.Add(c);
            }

            return listaClanova;
        }

        public Clan NadjiClana(int clanskiBroj)
        {
            List<Clan> lista = new List<Clan>();
            komanda.CommandText = $"Select * from Clan where ClanskiBroj = {clanskiBroj}";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Clan c = new Clan()
                {
                    Adresa = citac["Adresa"].ToString(),
                    BrojTelefona = citac["BrojTelefona"].ToString(),
                    ImePrezime = citac["ImePrezime"].ToString(),
                    ClanskiBroj = Convert.ToInt32(citac["ClanskiBroj"])
                };

                OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                    $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";
                komanda2.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac2 = komanda2.ExecuteReader();

                #region zaduzenje
                while (citac2.Read())
                {
                    Zaduzenje z = new Zaduzenje()
                    {
                        Clan = c,
                        DatumOd = Convert.ToDateTime(citac2["DatumOd"]),
                        KnjigaPrimerak = new KnjigaPrimerak()
                        {
                            PrimerakID = Convert.ToInt32(citac2["Zaduzenje.PrimerakID"]),
                            Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"]),
                            Knjiga = new Knjiga()
                            {
                                GodinaIzdanja = Convert.ToInt32(citac2["GodinaIzdanja"]),
                                Naziv = citac2["Naziv"].ToString(),
                                Opis = citac2["Opis"].ToString(),
                                KnjigaID = Convert.ToInt32(citac2["Knjiga.KnjigaID"]),
                                BrojPrimeraka = Convert.ToInt32(citac2["BrojPrimeraka"]),
                                Raspolozivo = Convert.ToInt32(citac2["Raspolozivo"])
                            }
                        }
                    };
                    if (citac2["DatumDo"] != DBNull.Value)
                    {
                        z.DatumDo = Convert.ToDateTime(citac2["DatumDo"]);
                    }

                    OleDbCommand komanda3 = konekcija.CreateCommand();
                    komanda3.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                    komanda3.CommandType = System.Data.CommandType.Text;
                    OleDbDataReader citac3 = komanda3.ExecuteReader();

                    while (citac3.Read())
                    {
                        KnjigaPrimerak kp = new KnjigaPrimerak()
                        {
                            Knjiga = z.KnjigaPrimerak.Knjiga,
                            PrimerakID = Convert.ToInt32(citac3["PrimerakID"]),
                            Raspoloziva = Convert.ToBoolean(citac3["Raspoloziva"])
                        };
                        z.KnjigaPrimerak.Knjiga.SpisakPrimeraka.Add(kp);
                    }
                    OleDbCommand komanda4 = konekcija.CreateCommand();
                    komanda4.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                    komanda4.CommandType = System.Data.CommandType.Text;
                    OleDbDataReader citac4 = komanda4.ExecuteReader();

                    while (citac4.Read())
                    {
                        Autor a = new Autor()
                        {
                            AutorID = Convert.ToInt32(citac4["Autor.AutorID"]),
                            Biografija = citac4["Biografija"].ToString(),
                            ImePrezime = citac4["ImePrezime"].ToString(),
                            GodinaRodjenja = Convert.ToInt32(citac4["GodinaRodjenja"])
                        };
                        z.KnjigaPrimerak.Knjiga.ListaAutora.Add(a);
                    }

                    c.ListaZaduzenja.Add(z);
                }
                #endregion
                lista.Add(c);
            }
            if (lista.Count == 0) return null;
            return lista[0];
        }
        
        public void ObrisiClana(Clan c) {
            komanda.CommandText = $"Delete from Clan where ClanskiBroj = {c.ClanskiBroj}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
        }
        #endregion

        #region ZADUZENJE
        public void Zaduzi(Zaduzenje z)
        {
            komanda.CommandText = $"insert into Zaduzenje values({z.Clan.ClanskiBroj}, {z.KnjigaPrimerak.Knjiga.KnjigaID}, {z.KnjigaPrimerak.PrimerakID}, '{DateTime.Now.ToShortDateString()}', NULL)";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"update KnjigaPrimerak set Raspoloziva = false where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo - 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

        }

        public void Razduzi(Zaduzenje z)
        {
            komanda.CommandText = $"Update Zaduzenje set DatumDo = '{DateTime.Now.ToString("dd-MMM-yyyy")}' where ClanskiBroj = {z.Clan.ClanskiBroj} and " +
                $"PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and DatumOd = #{z.DatumOd.ToString("dd-MMM-yyyy")}#";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"Update KnjigaPrimerak set Raspoloziva = true where PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();

            komanda.CommandText = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo + 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
            komanda.CommandType = System.Data.CommandType.Text;
            komanda.ExecuteNonQuery();
            
        }
         
        private List<Zaduzenje> VratiListuZaduzenjaClana(Clan c)
        {
            List<Zaduzenje> lista = new List<Zaduzenje>();

            OleDbCommand komanda2 = konekcija.CreateCommand();
            komanda2.CommandText = $"Select * from (Zaduzenje inner join KnjigaPrimerak on Zaduzenje.PrimerakID = KnjigaPrimerak.PrimerakID) " +
                $"inner join Knjiga on KnjigaPrimerak.KnjigaID = Knjiga.KnjigaID where Zaduzenje.ClanskiBroj = {c.ClanskiBroj}";
            komanda2.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac2 = komanda2.ExecuteReader();
            
            while (citac2.Read())
            {
                Zaduzenje z = new Zaduzenje()
                {
                    Clan = c,
                    DatumOd = Convert.ToDateTime(citac2["DatumOd"]),
                    KnjigaPrimerak = new KnjigaPrimerak()
                    {
                        PrimerakID = Convert.ToInt32(citac2["Zaduzenje.PrimerakID"]),
                        Raspoloziva = Convert.ToBoolean(citac2["Raspoloziva"]),
                        Knjiga = new Knjiga()
                        {
                            GodinaIzdanja = Convert.ToInt32(citac2["GodinaIzdanja"]),
                            Naziv = citac2["Naziv"].ToString(),
                            Opis = citac2["Opis"].ToString(),
                            KnjigaID = Convert.ToInt32(citac2["Knjiga.KnjigaID"]),
                            BrojPrimeraka = Convert.ToInt32(citac2["BrojPrimeraka"]),
                            Raspolozivo = Convert.ToInt32(citac2["Raspolozivo"])
                        }
                    }
                };
                if (citac2["DatumDo"] != DBNull.Value)
                {
                    z.DatumDo = Convert.ToDateTime(citac2["DatumDo"]);
                }

                OleDbCommand komanda3 = konekcija.CreateCommand();
                komanda3.CommandText = $"Select * from KnjigaPrimerak where KnjigaPrimerak.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                komanda3.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac3 = komanda3.ExecuteReader();

                while (citac3.Read())
                {
                    KnjigaPrimerak kp = new KnjigaPrimerak()
                    {
                        Knjiga = z.KnjigaPrimerak.Knjiga,
                        PrimerakID = Convert.ToInt32(citac3["PrimerakID"]),
                        Raspoloziva = Convert.ToBoolean(citac3["Raspoloziva"])
                    };
                    z.KnjigaPrimerak.Knjiga.SpisakPrimeraka.Add(kp);
                }
                OleDbCommand komanda4 = konekcija.CreateCommand();
                komanda4.CommandText = $"Select * from Autor inner join KnjigaAutor on Autor.AutorID = KnjigaAutor.AutorID where KnjigaAutor.KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                komanda4.CommandType = System.Data.CommandType.Text;
                OleDbDataReader citac4 = komanda4.ExecuteReader();

                while (citac4.Read())
                {
                    Autor a = new Autor()
                    {
                        AutorID = Convert.ToInt32(citac4["Autor.AutorID"]),
                        Biografija = citac4["Biografija"].ToString(),
                        ImePrezime = citac4["ImePrezime"].ToString(),
                        GodinaRodjenja = Convert.ToInt32(citac4["GodinaRodjenja"])
                    };
                    z.KnjigaPrimerak.Knjiga.ListaAutora.Add(a);
                }

                lista.Add(z);
            }
            return lista;
        }

        public Zaduzenje NadjiZaduzenje(Clan c, KnjigaPrimerak kp)
        {
            List<Zaduzenje> lista = new List<Zaduzenje>();

            komanda.CommandText = $"Select * from Zaduzenje where ClanskiBroj = {c.ClanskiBroj} and" +
                $" PrimerakID = {kp.PrimerakID} and KnjigaID = {kp.Knjiga.KnjigaID}" +
                $" and DatumDo is NULL";
            komanda.CommandType = System.Data.CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();

            while (citac.Read())
            {
                Zaduzenje zz = new Zaduzenje()
                {
                    Clan = c,
                    KnjigaPrimerak = kp,
                    DatumOd = Convert.ToDateTime(citac["DatumOd"].ToString())
                };
                lista.Add(zz);
            }
            if (lista.Count == 0) return null;
            return lista[0];
        }
        #endregion
    }
}



