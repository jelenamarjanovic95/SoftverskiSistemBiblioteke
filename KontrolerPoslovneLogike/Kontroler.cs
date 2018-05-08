using Model;
using Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerPoslovneLogike
{
    public class Kontroler
    {
        public static Bibliotekar Login(string korisnickoIme, string lozinka)
        {
            return Repozitorijum.NadjiBibliotekara(korisnickoIme, lozinka);
        }

        public static List<Clan> VratiSveClanove()
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                List<Clan> listaSvihClanova = Broker.Instanca.VratiSveClanove();
                return listaSvihClanova;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static List<Knjiga> VratiSveKnjige()
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                List<Knjiga> listaSvihKnjiga = Broker.Instanca.VratiSveKnjige();
                return listaSvihKnjiga;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static List<Autor> VratiSveAutore()
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                List<Autor> listaSvihAutora = Broker.Instanca.VratiSveAutore();
                return listaSvihAutora;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static bool SacuvajIzmeneKnjiga(Knjiga novo)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                Broker.Instanca.SacuvajIzmeneKnjiga(novo);
                Broker.Instanca.Commit();
                return true;
            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static int DajPrimerakID()
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                int rez = Broker.Instanca.DajPrimerakID();
                return rez;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static int UbaciKnjigu(Knjiga k)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                int knjigaID = Broker.Instanca.UbaciKnjigu(k);
                Broker.Instanca.Commit();
                return knjigaID;
            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static List<Knjiga> PretraziKnjige(string vrednostKriterijuma, KriterijumPretrage kriterijum)
        {
            try
            {
                if (vrednostKriterijuma == "")
                {
                    return VratiSveKnjige();
                }
                Broker.Instanca.OtvoriKonekciju();
                List<Knjiga> listaPronadjenihKnjiga = Broker.Instanca.PretraziKnjige(vrednostKriterijuma, kriterijum);
                return listaPronadjenihKnjiga;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static Knjiga NadjiKnjigu(int brojKnjige)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Knjiga c = Broker.Instanca.NadjiKnjigu(brojKnjige);
                return c;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static void ObrisiKnjigu(Knjiga k)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                Broker.Instanca.ObrisiKnjigu(k);
                Broker.Instanca.Commit();

            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static void SacuvajIzmeneClan(Clan novi)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.SacuvajIzmeneClan(novi);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static int UbaciClana(Clan c)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                int clanskiBr = Broker.Instanca.UbaciClana(c);
                return clanskiBr;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static List<Clan> PretraziClanove(string vrednostKriterijuma, KriterijumPretrage kriterijum)
        {
            try
            {
                if(vrednostKriterijuma == "")
                {
                    return VratiSveClanove();
                }
                Broker.Instanca.OtvoriKonekciju();
                List<Clan> listaPronadjenihClanova = Broker.Instanca.PretraziClanove(vrednostKriterijuma, kriterijum);
                return listaPronadjenihClanova;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static Clan NadjiClana(int clanskiBroj)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Clan c = Broker.Instanca.NadjiClana(clanskiBroj);
                return c;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static void ObrisiClana(Clan c)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                Broker.Instanca.ObrisiClana(c);
                Broker.Instanca.Commit();

            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static void Zaduzi(Zaduzenje z)
        {
            try
            {
                if (!z.KnjigaPrimerak.Raspoloziva)
                {
                    throw new Exception();
                }
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                Broker.Instanca.Zaduzi(z);
                Broker.Instanca.Commit();
            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static void Razduzi(Zaduzenje z)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Broker.Instanca.PokreniTransakciju();
                Broker.Instanca.Razduzi(z);
                Broker.Instanca.Commit();
            }
            catch (Exception e)
            {
                Broker.Instanca.Rollback();
                throw e;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }

        public static Zaduzenje NadjiZaduzenje(Clan c, KnjigaPrimerak kp)
        {
            try
            {
                Broker.Instanca.OtvoriKonekciju();
                Zaduzenje z = Broker.Instanca.NadjiZaduzenje(c, kp);
                return z;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Broker.Instanca.ZatvoriKonekciju();
            }
        }
    }
}
