namespace Forms
{
    partial class OdaberiAutora
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
            this.btnResetujPretragu = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvSpisakAutora = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOdabraniAutori = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakAutora)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetujPretragu);
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.dgvSpisakAutora);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberi autora";
            // 
            // btnResetujPretragu
            // 
            this.btnResetujPretragu.Location = new System.Drawing.Point(238, 26);
            this.btnResetujPretragu.Name = "btnResetujPretragu";
            this.btnResetujPretragu.Size = new System.Drawing.Size(48, 23);
            this.btnResetujPretragu.TabIndex = 2;
            this.btnResetujPretragu.Text = "X";
            this.btnResetujPretragu.UseVisualStyleBackColor = true;
            this.btnResetujPretragu.Click += new System.EventHandler(this.btnResetujPretragu_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 29);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 20);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvSpisakAutora
            // 
            this.dgvSpisakAutora.AllowUserToAddRows = false;
            this.dgvSpisakAutora.AllowUserToDeleteRows = false;
            this.dgvSpisakAutora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakAutora.Location = new System.Drawing.Point(6, 60);
            this.dgvSpisakAutora.Name = "dgvSpisakAutora";
            this.dgvSpisakAutora.ReadOnly = true;
            this.dgvSpisakAutora.Size = new System.Drawing.Size(280, 357);
            this.dgvSpisakAutora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOdabraniAutori);
            this.groupBox2.Location = new System.Drawing.Point(485, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabrani autori";
            // 
            // dgvOdabraniAutori
            // 
            this.dgvOdabraniAutori.AllowUserToAddRows = false;
            this.dgvOdabraniAutori.AllowUserToDeleteRows = false;
            this.dgvOdabraniAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniAutori.Location = new System.Drawing.Point(14, 33);
            this.dgvOdabraniAutori.Name = "dgvOdabraniAutori";
            this.dgvOdabraniAutori.ReadOnly = true;
            this.dgvOdabraniAutori.Size = new System.Drawing.Size(280, 384);
            this.dgvOdabraniAutori.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(359, 99);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(101, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(359, 144);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(101, 23);
            this.btnVrati.TabIndex = 3;
            this.btnVrati.Text = "<-";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(359, 302);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(101, 23);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj izbor";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // OdaberiAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 459);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OdaberiAutora";
            this.Text = "OdaberiAutora";
            this.Load += new System.EventHandler(this.OdaberiAutora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakAutora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.DataGridView dgvSpisakAutora;
        private System.Windows.Forms.DataGridView dgvOdabraniAutori;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnResetujPretragu;
    }
}