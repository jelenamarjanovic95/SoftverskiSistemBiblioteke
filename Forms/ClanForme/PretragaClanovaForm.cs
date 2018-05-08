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
    public partial class PretragaClanovaForm : Form
    {
        private BindingList<Clan> pronadjeniClanovi = new BindingList<Clan>();

        public PretragaClanovaForm()
        {
            InitializeComponent();

        }

        private void PretragaClanovaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            try
            {
                //pronadjeniClanovi = new BindingList<Clan>(Kontroler.VratiSveClanove());
                pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.VratiSveClanove());
                dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
                SakrijDugmice();
                meni.DisablePretragaClana();
                cbKriterijum.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska pri ucitavanju clanova!");
            }
        }

        private void SakrijDugmice()
        {
            if (pronadjeniClanovi.Count == 0)
            {
                btnIzmeni.Hide();
                btnObrisi.Hide();
                btnViseInfo.Hide();
            }
        }

        private void dgvPronadjeniClanovi_SelectionChanged(object sender, EventArgs e)
        {
            btnIzmeni.Show();
            btnObrisi.Show();
            btnViseInfo.Show();
        }

        private void btnViseInfo_Click(object sender, EventArgs e)
        {
            Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
            new ClanViseInfoForm(c).ShowDialog();
            this.PretraziClanove();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranog clana?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];

                try
                {
                    //Kontroler.ObrisiClana(c);
                    if (Komunikacija.Instance.ObrisiClana(c))
                    {
                        MessageBox.Show("Uspesno obrisan clan!");
                        PretraziClanove();
                    }
                    else
                    {
                        MessageBox.Show("Clan nije uspesno obrisan!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije moguce obrisati odabranog clana!");
                }
                //pronadjeniClanovi.Remove(c);
            }
            SakrijDugmice();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Clan c = pronadjeniClanovi[dgvPronadjeniClanovi.SelectedCells[0].RowIndex];
            new IzmeniClanaForm(c).ShowDialog();
            this.PretraziClanove();
        }

        private void txtVrednost_TextChanged(object sender, EventArgs e)
        {
            this.PretraziClanove();
        }

        private void PretraziClanove()
        {
            try
            {
                switch (cbKriterijum.SelectedIndex)
                {
                    case 0:
                        //pronadjeniClanovi = new BindingList<Clan>(Kontroler.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ImePrezimeClan));
                        pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ImePrezimeClan));
                        break;
                    case 1:
                        //pronadjeniClanovi = new BindingList<Clan>(Kontroler.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ClanskiBroj));
                        pronadjeniClanovi = new BindingList<Clan>(Komunikacija.Instance.PretraziClanove(txtVrednost.Text, KriterijumPretrage.ClanskiBroj));
                        break;
                }
                dgvPronadjeniClanovi.DataSource = pronadjeniClanovi;
                SakrijDugmice();
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom pretrage clanova!");
            }

        }

        private void btnPonistiPretragu_Click(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziClanove();
        }

        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziClanove();
        }

    }
}
