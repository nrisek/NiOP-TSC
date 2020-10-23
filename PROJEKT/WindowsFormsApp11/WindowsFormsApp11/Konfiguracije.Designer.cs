namespace WindowsFormsApp11
{
    partial class Konfiguracije
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
            this.lbKonfiguracije = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbKonfiguracije
            // 
            this.lbKonfiguracije.FormattingEnabled = true;
            this.lbKonfiguracije.Location = new System.Drawing.Point(12, 12);
            this.lbKonfiguracije.Name = "lbKonfiguracije";
            this.lbKonfiguracije.Size = new System.Drawing.Size(373, 433);
            this.lbKonfiguracije.TabIndex = 0;
            // 
            // Konfiguracije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKonfiguracije);
            this.Name = "Konfiguracije";
            this.Text = "Konfiguracije";
            this.Load += new System.EventHandler(this.Konfiguracije_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKonfiguracije;
    }
}