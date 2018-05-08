using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Meni : UserControl
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void članaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["UnosClanaForm"];

            if (fc != null)
                MessageBox.Show("Forma je vec otvorena");
            else
                new UnosClanaForm().Show();
        }

        public void EnableAll()
        {
            tsUnosClana.Enabled = true;
            tsUnosKnjige.Enabled = true;
            tsUnosZaduzenja.Enabled = true;
            tsIzmenaClana.Enabled = true;
            tsIzmenaKnjige.Enabled = true;
            tsIzmenaZaduzenja.Enabled = true;
            lala.Enabled = true;
            tsPretragaKnjiga.Enabled = true;
            lalala.Enabled = true;
            tsBrisanjeKnjige.Enabled = true;
        }


        #region disable
        public void DisableUnosClana()
        {
            EnableAll();
            tsUnosClana.Enabled = false;
        }

        public void DisableUnosKnjige()
        {
            EnableAll();
            tsUnosKnjige.Enabled = false;
        }

        public void DisableUnosZaduzenja()
        {
            EnableAll();
            tsUnosZaduzenja.Enabled = false;
        }

        public void DisableIzmenaClana()
        {
            EnableAll();
            tsIzmenaClana.Enabled = false;
        }

        public void DisableIzmenaKnjige()
        {
            EnableAll();
            tsIzmenaKnjige.Enabled = false;
        }

        public void DisableIzmenaZaduzenja()
        {
            EnableAll();
            tsIzmenaZaduzenja.Enabled = false;
        }

        public void DisablePretragaClana()
        {
            EnableAll();
            tsPretragaClanova.Enabled = false;
            tsBrisanjeClana.Enabled = false;
        }

        public void DisablePretragaKnjige()
        {
            EnableAll();
            tsPretragaKnjiga.Enabled = false;
            tsBrisanjeKnjige.Enabled = false;
        }
        #endregion

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("UnosKnjigeForm"))
                new UnosKnjigeForm().Show();
        }

        private void članovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaClanovaForm"))
                new PretragaClanovaForm().Show();
        }

        private void knjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaKnjigaForm"))
                new PretragaKnjigaForm().Show();
        }


        private void tsIzmenaClana_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaClanovaForm"))
                new PretragaClanovaForm().Show();
        }

        private void tsIzmenaKnjige_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaKnjigaForm"))
                new PretragaKnjigaForm().Show();
        }

        private void tsIzmenaZaduzenja_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("RazduziForm"))
                new RazduziForm().Show();
        }

        private void tsUnosZaduzenja_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("ZaduziForm"))
                new ZaduziForm().Show();
        }

        private void tsBrisanjeClana_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaClanovaForm"))
                new PretragaClanovaForm().Show();
        }

        private void tsBrisanjeKnjige_Click(object sender, EventArgs e)
        {
            if (!DaLiJeOtvorenaForma("PretragaKnjigaForm"))
                new PretragaKnjigaForm().Show();
        }

        public bool DaLiJeOtvorenaForma(string forma)
        {
            Form fc = Application.OpenForms[forma];

            if (fc != null)
            {

                MessageBox.Show("Forma je vec otvorena");
                return true;
            }
            else
                return false;
        }
    }
}
