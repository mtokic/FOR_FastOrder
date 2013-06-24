namespace Kreiranje_narudžbe
{
    partial class frmPovratnaPoruka
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
            this.btnPošaljiPoruku = new System.Windows.Forms.Button();
            this.txtPovratnaPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPošaljiPoruku
            // 
            this.btnPošaljiPoruku.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPošaljiPoruku.Location = new System.Drawing.Point(143, 212);
            this.btnPošaljiPoruku.Name = "btnPošaljiPoruku";
            this.btnPošaljiPoruku.Size = new System.Drawing.Size(129, 37);
            this.btnPošaljiPoruku.TabIndex = 0;
            this.btnPošaljiPoruku.Text = "Pošalji poruku";
            this.btnPošaljiPoruku.UseVisualStyleBackColor = true;
            this.btnPošaljiPoruku.Click += new System.EventHandler(this.btnPošaljiPoruku_Click);
            // 
            // txtPovratnaPoruka
            // 
            this.txtPovratnaPoruka.Location = new System.Drawing.Point(12, 12);
            this.txtPovratnaPoruka.Multiline = true;
            this.txtPovratnaPoruka.Name = "txtPovratnaPoruka";
            this.txtPovratnaPoruka.Size = new System.Drawing.Size(260, 194);
            this.txtPovratnaPoruka.TabIndex = 1;
            // 
            // frmPovratnaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPovratnaPoruka);
            this.Controls.Add(this.btnPošaljiPoruku);
            this.Name = "frmPovratnaPoruka";
            this.Text = "Povratna poruka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPošaljiPoruku;
        private System.Windows.Forms.TextBox txtPovratnaPoruka;
    }
}