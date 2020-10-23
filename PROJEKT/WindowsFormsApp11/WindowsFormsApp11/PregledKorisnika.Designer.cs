namespace WindowsFormsApp11
{
    partial class PregledKorisnika
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
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.Location = new System.Drawing.Point(14, 10);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(238, 498);
            this.lbKorisnici.TabIndex = 0;
            // 
            // PregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 518);
            this.Controls.Add(this.lbKorisnici);
            this.Name = "PregledKorisnika";
            this.Text = "PregledKorisnika";
            this.Load += new System.EventHandler(this.PregledKorisnika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKorisnici;
    }
}