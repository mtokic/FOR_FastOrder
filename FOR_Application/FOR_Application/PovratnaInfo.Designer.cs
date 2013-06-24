namespace FOR_Application
{
    partial class frmPovratneInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpovratneInformacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet1 = new FOR_Application.pi2013FastOrderdbDataSet();
            this.povratnaInformacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.povratnaInformacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.povratna_informacijaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Povratna_informacijaTableAdapter();
            this.evidencijaOZaposlenimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidencija_o_zaposlenimaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter();
            this.narudzbaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaOZaposlenimaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpovratneInformacijeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.fKIDnarudzbeDataGridViewTextBoxColumn,
            this.Datum});
            this.dataGridView1.DataSource = this.povratnaInformacijaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDpovratneInformacijeDataGridViewTextBoxColumn
            // 
            this.iDpovratneInformacijeDataGridViewTextBoxColumn.DataPropertyName = "ID_povratne informacije";
            this.iDpovratneInformacijeDataGridViewTextBoxColumn.HeaderText = "ID_povratne informacije";
            this.iDpovratneInformacijeDataGridViewTextBoxColumn.Name = "iDpovratneInformacijeDataGridViewTextBoxColumn";
            this.iDpovratneInformacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpovratneInformacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Width = 200;
            // 
            // fKIDnarudzbeDataGridViewTextBoxColumn
            // 
            this.fKIDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.HeaderText = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Name = "fKIDnarudzbeDataGridViewTextBoxColumn";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "FK_ID_narudzbe";
            this.Datum.DataSource = this.narudzbaBindingSource;
            this.Datum.DisplayMember = "Datum";
            this.Datum.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Datum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Datum.ValueMember = "ID_narudzbe";
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataMember = "Narudzba";
            this.narudzbaBindingSource.DataSource = this.pi2013FastOrderdbDataSet1;
            // 
            // pi2013FastOrderdbDataSet1
            // 
            this.pi2013FastOrderdbDataSet1.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // povratnaInformacijaBindingSource1
            // 
            this.povratnaInformacijaBindingSource1.DataMember = "Povratna informacija";
            this.povratnaInformacijaBindingSource1.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(228, 301);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(127, 28);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izađi";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // povratnaInformacijaBindingSource
            // 
            this.povratnaInformacijaBindingSource.DataMember = "Povratna informacija";
            this.povratnaInformacijaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // povratna_informacijaTableAdapter
            // 
            this.povratna_informacijaTableAdapter.ClearBeforeFill = true;
            // 
            // evidencijaOZaposlenimaBindingSource
            // 
            this.evidencijaOZaposlenimaBindingSource.DataMember = "Evidencija o zaposlenima";
            this.evidencijaOZaposlenimaBindingSource.DataSource = this.pi2013FastOrderdbDataSet1;
            // 
            // evidencija_o_zaposlenimaTableAdapter
            // 
            this.evidencija_o_zaposlenimaTableAdapter.ClearBeforeFill = true;
            // 
            // narudzbaTableAdapter
            // 
            this.narudzbaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPovratneInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(364, 336);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPovratneInfo";
            this.Text = "Povratne  informacije";
            this.Load += new System.EventHandler(this.PovratnaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaOZaposlenimaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzlaz;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource povratnaInformacijaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Povratna_informacijaTableAdapter povratna_informacijaTableAdapter;
        private System.Windows.Forms.BindingSource povratnaInformacijaBindingSource1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet1;
        private System.Windows.Forms.BindingSource evidencijaOZaposlenimaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Evidencija_o_zaposlenimaTableAdapter evidencija_o_zaposlenimaTableAdapter;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter narudzbaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpovratneInformacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Datum;
    }
}