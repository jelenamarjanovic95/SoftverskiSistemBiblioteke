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
    public partial class RazduziForm : Form
    {
        KnjigaPrimerak primerak;
        Clan clan;
        Zaduzenje zaduzenje;
        public RazduziForm()
        {
            InitializeComponent();
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
            if (txtBrojPrimerka.Text == "" || txtBrojKnjige.Text == "" || txtClanskiBroj.Text == "" || txtDatum.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }

            try
            {
                if (zaduzenje == null)
                {
                    //Knjiga k = Kontroler.NadjiKnjigu(Convert.ToInt32(txtBrojKnjige.Text));
                    Knjiga k = Komunikacija.Instance.NadjiKnjigu(Convert.ToInt32(txtBrojKnjige.Text));
                    zaduzenje = new Zaduzenje()
                    {
                        //Clan = Kontroler.NadjiClana(Convert.ToInt32(txtClanskiBroj.Text)),
                        Clan = Komunikacija.Instance.NadjiClana(Convert.ToInt32(txtClanskiBroj.Text)),
                        DatumOd = Convert.ToDateTime(txtDatum.Text)
                    };
                    if (primerak == null)
                    {
                        foreach (KnjigaPrimerak kp in k.SpisakPrimeraka)
                        {
                            if (kp.PrimerakID == Convert.ToInt32(txtBrojPrimerka.Text))
                            {
                                zaduzenje.KnjigaPrimerak = kp;
                                break;
                            }
                        }
                    }
                    else
                    {
                        zaduzenje.KnjigaPrimerak = primerak;
                    }
                }

                if (zaduzenje.KnjigaPrimerak == null || zaduzenje.Clan == null)
                {
                    lblPoruka.Text = "Nije moguce promeniti zaduzenje prema unetim podacima.";
                    lblPoruka.ForeColor = Color.Red;
                    return;
                }
                DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da razduzite knjigu?", "Provera", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (Komunikacija.Instance.Razduzi(zaduzenje))
                    {
                        lblPoruka.Text = "Razduzeno.";
                        lblPoruka.ForeColor = Color.Green;
                        OsveziFormu();
                    }
                    else
                    {
                        lblPoruka.Text = "Nije uspesno razduzeno.";
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
            txtDatum.Text = "";
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            ZaduzenjeForme.PronadjiZaduzenje pz = new ZaduzenjeForme.PronadjiZaduzenje();
            pz.ShowDialog();
            if(pz.DialogResult == DialogResult.OK)
            {
                zaduzenje = pz.Zaduzenje;
                txtBrojKnjige.Text = zaduzenje.KnjigaPrimerak.Knjiga.KnjigaID.ToString();
                txtBrojPrimerka.Text = zaduzenje.KnjigaPrimerak.PrimerakID.ToString();
                txtClanskiBroj.Text = zaduzenje.Clan.ClanskiBroj.ToString();
                txtDatum.Text = zaduzenje.DatumOd.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClanskiBroj.Text == "" || txtBrojKnjige.Text == "" || txtBrojPrimerka.Text == "")
            {
                MessageBox.Show("Potrebno je da unesete clanski broj, broj knjige i broj primerka da bi se vrsila pretraga.", "Obavestenje");
                return;
            }
            Clan c = new Clan()
            {
                ClanskiBroj = Convert.ToInt32(txtClanskiBroj.Text)
            };
            Knjiga k = new Knjiga()
            {
                KnjigaID = Convert.ToInt32(txtBrojKnjige.Text)
            };
            KnjigaPrimerak kp = new KnjigaPrimerak()
            {
                PrimerakID = Convert.ToInt32(txtBrojPrimerka.Text),
                Knjiga = k
            };

            try
            {
                Zaduzenje z = Komunikacija.Instance.NadjiZaduzenje(c, kp);
                txtDatum.Text = z.DatumOd.ToShortDateString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije pronadjeno zaduzenje po unesenim vrednostima");
            }

        }

        private void RazduziForm_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
        }

        private void RazduziForm_Load(object sender, EventArgs e)
        {

        }
    }
}
