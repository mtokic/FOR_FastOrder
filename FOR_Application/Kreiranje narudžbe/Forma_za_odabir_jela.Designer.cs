namespace Kreiranje_narudžbe
{
    partial class frmOdabirJela
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdabirJela));
            this.btnSpremiOdabirJela = new System.Windows.Forms.Button();
            this.dgvListaJela = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new Kreiranje_narudžbe.pi2013FastOrderdbDataSet();
            this.lblOdabranaJela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artikliTableAdapter = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.dgvNarucenaJela = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiJelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarucenaJela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremiOdabirJela
            // 
            this.btnSpremiOdabirJela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremiOdabirJela.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiOdabirJela.Location = new System.Drawing.Point(527, 503);
            this.btnSpremiOdabirJela.Name = "btnSpremiOdabirJela";
            this.btnSpremiOdabirJela.Size = new System.Drawing.Size(213, 44);
            this.btnSpremiOdabirJela.TabIndex = 0;
            this.btnSpremiOdabirJela.Text = "Spremi odabir";
            this.btnSpremiOdabirJela.UseVisualStyleBackColor = true;
            this.btnSpremiOdabirJela.Click += new System.EventHandler(this.btnSpremiOdabirJela_Click);
            // 
            // dgvListaJela
            // 
            this.dgvListaJela.AllowUserToAddRows = false;
            this.dgvListaJela.AllowUserToDeleteRows = false;
            this.dgvListaJela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaJela.AutoGenerateColumns = false;
            this.dgvListaJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn});
            this.dgvListaJela.DataSource = this.artikliBindingSource;
            this.dgvListaJela.Location = new System.Drawing.Point(12, 60);
            this.dgvListaJela.MultiSelect = false;
            this.dgvListaJela.Name = "dgvListaJela";
            this.dgvListaJela.ReadOnly = true;
            this.dgvListaJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaJela.Size = new System.Drawing.Size(302, 437);
            this.dgvListaJela.TabIndex = 3;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDartiklaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jedinicnacijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnacijenaDataGridViewTextBoxColumn.DataPropertyName = "Jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            this.jedinicnacijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            this.opisartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisartiklaDataGridViewTextBoxColumn.Visible = false;
            // 
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = " Količina";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            this.jedinicamjereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOdabranaJela
            // 
            this.lblOdabranaJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdabranaJela.AutoSize = true;
            this.lblOdabranaJela.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabranaJela.ForeColor = System.Drawing.Color.White;
            this.lblOdabranaJela.Location = new System.Drawing.Point(521, 21);
            this.lblOdabranaJela.Name = "lblOdabranaJela";
            this.lblOdabranaJela.Size = new System.Drawing.Size(201, 34);
            this.lblOdabranaJela.TabIndex = 4;
            this.lblOdabranaJela.Text = "Odabrane stavke";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = this.artikliTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Evidencija_o_zaposlenimaTableAdapter = null;
            
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.Popis_stolovaTableAdapter = null;
            this.tableAdapterManager.Povratna_informacijaTableAdapter = null;
            this.tableAdapterManager.Racun_za_gostaTableAdapter = null;
            
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvNarucenaJela
            // 
            this.dgvNarucenaJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarucenaJela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.cijena,
            this.kolicina});
            this.dgvNarucenaJela.Location = new System.Drawing.Point(451, 60);
            this.dgvNarucenaJela.Name = "dgvNarucenaJela";
            this.dgvNarucenaJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarucenaJela.Size = new System.Drawing.Size(321, 437);
            this.dgvNarucenaJela.TabIndex = 6;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = " Količina";
            this.kolicina.Name = "kolicina";
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajJelo.Location = new System.Drawing.Point(320, 209);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(126, 63);
            this.btnDodajJelo.TabIndex = 7;
            this.btnDodajJelo.Text = "Dodaj jelo ->";
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodajJelo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ponuda jela";
            // 
            // btnObrisiJelo
            // 
            this.btnObrisiJelo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiJelo.Location = new System.Drawing.Point(320, 301);
            this.btnObrisiJelo.Name = "btnObrisiJelo";
            this.btnObrisiJelo.Size = new System.Drawing.Size(125, 65);
            this.btnObrisiJelo.TabIndex = 13;
            this.btnObrisiJelo.Text = "Obriši jelo <-";
            this.btnObrisiJelo.UseVisualStyleBackColor = true;
            this.btnObrisiJelo.Click += new System.EventHandler(this.btnObrisiJelo_Click);
            // 
            // frmOdabirJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnObrisiJelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajJelo);
            this.Controls.Add(this.dgvNarucenaJela);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOdabranaJela);
            this.Controls.Add(this.dgvListaJela);
            this.Controls.Add(this.btnSpremiOdabirJela);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdabirJela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponuda jela";
            this.Load += new System.EventHandler(this.frmOdabirJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarucenaJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiOdabirJela;
        private System.Windows.Forms.DataGridView dgvListaJela;
        private System.Windows.Forms.Label lblOdabranaJela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvNarucenaJela;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiJelo;
    }
}