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
    public partial class PronadjiClanaZaduzenjeForm : Form
    {
        private BindingList<Clan> pronadjeniClanovi = new BindingList<Clan>();
        private Clan clan;

        public Clan Clan { get => clan; set => clan = value; }

        public PronadjiClanaZaduzenjeForm()
        {
            InitializeComponent();
        }

        private void PronadjiClanaZaduzenjeForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            try
            {
                //pronadjeniClanovi = new BindingList<Clan>(Kontroler.VratiSveClanove());
                pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.VratiSveClanove());
                dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
                cbKriterijum.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska pri ucitavanju clanova!");
            }
        }

        private void txtVrednost_TextChanged(object sender, EventArgs e)
        {
            PretraziClanove();
        }

        private void btnPonistiPretragu_Click(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziClanove();
        }

        private void btnOdaberiClana_Click(object sender, EventArgs e)
        {
            if(pronadjeniClanovi.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednog clana!");
                return;
            }
            Clan = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
            this.DialogResult = DialogResult.OK;
            this.Dispose();
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
            this.PretraziClanove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void dgvPronadjeniClanovi_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPronadjeniClanovi.SelectedCells.Count == 0)
            {
                btnOdaberiClana.Enabled = false;
            }
            else
            {
                btnOdaberiClana.Enabled = true;
            }
        }
    }
}
