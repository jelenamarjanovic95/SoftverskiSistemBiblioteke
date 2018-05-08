namespace Forms
{
    partial class MainForm
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
            this.lblBibl = new System.Windows.Forms.Label();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.meni1 = new Forms.Meni();
            this.btnKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBibl
            // 
            this.lblBibl.AutoSize = true;
            this.lblBibl.Location = new System.Drawing.Point(503, 30);
            this.lblBibl.Name = "lblBibl";
            this.lblBibl.Size = new System.Drawing.Size(110, 13);
            this.lblBibl.TabIndex = 1;
            this.lblBibl.Text = "[Ulogovan bibliotekar]";
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.Location = new System.Drawing.Point(87, 101);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(211, 23);
            this.btnZaduzi.TabIndex = 2;
            this.btnZaduzi.Text = "Zaduži knjigu";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(348, 101);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(211, 23);
            this.btnRazduzi.TabIndex = 3;
            this.btnRazduzi.Text = "Razduži knjigu";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            this.btnRazduzi.Click += new System.EventHandler(this.btnRazduzi_Click);
            // 
            // meni1
            // 
            this.meni1.Location = new System.Drawing.Point(2, 1);
            this.meni1.Margin = new System.Windows.Forms.Padding(6);
            this.meni1.Name = "meni1";
            this.meni1.Size = new System.Drawing.Size(642, 26);
            this.meni1.TabIndex = 4;
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(506, 1);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(138, 23);
            this.btnKraj.TabIndex = 5;
            this.btnKraj.Text = "Kraj rada";
            this.btnKraj.UseVisualStyleBackColor = true;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 167);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.meni1);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.lblBibl);
            this.Name = "MainForm";
            this.Text = "Biblioteka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBibl;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Button btnRazduzi;
        private Meni meni1;
        private System.Windows.Forms.Button btnKraj;
    }
}