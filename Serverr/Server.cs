using KontrolerPoslovneLogike;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket serverSoket;
        BinaryFormatter formater = new BinaryFormatter();
        
        public void pokreniserver()
        {
            serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSoket.Bind(new IPEndPoint(IPAddress.Any, 21212));
            Console.WriteLine("Server je uspesno startovan!");
            serverSoket.Listen(5);

            while (true)
            {
                Socket klijentSoket = serverSoket.Accept();
                Console.WriteLine("Klijent se povezao");

                ObradaZahteva(klijentSoket);
            }
        }

        private void ObradaZahteva(Socket klijentSoket)
        {
            NetworkStream tok = new NetworkStream(klijentSoket);
            bool kraj = false;
            while (!kraj)
            {
                TransferKlasa zahtevKlijenta = formater.Deserialize(tok) as TransferKlasa;
                TransferKlasa odgovor = new TransferKlasa();
                switch (zahtevKlijenta.Operacija)
                {
                    //1
                    case Operacija.Login:
                        
                        break;

                    //2
                    case Operacija.VratiSveClanove:
                        try
                        {
                            List<Clan> listaClanova = Kontroler.VratiSveClanove();
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
                            List<Knjiga> listaKnjiga = Kontroler.VratiSveKnjige();
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
                            List<Autor> listaAutora = Kontroler.VratiSveAutore();
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
                            Kontroler.SacuvajIzmeneKnjiga(zahtevKlijenta.TransferObjekat as Knjiga);
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
                            Kontroler.UbaciKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
                            odgovor.Signal = true;
                        }
                        catch (Exception e)
                        {
                            odgovor.Signal = false;
                        }
                        formater.Serialize(tok, odgovor);
                        break;

                    //8 - TODO: Kriterijum i vrednost u objekat za pretragu
                    case Operacija.PretraziKnjige:
                        
                        break;

                    //9
                    case Operacija.NadjiKnjigu:
                        try
                        {
                            Knjiga k = Kontroler.NadjiKnjigu((int)zahtevKlijenta.TransferObjekat);
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
                            Kontroler.IzbrisiKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
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
                            Kontroler.SacuvajIzmeneClan(zahtevKlijenta.TransferObjekat as Clan);
                            odgovor.Signal = true;
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
                            Kontroler.UbaciClana(zahtevKlijenta.TransferObjekat as Clan);
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

                        break;

                    //14
                    case Operacija.NadjiClana:
                        try
                        {
                            Clan c = Kontroler.NadjiClana((int)zahtevKlijenta.TransferObjekat);
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
                            Kontroler.IzbrisiClana(zahtevKlijenta.TransferObjekat as Clan);
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

                    //18 TODO: Treba da se proslede i clan i primerak
                    case Operacija.NadjiZaduzenje:
                        break;

                    //19
                    case Operacija.Kraj:
                        Console.WriteLine("Klijent je prekinuo vezu!");
                        kraj = true;
                        klijentSoket.Shutdown(SocketShutdown.Both);
                        klijentSoket.Close();
                        break;
                }
            }
        }

        public void ZaustaviServer()
        {
            Console.WriteLine("Server je ugasen");
            serverSoket.Shutdown(SocketShutdown.Both);
            serverSoket.Close();
        }

        //private void osluskujKlijente()
        //{
        //    soket.Listen(5);
        //    while (true)
        //    {
        //        Socket klijent = soket.Accept();
        //        NetworkStream tok = new NetworkStream(klijent);
        //        TransferKlasa transferObjekat = new TransferKlasa();
        //        if (klijenti.Count == 2)
        //        {
        //            transferObjekat.Operacija = Operacija.Kraj;
        //            formater.Serialize(tok, transferObjekat);
        //            continue;
        //        }
        //        TransferKlasa transfer = new TransferKlasa();
        //        transfer.TransferObjekat = klijent;
        //        transfer.Signal = true;
        //        klijenti.Add(transfer);
        //        transferObjekat.Signal = brojac;
        //        formater.Serialize(tok, transferObjekat);
        //        ObradaZahtevaKlijenata obrada = new ObradaZahtevaKlijenata(tok, klijenti, brojac);
        //        brojac++;

        //    }
        //}

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
