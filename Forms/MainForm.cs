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
    public partial class MainForm : Form
    {
        private Bibliotekar ulogovaniBibliotekar;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
                //MessageBox.Show("Uspesno povezan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska prilikom povezivanja na server" + ex.Message);
                this.Close();
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.OK)
            {
                ulogovaniBibliotekar = lf.Bibl;
                lblBibl.Text = ulogovaniBibliotekar.ToString();
                this.Show();
            }
            else
            {
                this.Close();
            }

            meni1.EnableAll();
        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            new ZaduziForm().Show();
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            new RazduziForm().Show();
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Komunikacija.Instance.Kraj();
        }
    }
}
