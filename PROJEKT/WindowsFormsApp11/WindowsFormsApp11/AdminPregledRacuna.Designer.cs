namespace WindowsFormsApp11
{
    partial class AdminPregledRacuna
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
            this.lbPregledRacuna = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPregledRacuna
            // 
            this.lbPregledRacuna.FormattingEnabled = true;
            this.lbPregledRacuna.Location = new System.Drawing.Point(12, 14);
            this.lbPregledRacuna.Name = "lbPregledRacuna";
            this.lbPregledRacuna.ScrollAlwaysVisible = true;
            this.lbPregledRacuna.Size = new System.Drawing.Size(322, 420);
            this.lbPregledRacuna.TabIndex = 0;
            // 
            // AdminPregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.lbPregledRacuna);
            this.Name = "AdminPregledRacuna";
            this.Text = "AdminPregledRacuna";
            this.Load += new System.EventHandler(this.AdminPregledRacuna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPregledRacuna;
    }
}