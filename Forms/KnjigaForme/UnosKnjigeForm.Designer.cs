namespace Forms
{
    partial class UnosKnjigeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAutori = new System.Windows.Forms.Label();
            this.btnAutori = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiPrimerak = new System.Windows.Forms.Button();
            this.dgvSpisakPrimeraka = new System.Windows.Forms.DataGridView();
            this.btnDodajPrimerak = new System.Windows.Forms.Button();
            this.txtPrimerakID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIzdanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.meni2 = new Forms.Meni();
            this.meni1 = new Forms.Meni();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAutori);
            this.groupBox1.Controls.Add(this.btnAutori);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIzdanje);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 586);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos knjige";
            // 
            // lblAutori
            // 
            this.lblAutori.AutoSize = true;
            this.lblAutori.Location = new System.Drawing.Point(305, 130);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(131, 13);
            this.lblAutori.TabIndex = 14;
            this.lblAutori.Text = "Nije odabran nijedan autor";
            // 
            // btnAutori
            // 
            this.btnAutori.Location = new System.Drawing.Point(112, 125);
            this.btnAutori.Name = "btnAutori";
            this.btnAutori.Size = new System.Drawing.Size(144, 23);
            this.btnAutori.TabIndex = 4;
            this.btnAutori.Text = "Odaberi autore";
            this.btnAutori.UseVisualStyleBackColor = true;
            this.btnAutori.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiPrimerak);
            this.groupBox2.Controls.Add(this.dgvSpisakPrimeraka);
            this.groupBox2.Controls.Add(this.btnDodajPrimerak);
            this.groupBox2.Controls.Add(this.txtPrimerakID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(28, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 239);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nov primerak";
            // 
            // btnObrisiPrimerak
            // 
            this.btnObrisiPrimerak.Location = new System.Drawing.Point(380, 69);
            this.btnObrisiPrimerak.Name = "btnObrisiPrimerak";
            this.btnObrisiPrimerak.Size = new System.Drawing.Size(151, 23);
            this.btnObrisiPrimerak.TabIndex = 4;
            this.btnObrisiPrimerak.Text = "Obrisi izabrani primerak";
            this.btnObrisiPrimerak.UseVisualStyleBackColor = true;
            this.btnObrisiPrimerak.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSpisakPrimeraka
            // 
            this.dgvSpisakPrimeraka.AllowUserToAddRows = false;
            this.dgvSpisakPrimeraka.AllowUserToDeleteRows = false;
            this.dgvSpisakPrimeraka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakPrimeraka.Location = new System.Drawing.Point(84, 69);
            this.dgvSpisakPrimeraka.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSpisakPrimeraka.Name = "dgvSpisakPrimeraka";
            this.dgvSpisakPrimeraka.ReadOnly = true;
            this.dgvSpisakPrimeraka.RowTemplate.Height = 33;
            this.dgvSpisakPrimeraka.Size = new System.Drawing.Size(271, 152);
            this.dgvSpisakPrimeraka.TabIndex = 3;
            this.dgvSpisakPrimeraka.SelectionChanged += new System.EventHandler(this.dgvSpisakPrimeraka_SelectionChanged);
            // 
            // btnDodajPrimerak
            // 
            this.btnDodajPrimerak.Location = new System.Drawing.Point(380, 18);
            this.btnDodajPrimerak.Name = "btnDodajPrimerak";
            this.btnDodajPrimerak.Size = new System.Drawing.Size(151, 23);
            this.btnDodajPrimerak.TabIndex = 2;
            this.btnDodajPrimerak.Text = "Dodaj primerak";
            this.btnDodajPrimerak.UseVisualStyleBackColor = true;
            this.btnDodajPrimerak.Click += new System.EventHandler(this.btnDodajPrimerak_Click);
            // 
            // txtPrimerakID
            // 
            this.txtPrimerakID.Location = new System.Drawing.Point(155, 27);
            this.txtPrimerakID.Name = "txtPrimerakID";
            this.txtPrimerakID.Size = new System.Drawing.Size(202, 20);
            this.txtPrimerakID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sledeci broj primerka:";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(112, 173);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtOpis.Size = new System.Drawing.Size(273, 119);
            this.txtOpis.TabIndex = 12;
            this.txtOpis.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(441, 554);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 23);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Autor:";
            // 
            // txtIzdanje
            // 
            this.txtIzdanje.Location = new System.Drawing.Point(112, 83);
            this.txtIzdanje.Name = "txtIzdanje";
            this.txtIzdanje.Size = new System.Drawing.Size(273, 20);
            this.txtIzdanje.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(112, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(273, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.Location = new System.Drawing.Point(180, 560);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina izdanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // meni2
            // 
            this.meni2.Location = new System.Drawing.Point(0, 0);
            this.meni2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.meni2.Name = "meni2";
            this.meni2.Size = new System.Drawing.Size(640, 26);
            this.meni2.TabIndex = 3;
            this.meni2.Load += new System.EventHandler(this.meni2_Load);
            // 
            // meni1
            // 
            this.meni1.Location = new System.Drawing.Point(2, 1);
            this.meni1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.meni1.Name = "meni1";
            this.meni1.Size = new System.Drawing.Size(640, 26);
            this.meni1.TabIndex = 0;
            // 
            // UnosKnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 633);
            this.Controls.Add(this.meni2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.meni1);
            this.Name = "UnosKnjigeForm";
            this.Text = "Unos nove knjige";
            this.Load += new System.EventHandler(this.UnosKnjigeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Meni meni1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtIzdanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimerakID;
        private System.Windows.Forms.Button btnDodajPrimerak;
        private Meni meni2;
        private System.Windows.Forms.Button btnAutori;
        private System.Windows.Forms.Label lblAutori;
        private System.Windows.Forms.DataGridView dgvSpisakPrimeraka;
        private System.Windows.Forms.Button btnObrisiPrimerak;
    }
}