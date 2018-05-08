namespace Forms
{
    partial class IzmeniKnjiguForm
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
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnOdaberiAutore = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtIzdanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAutori);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.btnOdaberiAutore);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.txtIzdanje);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(714, 815);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena knjige";
            // 
            // lblAutori
            // 
            this.lblAutori.AutoSize = true;
            this.lblAutori.Location = new System.Drawing.Point(36, 648);
            this.lblAutori.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(70, 25);
            this.lblAutori.TabIndex = 20;
            this.lblAutori.Text = "label5";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(222, 230);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(458, 349);
            this.txtOpis.TabIndex = 19;
            this.txtOpis.Text = "";
            // 
            // btnOdaberiAutore
            // 
            this.btnOdaberiAutore.Location = new System.Drawing.Point(26, 729);
            this.btnOdaberiAutore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOdaberiAutore.Name = "btnOdaberiAutore";
            this.btnOdaberiAutore.Size = new System.Drawing.Size(264, 44);
            this.btnOdaberiAutore.TabIndex = 18;
            this.btnOdaberiAutore.Text = "Odaberi autore";
            this.btnOdaberiAutore.UseVisualStyleBackColor = true;
            this.btnOdaberiAutore.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(400, 729);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(284, 44);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj promene";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtIzdanje
            // 
            this.txtIzdanje.Location = new System.Drawing.Point(218, 145);
            this.txtIzdanje.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIzdanje.Name = "txtIzdanje";
            this.txtIzdanje.Size = new System.Drawing.Size(156, 31);
            this.txtIzdanje.TabIndex = 15;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(218, 55);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(462, 31);
            this.txtNaziv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Izdanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv:";
            // 
            // IzmeniKnjiguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 862);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "IzmeniKnjiguForm";
            this.Text = "IzmeniKnjiguForm";
            this.Load += new System.EventHandler(this.IzmeniKnjiguForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtIzdanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdaberiAutore;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label lblAutori;
    }
}