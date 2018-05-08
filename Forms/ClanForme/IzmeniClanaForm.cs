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
    public partial class IzmeniClanaForm : Form
    {
        private Clan clan;
        public IzmeniClanaForm(Clan c)
        {
            clan = c;
            InitializeComponent();
        }

        private void IzmeniClanaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            txtAdresa.Text = clan.Adresa;
            txtBrojTelefona.Text = clan.BrojTelefona;
            txtClanskiBroj.Text = clan.ClanskiBroj.ToString();
            txtClanskiBroj.Enabled = false;
            txtImePrezime.Text = clan.ImePrezime;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text == "" || txtBrojTelefona.Text == "" || txtClanskiBroj.Text == "" || txtImePrezime.Text == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            string imePrez = txtImePrezime.Text;
            string adresa = txtAdresa.Text;
            string brojtel = txtBrojTelefona.Text;
            int clanskibr = Convert.ToInt32(txtClanskiBroj.Text);

            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da sacuvate izmene?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                clan.Adresa = adresa;
                clan.ImePrezime = imePrez;
                clan.BrojTelefona = brojtel;
                clan.ClanskiBroj = clanskibr;

                try
                {
                    //Kontroler.SacuvajIzmeneClan(clan)
                    if (Komunikacija.Instance.SacuvajIzmeneClan(clan))
                    {
                        MessageBox.Show("Uspesno sacuvane promene!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nisu sacuvane promene!", "Greska");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Desila se greska!", "Greska");
                }

            }

        }
    }
}
