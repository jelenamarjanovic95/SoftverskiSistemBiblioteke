namespace Forms.ZaduzenjeForme
{
    partial class PronadjiKnjiguZaduzenjeForm
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
            this.myPanel = new System.Windows.Forms.Panel();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPonistiPretragu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNadjiPrimerak = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgvPronadjeneKnjige = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myPanel.SuspendLayout();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeneKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.myPanel.Controls.Add(this.gbPretraga);
            this.myPanel.Location = new System.Drawing.Point(2, 2);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(641, 434);
            this.myPanel.TabIndex = 0;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnPonistiPretragu);
            this.gbPretraga.Controls.Add(this.button1);
            this.gbPretraga.Controls.Add(this.btnNadjiPrimerak);
            this.gbPretraga.Controls.Add(this.lblPoruka);
            this.gbPretraga.Controls.Add(this.dgvPronadjeneKnjige);
            this.gbPretraga.Controls.Add(this.label3);
            this.gbPretraga.Controls.Add(this.txtVrednost);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.cbKriterijum);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Location = new System.Drawing.Point(13, 13);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(620, 411);
            this.gbPretraga.TabIndex = 4;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga knjiga";
            // 
            // btnPonistiPretragu
            // 
            this.btnPonistiPretragu.Location = new System.Drawing.Point(106, 157);
            this.btnPonistiPretragu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPonistiPretragu.Name = "btnPonistiPretragu";
            this.btnPonistiPretragu.Size = new System.Drawing.Size(106, 21);
            this.btnPonistiPretragu.TabIndex = 18;
            this.btnPonistiPretragu.Text = "Poništi pretragu";
            this.btnPonistiPretragu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNadjiPrimerak
            // 
            this.btnNadjiPrimerak.Location = new System.Drawing.Point(456, 351);
            this.btnNadjiPrimerak.Name = "btnNadjiPrimerak";
            this.btnNadjiPrimerak.Size = new System.Drawing.Size(157, 38);
            this.btnNadjiPrimerak.TabIndex = 16;
            this.btnNadjiPrimerak.Text = "Nadji primerak";
            this.btnNadjiPrimerak.UseVisualStyleBackColor = true;
            this.btnNadjiPrimerak.Click += new System.EventHandler(this.btnNadjiPrimerak_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(13, 233);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 11;
            // 
            // dgvPronadjeneKnjige
            // 
            this.dgvPronadjeneKnjige.AllowUserToAddRows = false;
            this.dgvPronadjeneKnjige.AllowUserToDeleteRows = false;
            this.dgvPronadjeneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeneKnjige.Location = new System.Drawing.Point(242, 42);
            this.dgvPronadjeneKnjige.Name = "dgvPronadjeneKnjige";
            this.dgvPronadjeneKnjige.ReadOnly = true;
            this.dgvPronadjeneKnjige.Size = new System.Drawing.Size(369, 281);
            this.dgvPronadjeneKnjige.TabIndex = 10;
            this.dgvPronadjeneKnjige.SelectionChanged += new System.EventHandler(this.dgvPronadjeneKnjige_SelectionChanged);
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
            this.txtVrednost.TextChanged += new System.EventHandler(this.txtVrednost_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pronađene knjige po kriterijumu:";
            // 
            // cbKriterijum
            // 
            this.cbKriterijum.FormattingEnabled = true;
            this.cbKriterijum.Items.AddRange(new object[] {
            "Naziv knjige",
            "Ime i prezime autora",
            "Broj knjige"});
            this.cbKriterijum.Location = new System.Drawing.Point(25, 67);
            this.cbKriterijum.Name = "cbKriterijum";
            this.cbKriterijum.Size = new System.Drawing.Size(187, 21);
            this.cbKriterijum.TabIndex = 1;
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
            // PronadjiKnjiguZaduzenjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 437);
            this.Controls.Add(this.myPanel);
            this.Name = "PronadjiKnjiguZaduzenjeForm";
            this.Text = "Odaberi knjigu";
            this.Load += new System.EventHandler(this.PronadjiKnjiguZaduzenjeForm_Load);
            this.myPanel.ResumeLayout(false);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeneKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Button btnPonistiPretragu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNadjiPrimerak;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.DataGridView dgvPronadjeneKnjige;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKriterijum;
        private System.Windows.Forms.Label label1;
    }
}