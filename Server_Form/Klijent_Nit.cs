using KontrolerPoslovneLogike;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Form
{
    public delegate void noviBiblDelegat(Bibliotekar b);
    public class Klijent_Nit
    {
        List<Socket> listaKlijenata;
        Socket klijent;
        BinaryFormatter formater;
        NetworkStream tok;
        Bibliotekar b;
        bool kraj = false;

        ServerForm forma;

        public event noviBiblDelegat NoviBibliotekar;

        public Klijent_Nit(NetworkStream tok,List<Socket> k, Socket klij, ServerForm sf)
        {
            formater = new BinaryFormatter();
            forma = sf;
            this.tok = tok;
            listaKlijenata = k;
            klijent = klij;

            ThreadStart ts = ObradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void ObradaPodataka()
        {
            try
            {
                while (!kraj)
                {
                    TransferKlasa zahtevKlijenta = formater.Deserialize(tok) as TransferKlasa;
                    TransferKlasa odgovor = new TransferKlasa();
                    switch (zahtevKlijenta.Operacija)
                    {
                        //1
                        case Operacija.Login:
                            try
                            {
                                Bibliotekar bibl = zahtevKlijenta.TransferObjekat as Bibliotekar;
                                b = Kontroler.Login(bibl.KorisnickoIme, bibl.Lozinka);
                                odgovor.TransferObjekat = b;
                                odgovor.Signal = true;
                                NoviBibliotekar.Invoke(b);
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //2
                        case Operacija.VratiSveClanove:
                            try
                            {
                                //List<Clan> listaClanova = Kontroler.VratiSveClanove();
                                List<IOpstiDomenskiObjekat> listaClanova = KontrolerPL_Generic.VratiSveClanove();
                                odgovor.TransferObjekat = listaClanova;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //3
                        case Operacija.VratiSveKnjige:
                            try
                            {
                                //List<Knjiga> listaKnjiga = Kontroler.VratiSveKnjige();
                                List<IOpstiDomenskiObjekat> listaKnjiga = KontrolerPL_Generic.VratiSveKnjige();

                                odgovor.TransferObjekat = listaKnjiga;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //4
                        case Operacija.VratiSveAutore:
                            try
                            {
                                //List<Autor> listaAutora = Kontroler.VratiSveAutore();
                                List<IOpstiDomenskiObjekat> listaAutora = KontrolerPL_Generic.VratiSveAutore();

                                odgovor.TransferObjekat = listaAutora;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //5
                        case Operacija.SacuvajIzmeneKnjiga:
                            try
                            {
                                //Kontroler.SacuvajIzmeneKnjiga(zahtevKlijenta.TransferObjekat as Knjiga);
                                KontrolerPL_Generic.SacuvajIzmeneKnjiga(zahtevKlijenta.TransferObjekat as Knjiga);
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //6
                        case Operacija.DajPrimerakID:
                            try
                            {
                                int id = Kontroler.DajPrimerakID();
                                odgovor.TransferObjekat = id;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //7
                        case Operacija.UbaciKnjigu:
                            try
                            {
                                //int id = Kontroler.UbaciKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
                                int id = KontrolerPL_Generic.UbaciKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
                                odgovor.TransferObjekat = id;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //8
                        case Operacija.PretraziKnjige:
                            try
                            {
                                Pretraga p = zahtevKlijenta.TransferObjekat as Pretraga;
                                //List<Knjiga> listaKnjiga = Kontroler.PretraziKnjige(p.Vrednost, p.KriterijumPretrage);
                                List<IOpstiDomenskiObjekat> listaKnjiga = KontrolerPL_Generic.PretraziKnjige(p);
                                odgovor.TransferObjekat = listaKnjiga;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //9
                        case Operacija.NadjiKnjigu:
                            try
                            {
                                //Knjiga k = Kontroler.NadjiKnjigu((int)zahtevKlijenta.TransferObjekat);
                                Knjiga k = KontrolerPL_Generic.NadjiKnjigu((int)zahtevKlijenta.TransferObjekat);
                                odgovor.TransferObjekat = k;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //10
                        case Operacija.ObrisiKnjigu:
                            try
                            {
                                Kontroler.ObrisiKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //11
                        case Operacija.SacuvajIzmeneClan:
                            try
                            {
                                //Kontroler.SacuvajIzmeneClan(zahtevKlijenta.TransferObjekat as Clan);
                                odgovor.Signal = KontrolerPL_Generic.SacuvajIzmeneClan(zahtevKlijenta.TransferObjekat as Clan);
                                
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //12
                        case Operacija.UbaciClana:
                            try
                            {
                                //int cb = Kontroler.UbaciClana(zahtevKlijenta.TransferObjekat as Clan);
                                int cb = KontrolerPL_Generic.UbaciClana(zahtevKlijenta.TransferObjekat as Clan);

                                odgovor.TransferObjekat = cb;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //13
                        case Operacija.PretraziClanove:
                            try
                            {
                                Pretraga p = zahtevKlijenta.TransferObjekat as Pretraga;
                                //List<Clan> listaClanova = Kontroler.PretraziClanove(p.Vrednost, p.KriterijumPretrage);
                                List<IOpstiDomenskiObjekat> listaClanova = KontrolerPL_Generic.PretraziClanove(p);

                                odgovor.TransferObjekat = listaClanova;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //14
                        case Operacija.NadjiClana:
                            try
                            {
                                //Clan c = Kontroler.NadjiClana((int)zahtevKlijenta.TransferObjekat);
                                Clan c = KontrolerPL_Generic.NadjiClana((int)zahtevKlijenta.TransferObjekat);

                                odgovor.TransferObjekat = c;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //15
                        case Operacija.ObrisiClana:
                            try
                            {
                                KontrolerPL_Generic.ObrisiClana(zahtevKlijenta.TransferObjekat as Clan);
                                //Kontroler.ObrisiClana(zahtevKlijenta.TransferObjekat as Clan);
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //16
                        case Operacija.Zaduzi:
                            try
                            {
                                Kontroler.Zaduzi(zahtevKlijenta.TransferObjekat as Zaduzenje);
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //17
                        case Operacija.Razduzi:
                            try
                            {
                                Kontroler.Razduzi(zahtevKlijenta.TransferObjekat as Zaduzenje);
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //18
                        case Operacija.NadjiZaduzenje:
                            try
                            {
                                Zaduzenje zahtev = zahtevKlijenta.TransferObjekat as Zaduzenje;
                                Zaduzenje odg = Kontroler.NadjiZaduzenje(zahtev.Clan, zahtev.KnjigaPrimerak);
                                odgovor.TransferObjekat = odg;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        //19
                        case Operacija.Kraj:
                            Console.WriteLine("Klijent je prekinuo vezu!");
                            UgasiKlijenta();
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        internal void UgasiKlijenta()
        {
            try
            {
                kraj = true;
                listaKlijenata.Remove(klijent);
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Close();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
