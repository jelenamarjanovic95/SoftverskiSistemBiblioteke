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
    public partial class PronadjiZaduzenje : Form
    {
        private BindingList<Clan> pronadjeniClanovi = new BindingList<Clan>();
        private Zaduzenje zaduzenje;

        public Zaduzenje Zaduzenje { get => zaduzenje; set => zaduzenje = value; }

        public PronadjiZaduzenje()
        {
            InitializeComponent();
            cbKriterijum.SelectedIndex = 0;
            PretraziClanove();
        }

        private void txtVrednost_TextChanged(object sender, EventArgs e)
        {
            PretraziClanove();
        }

        private void PronadjiZaduzenje_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            try
            {
                //dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
                //pronadjeniClanovi = new BindingList<Clan>(Kontroler.VratiSveClanove());
                ////dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
                //dgvZaduzenja.DataSource = pronadjeniClanovi[0].ListaZaduzenja;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Desila se greska pri ucitavanju clanova!");
            }
        }

        private void dgvPronadjeniClanovi_SelectionChanged(object sender, EventArgs e)
        {
            if (pronadjeniClanovi.Count == 0 || dgvPronadjeniClanovi.SelectedCells.Count == 0)
            {
                dgvZaduzenja.DataSource = new List<Zaduzenje>();
                return;
            }
            Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
            dgvZaduzenja.DataSource = c.ListaZaduzenja;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (pronadjeniClanovi.Count != 0 && pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex].ListaZaduzenja.Count != 0)
            {
                Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
                zaduzenje = c.ListaZaduzenja[dgvZaduzenja.SelectedCells[0].RowIndex];
            }
            else
                Zaduzenje = null;

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void dgvZaduzenja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPronadjeniClanovi.SelectedCells.Count != 0 && dgvZaduzenja.SelectedCells.Count != 0)
            {
                Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
               
                if (c.ListaZaduzenja[dgvZaduzenja.SelectedCells[0].RowIndex].DatumDo == null)
                {
                    btnOdaberi.Enabled = true;
                }
                else
                {
                    btnOdaberi.Enabled = false;
                }
            }
        }

        private void btnPonistiPretragu_Click(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziClanove();
        }
        private void PretraziClanove()
        {
            try
            {
                switch (cbKriterijum.SelectedIndex)
                {
                    case 0:
                        pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ImePrezimeClan));
                        break;
                    case 1:
                        pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ClanskiBroj));
                        break;
                }
                dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom pretrage clanova!");
            }

        }

        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            PretraziClanove();
        }
    }
}
