namespace Forms
{
    partial class RazduziForm
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
            this.btnPronadjiDatum = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtBrojKnjige = new System.Windows.Forms.TextBox();
            this.txtBrojPrimerka = new System.Windows.Forms.TextBox();
            this.txtClanskiBroj = new System.Windows.Forms.TextBox();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPronadjiDatum);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.btnPretraga);
            this.groupBox1.Controls.Add(this.txtBrojKnjige);
            this.groupBox1.Controls.Add(this.txtBrojPrimerka);
            this.groupBox1.Controls.Add(this.txtClanskiBroj);
            this.groupBox1.Controls.Add(this.btnRazduzi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(375, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmeni zaduženje";
            // 
            // btnPronadjiDatum
            // 
            this.btnPronadjiDatum.Location = new System.Drawing.Point(230, 86);
            this.btnPronadjiDatum.Margin = new System.Windows.Forms.Padding(2);
            this.btnPronadjiDatum.Name = "btnPronadjiDatum";
            this.btnPronadjiDatum.Size = new System.Drawing.Size(122, 71);
            this.btnPronadjiDatum.TabIndex = 13;
            this.btnPronadjiDatum.Text = "Pronadji datum zaduzenja";
            this.btnPronadjiDatum.UseVisualStyleBackColor = true;
            this.btnPronadjiDatum.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(105, 185);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum zaduzenja:";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(19, 223);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 10;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(22, 262);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(122, 33);
            this.btnPretraga.TabIndex = 9;
            this.btnPretraga.Text = "Pretrazi zaduzenja";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // txtBrojKnjige
            // 
            this.txtBrojKnjige.Location = new System.Drawing.Point(105, 137);
            this.txtBrojKnjige.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojKnjige.Name = "txtBrojKnjige";
            this.txtBrojKnjige.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKnjige.TabIndex = 7;
            // 
            // txtBrojPrimerka
            // 
            this.txtBrojPrimerka.Location = new System.Drawing.Point(105, 86);
            this.txtBrojPrimerka.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojPrimerka.Name = "txtBrojPrimerka";
            this.txtBrojPrimerka.Size = new System.Drawing.Size(100, 20);
            this.txtBrojPrimerka.TabIndex = 6;
            // 
            // txtClanskiBroj
            // 
            this.txtClanskiBroj.Location = new System.Drawing.Point(105, 40);
            this.txtClanskiBroj.Margin = new System.Windows.Forms.Padding(2);
            this.txtClanskiBroj.Name = "txtClanskiBroj";
            this.txtClanskiBroj.Size = new System.Drawing.Size(100, 20);
            this.txtClanskiBroj.TabIndex = 5;
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(230, 262);
            this.btnRazduzi.Margin = new System.Windows.Forms.Padding(2);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(122, 33);
            this.btnRazduzi.TabIndex = 4;
            this.btnRazduzi.Text = "Razduži";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            this.btnRazduzi.Click += new System.EventHandler(this.btnRazduzi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj primerka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Članski broj:";
            // 
            // RazduziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 336);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RazduziForm";
            this.Text = "Razduzi";
            this.Load += new System.EventHandler(this.RazduziForm_Load);
            this.Click += new System.EventHandler(this.RazduziForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtBrojKnjige;
        private System.Windows.Forms.TextBox txtBrojPrimerka;
        private System.Windows.Forms.TextBox txtClanskiBroj;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPronadjiDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label4;
    }
}