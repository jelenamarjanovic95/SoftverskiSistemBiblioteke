namespace Forms.ZaduzenjeForme
{
    partial class PrimerciKnjigeForm
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
            this.lblNazivKnjige = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSpisakPrimeraka = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivKnjige
            // 
            this.lblNazivKnjige.AutoSize = true;
            this.lblNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKnjige.Location = new System.Drawing.Point(9, 12);
            this.lblNazivKnjige.Name = "lblNazivKnjige";
            this.lblNazivKnjige.Size = new System.Drawing.Size(92, 17);
            this.lblNazivKnjige.TabIndex = 3;
            this.lblNazivKnjige.Text = "[Naziv knjige]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdaberi);
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvSpisakPrimeraka);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primerci";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(211, 261);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(164, 38);
            this.btnOdaberi.TabIndex = 22;
            this.btnOdaberi.Text = "Odaberi primerak";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(21, 261);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(157, 38);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Spisak primeraka:";
            // 
            // dgvSpisakPrimeraka
            // 
            this.dgvSpisakPrimeraka.AllowUserToAddRows = false;
            this.dgvSpisakPrimeraka.AllowUserToDeleteRows = false;
            this.dgvSpisakPrimeraka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakPrimeraka.Location = new System.Drawing.Point(18, 44);
            this.dgvSpisakPrimeraka.Name = "dgvSpisakPrimeraka";
            this.dgvSpisakPrimeraka.ReadOnly = true;
            this.dgvSpisakPrimeraka.Size = new System.Drawing.Size(357, 211);
            this.dgvSpisakPrimeraka.TabIndex = 19;
            this.dgvSpisakPrimeraka.SelectionChanged += new System.EventHandler(this.dgvSpisakPrimeraka_SelectionChanged);
            // 
            // PrimerciKnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 376);
            this.Controls.Add(this.lblNazivKnjige);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrimerciKnjigeForm";
            this.Text = "PrimerciKnjigeForm";
            this.Load += new System.EventHandler(this.PrimerciKnjigeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakPrimeraka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSpisakPrimeraka;
    }
}