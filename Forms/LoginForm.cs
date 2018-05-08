using KontrolerPoslovneLogike;
using Model;
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
    public partial class LoginForm : Form
    {
        private List<Bibliotekar> bibliotekari;
        private Bibliotekar bibl;

        public Bibliotekar Bibl { get => bibl; set => bibl = value; }

        public LoginForm()
        {
            InitializeComponent();

            bibliotekari = new List<Bibliotekar>()
            {
                new Bibliotekar()
                {
                    Ime = "Jelena",
                    KorisnickoIme = "j",
                    Lozinka = "j",
                    Prezime = "Marjanovic"
                }
            };
        }

        private void OsveziFormu()
        {

            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "" || txtLozinka.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                OsveziFormu();
                return;
            }
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            //bibl = Kontroler.Login(korisnickoIme, lozinka);
            bibl = Komunikacija.Instance.PrijaviSe(korisnickoIme, lozinka);
            if (bibl != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                lblPoruka.Text = "Pogresno korisnicko ime ili lozinka!";
                lblPoruka.ForeColor = Color.Red;
                OsveziFormu();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
