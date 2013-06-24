namespace FOR_Application
{
    partial class frmPregledNarudzbi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaZaposlenihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stoloviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevinarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDzaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter();
            this.stavke_narudzbeTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.artikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.raToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izradiRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.lstStatus);
            this.splitContainer1.Size = new System.Drawing.Size(912, 400);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudzbeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.zahtjevinarudzbeDataGridViewTextBoxColumn,
            this.fKIDstolaDataGridViewTextBoxColumn,
            this.fKIDzaposlenikaDataGridViewTextBoxColumn,
            this.iDStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(906, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView2.DataSource = this.artikliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(676, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(685, 3);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(224, 147);
            this.lstStatus.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.evidencijaZaposlenihToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.stoloviToolStripMenuItem,
            this.raToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // evidencijaZaposlenihToolStripMenuItem
            // 
            this.evidencijaZaposlenihToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1});
            this.evidencijaZaposlenihToolStripMenuItem.Name = "evidencijaZaposlenihToolStripMenuItem";
            this.evidencijaZaposlenihToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.evidencijaZaposlenihToolStripMenuItem.Text = "Evidencija zaposlenih";
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.unosToolStripMenuItem1.Text = "Unos";
            this.unosToolStripMenuItem1.Click += new System.EventHandler(this.unosToolStripMenuItem1_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem2});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // unosToolStripMenuItem2
            // 
            this.unosToolStripMenuItem2.Name = "unosToolStripMenuItem2";
            this.unosToolStripMenuItem2.Size = new System.Drawing.Size(101, 22);
            this.unosToolStripMenuItem2.Text = "Unos";
            this.unosToolStripMenuItem2.Click += new System.EventHandler(this.unosToolStripMenuItem2_Click);
            // 
            // stoloviToolStripMenuItem
            // 
            this.stoloviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem});
            this.stoloviToolStripMenuItem.Name = "stoloviToolStripMenuItem";
            this.stoloviToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.stoloviToolStripMenuItem.Text = "Stolovi";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.DataSource = this.stavkeNarudzbeBindingSource;
            this.Column1.DisplayMember = "Kolicina";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Količina";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "FK_ID_narudzbe";
            // 
            // iDnarudzbeDataGridViewTextBoxColumn
            // 
            this.iDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "ID_narudzbe";
            this.iDnarudzbeDataGridViewTextBoxColumn.HeaderText = "Šifra narudžbe";
            this.iDnarudzbeDataGridViewTextBoxColumn.Name = "iDnarudzbeDataGridViewTextBoxColumn";
            this.iDnarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // zahtjevinarudzbeDataGridViewTextBoxColumn
            // 
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.DataPropertyName = "Zahtjevi_narudzbe";
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.HeaderText = "Zahtjevi narudzbe";
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.Name = "zahtjevinarudzbeDataGridViewTextBoxColumn";
            // 
            // fKIDstolaDataGridViewTextBoxColumn
            // 
            this.fKIDstolaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_stola";
            this.fKIDstolaDataGridViewTextBoxColumn.HeaderText = "FK_ID_stola";
            this.fKIDstolaDataGridViewTextBoxColumn.Name = "fKIDstolaDataGridViewTextBoxColumn";
            this.fKIDstolaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKIDzaposlenikaDataGridViewTextBoxColumn
            // 
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_zaposlenika";
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.HeaderText = "FK_ID_zaposlenika";
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.Name = "fKIDzaposlenikaDataGridViewTextBoxColumn";
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDStatusDataGridViewTextBoxColumn
            // 
            this.iDStatusDataGridViewTextBoxColumn.DataPropertyName = "IDStatus";
            this.iDStatusDataGridViewTextBoxColumn.HeaderText = "IDStatus";
            this.iDStatusDataGridViewTextBoxColumn.Name = "iDStatusDataGridViewTextBoxColumn";
            this.iDStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataMember = "Narudzba";
            this.narudzbaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // jedinicnacijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnacijenaDataGridViewTextBoxColumn.DataPropertyName = "Jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            this.opisartiklaDataGridViewTextBoxColumn.Visible = false;
            // 
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "Jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "Jedinica mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            // 
            // stavkeNarudzbeBindingSource
            // 
            this.stavkeNarudzbeBindingSource.DataMember = "Stavke narudzbe";
            this.stavkeNarudzbeBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // narudzbaTableAdapter
            // 
            this.narudzbaTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_narudzbeTableAdapter
            // 
            this.stavke_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // raToolStripMenuItem
            // 
            this.raToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izradiRačunToolStripMenuItem});
            this.raToolStripMenuItem.Name = "raToolStripMenuItem";
            this.raToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.raToolStripMenuItem.Text = "Račun";
            // 
            // izradiRačunToolStripMenuItem
            // 
            this.izradiRačunToolStripMenuItem.Name = "izradiRačunToolStripMenuItem";
            this.izradiRačunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izradiRačunToolStripMenuItem.Text = "Izradi račun";
            this.izradiRačunToolStripMenuItem.Click += new System.EventHandler(this.izradiRačunToolStripMenuItem_Click);
            // 
            // frmPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPregledNarudzbi";
            this.Text = "Pregled_narudzbi";
            this.Load += new System.EventHandler(this.frmPregledNarudzbi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter narudzbaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stavkeNarudzbeBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter stavke_narudzbeTableAdapter;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjevinarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDzaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem evidencijaZaposlenihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stoloviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem raToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izradiRačunToolStripMenuItem;
    }
}