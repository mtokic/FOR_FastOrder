namespace FOR_Application
{
    partial class frmModifikacijaArtikala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifikacijaArtikala));
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.txtOpisArtikla = new System.Windows.Forms.TextBox();
            this.txtJedinicaMjere = new System.Windows.Forms.TextBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblJedinicnaCijena = new System.Windows.Forms.Label();
            this.lblOpisArtikla = new System.Windows.Forms.Label();
            this.lblJedinicaMjere = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblpopis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.ForeColor = System.Drawing.Color.Black;
            this.txtNazivArtikla.Location = new System.Drawing.Point(138, 18);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(146, 20);
            this.txtNazivArtikla.TabIndex = 0;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.ForeColor = System.Drawing.Color.Black;
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(138, 46);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(146, 20);
            this.txtJedinicnaCijena.TabIndex = 1;
            // 
            // txtOpisArtikla
            // 
            this.txtOpisArtikla.ForeColor = System.Drawing.Color.Black;
            this.txtOpisArtikla.Location = new System.Drawing.Point(138, 72);
            this.txtOpisArtikla.Name = "txtOpisArtikla";
            this.txtOpisArtikla.Size = new System.Drawing.Size(38, 20);
            this.txtOpisArtikla.TabIndex = 2;
            // 
            // txtJedinicaMjere
            // 
            this.txtJedinicaMjere.ForeColor = System.Drawing.Color.Black;
            this.txtJedinicaMjere.Location = new System.Drawing.Point(138, 133);
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.Size = new System.Drawing.Size(146, 20);
            this.txtJedinicaMjere.TabIndex = 3;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Maroon;
            this.btnDodajArtikl.Location = new System.Drawing.Point(311, 113);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(136, 40);
            this.btnDodajArtikl.TabIndex = 4;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivArtikla.ForeColor = System.Drawing.Color.White;
            this.lblNazivArtikla.Location = new System.Drawing.Point(50, 18);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(82, 17);
            this.lblNazivArtikla.TabIndex = 5;
            this.lblNazivArtikla.Text = "Naziv artikla:";
            // 
            // lblJedinicnaCijena
            // 
            this.lblJedinicnaCijena.AutoSize = true;
            this.lblJedinicnaCijena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJedinicnaCijena.ForeColor = System.Drawing.Color.White;
            this.lblJedinicnaCijena.Location = new System.Drawing.Point(47, 49);
            this.lblJedinicnaCijena.Name = "lblJedinicnaCijena";
            this.lblJedinicnaCijena.Size = new System.Drawing.Size(85, 17);
            this.lblJedinicnaCijena.TabIndex = 6;
            this.lblJedinicnaCijena.Text = "Cijena artikla:";
            // 
            // lblOpisArtikla
            // 
            this.lblOpisArtikla.AutoSize = true;
            this.lblOpisArtikla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisArtikla.ForeColor = System.Drawing.Color.White;
            this.lblOpisArtikla.Location = new System.Drawing.Point(6, 72);
            this.lblOpisArtikla.Name = "lblOpisArtikla";
            this.lblOpisArtikla.Size = new System.Drawing.Size(126, 51);
            this.lblOpisArtikla.TabIndex = 7;
            this.lblOpisArtikla.Text = "Opis: \r\n\r\n(1 - piće / 2 - hrana)";
            this.lblOpisArtikla.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblJedinicaMjere
            // 
            this.lblJedinicaMjere.AutoSize = true;
            this.lblJedinicaMjere.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJedinicaMjere.ForeColor = System.Drawing.Color.White;
            this.lblJedinicaMjere.Location = new System.Drawing.Point(38, 133);
            this.lblJedinicaMjere.Name = "lblJedinicaMjere";
            this.lblJedinicaMjere.Size = new System.Drawing.Size(94, 17);
            this.lblJedinicaMjere.TabIndex = 8;
            this.lblJedinicaMjere.Text = "Jedinica mjere:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 267);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblpopis
            // 
            this.lblpopis.AutoSize = true;
            this.lblpopis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpopis.ForeColor = System.Drawing.Color.White;
            this.lblpopis.Location = new System.Drawing.Point(203, 185);
            this.lblpopis.Name = "lblpopis";
            this.lblpopis.Size = new System.Drawing.Size(81, 17);
            this.lblpopis.TabIndex = 10;
            this.lblpopis.Text = "Baza artikala";
            // 
            // frmModifikacijaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(486, 492);
            this.Controls.Add(this.lblpopis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblJedinicaMjere);
            this.Controls.Add(this.lblOpisArtikla);
            this.Controls.Add(this.lblJedinicnaCijena);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.txtJedinicaMjere);
            this.Controls.Add(this.txtOpisArtikla);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(this.txtNazivArtikla);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifikacijaArtikala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifikacija artikala";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.TextBox txtOpisArtikla;
        private System.Windows.Forms.TextBox txtJedinicaMjere;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label lblJedinicnaCijena;
        private System.Windows.Forms.Label lblOpisArtikla;
        private System.Windows.Forms.Label lblJedinicaMjere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblpopis;
    }
}