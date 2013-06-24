namespace FOR_Application
{
    partial class frmEvidencijaStolova
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
            this.btnUnoStola = new System.Windows.Forms.Button();
            this.dgvListaStolova = new System.Windows.Forms.DataGridView();
            this.popis_stolovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.btnObrisiStol = new System.Windows.Forms.Button();
            this.popis_stolovaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Popis_stolovaTableAdapter();
            this.tableAdapterManager = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.txtOpisStola = new System.Windows.Forms.TextBox();
            this.lblOpisStolova = new System.Windows.Forms.Label();
            this.iDstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStolova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_stolovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnoStola
            // 
            this.btnUnoStola.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnoStola.ForeColor = System.Drawing.Color.Maroon;
            this.btnUnoStola.Location = new System.Drawing.Point(64, 90);
            this.btnUnoStola.Name = "btnUnoStola";
            this.btnUnoStola.Size = new System.Drawing.Size(129, 54);
            this.btnUnoStola.TabIndex = 0;
            this.btnUnoStola.Text = "Unos stola:";
            this.btnUnoStola.UseVisualStyleBackColor = true;
            this.btnUnoStola.Click += new System.EventHandler(this.btnUnoStola_Click);
            // 
            // dgvListaStolova
            // 
            this.dgvListaStolova.AutoGenerateColumns = false;
            this.dgvListaStolova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaStolova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstolaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dgvListaStolova.DataSource = this.popis_stolovaBindingSource;
            this.dgvListaStolova.Location = new System.Drawing.Point(224, 12);
            this.dgvListaStolova.Name = "dgvListaStolova";
            this.dgvListaStolova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaStolova.Size = new System.Drawing.Size(245, 207);
            this.dgvListaStolova.TabIndex = 2;
            // 
            // popis_stolovaBindingSource
            // 
            this.popis_stolovaBindingSource.DataMember = "Popis stolova";
            this.popis_stolovaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnObrisiStol
            // 
            this.btnObrisiStol.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStol.ForeColor = System.Drawing.Color.Maroon;
            this.btnObrisiStol.Location = new System.Drawing.Point(64, 167);
            this.btnObrisiStol.Name = "btnObrisiStol";
            this.btnObrisiStol.Size = new System.Drawing.Size(129, 52);
            this.btnObrisiStol.TabIndex = 3;
            this.btnObrisiStol.Text = "Obriši stol";
            this.btnObrisiStol.UseVisualStyleBackColor = true;
            this.btnObrisiStol.Click += new System.EventHandler(this.btnObrisiStol_Click);
            // 
            // popis_stolovaTableAdapter
            // 
            this.popis_stolovaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Evidencija_o_zaposlenimaTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.Popis_stolovaTableAdapter = this.popis_stolovaTableAdapter;
            this.tableAdapterManager.Povratna_informacijaTableAdapter = null;
            this.tableAdapterManager.Racun_za_gostaTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtOpisStola
            // 
            this.txtOpisStola.Location = new System.Drawing.Point(93, 32);
            this.txtOpisStola.Name = "txtOpisStola";
            this.txtOpisStola.Size = new System.Drawing.Size(100, 20);
            this.txtOpisStola.TabIndex = 4;
            // 
            // lblOpisStolova
            // 
            this.lblOpisStolova.AutoSize = true;
            this.lblOpisStolova.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisStolova.ForeColor = System.Drawing.Color.White;
            this.lblOpisStolova.Location = new System.Drawing.Point(13, 29);
            this.lblOpisStolova.Name = "lblOpisStolova";
            this.lblOpisStolova.Size = new System.Drawing.Size(83, 23);
            this.lblOpisStolova.TabIndex = 5;
            this.lblOpisStolova.Text = "Opis stola: ";
            // 
            // iDstolaDataGridViewTextBoxColumn
            // 
            this.iDstolaDataGridViewTextBoxColumn.DataPropertyName = "ID_stola";
            this.iDstolaDataGridViewTextBoxColumn.HeaderText = "Broj stola";
            this.iDstolaDataGridViewTextBoxColumn.Name = "iDstolaDataGridViewTextBoxColumn";
            this.iDstolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Vanjski/unutarnji";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // frmEvidencijaStolova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(481, 233);
            this.Controls.Add(this.lblOpisStolova);
            this.Controls.Add(this.txtOpisStola);
            this.Controls.Add(this.btnObrisiStol);
            this.Controls.Add(this.dgvListaStolova);
            this.Controls.Add(this.btnUnoStola);
            this.Name = "frmEvidencijaStolova";
            this.Text = "Unos stolova";
            this.Load += new System.EventHandler(this.frmEvidencijaStolova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStolova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_stolovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnoStola;
        private System.Windows.Forms.DataGridView dgvListaStolova;
        private System.Windows.Forms.Button btnObrisiStol;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource popis_stolovaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.Popis_stolovaTableAdapter popis_stolovaTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtOpisStola;
        private System.Windows.Forms.Label lblOpisStolova;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}