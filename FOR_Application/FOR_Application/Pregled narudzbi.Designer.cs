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
            this.btnGotovo = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDnarudžbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevinarudžbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDzaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudžbaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKIDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudžbaTableAdapter();
            this.stavke_narudzbeTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGotovo);
            this.splitContainer1.Panel1.Controls.Add(this.btnKreiraj);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 571);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGotovo
            // 
            this.btnGotovo.Location = new System.Drawing.Point(943, 306);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(90, 39);
            this.btnGotovo.TabIndex = 2;
            this.btnGotovo.Text = "Gotovo jelo";
            this.btnGotovo.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(845, 306);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(92, 39);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj račun";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudžbeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.iDstolaDataGridViewTextBoxColumn,
            this.zahtjevinarudžbeDataGridViewTextBoxColumn,
            this.fKIDstolaDataGridViewTextBoxColumn,
            this.fKIDzaposlenikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudžbaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDnarudžbeDataGridViewTextBoxColumn
            // 
            this.iDnarudžbeDataGridViewTextBoxColumn.DataPropertyName = "ID_narudžbe";
            this.iDnarudžbeDataGridViewTextBoxColumn.HeaderText = "ID_narudžbe";
            this.iDnarudžbeDataGridViewTextBoxColumn.Name = "iDnarudžbeDataGridViewTextBoxColumn";
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
            // zahtjevinarudžbeDataGridViewTextBoxColumn
            // 
            this.zahtjevinarudžbeDataGridViewTextBoxColumn.DataPropertyName = "Zahtjevi_narudžbe";
            this.zahtjevinarudžbeDataGridViewTextBoxColumn.HeaderText = "Zahtjevi_narudžbe";
            this.zahtjevinarudžbeDataGridViewTextBoxColumn.Name = "zahtjevinarudžbeDataGridViewTextBoxColumn";
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
            // narudžbaBindingSource1
            // 
            this.narudžbaBindingSource1.DataMember = "Narudžba";
            this.narudžbaBindingSource1.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(646, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 212);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fKIDnarudzbeDataGridViewTextBoxColumn,
            this.fKIDartiklaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkeNarudzbeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(637, 213);
            this.dataGridView2.TabIndex = 0;
            // 
            // fKIDnarudzbeDataGridViewTextBoxColumn
            // 
            this.fKIDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.HeaderText = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Name = "fKIDnarudzbeDataGridViewTextBoxColumn";
            // 
            // fKIDartiklaDataGridViewTextBoxColumn
            // 
            this.fKIDartiklaDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_artikla";
            this.fKIDartiklaDataGridViewTextBoxColumn.HeaderText = "FK_ID_artikla";
            this.fKIDartiklaDataGridViewTextBoxColumn.Name = "fKIDartiklaDataGridViewTextBoxColumn";
            // 
            // stavkeNarudzbeBindingSource
            // 
            this.stavkeNarudzbeBindingSource.DataMember = "Stavke narudzbe";
            this.stavkeNarudzbeBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // narudžbaBindingSource
            // 
            this.narudžbaBindingSource.DataMember = "Narudžba";
            this.narudžbaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // narudžbaTableAdapter
            // 
            this.narudžbaTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_narudzbeTableAdapter
            // 
            this.stavke_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 571);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPregledNarudzbi";
            this.Text = "Pregled narudžbi";
            this.Load += new System.EventHandler(this.frmPregledNarudzbi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGotovo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource narudžbaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.NarudžbaTableAdapter narudžbaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudžbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjevinarudžbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDzaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource narudžbaBindingSource1;
        private System.Windows.Forms.BindingSource stavkeNarudzbeBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter stavke_narudzbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDartiklaDataGridViewTextBoxColumn;
    }
}

