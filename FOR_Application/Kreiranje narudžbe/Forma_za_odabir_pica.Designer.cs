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
            this.dbListaPica = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new Kreiranje_narudžbe.pi2013FastOrderdbDataSet();
            this.lstOdabranaPica = new System.Windows.Forms.ListBox();
            this.lblOdabranaPica = new System.Windows.Forms.Label();
            this.btnSpremiOdabirPica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artikliTableAdapter = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.fKStavkeNarudzbeArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_narudzbeTableAdapter = new Kreiranje_narudžbe.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbListaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbListaPica
            // 
            this.dbListaPica.AllowUserToAddRows = false;
            this.dbListaPica.AllowUserToDeleteRows = false;
            this.dbListaPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbListaPica.AutoGenerateColumns = false;
            this.dbListaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbListaPica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn});
            this.dbListaPica.DataSource = this.artikliBindingSource;
            this.dbListaPica.Location = new System.Drawing.Point(20, 60);
            this.dbListaPica.Name = "dbListaPica";
            this.dbListaPica.ReadOnly = true;
            this.dbListaPica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbListaPica.Size = new System.Drawing.Size(298, 437);
            this.dbListaPica.TabIndex = 0;
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
            // lstOdabranaPica
            // 
            this.lstOdabranaPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstOdabranaPica.FormattingEnabled = true;
            this.lstOdabranaPica.Location = new System.Drawing.Point(347, 230);
            this.lstOdabranaPica.Name = "lstOdabranaPica";
            this.lstOdabranaPica.Size = new System.Drawing.Size(405, 199);
            this.lstOdabranaPica.TabIndex = 1;
            // 
            // lblOdabranaPica
            // 
            this.lblOdabranaPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdabranaPica.AutoSize = true;
            this.lblOdabranaPica.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabranaPica.ForeColor = System.Drawing.Color.White;
            this.lblOdabranaPica.Location = new System.Drawing.Point(341, 190);
            this.lblOdabranaPica.Name = "lblOdabranaPica";
            this.lblOdabranaPica.Size = new System.Drawing.Size(201, 34);
            this.lblOdabranaPica.TabIndex = 5;
            this.lblOdabranaPica.Text = "Odabrane stavke";
            // 
            // btnSpremiOdabirPica
            // 
            this.btnSpremiOdabirPica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremiOdabirPica.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiOdabirPica.Location = new System.Drawing.Point(435, 454);
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
            this.pictureBox1.Location = new System.Drawing.Point(586, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            this.tableAdapterManager.JelovnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.Popis_stolovaTableAdapter = null;
            this.tableAdapterManager.Povratna_informacijaTableAdapter = null;
            this.tableAdapterManager.Racun_za_gostaTableAdapter = null;
            this.tableAdapterManager.Stavke_jelovnikaTableAdapter = null;
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
            // frmOdabirPica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremiOdabirPica);
            this.Controls.Add(this.lblOdabranaPica);
            this.Controls.Add(this.lstOdabranaPica);
            this.Controls.Add(this.dbListaPica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdabirPica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponuda pića";
            this.Load += new System.EventHandler(this.frmOdabirPica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbListaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkeNarudzbeArtikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbListaPica;
        private System.Windows.Forms.ListBox lstOdabranaPica;
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
    }
}