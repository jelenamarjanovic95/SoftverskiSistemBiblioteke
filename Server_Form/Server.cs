using KontrolerPoslovneLogike;
using Model;
using Server_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server_Form
{
    public class Server
    {
        static Socket serverSoket;
        static BinaryFormatter formater = new BinaryFormatter();
        static NetworkStream tok;
        private static List<Socket> klijenti;
        private static List<Bibliotekar> bibliotekari;
        private static List<Klijent_Nit> klijentNiti = new List<Klijent_Nit>();

        public void PokreniServer()
        {
            serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSoket.Bind(new IPEndPoint(IPAddress.Any, 21212));
            Console.WriteLine("Server je uspesno startovan!");
            klijenti = new List<Socket>();
            bibliotekari = new List<Bibliotekar>();
            ObradiKlijenta();
        }

        //private static void ObradaZahteva(Socket klijentSoket)
        //{
        //    NetworkStream tok = new NetworkStream(klijentSoket);
        //    bool kraj = false;
        //    while (!kraj)
        //    {
        //        TransferKlasa zahtevKlijenta = formater.Deserialize(tok) as TransferKlasa;
        //        TransferKlasa odgovor = new TransferKlasa();
        //        switch (zahtevKlijenta.Operacija)
        //        {
        //            //1
        //            case Operacija.Login:
        //                try
        //                {
        //                    Bibliotekar b = zahtevKlijenta.TransferObjekat as Bibliotekar;
        //                    odgovor.TransferObjekat = Kontroler.Login(b.KorisnickoIme, b.Lozinka);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //2
        //            case Operacija.VratiSveClanove:
        //                try
        //                {
        //                    List<Clan> listaClanova = Kontroler.VratiSveClanove();
        //                    odgovor.TransferObjekat = listaClanova;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //3
        //            case Operacija.VratiSveKnjige:
        //                try
        //                {
        //                    List<Knjiga> listaKnjiga = Kontroler.VratiSveKnjige();
        //                    odgovor.TransferObjekat = listaKnjiga;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //4
        //            case Operacija.VratiSveAutore:
        //                try
        //                {
        //                    List<Autor> listaAutora = Kontroler.VratiSveAutore();
        //                    odgovor.TransferObjekat = listaAutora;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //5
        //            case Operacija.SacuvajIzmeneKnjiga:
        //                try
        //                {
        //                    Kontroler.SacuvajIzmeneKnjiga(zahtevKlijenta.TransferObjekat as Knjiga);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //6
        //            case Operacija.DajPrimerakID:
        //                try
        //                {
        //                    int id = Kontroler.DajPrimerakID();
        //                    odgovor.TransferObjekat = id;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //7
        //            case Operacija.UbaciKnjigu:
        //                try
        //                {
        //                    int id = Kontroler.UbaciKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
        //                    odgovor.TransferObjekat = id;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //8
        //            case Operacija.PretraziKnjige:
        //                try
        //                {
        //                    Pretraga p = zahtevKlijenta.TransferObjekat as Pretraga;
        //                    List<Knjiga> listaKnjiga = Kontroler.PretraziKnjige(p.Vrednost, p.KriterijumPretrage);
        //                    odgovor.TransferObjekat = listaKnjiga;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //9
        //            case Operacija.NadjiKnjigu:
        //                try
        //                {
        //                    Knjiga k = Kontroler.NadjiKnjigu((int)zahtevKlijenta.TransferObjekat);
        //                    odgovor.TransferObjekat = k;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //10
        //            case Operacija.ObrisiKnjigu:
        //                try
        //                {
        //                    Kontroler.ObrisiKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //11
        //            case Operacija.SacuvajIzmeneClan:
        //                try
        //                {
        //                    Kontroler.SacuvajIzmeneClan(zahtevKlijenta.TransferObjekat as Clan);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //12
        //            case Operacija.UbaciClana:
        //                try
        //                {
        //                    int cb = Kontroler.UbaciClana(zahtevKlijenta.TransferObjekat as Clan);
        //                    odgovor.TransferObjekat = cb;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //13
        //            case Operacija.PretraziClanove:
        //                try
        //                {
        //                    Pretraga p = zahtevKlijenta.TransferObjekat as Pretraga;
        //                    List<Clan> listaClanova = Kontroler.PretraziClanove(p.Vrednost, p.KriterijumPretrage);
        //                    odgovor.TransferObjekat = listaClanova;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //14
        //            case Operacija.NadjiClana:
        //                try
        //                {
        //                    Clan c = Kontroler.NadjiClana((int)zahtevKlijenta.TransferObjekat);
        //                    odgovor.TransferObjekat = c;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //15
        //            case Operacija.ObrisiClana:
        //                try
        //                {
        //                    Kontroler.ObrisiClana(zahtevKlijenta.TransferObjekat as Clan);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //16
        //            case Operacija.Zaduzi:
        //                try
        //                {
        //                    Kontroler.Zaduzi(zahtevKlijenta.TransferObjekat as Zaduzenje);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //17
        //            case Operacija.Razduzi:
        //                try
        //                {
        //                    Kontroler.Razduzi(zahtevKlijenta.TransferObjekat as Zaduzenje);
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //18
        //            case Operacija.NadjiZaduzenje:
        //                try
        //                {
        //                    Zaduzenje zahtev = zahtevKlijenta.TransferObjekat as Zaduzenje;
        //                    Zaduzenje odg = Kontroler.NadjiZaduzenje(zahtev.Clan, zahtev.KnjigaPrimerak);
        //                    odgovor.TransferObjekat = odg;
        //                    odgovor.Signal = true;
        //                }
        //                catch (Exception)
        //                {
        //                    odgovor.Signal = false;
        //                }
        //                formater.Serialize(tok, odgovor);
        //                break;

        //            //19
        //            case Operacija.Kraj:
        //                Console.WriteLine("Klijent je prekinuo vezu!");
        //                kraj = true;
        //                klijentSoket.Shutdown(SocketShutdown.Both);
        //                klijentSoket.Close();
        //                break;
        //        }
        //    }
        //}

        public void ObradiKlijenta()
        {
            serverSoket.Listen(5);

            try
            {
                while (true)
                {
                    Socket klijent = serverSoket.Accept();
                    Console.WriteLine("Konektovan klijent broj: " + klijenti.Count());
                    tok = new NetworkStream(klijent);
                    klijenti.Add(klijent);
                    Klijent_Nit nit = new Klijent_Nit(tok, klijenti, klijent);
                    klijentNiti.Add(nit);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public void ZaustaviServer()
        {
            Console.WriteLine("Server je ugasen");
            //serverSoket.Shutdown(SocketShutdown.Both);
            UgasiSveKlijente();
            serverSoket.Close();
        }

        private void UgasiSveKlijente()
        {
            foreach(Klijent_Nit kn in klijentNiti)
            {
                kn.UgasiKlijenta();
            }
        }

        
        //public void ugasiKlijenta()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Broj klijenta kojeg zelite da ugasite?");
        //        string zahtev = Console.ReadLine();
        //        int brojKlijenta = Convert.ToInt32(zahtev);
        //        foreach (TransferKlasa tk in klijenti)
        //        {
        //            if (tk.Signal == brojKlijenta)
        //            {
        //                (tk.TransferObjekat as Socket).Close();
        //                klijenti.Remove(tk);
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}

