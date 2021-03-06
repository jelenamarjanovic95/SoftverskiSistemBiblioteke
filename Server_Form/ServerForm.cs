﻿using Model;
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
        public static List<Socket> klijenti;
        public static List<Bibliotekar> bibliotekari = new List<Bibliotekar>();

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
                server = new Server(this);
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
            dgvBibliotekari.DataSource = bibliotekari;
            dgvBibliotekari.Columns[0].Width = 100;
            dgvBibliotekari.Columns[1].Width = 150;
            dgvBibliotekari.Columns[2].Width = 105;
        }

        private void btnUgasi_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            lblStanje.Text = "Server je ugasen.";
            lblStanje.ForeColor = Color.Red;
            btnZaustavi.Enabled = false;
            btnPokreni.Enabled = true;
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                server.ZaustaviServer();
            }
            catch (Exception)
            {

            }
        }

        internal void OsveziDgv()
        {
            Invoke(new Action(OsveziFormu));
        }

        private void OsveziFormu()
        {
            dgvBibliotekari.DataSource = null;
            dgvBibliotekari.DataSource = server.Bibliotekari;
            dgvBibliotekari.Columns[0].Width = 100;
            dgvBibliotekari.Columns[1].Width = 150;
            dgvBibliotekari.Columns[2].Width = 105;
            dgvBibliotekari.Refresh();
        }

        private void btnDiskonektuj_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da diskonektujete odabranog bibliotekara?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                server.DiskonektujKlijenta(dgvBibliotekari.SelectedCells[0].RowIndex);
            }
        }

    }
}
