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
    public partial class ZaduziForm : Form
    {
        private Clan clan;
        private KnjigaPrimerak primerak;

        public ZaduziForm()
        {
            InitializeComponent();
        }

        public ZaduziForm(KnjigaPrimerak kp)
        {
            InitializeComponent();
            primerak = kp;
            txtBrojKnjige.Text = primerak.Knjiga.KnjigaID.ToString();
            txtBrojPrimerka.Text = primerak.PrimerakID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new PretragaClanovaForm().Show();
            ZaduzenjeForme.PronadjiClanaZaduzenjeForm pc = new ZaduzenjeForme.PronadjiClanaZaduzenjeForm();
            pc.ShowDialog();
            if (pc.DialogResult == DialogResult.OK)
            {
                clan = pc.Clan;
                txtClanskiBroj.Text = clan.ClanskiBroj.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new PretragaKnjigaForm().Show();
            ZaduzenjeForme.PronadjiKnjiguZaduzenjeForm pk = new ZaduzenjeForme.PronadjiKnjiguZaduzenjeForm();
            pk.ShowDialog();
            if (pk.DialogResult == DialogResult.OK)
            {
                primerak = pk.Primerak;
                txtBrojPrimerka.Text = primerak.PrimerakID.ToString();
                txtBrojKnjige.Text = primerak.Knjiga.KnjigaID.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
            if (txtBrojPrimerka.Text == "" || txtBrojKnjige.Text == "" || txtClanskiBroj.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }

            try
            {
                Knjiga k = Komunikacija.Instance.NadjiKnjigu(Convert.ToInt32(txtBrojKnjige.Text));
                Zaduzenje z = new Zaduzenje();
                if (clan == null)
                {
                    clan = Komunikacija.Instance.NadjiClana(Convert.ToInt32(txtClanskiBroj.Text));
                }
                if (primerak == null)
                {
                    foreach (KnjigaPrimerak kp in k.SpisakPrimeraka)
                    {
                        if (kp.PrimerakID == Convert.ToInt32(txtBrojPrimerka.Text))
                        {
                            primerak = kp;
                            break;
                        }
                    }
                }
                z.Clan = clan;
                primerak.Knjiga = k;
                z.KnjigaPrimerak = primerak;


                if (z.KnjigaPrimerak == null || z.Clan == null)
                {
                    lblPoruka.Text = "Nije moguce kreirati zaduzenje prema unetim podacima.";
                    lblPoruka.ForeColor = Color.Red;
                    return;
                }
                if (z.KnjigaPrimerak.Raspoloziva == false)
                {
                    lblPoruka.Text = "Ovaj primerak nije raspoloziv!";
                    lblPoruka.ForeColor = Color.Red;
                    return;
                }
                DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da zaduzie knjigu?", "Provera", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    //Kontroler.Zaduzi(z);
                    if (Komunikacija.Instance.Zaduzi(z))
                    {
                        lblPoruka.Text = "Sacuvano zaduzenje.";
                        primerak.Raspoloziva = false;
                        lblPoruka.ForeColor = Color.Green;
                        OsveziFormu();
                    }
                    else
                    {
                        lblPoruka.Text = "Nije uspesno zaduzeno.";
                        lblPoruka.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska!");
            }


        }
        private void OsveziFormu()
        {
            txtBrojKnjige.Text = "";
            txtBrojPrimerka.Text = "";
            txtClanskiBroj.Text = "";
        }

        private void ZaduziForm_Load(object sender, EventArgs e)
        {

        }

        private void ZaduziForm_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
        }
    }
}
