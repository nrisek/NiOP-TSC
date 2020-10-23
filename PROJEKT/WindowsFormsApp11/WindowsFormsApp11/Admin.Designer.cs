namespace WindowsFormsApp11
{
    partial class Admin
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
            this.tbPrijavljeni = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.označiSPlaćenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKonfiguracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNatragNaPrijavu = new System.Windows.Forms.Button();
            this.porukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPorukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrijavljeni
            // 
            this.tbPrijavljeni.Location = new System.Drawing.Point(12, 418);
            this.tbPrijavljeni.Name = "tbPrijavljeni";
            this.tbPrijavljeni.Size = new System.Drawing.Size(196, 20);
            this.tbPrijavljeni.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.racuniToolStripMenuItem,
            this.konfiguracijeToolStripMenuItem,
            this.porukeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.brisanjeToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            this.brisanjeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeToolStripMenuItem_Click);
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stvoriToolStripMenuItem,
            this.pregledRačunaToolStripMenuItem,
            this.označiSPlaćenoToolStripMenuItem});
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.racuniToolStripMenuItem.Text = "Racuni";
            // 
            // stvoriToolStripMenuItem
            // 
            this.stvoriToolStripMenuItem.Name = "stvoriToolStripMenuItem";
            this.stvoriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.stvoriToolStripMenuItem.Text = "Stvori";
            this.stvoriToolStripMenuItem.Click += new System.EventHandler(this.stvoriToolStripMenuItem_Click);
            // 
            // pregledRačunaToolStripMenuItem
            // 
            this.pregledRačunaToolStripMenuItem.Name = "pregledRačunaToolStripMenuItem";
            this.pregledRačunaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledRačunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledRačunaToolStripMenuItem_Click);
            // 
            // označiSPlaćenoToolStripMenuItem
            // 
            this.označiSPlaćenoToolStripMenuItem.Name = "označiSPlaćenoToolStripMenuItem";
            this.označiSPlaćenoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.označiSPlaćenoToolStripMenuItem.Text = "Označi s plaćeno";
            this.označiSPlaćenoToolStripMenuItem.Click += new System.EventHandler(this.označiSPlaćenoToolStripMenuItem_Click);
            // 
            // konfiguracijeToolStripMenuItem
            // 
            this.konfiguracijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.dodajKonfiguracijuToolStripMenuItem});
            this.konfiguracijeToolStripMenuItem.Name = "konfiguracijeToolStripMenuItem";
            this.konfiguracijeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.konfiguracijeToolStripMenuItem.Text = "Konfiguracije";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // dodajKonfiguracijuToolStripMenuItem
            // 
            this.dodajKonfiguracijuToolStripMenuItem.Name = "dodajKonfiguracijuToolStripMenuItem";
            this.dodajKonfiguracijuToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dodajKonfiguracijuToolStripMenuItem.Text = "Dodaj konfiguraciju";
            // 
            // btnNatragNaPrijavu
            // 
            this.btnNatragNaPrijavu.Location = new System.Drawing.Point(713, 415);
            this.btnNatragNaPrijavu.Name = "btnNatragNaPrijavu";
            this.btnNatragNaPrijavu.Size = new System.Drawing.Size(75, 23);
            this.btnNatragNaPrijavu.TabIndex = 5;
            this.btnNatragNaPrijavu.Text = "ODJAVA";
            this.btnNatragNaPrijavu.UseVisualStyleBackColor = true;
            this.btnNatragNaPrijavu.Click += new System.EventHandler(this.btnNatragNaPrijavu_Click);
            // 
            // porukeToolStripMenuItem
            // 
            this.porukeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPorukaToolStripMenuItem,
            this.inboksToolStripMenuItem});
            this.porukeToolStripMenuItem.Name = "porukeToolStripMenuItem";
            this.porukeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.porukeToolStripMenuItem.Text = "Poruke";
            // 
            // novaPorukaToolStripMenuItem
            // 
            this.novaPorukaToolStripMenuItem.Name = "novaPorukaToolStripMenuItem";
            this.novaPorukaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaPorukaToolStripMenuItem.Text = "Nova poruka";
            this.novaPorukaToolStripMenuItem.Click += new System.EventHandler(this.novaPorukaToolStripMenuItem_Click);
            // 
            // inboksToolStripMenuItem
            // 
            this.inboksToolStripMenuItem.Name = "inboksToolStripMenuItem";
            this.inboksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inboksToolStripMenuItem.Text = "Inboks";
            this.inboksToolStripMenuItem.Click += new System.EventHandler(this.inboksToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatragNaPrijavu);
            this.Controls.Add(this.tbPrijavljeni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPrijavljeni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stvoriToolStripMenuItem;
        private System.Windows.Forms.Button btnNatragNaPrijavu;
        private System.Windows.Forms.ToolStripMenuItem pregledRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem označiSPlaćenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajKonfiguracijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porukeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPorukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboksToolStripMenuItem;
    }
}

