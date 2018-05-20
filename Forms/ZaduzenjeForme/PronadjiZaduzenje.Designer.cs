namespace Forms.ZaduzenjeForme
{
    partial class PronadjiZaduzenje
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPonistiPretragu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.cbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPronadjeniClanovi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dgvZaduzenja = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.btnPonistiPretragu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVrednost);
            this.groupBox1.Controls.Add(this.cbKriterijum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvPronadjeniClanovi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nadji clana";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(534, 358);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(142, 43);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPonistiPretragu
            // 
            this.btnPonistiPretragu.Location = new System.Drawing.Point(99, 144);
            this.btnPonistiPretragu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPonistiPretragu.Name = "btnPonistiPretragu";
            this.btnPonistiPretragu.Size = new System.Drawing.Size(106, 21);
            this.btnPonistiPretragu.TabIndex = 18;
            this.btnPonistiPretragu.Text = "Poništi pretragu";
            this.btnPonistiPretragu.UseVisualStyleBackColor = true;
            this.btnPonistiPretragu.Click += new System.EventHandler(this.btnPonistiPretragu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vrednost:";
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(19, 106);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(187, 20);
            this.txtVrednost.TabIndex = 16;
            this.txtVrednost.TextChanged += new System.EventHandler(this.txtVrednost_TextChanged);
            // 
            // cbKriterijum
            // 
            this.cbKriterijum.FormattingEnabled = true;
            this.cbKriterijum.Items.AddRange(new object[] {
            "Ime i prezime",
            "Clanski broj"});
            this.cbKriterijum.Location = new System.Drawing.Point(19, 55);
            this.cbKriterijum.Name = "cbKriterijum";
            this.cbKriterijum.Size = new System.Drawing.Size(187, 21);
            this.cbKriterijum.TabIndex = 15;
            this.cbKriterijum.SelectedIndexChanged += new System.EventHandler(this.cbKriterijum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kriterijum pretrage:";
            // 
            // dgvPronadjeniClanovi
            // 
            this.dgvPronadjeniClanovi.AllowUserToAddRows = false;
            this.dgvPronadjeniClanovi.AllowUserToDeleteRows = false;
            this.dgvPronadjeniClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeniClanovi.Location = new System.Drawing.Point(227, 55);
            this.dgvPronadjeniClanovi.Name = "dgvPronadjeniClanovi";
            this.dgvPronadjeniClanovi.ReadOnly = true;
            this.dgvPronadjeniClanovi.Size = new System.Drawing.Size(449, 281);
            this.dgvPronadjeniClanovi.TabIndex = 12;
            this.dgvPronadjeniClanovi.SelectionChanged += new System.EventHandler(this.dgvPronadjeniClanovi_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pronađeni članovi po kriterijumu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOdaberi);
            this.groupBox2.Controls.Add(this.dgvZaduzenja);
            this.groupBox2.Location = new System.Drawing.Point(726, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spisak zaduzenja";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(184, 358);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(148, 43);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi zaduzenje";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // dgvZaduzenja
            // 
            this.dgvZaduzenja.AllowUserToAddRows = false;
            this.dgvZaduzenja.AllowUserToDeleteRows = false;
            this.dgvZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenja.Location = new System.Drawing.Point(14, 25);
            this.dgvZaduzenja.Name = "dgvZaduzenja";
            this.dgvZaduzenja.ReadOnly = true;
            this.dgvZaduzenja.Size = new System.Drawing.Size(318, 311);
            this.dgvZaduzenja.TabIndex = 0;
            this.dgvZaduzenja.SelectionChanged += new System.EventHandler(this.dgvZaduzenja_SelectionChanged);
            // 
            // PronadjiZaduzenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PronadjiZaduzenje";
            this.Text = "Pronadji zaduzenje";
            this.Load += new System.EventHandler(this.PronadjiZaduzenje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPronadjeniClanovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPonistiPretragu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.ComboBox cbKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaduzenja;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnOdustani;
    }
}