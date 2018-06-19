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
    public partial class PretragaKnjigaForm : Form
    {
        private BindingList<Knjiga> pronadjeneKnjige = new BindingList<Knjiga>();

        public PretragaKnjigaForm()
        {
            InitializeComponent();
            try
            {
                //pronadjeneKnjige = new BindingList<Knjiga>(Kontroler.VratiSveKnjige());
                pronadjeneKnjige = new BindingList<Knjiga>(Komunikacija.Instance.VratiSveKnjige());
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom ucitavanja knjiga!");
            }
        }

        private void PretragaKnjigaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            SakrijDugmice();
            meni1.DisablePretragaKnjige();
            dgvPronadjeneKnjige.DataSource = pronadjeneKnjige;
            cbKriterijum.SelectedIndex = 0;
        }

        private void SakrijDugmice()
        {
            if (pronadjeneKnjige.Count == 0)
            {
                btnIzmeni.Hide();
                btnObrisi.Hide();
                btnViseInfo.Hide();
            }
        }

        private void btnViseInfo_Click(object sender, EventArgs e)
        {
            Knjiga k = pronadjeneKnjige[dgvPronadjeneKnjige.SelectedCells[0].RowIndex];
            new KnjigaViseInfoForm(k).ShowDialog();
            PretraziKnjige();
        }
        
        private void dgvPronadjeneKnjige_SelectionChanged(object sender, EventArgs e)
        {
            btnIzmeni.Show();
            btnObrisi.Show();
            btnViseInfo.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Knjiga k = pronadjeneKnjige[dgvPronadjeneKnjige.SelectedCells[0].RowIndex];
            new IzmeniKnjiguForm(k).ShowDialog();
            PretraziKnjige();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu knjigu?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Knjiga k = pronadjeneKnjige[dgvPronadjeneKnjige.SelectedCells[0].RowIndex];

                try
                {
                    //Kontroler.ObrisiKnjigu(k);
                    if (Komunikacija.Instance.ObrisiKnjigu(k))
                    {
                        MessageBox.Show("Uspesno obrisana knjiga!");
                        PretraziKnjige();
                    }
                    else
                    {
                        MessageBox.Show("Nije moguce obrisati knjigu!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Desila se greska pri brisanju knjige!");
                }
            }
            SakrijDugmice();
        }

        private void txtVrednost_TextChanged(object sender, EventArgs e)
        {
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
                SakrijDugmice();
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom pretrage knjiga!");
            }

        }

        private void btnPonistiPretragu_Click(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziKnjige();
        }

        private void cbKriterijum_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVrednost.Text = "";
            PretraziKnjige();
        }
    }
}
