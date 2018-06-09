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
    public partial class ClanViseInfoForm : Form
    {
        private Clan clan;
        private BindingList<Zaduzenje> spisakZaduzenja;

        public ClanViseInfoForm(Clan c)
        {
            this.clan = c;
            InitializeComponent();
            spisakZaduzenja = new BindingList<Zaduzenje>(c.ListaZaduzenja);
        }

        private void ViseInfoForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            btnRazduzi.Hide();
            lblClanskiBroj.Text = clan.ClanskiBroj.ToString();
            lblAdresa.Text = clan.Adresa;
            lblBrojTel.Text = clan.BrojTelefona;
            lblImePrezime.Text = $"{clan.ImePrezime}";
            dgvZaduzenja.DataSource = spisakZaduzenja;
        }

        private void dgvZaduzenja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaduzenja.SelectedCells.Count == 0)
            {
                btnRazduzi.Hide();
                return;
            }
            btnRazduzi.Show();
            btnRazduzi.Enabled = false;
            Zaduzenje z = clan.ListaZaduzenja[dgvZaduzenja.SelectedCells[0].RowIndex];
            if (z.DatumDo == null)
            {
                btnRazduzi.Enabled = true;
            }
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            Zaduzenje z = clan.ListaZaduzenja[dgvZaduzenja.SelectedCells[0].RowIndex];
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da razduzite ovu knjigu?", "Provera", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (KontrolerKorisnickogInterfejsa.Razduzi(z))
                    {
                        MessageBox.Show("Uspesno razduzena knjiga!");
                        //spisakZaduzenja = new BindingList<Zaduzenje>(Kontroler.NadjiClana(clan.ClanskiBroj).ListaZaduzenja);
                        spisakZaduzenja = new BindingList<Zaduzenje>(Komunikacija.Instance.NadjiClana(clan.ClanskiBroj).ListaZaduzenja);

                        z.DatumDo = DateTime.Now.Date;
                        dgvZaduzenja.DataSource = spisakZaduzenja;
                    }
                    else
                    {
                        MessageBox.Show("Knjiga nije uspesno razduzena!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Desila se greska pri razduzivanju knjige!");
                }

            }
        }
    }
}
