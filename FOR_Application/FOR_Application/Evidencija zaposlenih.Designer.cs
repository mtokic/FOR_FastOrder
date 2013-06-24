namespace FOR_Application
{
    partial class frmEvidencija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvidencija));
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblRadnoMjesto = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.dgvEvidencija = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(105, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(105, 41);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(141, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.Location = new System.Drawing.Point(105, 70);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(141, 20);
            this.txtRadnoMjesto.TabIndex = 3;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(42, 93);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(52, 17);
            this.lblAdresa.TabIndex = 14;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblRadnoMjesto
            // 
            this.lblRadnoMjesto.AutoSize = true;
            this.lblRadnoMjesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRadnoMjesto.Location = new System.Drawing.Point(7, 67);
            this.lblRadnoMjesto.Name = "lblRadnoMjesto";
            this.lblRadnoMjesto.Size = new System.Drawing.Size(92, 17);
            this.lblRadnoMjesto.TabIndex = 13;
            this.lblRadnoMjesto.Text = "Radno mjesto:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(42, 38);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(57, 17);
            this.lblPrezime.TabIndex = 12;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(67, 12);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 17);
            this.lblIme.TabIndex = 11;
            this.lblIme.Text = "Ime:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(105, 96);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(172, 20);
            this.txtAdresa.TabIndex = 15;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(294, 15);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(136, 46);
            this.btnDodajZaposlenika.TabIndex = 16;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // dgvEvidencija
            // 
            this.dgvEvidencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencija.Location = new System.Drawing.Point(12, 141);
            this.dgvEvidencija.Name = "dgvEvidencija";
            this.dgvEvidencija.Size = new System.Drawing.Size(418, 249);
            this.dgvEvidencija.TabIndex = 17;
            // 
            // frmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 402);
            this.Controls.Add(this.dgvEvidencija);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblRadnoMjesto);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvidencija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija zaposlenih";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblRadnoMjesto;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.DataGridView dgvEvidencija;
    }
}