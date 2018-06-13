using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public class Komunikacija
    {
        private static Komunikacija instance;

        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();
        MainForm glavnaForma;

        private Komunikacija()
        {

        }

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }
        }

        public void PoveziSe(MainForm mf)
        {
            try
            {
                glavnaForma = mf;
                this.klijent = new TcpClient("127.0.0.1", 21212);
                this.tok = klijent.GetStream();
                glavnaForma.Povezan = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bibliotekar PrijaviSe(string korisnickoIme, string lozinka)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    TransferObjekat = new Bibliotekar()
                    {
                        KorisnickoIme = korisnickoIme,
                        Lozinka = lozinka
                    },
                    Operacija = Operacija.Login
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;
                if (odgovor.Signal)
                {
                    return odgovor.TransferObjekat as Bibliotekar;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public void Kraj()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa
                {
                    Operacija = Operacija.Kraj,
                };
                formater.Serialize(tok, transfer);
                klijent.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
            }
        }

        public bool Razduzi(Zaduzenje z)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    TransferObjekat = z,
                    Operacija = Operacija.Razduzi
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Zatvori();
                return false;
            }
        }

        public Clan NadjiClana(int clanskiBroj)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.NadjiClana,
                    TransferObjekat = clanskiBroj
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return odgovor.TransferObjekat as Clan;
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public bool SacuvajIzmeneClan(Clan c)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.SacuvajIzmeneClan,
                    TransferObjekat = c
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return false;
            }
        }

        public List<Clan> VratiSveClanove()
        {
            try
            {
                List<Clan> listaClanova = new List<Clan>();
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.VratiSveClanove
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                {
                    List<IOpstiDomenskiObjekat> lista = odgovor.TransferObjekat as List<IOpstiDomenskiObjekat>;
                    foreach (IOpstiDomenskiObjekat odo in lista)
                    {
                        listaClanova.Add((Clan)odo);
                    }
                    return listaClanova;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public List<Clan> PretraziClanove(string vrednost, KriterijumPretrage kriterijum)
        {
            try
            {
                List<Clan> listaPronadjenihClanova = new List<Clan>();
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.PretraziClanove,
                    TransferObjekat = new Pretraga()
                    {
                        KriterijumPretrage = kriterijum,
                        Vrednost = vrednost
                    }
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                {
                    List<IOpstiDomenskiObjekat> lista = odgovor.TransferObjekat as List<IOpstiDomenskiObjekat>;
                    foreach (IOpstiDomenskiObjekat odo in lista)
                    {
                        listaPronadjenihClanova.Add((Clan)odo);
                    }
                    return listaPronadjenihClanova;
                }
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public bool ObrisiClana(Clan c)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.ObrisiClana,
                    TransferObjekat = c
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return false;
            }
        }

        public int UbaciClana(Clan c)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.UbaciClana,
                    TransferObjekat = c
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return (int)odgovor.TransferObjekat;
                else
                    return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return -1;
            }
        }

        public bool SacuvajIzmeneKnjiga(Knjiga k)
        {
            try
            {

                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.SacuvajIzmeneKnjiga,
                    TransferObjekat = k
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return false;
            }
        }

        public List<Autor> VratiSveAutore()
        {
            try
            {
                List<Autor> listaAutora = new List<Autor>();
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.VratiSveAutore
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                {
                    List<IOpstiDomenskiObjekat> lista = odgovor.TransferObjekat as List<IOpstiDomenskiObjekat>;
                    foreach (IOpstiDomenskiObjekat odo in lista)
                    {
                        listaAutora.Add((Autor)odo);
                    }
                    return listaAutora;
                }
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public List<Knjiga> VratiSveKnjige()
        {
            try
            {
                List<Knjiga> listaKnjiga = new List<Knjiga>();
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.VratiSveKnjige
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                {
                    List<IOpstiDomenskiObjekat> lista = odgovor.TransferObjekat as List<IOpstiDomenskiObjekat>;
                    foreach (IOpstiDomenskiObjekat odo in lista)
                    {
                        listaKnjiga.Add(odo as Knjiga);
                    }
                    return listaKnjiga;
                }
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public bool ObrisiKnjigu(Knjiga k)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.ObrisiClana,
                    TransferObjekat = k
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return false;
            }
        }

        public List<Knjiga> PretraziKnjige(string vrednost, KriterijumPretrage kriterijum)
        {
            try
            {
                List<Knjiga> listaPronadjenihKnjiga = new List<Knjiga>();
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.PretraziKnjige,
                    TransferObjekat = new Pretraga()
                    {
                        KriterijumPretrage = kriterijum,
                        Vrednost = vrednost
                    }
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                {
                    List<IOpstiDomenskiObjekat> lista = odgovor.TransferObjekat as List<IOpstiDomenskiObjekat>;
                    foreach (IOpstiDomenskiObjekat odo in lista)
                    {
                        listaPronadjenihKnjiga.Add((Knjiga)odo);
                    }
                    return listaPronadjenihKnjiga;
                }
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public int DajPrimerakID()
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.DajPrimerakID
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return (int)odgovor.TransferObjekat;
                else return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return -1;
            }
        }

        public int UbaciKnjigu(Knjiga k)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.UbaciKnjigu,
                    TransferObjekat = k
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return Convert.ToInt32(odgovor.TransferObjekat);
                else
                    return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return -1;
            }
        }

        public Knjiga NadjiKnjigu(int knjigaID)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.NadjiKnjigu,
                    TransferObjekat = knjigaID
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return odgovor.TransferObjekat as Knjiga;
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public Zaduzenje NadjiZaduzenje(Clan c, KnjigaPrimerak kp)
        {
            try
            {
                Zaduzenje z = new Zaduzenje()
                {
                    Clan = c,
                    KnjigaPrimerak = kp
                };
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.NadjiZaduzenje,
                    TransferObjekat = z
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                if (odgovor.Signal)
                    return odgovor.TransferObjekat as Zaduzenje;
                else return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return null;
            }
        }

        public bool Zaduzi(Zaduzenje z)
        {
            try
            {
                TransferKlasa zahtev = new TransferKlasa()
                {
                    Operacija = Operacija.Zaduzi,
                    TransferObjekat = z
                };
                formater.Serialize(tok, zahtev);
                TransferKlasa odgovor = formater.Deserialize(tok) as TransferKlasa;

                return odgovor.Signal;
            }
            catch (Exception)
            {
                MessageBox.Show("Izgubljena je konekcija sa serverom! Zatvaram formu...");
                klijent.Close();
                glavnaForma.Povezan = false;
                glavnaForma.Zatvori();
                return false;
            }
        }
    }
}
