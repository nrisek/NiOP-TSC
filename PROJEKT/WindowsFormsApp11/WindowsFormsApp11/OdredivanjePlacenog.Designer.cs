namespace WindowsFormsApp11
{
    partial class OdredivanjePlacenog
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
            this.tbIDRacuna = new System.Windows.Forms.TextBox();
            this.btnPlaceno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID računa";
            // 
            // tbIDRacuna
            // 
            this.tbIDRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIDRacuna.Location = new System.Drawing.Point(157, 33);
            this.tbIDRacuna.Name = "tbIDRacuna";
            this.tbIDRacuna.Size = new System.Drawing.Size(118, 31);
            this.tbIDRacuna.TabIndex = 1;
            // 
            // btnPlaceno
            // 
            this.btnPlaceno.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPlaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlaceno.Location = new System.Drawing.Point(116, 86);
            this.btnPlaceno.Name = "btnPlaceno";
            this.btnPlaceno.Size = new System.Drawing.Size(109, 36);
            this.btnPlaceno.TabIndex = 2;
            this.btnPlaceno.Text = "Plaćeno";
            this.btnPlaceno.UseVisualStyleBackColor = false;
            this.btnPlaceno.Click += new System.EventHandler(this.btnPlaceno_Click);
            // 
            // OdredivanjePlacenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 157);
            this.Controls.Add(this.btnPlaceno);
            this.Controls.Add(this.tbIDRacuna);
            this.Controls.Add(this.label1);
            this.Name = "OdredivanjePlacenog";
            this.Text = "OdredivanjePlacenog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDRacuna;
        private System.Windows.Forms.Button btnPlaceno;
    }
}