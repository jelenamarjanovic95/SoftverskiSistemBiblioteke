﻿using KontrolerPoslovneLogike;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Console
{
    public class Klijent_Nit
    {
        BinaryFormatter formater;
        NetworkStream tok;
        Bibliotekar b;
        int indeks;

        public Klijent_Nit(NetworkStream tok, int indeks)
        {
            formater = new BinaryFormatter();
            this.tok = tok;
            this.indeks = indeks-1;

            ThreadStart ts = obradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void obradaPodataka()
        {
            bool kraj = false;
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
                            Bibliotekar b = zahtevKlijenta.TransferObjekat as Bibliotekar;
                            odgovor.TransferObjekat = Kontroler.Login(b.KorisnickoIme, b.Lozinka);
                            odgovor.Signal = true;
                            this.b = b;
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
                            int id = Kontroler.UbaciKnjigu(zahtevKlijenta.TransferObjekat as Knjiga);
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
                            List<Knjiga> listaKnjiga = Kontroler.PretraziKnjige(p.Vrednost, p.KriterijumPretrage);
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
                            int cb = Kontroler.UbaciClana(zahtevKlijenta.TransferObjekat as Clan);
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
                            List<Clan> listaClanova = Kontroler.PretraziClanove(p.Vrednost, p.KriterijumPretrage);
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
                            Kontroler.ObrisiClana(zahtevKlijenta.TransferObjekat as Clan);
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
                        kraj = true;
                        PrekiniKonekciju();
                        break;
                }
            }
        }

        private void PrekiniKonekciju()
        {
            Server.klijenti[indeks].Shutdown(SocketShutdown.Both);
            Server.klijenti[indeks].Close();
            Server.klijenti.RemoveAt(indeks);
        }
    }
}
