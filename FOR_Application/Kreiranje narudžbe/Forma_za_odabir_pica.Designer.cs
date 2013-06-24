namespace Kreiranje_narudžbe
{
    partial class frmOdabirPica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdabirPica));
            this.dgvListaPica = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new Kreiranje_narudžbe.pi2013FastOrderdbDataSet();
            this.lblOdabranaPica = new System.Windows.Forms.Label();
            this.btnSpremiOdabirPica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artikliTableAdapter = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.fKStavkeNarudzbeArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_narudzbeTableAdapter = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.btnDodajPice = new System.Windows.Forms.Button();
            this.dgvNarucenaPica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStavkeNarudzbeArtikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiPice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarucenaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPica
            // 
            this.dgvListaPica.AllowUserToAddRows = false;
            this.dgvListaPica.AllowUserToDeleteRows = false;
            this.dgvListaPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaPica.AutoGenerateColumns = false;
            this.dgvListaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn});
            this.dgvListaPica.DataSource = this.artikliBindingSource;
            this.dgvListaPica.Location = new System.Drawing.Point(12, 53);
            this.dgvListaPica.Name = "dgvListaPica";
            this.dgvListaPica.ReadOnly = true;
            this.dgvListaPica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPica.Size = new System.Drawing.Size(298, 428);
            this.dgvListaPica.TabIndex = 0;
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
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "Količina";
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
            // lblOdabranaPica
            // 
            this.lblOdabranaPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdabranaPica.AutoSize = true;
            this.lblOdabranaPica.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabranaPica.ForeColor = System.Drawing.Color.White;
            this.lblOdabranaPica.Location = new System.Drawing.Point(540, 16);
            this.lblOdabranaPica.Name = "lblOdabranaPica";
            this.lblOdabranaPica.Size = new System.Drawing.Size(201, 34);
            this.lblOdabranaPica.TabIndex = 5;
            this.lblOdabranaPica.Text = "Odabrane stavke";
            // 
            // btnSpremiOdabirPica
            // 
            this.btnSpremiOdabirPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremiOdabirPica.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiOdabirPica.Location = new System.Drawing.Point(503, 496);
            this.btnSpremiOdabirPica.Name = "btnSpremiOdabirPica";
            this.btnSpremiOdabirPica.Size = new System.Drawing.Size(207, 43);
            this.btnSpremiOdabirPica.TabIndex = 6;
            this.btnSpremiOdabirPica.Text = "Spremi odabir";
            this.btnSpremiOdabirPica.UseVisualStyleBackColor = true;
            this.btnSpremiOdabirPica.Click += new System.EventHandler(this.btnSpremiOdabirPica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
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
            // fKStavkeNarudzbeArtikliBindingSource
            // 
            this.fKStavkeNarudzbeArtikliBindingSource.DataMember = "FK_Stavke narudzbe_Artikli";
            this.fKStavkeNarudzbeArtikliBindingSource.DataSource = this.artikliBindingSource;
            // 
            // stavke_narudzbeTableAdapter
            // 
            this.stavke_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodajPice
            // 
            this.btnDodajPice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPice.Location = new System.Drawing.Point(316, 200);
            this.btnDodajPice.Name = "btnDodajPice";
            this.btnDodajPice.Size = new System.Drawing.Size(125, 63);
            this.btnDodajPice.TabIndex = 9;
            this.btnDodajPice.Text = "Dodaj piće ->";
            this.btnDodajPice.UseVisualStyleBackColor = true;
            this.btnDodajPice.Click += new System.EventHandler(this.btnDodajPice_Click);
            // 
            // dgvNarucenaPica
            // 
            this.dgvNarucenaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarucenaPica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNarucenaPica.Location = new System.Drawing.Point(447, 53);
            this.dgvNarucenaPica.Name = "dgvNarucenaPica";
            this.dgvNarucenaPica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarucenaPica.Size = new System.Drawing.Size(313, 428);
            this.dgvNarucenaPica.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Naziv";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cijena";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = " Količina";
            this.Column3.Name = "Column3";
            // 
            // fKStavkeNarudzbeArtikliBindingSource1
            // 
            this.fKStavkeNarudzbeArtikliBindingSource1.DataMember = "FK_Stavke narudzbe_Artikli";
            this.fKStavkeNarudzbeArtikliBindingSource1.DataSource = this.artikliBindingSource;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ponuda pića";
            // 
            // btnObrisiPice
            // 
            this.btnObrisiPice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPice.Location = new System.Drawing.Point(316, 289);
            this.btnObrisiPice.Name = "btnObrisiPice";
            this.btnObrisiPice.Size = new System.Drawing.Size(125, 65);
            this.btnObrisiPice.TabIndex = 12;
            this.btnObrisiPice.Text = "Obriši piće <-";
            this.btnObrisiPice.UseVisualStyleBackColor = true;
            this.btnObrisiPice.Click += new System.EventHandler(this.btnObrisiPice_Click);
            // 
            // frmOdabirPica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnObrisiPice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNarucenaPica);
            this.Controls.Add(this.btnDodajPice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremiOdabirPica);
            this.Controls.Add(this.lblOdabranaPica);
            this.Controls.Add(this.dgvListaPica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdabirPica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponuda pića";
            this.Load += new System.EventHandler(this.frmOdabirPica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarucenaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPica;
        private System.Windows.Forms.Label lblOdabranaPica;
        private System.Windows.Forms.Button btnSpremiOdabirPica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        
        private System.Windows.Forms.BindingSource fKStavkeNarudzbeArtikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter stavke_narudzbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajPice;
        private System.Windows.Forms.DataGridView dgvNarucenaPica;
        private System.Windows.Forms.BindingSource fKStavkeNarudzbeArtikliBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiPice;
    }
}