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
    public partial class OdaberiAutora : Form
    {
        BindingList<Autor> spisakAutora;
        BindingList<Autor> prethodnoStanje;
        BindingList<Autor> odabraniAutori = new BindingList<Autor>();
        Knjiga knjiga;

        public OdaberiAutora(Knjiga knjiga)
        {
            InitializeComponent();
            if(knjiga.ListaAutora.Count == 0) {
                try
                {
                    //spisakAutora = new BindingList<Autor>(Kontroler.VratiSveAutore());
                    spisakAutora = new BindingList<Autor>(Komunikacija.Instance.VratiSveAutore());
                }
                catch (Exception)
                {
                    MessageBox.Show("Desila se greska prilikom ucitavanja autora!");
                }
            }
            else
            {
                odabraniAutori = new BindingList<Autor>(knjiga.ListaAutora);
                spisakAutora = new BindingList<Autor>();
                SpisakOstaliAutori(odabraniAutori);
            }
            prethodnoStanje = Kloniraj(spisakAutora);
            this.knjiga = knjiga;
        }
        

        private void OdaberiAutora_Load(object sender, EventArgs e)
        {
            dgvOdabraniAutori.DataSource = odabraniAutori;
            dgvSpisakAutora.DataSource = spisakAutora;
        }

        private void SpisakOstaliAutori(BindingList<Autor> odabraniAutori)
        {

            try
            {
                foreach (Autor a in Komunikacija.Instance.VratiSveAutore())
                {
                    bool nalazi = false;
                    foreach (Autor aa in odabraniAutori)
                    {
                        if (aa.AutorID == a.AutorID)
                        {
                            nalazi = true;
                            break;
                        }
                    }
                    if (!nalazi)
                        spisakAutora.Add(a);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Desila se greska prilikom pretrage autora!");
                this.Dispose();
            }
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(dgvSpisakAutora.SelectedCells.Count == 0)
            {
                return;
            }
            Autor a = spisakAutora[dgvSpisakAutora.SelectedCells[0].RowIndex];
            odabraniAutori.Add(a);
            spisakAutora.Remove(a);
            prethodnoStanje.Remove(a);
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (dgvOdabraniAutori.SelectedCells.Count == 0)
            {
                return;
            }
            Autor a = odabraniAutori[dgvOdabraniAutori.SelectedCells[0].RowIndex];
            odabraniAutori.Remove(a);
            spisakAutora.Add(a);
            prethodnoStanje.Add(a);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = txtPretraga.Text;
            if (text == "")
            {
                spisakAutora = Kloniraj(prethodnoStanje);
                dgvSpisakAutora.DataSource = spisakAutora;
                return;
            }

            spisakAutora.Clear();
            foreach (Autor a in prethodnoStanje)
            {
                if (a.ImePrezime.ToLower().Contains(text.ToLower()))
                {
                    spisakAutora.Add(a);
                }
            }
        }

        private void btnResetujPretragu_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
        }

        private BindingList<Autor> Kloniraj(BindingList<Autor> lista)
        {
            BindingList<Autor> listaAutora = new BindingList<Autor>();

            foreach(Autor a in lista)
            {
                listaAutora.Add(a);
            }

            return listaAutora;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            knjiga.ListaAutora = odabraniAutori.ToList();
            this.Close();
        }
    }
}
