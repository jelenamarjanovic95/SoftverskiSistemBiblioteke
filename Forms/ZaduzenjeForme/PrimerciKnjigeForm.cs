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
    public partial class PrimerciKnjigeForm : Form
    {
        Knjiga knjiga;
        KnjigaPrimerak primerak;
        public PrimerciKnjigeForm(Knjiga k)
        {
            InitializeComponent();
            knjiga = k;
        }

        public KnjigaPrimerak Primerak { get => primerak; set => primerak = value; }

        private void PrimerciKnjigeForm_Load(object sender, EventArgs e)
        {
            lblNazivKnjige.Text = knjiga.Naziv;
            dgvSpisakPrimeraka.DataSource = knjiga.SpisakPrimeraka;
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (dgvSpisakPrimeraka.SelectedCells.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedan primerak!");
                return;
            }
            primerak = knjiga.SpisakPrimeraka[dgvSpisakPrimeraka.SelectedCells[0].RowIndex];
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void dgvSpisakPrimeraka_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpisakPrimeraka.SelectedCells.Count == 0 || !knjiga.SpisakPrimeraka[dgvSpisakPrimeraka.SelectedCells[0].RowIndex].Raspoloziva)
                btnOdaberi.Enabled = false;
            else
                btnOdaberi.Enabled = true;
        }
    }
}
