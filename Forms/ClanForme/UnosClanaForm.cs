﻿using KontrolerPoslovneLogike;
using Model;
using Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class UnosClanaForm : Form
    {
        public UnosClanaForm()
        {
            InitializeComponent();
        }

        private void UnosClana_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            meni1.DisableUnosClana();
            lblClanskiBroj.Text = "";
        }

        private bool SamoCifre(string str)
        {
            foreach (char c in str)
            {
                if (c == '/' || c == '-')
                    continue;
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
            if(txtAdresa.Text=="" || txtBrojTel.Text == "" || txtImePrezime.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }
            if(!SamoCifre(txtBrojTel.Text))
            {
                lblPoruka.Text = "Broj telefona moze da sadrzi samo cifre!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }
            Clan c = new Clan()
            {
                Adresa = txtAdresa.Text,
                BrojTelefona = txtBrojTel.Text,
                ImePrezime = txtImePrezime.Text 
            };

            try
            {
                int cb = Komunikacija.Instance.UbaciClana(c);
                if (cb != -1)
                {
                    lblClanskiBroj.Text = cb.ToString();
                    MessageBox.Show($"Uspesno dodat novi clan! Clanski broj: {cb}");
                    OsveziFormu();
                }
                else
                {
                    MessageBox.Show("Ubacivanje clana nije bilo uspesno!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska pri dodavanju novog clana!");
            }
        }

        private void OsveziFormu()
        {
            txtAdresa.Text = "";
            txtBrojTel.Text = "";
            txtImePrezime.Text = "";
        }
    }
}
