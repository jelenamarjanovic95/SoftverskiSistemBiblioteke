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
    public partial class IzmeniKnjiguForm : Form
    {
        Knjiga knjiga;

        public IzmeniKnjiguForm(Knjiga k)
        {
            InitializeComponent();
            knjiga = k;
        }

        private void IzmeniKnjiguForm_Load(object sender, EventArgs e)
        {
            txtIzdanje.Text = knjiga.GodinaIzdanja.ToString();
            txtNaziv.Text = knjiga.Naziv;
            txtOpis.Text = knjiga.Opis;
            lblAutori.Text = knjiga.Autori;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            new OdaberiAutora(knjiga).ShowDialog();
            lblAutori.Text = knjiga.Autori;
        }

        bool SamoCifre(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtIzdanje.Text == "" || txtNaziv.Text == "" || txtOpis.Text == "")
            {
                //MessageBox.Show("Sva polja su obavezna!");
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }
            if (!SamoCifre(txtIzdanje.Text))
            {
                lblPoruka.Text = "Godina izdanja ne sme sadrzati slova!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }
            if (knjiga.ListaAutora.Count == 0)
            {
                lblPoruka.Text = "Niste odabrali nijednog autora!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }

            int izdanje = Convert.ToInt32(txtIzdanje.Text);
            string naziv = txtNaziv.Text;
            string opis = txtOpis.Text;

            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da sacuvate izmene?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                knjiga.GodinaIzdanja = izdanje;
                knjiga.Naziv = naziv;
                knjiga.Opis = opis;
                try
                {
                    //Kontroler.SacuvajIzmeneKnjiga(knjiga);
                    if (Komunikacija.Instance.SacuvajIzmeneKnjiga(knjiga))
                    {
                        MessageBox.Show("Uspesno sacuvane promene!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Promene nisu uspesno sacuvane!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Desila se greska - nije moguce izmeniti knjigu!");
                }
            }
        }
    }
}
