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

namespace Forms.ZaduzenjeForme
{
    public partial class PronadjiKnjiguZaduzenjeForm : Form
    {
        private BindingList<Knjiga> pronadjeneKnjige = new BindingList<Knjiga>();
        private KnjigaPrimerak primerak;

        public KnjigaPrimerak Primerak { get => primerak; set => primerak = value; }

        public PronadjiKnjiguZaduzenjeForm()
        {
            InitializeComponent();

            try
            {
                pronadjeneKnjige = new BindingList<Knjiga>(Komunikacija.Instance.VratiSveKnjige());
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom ucitavanja knjiga!");
            }
        }

        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziKnjige();
        }

        private void PretraziKnjige()
        {
            try
            {
                switch (cbKriterijum.SelectedIndex)
                {
                    case 0:
                        pronadjeneKnjige = new BindingList<Knjiga>(Komunikacija.Instance.PretraziKnjige(txtVrednost.Text, KriterijumPretrage.NazivKnjige));

                        break;
                    case 1:
                        pronadjeneKnjige = new BindingList<Knjiga>(Komunikacija.Instance.PretraziKnjige(txtVrednost.Text, KriterijumPretrage.ImePrezimeAutor));
                        break;
                    case 2:
                        pronadjeneKnjige = new BindingList<Knjiga>(Komunikacija.Instance.PretraziKnjige(txtVrednost.Text, KriterijumPretrage.BrojKnjige));
                        break;
                }
                dgvPronadjeneKnjige.DataSource = pronadjeneKnjige;
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom pretrage knjiga!");
            }

        }

        private void PronadjiKnjiguZaduzenjeForm_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;

            dgvPronadjeneKnjige.DataSource = pronadjeneKnjige;
            cbKriterijum.SelectedIndex = 0;
        }

        private void txtVrednost_TextChanged(object sender, EventArgs e)
        {
            PretraziKnjige();
        }

        private void btnPonistiPretragu_Click(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziKnjige();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnNadjiPrimerak_Click(object sender, EventArgs e)
        {
            Knjiga k = pronadjeneKnjige[dgvPronadjeneKnjige.SelectedCells[0].RowIndex];
            if (k == null)
            {
                MessageBox.Show("Niste odabrali nijednu knjigu!");
                return;
            }
            this.Hide();
            ZaduzenjeForme.PrimerciKnjigeForm pk = new PrimerciKnjigeForm(k);
            pk.ShowDialog();
            if (pk.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
            if (pk.DialogResult == DialogResult.OK)
            {
                primerak = pk.Primerak;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void txtVrednost_TextChanged_1(object sender, EventArgs e)
        {
            PretraziKnjige();
        }

        private void dgvPronadjeneKnjige_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPronadjeneKnjige.SelectedCells.Count == 0)
                btnNadjiPrimerak.Enabled = false;
            else
                btnNadjiPrimerak.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
