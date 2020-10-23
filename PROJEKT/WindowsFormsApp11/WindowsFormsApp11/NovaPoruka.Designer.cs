namespace WindowsFormsApp11
{
    partial class NovaPoruka
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
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.btnSalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sadržaj poruke: ";
            // 
            // tbTekst
            // 
            this.tbTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTekst.Location = new System.Drawing.Point(24, 58);
            this.tbTekst.Multiline = true;
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(496, 168);
            this.tbTekst.TabIndex = 1;
            // 
            // btnSalji
            // 
            this.btnSalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalji.Location = new System.Drawing.Point(202, 250);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(128, 57);
            this.btnSalji.TabIndex = 2;
            this.btnSalji.Text = "Šalji";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // NovaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 322);
            this.Controls.Add(this.btnSalji);
            this.Controls.Add(this.tbTekst);
            this.Controls.Add(this.label1);
            this.Name = "NovaPoruka";
            this.Text = "NovaPoruka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.Button btnSalji;
    }
}