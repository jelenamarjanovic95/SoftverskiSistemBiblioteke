namespace Forms
{
    partial class PretragaClanovaForm
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
            this.btnPonistiPretragu = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgvPronadjeniClanovi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnViseInfo = new System.Windows.Forms.Button();
            this.cbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.meni = new Forms.Meni();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPonistiPretragu);
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.dgvPronadjeniClanovi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVrednost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnViseInfo);
            this.groupBox1.Controls.Add(this.cbKriterijum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga članova";
            // 
            // btnPonistiPretragu
            // 
            this.btnPonistiPretragu.Location = new System.Drawing.Point(105, 156);
            this.btnPonistiPretragu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPonistiPretragu.Name = "btnPonistiPretragu";
            this.btnPonistiPretragu.Size = new System.Drawing.Size(106, 21);
            this.btnPonistiPretragu.TabIndex = 13;
            this.btnPonistiPretragu.Text = "Poništi pretragu";
            this.btnPonistiPretragu.UseVisualStyleBackColor = true;
            this.btnPonistiPretragu.Click += new System.EventHandler(this.btnPonistiPretragu_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(3, 229);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 11;
            // 
            // dgvPronadjeniClanovi
            // 
            this.dgvPronadjeniClanovi.AllowUserToAddRows = false;
            this.dgvPronadjeniClanovi.AllowUserToDeleteRows = false;
            this.dgvPronadjeniClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeniClanovi.Location = new System.Drawing.Point(242, 42);
            this.dgvPronadjeniClanovi.Name = "dgvPronadjeniClanovi";
            this.dgvPronadjeniClanovi.ReadOnly = true;
            this.dgvPronadjeniClanovi.Size = new System.Drawing.Size(445, 281);
            this.dgvPronadjeniClanovi.TabIndex = 10;
            this.dgvPronadjeniClanovi.SelectionChanged += new System.EventHandler(this.dgvPronadjeniClanovi_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrednost:";
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(25, 118);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(187, 20);
            this.txtVrednost.TabIndex = 8;
            this.txtVrednost.TextChanged += new System.EventHandler(this.txtVrednost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pronađeni članovi po kriterijumu:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(582, 343);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(416, 343);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(105, 23);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnViseInfo
            // 
            this.btnViseInfo.Location = new System.Drawing.Point(242, 343);
            this.btnViseInfo.Name = "btnViseInfo";
            this.btnViseInfo.Size = new System.Drawing.Size(105, 23);
            this.btnViseInfo.TabIndex = 4;
            this.btnViseInfo.Text = "Više informacija";
            this.btnViseInfo.UseVisualStyleBackColor = true;
            this.btnViseInfo.Click += new System.EventHandler(this.btnViseInfo_Click);
            // 
            // cbKriterijum
            // 
            this.cbKriterijum.FormattingEnabled = true;
            this.cbKriterijum.Items.AddRange(new object[] {
            "Ime i prezime",
            "Clanski broj"});
            this.cbKriterijum.Location = new System.Drawing.Point(25, 67);
            this.cbKriterijum.Name = "cbKriterijum";
            this.cbKriterijum.Size = new System.Drawing.Size(187, 21);
            this.cbKriterijum.TabIndex = 1;
            this.cbKriterijum.SelectedIndexChanged += new System.EventHandler(this.cbKriterijum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriterijum pretrage:";
            // 
            // meni
            // 
            this.meni.Location = new System.Drawing.Point(1, 0);
            this.meni.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.meni.Name = "meni";
            this.meni.Size = new System.Drawing.Size(725, 26);
            this.meni.TabIndex = 2;
            // 
            // PretragaClanovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.meni);
            this.Controls.Add(this.groupBox1);
            this.Name = "PretragaClanovaForm";
            this.Text = "Pretraga članova";
            this.Load += new System.EventHandler(this.PretragaClanovaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKriterijum;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnViseInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPronadjeniClanovi;
        private System.Windows.Forms.Label lblPoruka;
        private Meni meni;
        private System.Windows.Forms.Button btnPonistiPretragu;
    }
}