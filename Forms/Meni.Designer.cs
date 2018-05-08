namespace Forms
{
    partial class Meni
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUnosClana = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUnosKnjige = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUnosZaduzenja = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIzmenaClana = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIzmenaKnjige = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIzmenaZaduzenja = new System.Windows.Forms.ToolStripMenuItem();
            this.lala = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPretragaClanova = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPretragaKnjiga = new System.Windows.Forms.ToolStripMenuItem();
            this.lalala = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBrisanjeClana = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBrisanjeKnjige = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeToolStripMenuItem,
            this.izmenaToolStripMenuItem,
            this.lala,
            this.lalala});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodavanjeToolStripMenuItem
            // 
            this.dodavanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUnosClana,
            this.tsUnosKnjige,
            this.tsUnosZaduzenja});
            this.dodavanjeToolStripMenuItem.Name = "dodavanjeToolStripMenuItem";
            this.dodavanjeToolStripMenuItem.Size = new System.Drawing.Size(81, 38);
            this.dodavanjeToolStripMenuItem.Text = "Unos";
            // 
            // tsUnosClana
            // 
            this.tsUnosClana.Name = "tsUnosClana";
            this.tsUnosClana.Size = new System.Drawing.Size(224, 38);
            this.tsUnosClana.Text = "Člana";
            this.tsUnosClana.Click += new System.EventHandler(this.članaToolStripMenuItem_Click);
            // 
            // tsUnosKnjige
            // 
            this.tsUnosKnjige.Name = "tsUnosKnjige";
            this.tsUnosKnjige.Size = new System.Drawing.Size(224, 38);
            this.tsUnosKnjige.Text = "Knjige";
            this.tsUnosKnjige.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // tsUnosZaduzenja
            // 
            this.tsUnosZaduzenja.Name = "tsUnosZaduzenja";
            this.tsUnosZaduzenja.Size = new System.Drawing.Size(324, 38);
            this.tsUnosZaduzenja.Text = "Zaduženja";
            this.tsUnosZaduzenja.Click += new System.EventHandler(this.tsUnosZaduzenja_Click);
            // 
            // izmenaToolStripMenuItem
            // 
            this.izmenaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIzmenaClana,
            this.tsIzmenaKnjige,
            this.tsIzmenaZaduzenja});
            this.izmenaToolStripMenuItem.Name = "izmenaToolStripMenuItem";
            this.izmenaToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.izmenaToolStripMenuItem.Text = "Izmena";
            // 
            // tsIzmenaClana
            // 
            this.tsIzmenaClana.Name = "tsIzmenaClana";
            this.tsIzmenaClana.Size = new System.Drawing.Size(324, 38);
            this.tsIzmenaClana.Text = "Člana";
            this.tsIzmenaClana.Click += new System.EventHandler(this.tsIzmenaClana_Click);
            // 
            // tsIzmenaKnjige
            // 
            this.tsIzmenaKnjige.Name = "tsIzmenaKnjige";
            this.tsIzmenaKnjige.Size = new System.Drawing.Size(324, 38);
            this.tsIzmenaKnjige.Text = "Knjige";
            this.tsIzmenaKnjige.Click += new System.EventHandler(this.tsIzmenaKnjige_Click);
            // 
            // tsIzmenaZaduzenja
            // 
            this.tsIzmenaZaduzenja.Name = "tsIzmenaZaduzenja";
            this.tsIzmenaZaduzenja.Size = new System.Drawing.Size(324, 38);
            this.tsIzmenaZaduzenja.Text = "Zaduženja";
            this.tsIzmenaZaduzenja.Click += new System.EventHandler(this.tsIzmenaZaduzenja_Click);
            // 
            // lala
            // 
            this.lala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPretragaClanova,
            this.tsPretragaKnjiga});
            this.lala.Name = "lala";
            this.lala.Size = new System.Drawing.Size(115, 38);
            this.lala.Text = "Pretraga";
            // 
            // tsPretragaClanova
            // 
            this.tsPretragaClanova.Name = "tsPretragaClanova";
            this.tsPretragaClanova.Size = new System.Drawing.Size(199, 38);
            this.tsPretragaClanova.Text = "Članova";
            this.tsPretragaClanova.Click += new System.EventHandler(this.članovaToolStripMenuItem_Click);
            // 
            // tsPretragaKnjiga
            // 
            this.tsPretragaKnjiga.Name = "tsPretragaKnjiga";
            this.tsPretragaKnjiga.Size = new System.Drawing.Size(199, 38);
            this.tsPretragaKnjiga.Text = "Knjiga";
            this.tsPretragaKnjiga.Click += new System.EventHandler(this.knjigaToolStripMenuItem_Click);
            // 
            // lalala
            // 
            this.lalala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBrisanjeClana,
            this.tsBrisanjeKnjige});
            this.lalala.Name = "lalala";
            this.lalala.Size = new System.Drawing.Size(110, 38);
            this.lalala.Text = "Brisanje";
            // 
            // tsBrisanjeClana
            // 
            this.tsBrisanjeClana.Name = "tsBrisanjeClana";
            this.tsBrisanjeClana.Size = new System.Drawing.Size(324, 38);
            this.tsBrisanjeClana.Text = "Člana";
            this.tsBrisanjeClana.Click += new System.EventHandler(this.tsBrisanjeClana_Click);
            // 
            // tsBrisanjeKnjige
            // 
            this.tsBrisanjeKnjige.Name = "tsBrisanjeKnjige";
            this.tsBrisanjeKnjige.Size = new System.Drawing.Size(324, 38);
            this.tsBrisanjeKnjige.Text = "Knjige";
            this.tsBrisanjeKnjige.Click += new System.EventHandler(this.tsBrisanjeKnjige_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Meni";
            this.Size = new System.Drawing.Size(1280, 50);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsUnosClana;
        private System.Windows.Forms.ToolStripMenuItem tsUnosKnjige;
        private System.Windows.Forms.ToolStripMenuItem tsUnosZaduzenja;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsIzmenaClana;
        private System.Windows.Forms.ToolStripMenuItem tsIzmenaKnjige;
        private System.Windows.Forms.ToolStripMenuItem tsIzmenaZaduzenja;
        private System.Windows.Forms.ToolStripMenuItem lala;
        private System.Windows.Forms.ToolStripMenuItem tsPretragaClanova;
        private System.Windows.Forms.ToolStripMenuItem tsPretragaKnjiga;
        private System.Windows.Forms.ToolStripMenuItem lalala;
        private System.Windows.Forms.ToolStripMenuItem tsBrisanjeClana;
        private System.Windows.Forms.ToolStripMenuItem tsBrisanjeKnjige;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
