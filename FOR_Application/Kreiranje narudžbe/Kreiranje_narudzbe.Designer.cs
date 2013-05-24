namespace Kreiranje_narudžbe
{
    partial class frmKreiranjeNarudzbeGlavna
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
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKreiranjeNarudzbeGlavna));
            this.msIzbornikHelp = new System.Windows.Forms.MenuStrip();
            this.msPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.msUputeZaKoristenje = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.croatianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdaberiJelo = new System.Windows.Forms.Button();
            this.btnOdaberiPice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstNaruceneStavke = new System.Windows.Forms.ListBox();
            this.lblNaruceneStavke = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.btnUpute = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.msIzbornikHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateTimePicker1.Checked = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new System.Drawing.Point(452, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            dateTimePicker1.TabIndex = 1;
            // 
            // msIzbornikHelp
            // 
            this.msIzbornikHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPomoc});
            this.msIzbornikHelp.Location = new System.Drawing.Point(0, 0);
            this.msIzbornikHelp.Name = "msIzbornikHelp";
            this.msIzbornikHelp.Size = new System.Drawing.Size(577, 24);
            this.msIzbornikHelp.TabIndex = 0;
            this.msIzbornikHelp.Text = "menuStrip1";
            // 
            // msPomoc
            // 
            this.msPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUputeZaKoristenje,
            this.msIzlaz});
            this.msPomoc.Name = "msPomoc";
            this.msPomoc.Size = new System.Drawing.Size(53, 20);
            this.msPomoc.Text = "Pomoć";
            // 
            // msUputeZaKoristenje
            // 
            this.msUputeZaKoristenje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.croatianToolStripMenuItem});
            this.msUputeZaKoristenje.Name = "msUputeZaKoristenje";
            this.msUputeZaKoristenje.Size = new System.Drawing.Size(174, 22);
            this.msUputeZaKoristenje.Text = "Upute za korištenje";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // croatianToolStripMenuItem
            // 
            this.croatianToolStripMenuItem.Name = "croatianToolStripMenuItem";
            this.croatianToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.croatianToolStripMenuItem.Text = "Croatian";
            // 
            // msIzlaz
            // 
            this.msIzlaz.Name = "msIzlaz";
            this.msIzlaz.Size = new System.Drawing.Size(174, 22);
            this.msIzlaz.Text = "Izlaz";
            // 
            // btnOdaberiJelo
            // 
            this.btnOdaberiJelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiJelo.Location = new System.Drawing.Point(15, 414);
            this.btnOdaberiJelo.Name = "btnOdaberiJelo";
            this.btnOdaberiJelo.Size = new System.Drawing.Size(157, 65);
            this.btnOdaberiJelo.TabIndex = 2;
            this.btnOdaberiJelo.Text = "Odaberi jelo";
            this.btnOdaberiJelo.UseVisualStyleBackColor = true;
            this.btnOdaberiJelo.Click += new System.EventHandler(this.btnOdaberiJelo_Click);
            // 
            // btnOdaberiPice
            // 
            this.btnOdaberiPice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiPice.Location = new System.Drawing.Point(15, 321);
            this.btnOdaberiPice.Name = "btnOdaberiPice";
            this.btnOdaberiPice.Size = new System.Drawing.Size(157, 67);
            this.btnOdaberiPice.TabIndex = 3;
            this.btnOdaberiPice.Text = "Odaberi piće";
            this.btnOdaberiPice.UseVisualStyleBackColor = true;
            this.btnOdaberiPice.Click += new System.EventHandler(this.btnOdaberiPice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lstNaruceneStavke
            // 
            this.lstNaruceneStavke.FormattingEnabled = true;
            this.lstNaruceneStavke.Location = new System.Drawing.Point(12, 44);
            this.lstNaruceneStavke.Name = "lstNaruceneStavke";
            this.lstNaruceneStavke.Size = new System.Drawing.Size(553, 238);
            this.lstNaruceneStavke.TabIndex = 5;
            // 
            // lblNaruceneStavke
            // 
            this.lblNaruceneStavke.AutoSize = true;
            this.lblNaruceneStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaruceneStavke.Location = new System.Drawing.Point(229, 24);
            this.lblNaruceneStavke.Name = "lblNaruceneStavke";
            this.lblNaruceneStavke.Size = new System.Drawing.Size(115, 17);
            this.lblNaruceneStavke.TabIndex = 6;
            this.lblNaruceneStavke.Text = "Naručene stavke";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaruci.Location = new System.Drawing.Point(350, 321);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(215, 67);
            this.btnNaruci.TabIndex = 7;
            this.btnNaruci.Text = "NARUČI";
            this.btnNaruci.UseVisualStyleBackColor = true;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.Location = new System.Drawing.Point(347, 292);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(61, 17);
            this.lblUkupno.TabIndex = 8;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // btnUpute
            // 
            this.btnUpute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpute.Location = new System.Drawing.Point(350, 410);
            this.btnUpute.Name = "btnUpute";
            this.btnUpute.Size = new System.Drawing.Size(215, 67);
            this.btnUpute.TabIndex = 9;
            this.btnUpute.Text = "UPUTE";
            this.btnUpute.UseVisualStyleBackColor = true;
            this.btnUpute.Click += new System.EventHandler(this.btnUpute_Click);
            // 
            // frmKreiranjeNarudzbeGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 491);
            this.Controls.Add(this.btnUpute);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.lblNaruceneStavke);
            this.Controls.Add(this.lstNaruceneStavke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdaberiPice);
            this.Controls.Add(this.btnOdaberiJelo);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(this.msIzbornikHelp);
            this.MainMenuStrip = this.msIzbornikHelp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKreiranjeNarudzbeGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje narudžbe";
            this.msIzbornikHelp.ResumeLayout(false);
            this.msIzbornikHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornikHelp;
        private System.Windows.Forms.ToolStripMenuItem msPomoc;
        private System.Windows.Forms.ToolStripMenuItem msUputeZaKoristenje;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem croatianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msIzlaz;
        private System.Windows.Forms.Button btnOdaberiJelo;
        private System.Windows.Forms.Button btnOdaberiPice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstNaruceneStavke;
        private System.Windows.Forms.Label lblNaruceneStavke;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Button btnUpute;
    }
}

