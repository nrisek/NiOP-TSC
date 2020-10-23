namespace WindowsFormsApp11
{
    partial class Korisnik
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
            this.lbPlaceno = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRacuni = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaćenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaPlatitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPorukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPrijavljeni = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNatragNaPrijavu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlaceno
            // 
            this.lbPlaceno.FormattingEnabled = true;
            this.lbPlaceno.Location = new System.Drawing.Point(12, 75);
            this.lbPlaceno.Name = "lbPlaceno";
            this.lbPlaceno.Size = new System.Drawing.Size(125, 95);
            this.lbPlaceno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaćeno:";
            // 
            // lbRacuni
            // 
            this.lbRacuni.FormattingEnabled = true;
            this.lbRacuni.Location = new System.Drawing.Point(169, 75);
            this.lbRacuni.Name = "lbRacuni";
            this.lbRacuni.Size = new System.Drawing.Size(125, 95);
            this.lbRacuni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Za platiti:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniToolStripMenuItem,
            this.porukeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plaćenoToolStripMenuItem,
            this.zaPlatitiToolStripMenuItem});
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.racuniToolStripMenuItem.Text = "Racuni";
            // 
            // plaćenoToolStripMenuItem
            // 
            this.plaćenoToolStripMenuItem.Name = "plaćenoToolStripMenuItem";
            this.plaćenoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.plaćenoToolStripMenuItem.Text = "Plaćeno";
            this.plaćenoToolStripMenuItem.Click += new System.EventHandler(this.plaćenoToolStripMenuItem_Click);
            // 
            // zaPlatitiToolStripMenuItem
            // 
            this.zaPlatitiToolStripMenuItem.Name = "zaPlatitiToolStripMenuItem";
            this.zaPlatitiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zaPlatitiToolStripMenuItem.Text = "Za platiti";
            this.zaPlatitiToolStripMenuItem.Click += new System.EventHandler(this.zaPlatitiToolStripMenuItem_Click);
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
            // tbPrijavljeni
            // 
            this.tbPrijavljeni.Location = new System.Drawing.Point(15, 418);
            this.tbPrijavljeni.Name = "tbPrijavljeni";
            this.tbPrijavljeni.Size = new System.Drawing.Size(182, 20);
            this.tbPrijavljeni.TabIndex = 5;
            // 
            // btnNatragNaPrijavu
            // 
            this.btnNatragNaPrijavu.Location = new System.Drawing.Point(713, 418);
            this.btnNatragNaPrijavu.Name = "btnNatragNaPrijavu";
            this.btnNatragNaPrijavu.Size = new System.Drawing.Size(75, 23);
            this.btnNatragNaPrijavu.TabIndex = 6;
            this.btnNatragNaPrijavu.Text = "ODJAVA";
            this.btnNatragNaPrijavu.UseVisualStyleBackColor = true;
            this.btnNatragNaPrijavu.Click += new System.EventHandler(this.btnNatragNaPrijavu_Click);
            // 
            // Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatragNaPrijavu);
            this.Controls.Add(this.tbPrijavljeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRacuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlaceno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Korisnik";
            this.Text = "KORISNIK";
            this.Load += new System.EventHandler(this.Korisnik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlaceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRacuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plaćenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaPlatitiToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPrijavljeni;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNatragNaPrijavu;
        private System.Windows.Forms.ToolStripMenuItem porukeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPorukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboksToolStripMenuItem;
    }
}