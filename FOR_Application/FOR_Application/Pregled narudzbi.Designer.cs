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
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter();
            this.iDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevinarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDzaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stavkeNarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_narudzbeTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.fKIDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKIDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudzbeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.iDstolaDataGridViewTextBoxColumn,
            this.zahtjevinarudzbeDataGridViewTextBoxColumn,
            this.fKIDstolaDataGridViewTextBoxColumn,
            this.fKIDzaposlenikaDataGridViewTextBoxColumn,
            this.iDStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(685, 3);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(224, 147);
            this.lstStatus.TabIndex = 0;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataMember = "Narudzba";
            this.narudzbaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // narudzbaTableAdapter
            // 
            this.narudzbaTableAdapter.ClearBeforeFill = true;
            // 
            // iDnarudzbeDataGridViewTextBoxColumn
            // 
            this.iDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "ID_narudzbe";
            this.iDnarudzbeDataGridViewTextBoxColumn.HeaderText = "ID_narudzbe";
            this.iDnarudzbeDataGridViewTextBoxColumn.Name = "iDnarudzbeDataGridViewTextBoxColumn";
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
            // iDstolaDataGridViewTextBoxColumn
            // 
            this.iDstolaDataGridViewTextBoxColumn.DataPropertyName = "ID_stola";
            this.iDstolaDataGridViewTextBoxColumn.HeaderText = "ID_stola";
            this.iDstolaDataGridViewTextBoxColumn.Name = "iDstolaDataGridViewTextBoxColumn";
            // 
            // zahtjevinarudzbeDataGridViewTextBoxColumn
            // 
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.DataPropertyName = "Zahtjevi_narudzbe";
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.HeaderText = "Zahtjevi_narudzbe";
            this.zahtjevinarudzbeDataGridViewTextBoxColumn.Name = "zahtjevinarudzbeDataGridViewTextBoxColumn";
            // 
            // fKIDstolaDataGridViewTextBoxColumn
            // 
            this.fKIDstolaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_stola";
            this.fKIDstolaDataGridViewTextBoxColumn.HeaderText = "FK_ID_stola";
            this.fKIDstolaDataGridViewTextBoxColumn.Name = "fKIDstolaDataGridViewTextBoxColumn";
            // 
            // fKIDzaposlenikaDataGridViewTextBoxColumn
            // 
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_zaposlenika";
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.HeaderText = "FK_ID_zaposlenika";
            this.fKIDzaposlenikaDataGridViewTextBoxColumn.Name = "fKIDzaposlenikaDataGridViewTextBoxColumn";
            // 
            // iDStatusDataGridViewTextBoxColumn
            // 
            this.iDStatusDataGridViewTextBoxColumn.DataPropertyName = "IDStatus";
            this.iDStatusDataGridViewTextBoxColumn.HeaderText = "IDStatus";
            this.iDStatusDataGridViewTextBoxColumn.Name = "iDStatusDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fKIDnarudzbeDataGridViewTextBoxColumn,
            this.Column1,
            this.fKIDartiklaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkeNarudzbeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(676, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // stavkeNarudzbeBindingSource
            // 
            this.stavkeNarudzbeBindingSource.DataMember = "Stavke narudzbe";
            this.stavkeNarudzbeBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // stavke_narudzbeTableAdapter
            // 
            this.stavke_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // fKIDnarudzbeDataGridViewTextBoxColumn
            // 
            this.fKIDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.HeaderText = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Name = "fKIDnarudzbeDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataSource = this.artikliBindingSource;
            this.Column1.DisplayMember = "Naziv";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Naziv";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fKIDartiklaDataGridViewTextBoxColumn
            // 
            this.fKIDartiklaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_artikla";
            this.fKIDartiklaDataGridViewTextBoxColumn.HeaderText = "FK_ID_artikla";
            this.fKIDartiklaDataGridViewTextBoxColumn.Name = "fKIDartiklaDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
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
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjevinarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDzaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stavkeNarudzbeBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter stavke_narudzbeTableAdapter;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}