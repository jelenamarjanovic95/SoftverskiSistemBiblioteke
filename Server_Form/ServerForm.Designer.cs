namespace Server_Form
{
    partial class ServerForm
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.dgvBibliotekari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiskonektuj = new System.Windows.Forms.Button();
            this.lblStanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotekari)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(33, 25);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(120, 43);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(412, 25);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(120, 43);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnUgasi_Click);
            // 
            // dgvBibliotekari
            // 
            this.dgvBibliotekari.AllowUserToAddRows = false;
            this.dgvBibliotekari.AllowUserToDeleteRows = false;
            this.dgvBibliotekari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotekari.Location = new System.Drawing.Point(33, 177);
            this.dgvBibliotekari.Name = "dgvBibliotekari";
            this.dgvBibliotekari.ReadOnly = true;
            this.dgvBibliotekari.Size = new System.Drawing.Size(409, 236);
            this.dgvBibliotekari.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulogovani bibliotekari:";
            // 
            // btnDiskonektuj
            // 
            this.btnDiskonektuj.Location = new System.Drawing.Point(452, 360);
            this.btnDiskonektuj.Name = "btnDiskonektuj";
            this.btnDiskonektuj.Size = new System.Drawing.Size(120, 53);
            this.btnDiskonektuj.TabIndex = 4;
            this.btnDiskonektuj.Text = "Diskonektuj bibliotekara";
            this.btnDiskonektuj.UseVisualStyleBackColor = true;
            this.btnDiskonektuj.Click += new System.EventHandler(this.btnDiskonektuj_Click);
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanje.Location = new System.Drawing.Point(226, 38);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(0, 15);
            this.lblStanje.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 95);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.btnDiskonektuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBibliotekari);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "ServerForm";
            this.Text = "Server forma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotekari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.DataGridView dgvBibliotekari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiskonektuj;
        private System.Windows.Forms.Label lblStanje;
    }
}

