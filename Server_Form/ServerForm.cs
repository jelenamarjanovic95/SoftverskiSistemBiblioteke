using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Form
{
    public partial class ServerForm : Form
    {
        Socket serverSoket;
        BinaryFormatter formater = new BinaryFormatter();
        NetworkStream tok;
        public static List<Socket> klijenti;
        public static List<Bibliotekar> bibliotekari;

        public ServerForm()
        {
            InitializeComponent();

            lblStanje.Text = "Server je ugasen.";
            lblStanje.ForeColor = Color.Red;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = false;
            btnUgasi.Enabled = true;
            Server.PokreniServer();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btnUgasi.Enabled = false;
        }

        private void btnUgasi_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnUgasi.Enabled = false;
            Server.ZaustaviServer();
        }
        
        public void PokreniServer()
        {
            serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSoket.Bind(new IPEndPoint(IPAddress.Any, 21212));
            Console.WriteLine("Server je uspesno startovan!");
            klijenti = new List<Socket>();
            bibliotekari = new List<Bibliotekar>();

            lblStanje.Text = "Server je aktivan.";
            lblStanje.ForeColor = Color.Green;

            ObradiKlijenta();

        }

        public void ObradiKlijenta()
        {
            serverSoket.Listen(5);

            while (true)
            {
                Socket klijent = serverSoket.Accept();
                Console.WriteLine("Konektovan klijent broj: " + klijenti.Count());
                tok = new NetworkStream(klijent);
                klijenti.Add(klijent);
                Klijent_Nit nit = new Klijent_Nit(tok, klijenti.Count);
            }
        }

        public void ZaustaviServer()
        {
            Console.WriteLine("Server je ugasen");
            serverSoket.Shutdown(SocketShutdown.Both);
            serverSoket.Close();

            lblStanje.Text = "Server je ugasen.";
            lblStanje.ForeColor = Color.Red;
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
