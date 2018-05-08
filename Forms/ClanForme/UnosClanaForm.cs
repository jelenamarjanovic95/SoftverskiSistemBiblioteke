using KontrolerPoslovneLogike;
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
            if(txtAdresa.Text=="" || txtBrojTel.Text == "" || txtImePrezime.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
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
                //int cb = Kontroler.UbaciClana(c);
                int cb = Komunikacija.Instance.UbaciClana(c);
                lblClanskiBroj.Text = cb.ToString();
                MessageBox.Show($"Uspesno dodat novi clan! Clanski broj: {cb}");
                OsveziFormu();
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
