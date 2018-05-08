using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class DB_Broker
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acoji\Desktop\Jelena\Softveri\Projekat\Baza.accdb";
        private OleDbConnection konekcija;
        private OleDbCommand komanda;
        private OleDbTransaction transakcija;

        private static DB_Broker instanca;

        private DB_Broker()
        {
            konekcija = new OleDbConnection(connectionString);
            komanda = konekcija.CreateCommand();
        }

        public static DB_Broker Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new DB_Broker();
                return instanca;
            }
        }

        //Daj sve clanove
        public List<Clan> VratiSveClanove()
        {
            List<Clan> listaClanova = new List<Clan>();

            try
            {
                komanda.CommandText = "Select * from Clan order by ImePrezime";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
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
                        if(citac2["DatumDo"] != DBNull.Value)
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }
        //Daj sve knjige
        public List<Knjiga> VratiSveKnjige()
        {
            List<Knjiga> listaKnjiga = new List<Knjiga>();

            try
            {
                komanda.CommandText = "Select * from Knjiga order by Naziv ASC";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }
        //Daj sve autore
        public List<Autor> VratiSveAutore()
        {
            List<Autor> listaAutora = new List<Autor>();
            try
            {
                komanda.CommandText = "Select * from Autor order by ImePrezime ASC";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(konekcija != null)
                    konekcija.Close();
            }
        }

        #region KNJIGA
        public void SacuvajIzmeneKnjiga(Knjiga novo)
        {
            try
            {
                komanda.CommandText = $"update Knjiga set Naziv = '{novo.Naziv}', Opis = '{novo.Opis}', GodinaIzdanja = {novo.GodinaIzdanja} where KnjigaID = {novo.KnjigaID}";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda.Transaction = transakcija;
                int res = komanda.ExecuteNonQuery();

                OleDbCommand komanda2 = konekcija.CreateCommand();
                komanda2.Transaction = transakcija;
                komanda2.CommandText = $"Delete from KnjigaAutor where KnjigaID = {novo.KnjigaID}";
                komanda2.CommandType = System.Data.CommandType.Text;
                komanda2.ExecuteNonQuery();
                
                OleDbCommand komanda3 = konekcija.CreateCommand();
                komanda3.Transaction = transakcija;
                foreach (Autor a in novo.ListaAutora)
                {
                    komanda3.CommandText = $"Insert into KnjigaAutor values ({novo.KnjigaID}, {a.AutorID})";
                    komanda3.CommandType = System.Data.CommandType.Text;
                    komanda3.ExecuteNonQuery();
                }

                transakcija.Commit();

            }
            catch (Exception)
            {
                transakcija.Rollback();
                throw;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }
        
        public int DajPrimerakID()
        {
            try
            {
                komanda.CommandText = "Select Max(PrimerakID) from KnjigaPrimerak";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                var res = komanda.ExecuteScalar();
                if(res != DBNull.Value)
                {
                    return Convert.ToInt32(res) + 1;
                }
                else
                {
                    return 111;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private int DajKnjigaID()
        {
            try
            {
                komanda.CommandText = "Select Max(KnjigaID) from Knjiga";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        public int UbaciKnjigu(Knjiga k)
        {
            try
            {
                int knjigaID = this.DajKnjigaID();
                komanda.CommandText = $"insert into Knjiga values ({knjigaID}, '{k.Naziv}', '{k.Opis}', {k.GodinaIzdanja}, {k.BrojPrimeraka}, {k.Raspolozivo})";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda.Transaction = transakcija;
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

                transakcija.Commit();
                return knjigaID;
            }
            catch (Exception ex)
            {
                transakcija.Rollback();
                throw ex;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public void IzbrisiKnjigu(Knjiga k) { }
        #endregion

        #region CLAN
        public void SacuvajIzmeneClan(Clan novi)
        {
            try
            {
                komanda.CommandText = $"update Clan set ImePrezime = '{novi.ImePrezime}', BrojTelefona = '{novi.BrojTelefona}', Adresa = '{novi.Adresa}' where ClanskiBroj = {novi.ClanskiBroj}";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                komanda.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        private int DajClanskiBroj()
        {
            try
            {
                komanda.CommandText = "Select Max(ClanskiBroj) from Clan";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        public int UbaciClana(Clan c)
        {
            try
            {
                int cb = this.DajClanskiBroj();
                komanda.CommandText = $"Insert into Clan values ({cb}, '{c.ImePrezime}', '{c.BrojTelefona}', '{c.Adresa}')";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                komanda.ExecuteNonQuery();
                return cb;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public void ObrisiClana(Clan c) { }
        #endregion

        #region ZADUZENJE
        public void Zaduzi(Zaduzenje z)
        {
            try
            {
                komanda.CommandText = $"insert into Zaduzenje values({z.Clan.ClanskiBroj}, {z.KnjigaPrimerak.Knjiga.KnjigaID}, {z.KnjigaPrimerak.PrimerakID}, '{DateTime.Now.ToShortDateString()}')";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();

                komanda.ExecuteNonQuery();

                komanda.CommandText = $"update KnjigaPrimerak set Raspoloziva = false where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
                komanda.CommandType = System.Data.CommandType.Text;
                komanda.ExecuteNonQuery();

                komanda.CommandText = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo - 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                komanda.CommandType = System.Data.CommandType.Text;
                komanda.ExecuteNonQuery();

                transakcija.Commit();

            }
            catch (Exception)
            {
                transakcija.Rollback();
                throw;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public void Razduzi(Zaduzenje z)
        {
            try
            {
                komanda.CommandText = $"Update Zaduzenje set DatumDo = '{z.DatumDo.Value.ToString("dd-MMM-yyyy")}' where ClanskiBroj = {z.Clan.ClanskiBroj} and " +
                    $"PrimerakID = {z.KnjigaPrimerak.PrimerakID} and KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID} and DatumOd = #{z.DatumOd.ToString("dd-MMM-yyyy")}#";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda.Transaction = transakcija;
                komanda.ExecuteNonQuery();

                komanda.CommandText = $"Update KnjigaPrimerak set Raspoloziva = true where PrimerakID = {z.KnjigaPrimerak.PrimerakID}";
                komanda.CommandType = System.Data.CommandType.Text;
                komanda.ExecuteNonQuery();

                komanda.CommandText = $"Update Knjiga set Raspolozivo = {z.KnjigaPrimerak.Knjiga.Raspolozivo + 1} where KnjigaID = {z.KnjigaPrimerak.Knjiga.KnjigaID}";
                komanda.CommandType = System.Data.CommandType.Text;
                komanda.ExecuteNonQuery();

                transakcija.Commit();

            }
            catch (Exception ex)
            {
                transakcija.Rollback();
                throw ex;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }
        #endregion

    }
}
