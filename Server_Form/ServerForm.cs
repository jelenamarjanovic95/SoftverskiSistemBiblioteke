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
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Form
{
    public partial class ServerForm : Form
    {
        Thread nitServer;
        Server server;
        //Socket serverSoket;
        //BinaryFormatter formater = new BinaryFormatter();
        //NetworkStream tok;
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
            try
            {
                server = new Server();
                nitServer = new Thread(server.PokreniServer);
                nitServer.Start();

                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                lblStanje.Text = "Server radi!";
                lblStanje.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije moguce pokrenuti server!");
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btnZaustavi.Enabled = false;
        }

        private void btnUgasi_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.ZaustaviServer();
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
