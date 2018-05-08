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
    public partial class KnjigaViseInfoForm : Form
    {
        private Knjiga knjiga;
        public KnjigaViseInfoForm(Knjiga k)
        {
            knjiga = k;
            InitializeComponent();
        }

        private void KnjigaViseInfoForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lblBrprRaspol.Text = knjiga.BrojPrimeraka.ToString() + "/" + knjiga.Raspolozivo.ToString();
            lblImePrezimeAutora.Text = knjiga.Autori;
            lblNaziv.Text = knjiga.Naziv;
            
            dgvSpisakPrimeraka.DataSource = knjiga.SpisakPrimeraka;

            lblOpis.MaximumSize = new Size(350, 200);
            lblOpis.AutoSize = true;
            lblOpis.Text = "Izdanje: " + knjiga.GodinaIzdanja.ToString() + "\n\n" + knjiga.Opis;
            lblBrojKnjige.Text = knjiga.KnjigaID.ToString();
        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            KnjigaPrimerak kp = knjiga.SpisakPrimeraka[dgvSpisakPrimeraka.SelectedCells[0].RowIndex];
            new ZaduziForm(kp).Show();
            //TODO: Refresh info na formi
            if(kp.Raspoloziva == false)
            {
                knjiga.Raspolozivo--;
                lblBrprRaspol.Text = knjiga.Raspolozivo.ToString();
            }

        }

        private void dgvSpisakPrimeraka_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpisakPrimeraka.SelectedCells.Count == 0)
            {
                btnZaduzi.Hide();
                return;
            }
            btnZaduzi.Show();
            btnZaduzi.Enabled = false;
            KnjigaPrimerak pr = knjiga.SpisakPrimeraka[dgvSpisakPrimeraka.SelectedCells[0].RowIndex];
            if (pr.Raspoloziva)
            {
                btnZaduzi.Enabled = true;
            }
        }
    }
}
