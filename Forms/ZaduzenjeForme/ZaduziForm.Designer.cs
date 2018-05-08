namespace Forms
{
    partial class ZaduziForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBrojKnjige = new System.Windows.Forms.TextBox();
            this.txtBrojPrimerka = new System.Windows.Forms.TextBox();
            this.txtClanskiBroj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj primerka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj knjige:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zaduži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPoruka);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBrojKnjige);
            this.groupBox1.Controls.Add(this.txtBrojPrimerka);
            this.groupBox1.Controls.Add(this.txtClanskiBroj);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(375, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo zaduženje";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(19, 202);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pronađi primerak knjige";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pronađi člana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBrojKnjige
            // 
            this.txtBrojKnjige.Location = new System.Drawing.Point(105, 151);
            this.txtBrojKnjige.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojKnjige.Name = "txtBrojKnjige";
            this.txtBrojKnjige.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKnjige.TabIndex = 7;
            // 
            // txtBrojPrimerka
            // 
            this.txtBrojPrimerka.Location = new System.Drawing.Point(105, 96);
            this.txtBrojPrimerka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojPrimerka.Name = "txtBrojPrimerka";
            this.txtBrojPrimerka.Size = new System.Drawing.Size(100, 20);
            this.txtBrojPrimerka.TabIndex = 6;
            // 
            // txtClanskiBroj
            // 
            this.txtClanskiBroj.Location = new System.Drawing.Point(105, 40);
            this.txtClanskiBroj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClanskiBroj.Name = "txtClanskiBroj";
            this.txtClanskiBroj.Size = new System.Drawing.Size(100, 20);
            this.txtClanskiBroj.TabIndex = 5;
            // 
            // ZaduziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 334);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ZaduziForm";
            this.Text = "Kreiraj zaduženje";
            this.Load += new System.EventHandler(this.ZaduziForm_Load);
            this.Click += new System.EventHandler(this.ZaduziForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrojKnjige;
        private System.Windows.Forms.TextBox txtBrojPrimerka;
        private System.Windows.Forms.TextBox txtClanskiBroj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPoruka;
    }
}