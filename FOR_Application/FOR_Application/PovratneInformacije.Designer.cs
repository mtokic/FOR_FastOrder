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
            this.povratnaInformacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.povratna_informacijaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Povratna_informacijaTableAdapter();
            this.iDpovratneInformacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpovratneInformacijeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.fKIDnarudzbeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.povratnaInformacijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // povratnaInformacijaBindingSource
            // 
            this.povratnaInformacijaBindingSource.DataMember = "Povratna informacija";
            this.povratnaInformacijaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // povratna_informacijaTableAdapter
            // 
            this.povratna_informacijaTableAdapter.ClearBeforeFill = true;
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
            this.opisDataGridViewTextBoxColumn.FillWeight = 200F;
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 350;
            // 
            // fKIDnarudzbeDataGridViewTextBoxColumn
            // 
            this.fKIDnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.HeaderText = "FK_ID_narudzbe";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Name = "fKIDnarudzbeDataGridViewTextBoxColumn";
            this.fKIDnarudzbeDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(302, 324);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 1;
            this.btnIzadji.Text = "button1";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPovratneInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 353);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPovratneInfo";
            this.Text = "PovratneInformacije";
            this.Load += new System.EventHandler(this.frmPovratneInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratnaInformacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource povratnaInformacijaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Povratna_informacijaTableAdapter povratna_informacijaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpovratneInformacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzadji;
    }
}