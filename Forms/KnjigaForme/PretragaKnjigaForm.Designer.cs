namespace Forms
{
    partial class PretragaKnjigaForm
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
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgvPronadjeneKnjige = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnViseInfo = new System.Windows.Forms.Button();
            this.cbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPonistiPretragu = new System.Windows.Forms.Button();
            this.meni1 = new Forms.Meni();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeneKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.dgvPronadjeneKnjige);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVrednost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnViseInfo);
            this.groupBox1.Controls.Add(this.cbKriterijum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1137, 759);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga knjiga";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(24, 430);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 25);
            this.lblPoruka.TabIndex = 11;
            // 
            // dgvPronadjeneKnjige
            // 
            this.dgvPronadjeneKnjige.AllowUserToAddRows = false;
            this.dgvPronadjeneKnjige.AllowUserToDeleteRows = false;
            this.dgvPronadjeneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeneKnjige.Location = new System.Drawing.Point(444, 78);
            this.dgvPronadjeneKnjige.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPronadjeneKnjige.Name = "dgvPronadjeneKnjige";
            this.dgvPronadjeneKnjige.ReadOnly = true;
            this.dgvPronadjeneKnjige.Size = new System.Drawing.Size(677, 519);
            this.dgvPronadjeneKnjige.TabIndex = 10;
            this.dgvPronadjeneKnjige.SelectionChanged += new System.EventHandler(this.dgvPronadjeneKnjige_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrednost:";
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(46, 218);
            this.txtVrednost.Margin = new System.Windows.Forms.Padding(6);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(340, 29);
            this.txtVrednost.TabIndex = 8;
            this.txtVrednost.TextChanged += new System.EventHandler(this.txtVrednost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pronađene knjige po kriterijumu:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(928, 657);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(193, 42);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(691, 657);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(6);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(193, 42);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnViseInfo
            // 
            this.btnViseInfo.Location = new System.Drawing.Point(440, 657);
            this.btnViseInfo.Margin = new System.Windows.Forms.Padding(6);
            this.btnViseInfo.Name = "btnViseInfo";
            this.btnViseInfo.Size = new System.Drawing.Size(193, 42);
            this.btnViseInfo.TabIndex = 4;
            this.btnViseInfo.Text = "Više informacija";
            this.btnViseInfo.UseVisualStyleBackColor = true;
            this.btnViseInfo.Click += new System.EventHandler(this.btnViseInfo_Click);
            // 
            // cbKriterijum
            // 
            this.cbKriterijum.FormattingEnabled = true;
            this.cbKriterijum.Items.AddRange(new object[] {
            "Naziv knjige",
            "Ime i prezime autora",
            "Broj knjige"});
            this.cbKriterijum.Location = new System.Drawing.Point(46, 124);
            this.cbKriterijum.Margin = new System.Windows.Forms.Padding(6);
            this.cbKriterijum.Name = "cbKriterijum";
            this.cbKriterijum.Size = new System.Drawing.Size(340, 32);
            this.cbKriterijum.TabIndex = 1;
            this.cbKriterijum.SelectedIndexChanged += new System.EventHandler(this.cbKriterijum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriterijum pretrage:";
            // 
            // btnPonistiPretragu
            // 
            this.btnPonistiPretragu.Location = new System.Drawing.Point(214, 332);
            this.btnPonistiPretragu.Name = "btnPonistiPretragu";
            this.btnPonistiPretragu.Size = new System.Drawing.Size(194, 38);
            this.btnPonistiPretragu.TabIndex = 12;
            this.btnPonistiPretragu.Text = "Poništi pretragu";
            this.btnPonistiPretragu.UseVisualStyleBackColor = true;
            this.btnPonistiPretragu.Click += new System.EventHandler(this.btnPonistiPretragu_Click);
            // 
            // meni1
            // 
            this.meni1.Location = new System.Drawing.Point(4, 4);
            this.meni1.Margin = new System.Windows.Forms.Padding(11);
            this.meni1.Name = "meni1";
            this.meni1.Size = new System.Drawing.Size(1173, 48);
            this.meni1.TabIndex = 0;
            // 
            // PretragaKnjigaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 831);
            this.Controls.Add(this.btnPonistiPretragu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.meni1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PretragaKnjigaForm";
            this.Text = "Pretraga knjiga";
            this.Load += new System.EventHandler(this.PretragaKnjigaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeneKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Meni meni1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPronadjeneKnjige;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnViseInfo;
        private System.Windows.Forms.ComboBox cbKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnPonistiPretragu;
    }
}