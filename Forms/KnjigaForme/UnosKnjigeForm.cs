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
    public partial class UnosKnjigeForm : Form
    {
        private BindingList<KnjigaPrimerak> listaPrimeraka = new BindingList<KnjigaPrimerak>();
        private Knjiga unosKnjiga;
        private int sledeciPrimerakID;

        public UnosKnjigeForm()
        {
            InitializeComponent();

            unosKnjiga = new Knjiga();
            meni1.DisableUnosKnjige();
        }

        private void UnosKnjigeForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            try
            {
                //sledeciPrimerakID = Kontroler.DajPrimerakID();
                sledeciPrimerakID = Komunikacija.Instance.DajPrimerakID();
                if(sledeciPrimerakID != -1)
                    txtPrimerakID.Text = sledeciPrimerakID.ToString();
                else
                    MessageBox.Show("Desila se greska prilikom uzimanja broja primerka!");
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom uzimanja broja primerka!");
            }
            dgvSpisakPrimeraka.DataSource = listaPrimeraka;
            txtPrimerakID.Enabled = false;
        }

        private void meni2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OdaberiAutora(unosKnjiga).ShowDialog();
            lblAutori.Text = unosKnjiga.Autori;
        }

        private void btnDodajPrimerak_Click(object sender, EventArgs e)
        {
            KnjigaPrimerak kp = new KnjigaPrimerak()
            {
                PrimerakID = sledeciPrimerakID++,
                Raspoloziva = true
            };

            txtPrimerakID.Text = sledeciPrimerakID.ToString();
            listaPrimeraka.Add(kp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaPrimeraka.RemoveAt(dgvSpisakPrimeraka.SelectedCells[0].RowIndex);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtIzdanje.Text == "" || txtNaziv.Text == "" || txtOpis.Text == "")
            {
                lblPoruka.Text = "Sva polja su obavezna!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }
            if (unosKnjiga.ListaAutora.Count == 0)
            {
                lblPoruka.Text = "Odaberite autora!";
                lblPoruka.ForeColor = Color.Red;
                return;
            }

            unosKnjiga.GodinaIzdanja = Convert.ToInt32(txtIzdanje.Text);
            unosKnjiga.Naziv = txtNaziv.Text;
            unosKnjiga.Opis = txtOpis.Text;
            unosKnjiga.SpisakPrimeraka = listaPrimeraka.ToList();
            unosKnjiga.BrojPrimeraka = listaPrimeraka.Count;
            unosKnjiga.Raspolozivo = listaPrimeraka.Count;

            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da unesete knjigu?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    //int id = Kontroler.UbaciKnjigu(unosKnjiga);
                    int id = Komunikacija.Instance.UbaciKnjigu(unosKnjiga);
                    if (id != -1)
                    {
                        lblPoruka.Text = $"Broj knjige: { id }";
                        OsveziFormu();
                        MessageBox.Show($"Uspesno sacuvana knjiga! Broj knjige je {id}", "Uspesno");
                    }
                    else
                    {
                        MessageBox.Show($"Knjiga nije uspesno sacuvana", "Greska");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Desila se greska prilikom unosa knjige!" + ex.Message);
                }


            }

        }

        public void OsveziFormu()
        {
            txtOpis.Text = "";
            txtNaziv.Text = "";
            txtIzdanje.Text = "";
            listaPrimeraka.Clear();
            txtPrimerakID.Text = "";
            unosKnjiga = new Knjiga();
            lblAutori.Text = "Nije odabran nijedan autor";
        }

        private void dgvSpisakPrimeraka_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpisakPrimeraka.SelectedCells.Count == 0)
                btnObrisiPrimerak.Enabled = false;
            else
                btnObrisiPrimerak.Enabled = true;
        }
    }
}
