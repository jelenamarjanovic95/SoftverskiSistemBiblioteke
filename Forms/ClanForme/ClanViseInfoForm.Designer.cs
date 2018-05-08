namespace Forms
{
    partial class ClanViseInfoForm
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblBrojTel = new System.Windows.Forms.Label();
            this.dgvZaduzenja = new System.Windows.Forms.DataGridView();
            this.lblClanskiBroj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.Location = new System.Drawing.Point(190, 12);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(236, 31);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "[IME I PREZIME]";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj telefona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spisak zaduženja:";
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(470, 800);
            this.btnRazduzi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(246, 44);
            this.btnRazduzi.TabIndex = 6;
            this.btnRazduzi.Text = "Razduzi";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            this.btnRazduzi.Click += new System.EventHandler(this.btnRazduzi_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(208, 152);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(150, 25);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "[Adresa clana]";
            // 
            // lblBrojTel
            // 
            this.lblBrojTel.AutoSize = true;
            this.lblBrojTel.Location = new System.Drawing.Point(208, 200);
            this.lblBrojTel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrojTel.Name = "lblBrojTel";
            this.lblBrojTel.Size = new System.Drawing.Size(203, 25);
            this.lblBrojTel.TabIndex = 8;
            this.lblBrojTel.Text = "[Broj telefona clana]";
            // 
            // dgvZaduzenja
            // 
            this.dgvZaduzenja.AllowUserToAddRows = false;
            this.dgvZaduzenja.AllowUserToDeleteRows = false;
            this.dgvZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenja.Location = new System.Drawing.Point(30, 319);
            this.dgvZaduzenja.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvZaduzenja.Name = "dgvZaduzenja";
            this.dgvZaduzenja.ReadOnly = true;
            this.dgvZaduzenja.Size = new System.Drawing.Size(686, 450);
            this.dgvZaduzenja.TabIndex = 9;
            this.dgvZaduzenja.SelectionChanged += new System.EventHandler(this.dgvZaduzenja_SelectionChanged);
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(276, 67);
            this.lblClanskiBroj.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(137, 25);
            this.lblClanskiBroj.TabIndex = 10;
            this.lblClanskiBroj.Text = "[Clanski broj]";
            // 
            // ClanViseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 867);
            this.Controls.Add(this.lblClanskiBroj);
            this.Controls.Add(this.dgvZaduzenja);
            this.Controls.Add(this.lblBrojTel);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImePrezime);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClanViseInfoForm";
            this.Text = "Više informacija o članu";
            this.Load += new System.EventHandler(this.ViseInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblBrojTel;
        private System.Windows.Forms.DataGridView dgvZaduzenja;
        private System.Windows.Forms.Label lblClanskiBroj;
    }
}