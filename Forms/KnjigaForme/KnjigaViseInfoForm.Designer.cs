namespace Forms
{
    partial class KnjigaViseInfoForm
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
            this.lblImePrezimeAutora = new System.Windows.Forms.Label();
            this.dgvSpisakPrimeraka = new System.Windows.Forms.DataGridView();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblBrprRaspol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.lblBrojKnjige = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImePrezimeAutora
            // 
            this.lblImePrezimeAutora.AutoSize = true;
            this.lblImePrezimeAutora.Location = new System.Drawing.Point(29, 59);
            this.lblImePrezimeAutora.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImePrezimeAutora.Name = "lblImePrezimeAutora";
            this.lblImePrezimeAutora.Size = new System.Drawing.Size(199, 25);
            this.lblImePrezimeAutora.TabIndex = 19;
            this.lblImePrezimeAutora.Text = "[Ime i prezime autora]";
            // 
            // dgvSpisakPrimeraka
            // 
            this.dgvSpisakPrimeraka.AllowUserToAddRows = false;
            this.dgvSpisakPrimeraka.AllowUserToDeleteRows = false;
            this.dgvSpisakPrimeraka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakPrimeraka.Location = new System.Drawing.Point(31, 487);
            this.dgvSpisakPrimeraka.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSpisakPrimeraka.Name = "dgvSpisakPrimeraka";
            this.dgvSpisakPrimeraka.ReadOnly = true;
            this.dgvSpisakPrimeraka.Size = new System.Drawing.Size(613, 323);
            this.dgvSpisakPrimeraka.TabIndex = 18;
            this.dgvSpisakPrimeraka.SelectionChanged += new System.EventHandler(this.dgvSpisakPrimeraka_SelectionChanged);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(26, 134);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(58, 20);
            this.lblOpis.TabIndex = 17;
            this.lblOpis.Text = "[OPIS]";
            // 
            // lblBrprRaspol
            // 
            this.lblBrprRaspol.AutoSize = true;
            this.lblBrprRaspol.Location = new System.Drawing.Point(305, 392);
            this.lblBrprRaspol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrprRaspol.Name = "lblBrprRaspol";
            this.lblBrprRaspol.Size = new System.Drawing.Size(112, 25);
            this.lblBrprRaspol.TabIndex = 16;
            this.lblBrprRaspol.Text = "[UK/RASP]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Spisak primeraka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Broj primeraka/Raspoloživo:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(27, 20);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(201, 29);
            this.lblNaziv.TabIndex = 11;
            this.lblNaziv.Text = "[NAZIV KNJIGE]";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.Location = new System.Drawing.Point(418, 822);
            this.btnZaduzi.Margin = new System.Windows.Forms.Padding(6);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(226, 42);
            this.btnZaduzi.TabIndex = 20;
            this.btnZaduzi.Text = "Zaduzi";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // lblBrojKnjige
            // 
            this.lblBrojKnjige.AutoSize = true;
            this.lblBrojKnjige.Location = new System.Drawing.Point(41, 829);
            this.lblBrojKnjige.Name = "lblBrojKnjige";
            this.lblBrojKnjige.Size = new System.Drawing.Size(98, 25);
            this.lblBrojKnjige.TabIndex = 21;
            this.lblBrojKnjige.Text = "[KnjigaID]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Opis knjige:";
            // 
            // KnjigaViseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 882);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBrojKnjige);
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.lblImePrezimeAutora);
            this.Controls.Add(this.dgvSpisakPrimeraka);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblBrprRaspol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KnjigaViseInfoForm";
            this.Text = "Više informacija o knjizi";
            this.Load += new System.EventHandler(this.KnjigaViseInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezimeAutora;
        private System.Windows.Forms.DataGridView dgvSpisakPrimeraka;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblBrprRaspol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Label lblBrojKnjige;
        private System.Windows.Forms.Label label2;
    }
}