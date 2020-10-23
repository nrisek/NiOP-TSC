namespace WindowsFormsApp11
{
    partial class StvaranjeRacuna
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
            this.tbNazivRacuna = new System.Windows.Forms.TextBox();
            this.tbIDKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStvoriRacun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // tbNazivRacuna
            // 
            this.tbNazivRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazivRacuna.Location = new System.Drawing.Point(164, 33);
            this.tbNazivRacuna.Name = "tbNazivRacuna";
            this.tbNazivRacuna.Size = new System.Drawing.Size(159, 31);
            this.tbNazivRacuna.TabIndex = 1;
            // 
            // tbIDKorisnika
            // 
            this.tbIDKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIDKorisnika.Location = new System.Drawing.Point(164, 83);
            this.tbIDKorisnika.Name = "tbIDKorisnika";
            this.tbIDKorisnika.Size = new System.Drawing.Size(159, 31);
            this.tbIDKorisnika.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID korisnika";
            // 
            // btnStvoriRacun
            // 
            this.btnStvoriRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStvoriRacun.Location = new System.Drawing.Point(117, 144);
            this.btnStvoriRacun.Name = "btnStvoriRacun";
            this.btnStvoriRacun.Size = new System.Drawing.Size(138, 44);
            this.btnStvoriRacun.TabIndex = 4;
            this.btnStvoriRacun.Text = "STVORI";
            this.btnStvoriRacun.UseVisualStyleBackColor = true;
            this.btnStvoriRacun.Click += new System.EventHandler(this.btnStvoriRacun_Click);
            // 
            // StvaranjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 220);
            this.Controls.Add(this.btnStvoriRacun);
            this.Controls.Add(this.tbIDKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNazivRacuna);
            this.Controls.Add(this.label1);
            this.Name = "StvaranjeRacuna";
            this.Text = "StvaranjeRacuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazivRacuna;
        private System.Windows.Forms.TextBox tbIDKorisnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStvoriRacun;
    }
}