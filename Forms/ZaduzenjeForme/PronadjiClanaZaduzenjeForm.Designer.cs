namespace Forms.ZaduzenjeForme
{
    partial class PronadjiClanaZaduzenjeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOdaberiClana = new System.Windows.Forms.Button();
            this.btnPonistiPretragu = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgvPronadjeniClanovi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnOdaberiClana);
            this.groupBox1.Controls.Add(this.btnPonistiPretragu);
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.dgvPronadjeniClanovi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVrednost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbKriterijum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga članova";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdaberiClana
            // 
            this.btnOdaberiClana.Location = new System.Drawing.Point(530, 343);
            this.btnOdaberiClana.Name = "btnOdaberiClana";
            this.btnOdaberiClana.Size = new System.Drawing.Size(157, 38);
            this.btnOdaberiClana.TabIndex = 14;
            this.btnOdaberiClana.Text = "Odaberi člana";
            this.btnOdaberiClana.UseVisualStyleBackColor = true;
            this.btnOdaberiClana.Click += new System.EventHandler(this.btnOdaberiClana_Click);
            // 
            // btnPonistiPretragu
            // 
            this.btnPonistiPretragu.Location = new System.Drawing.Point(105, 156);
            this.btnPonistiPretragu.Margin = new System.Windows.Forms.Padding(2);
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
            // PronadjiClanaZaduzenjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "PronadjiClanaZaduzenjeForm";
            this.Text = "PronadjiClanaZaduzenjeForm";
            this.Load += new System.EventHandler(this.PronadjiClanaZaduzenjeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniClanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberiClana;
        private System.Windows.Forms.Button btnPonistiPretragu;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.DataGridView dgvPronadjeniClanovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}