namespace FOR_Application
{
    partial class frmUnosArtikla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosArtikla));
            System.Windows.Forms.Label iD_artiklaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label jedinica_mjereLabel;
            System.Windows.Forms.Label opis_artiklaLabel;
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager();
            this.artikliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.artikliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_artiklaTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.jedinicna_cijenaTextBox = new System.Windows.Forms.TextBox();
            this.jedinica_mjereTextBox = new System.Windows.Forms.TextBox();
            this.opis_artiklaTextBox = new System.Windows.Forms.TextBox();
            iD_artiklaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            jedinica_mjereLabel = new System.Windows.Forms.Label();
            opis_artiklaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingNavigator)).BeginInit();
            this.artikliBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.UpdateOrder = FOR_Application.pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artikliBindingNavigator
            // 
            this.artikliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.artikliBindingNavigator.BindingSource = this.artikliBindingSource;
            this.artikliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.artikliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.artikliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.artikliBindingNavigatorSaveItem});
            this.artikliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.artikliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.artikliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.artikliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.artikliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.artikliBindingNavigator.Name = "artikliBindingNavigator";
            this.artikliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.artikliBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.artikliBindingNavigator.TabIndex = 0;
            this.artikliBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // artikliBindingNavigatorSaveItem
            // 
            this.artikliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.artikliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("artikliBindingNavigatorSaveItem.Image")));
            this.artikliBindingNavigatorSaveItem.Name = "artikliBindingNavigatorSaveItem";
            this.artikliBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.artikliBindingNavigatorSaveItem.Text = "Save Data";
            this.artikliBindingNavigatorSaveItem.Click += new System.EventHandler(this.artikliBindingNavigatorSaveItem_Click);
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AllowUserToAddRows = false;
            this.artikliDataGridView.AllowUserToDeleteRows = false;
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Location = new System.Drawing.Point(0, 154);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(545, 220);
            this.artikliDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_artikla";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_artikla";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Jedinicna_cijena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Jedinicna_cijena";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Opis_artikla";
            this.dataGridViewTextBoxColumn4.HeaderText = "Opis_artikla";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Jedinica_mjere";
            this.dataGridViewTextBoxColumn5.HeaderText = "Jedinica_mjere";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iD_artiklaLabel
            // 
            iD_artiklaLabel.AutoSize = true;
            iD_artiklaLabel.Location = new System.Drawing.Point(12, 36);
            iD_artiklaLabel.Name = "iD_artiklaLabel";
            iD_artiklaLabel.Size = new System.Drawing.Size(62, 13);
            iD_artiklaLabel.TabIndex = 2;
            iD_artiklaLabel.Text = "Šifra artikla:";
            // 
            // iD_artiklaTextBox
            // 
            this.iD_artiklaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "ID_artikla", true));
            this.iD_artiklaTextBox.Location = new System.Drawing.Point(77, 33);
            this.iD_artiklaTextBox.Name = "iD_artiklaTextBox";
            this.iD_artiklaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_artiklaTextBox.TabIndex = 3;
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(37, 67);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 4;
            nazivLabel.Text = "Naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(77, 64);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 5;
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(243, 36);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 6;
            jedinicna_cijenaLabel.Text = "Jedinična cijena:";
            // 
            // jedinicna_cijenaTextBox
            // 
            this.jedinicna_cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Jedinicna_cijena", true));
            this.jedinicna_cijenaTextBox.Location = new System.Drawing.Point(335, 33);
            this.jedinicna_cijenaTextBox.Name = "jedinicna_cijenaTextBox";
            this.jedinicna_cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinicna_cijenaTextBox.TabIndex = 7;
            // 
            // jedinica_mjereLabel
            // 
            jedinica_mjereLabel.AutoSize = true;
            jedinica_mjereLabel.Location = new System.Drawing.Point(252, 67);
            jedinica_mjereLabel.Name = "jedinica_mjereLabel";
            jedinica_mjereLabel.Size = new System.Drawing.Size(77, 13);
            jedinica_mjereLabel.TabIndex = 8;
            jedinica_mjereLabel.Text = "Jedinica mjere:";
            // 
            // jedinica_mjereTextBox
            // 
            this.jedinica_mjereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Jedinica_mjere", true));
            this.jedinica_mjereTextBox.Location = new System.Drawing.Point(335, 64);
            this.jedinica_mjereTextBox.Name = "jedinica_mjereTextBox";
            this.jedinica_mjereTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinica_mjereTextBox.TabIndex = 9;
            // 
            // opis_artiklaLabel
            // 
            opis_artiklaLabel.AutoSize = true;
            opis_artiklaLabel.Location = new System.Drawing.Point(12, 98);
            opis_artiklaLabel.Name = "opis_artiklaLabel";
            opis_artiklaLabel.Size = new System.Drawing.Size(62, 13);
            opis_artiklaLabel.TabIndex = 10;
            opis_artiklaLabel.Text = "Opis artikla:";
            // 
            // opis_artiklaTextBox
            // 
            this.opis_artiklaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Opis_artikla", true));
            this.opis_artiklaTextBox.Location = new System.Drawing.Point(77, 95);
            this.opis_artiklaTextBox.Name = "opis_artiklaTextBox";
            this.opis_artiklaTextBox.Size = new System.Drawing.Size(100, 20);
            this.opis_artiklaTextBox.TabIndex = 11;
            // 
            // frmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 378);
            this.Controls.Add(opis_artiklaLabel);
            this.Controls.Add(this.opis_artiklaTextBox);
            this.Controls.Add(jedinica_mjereLabel);
            this.Controls.Add(this.jedinica_mjereTextBox);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.jedinicna_cijenaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(iD_artiklaLabel);
            this.Controls.Add(this.iD_artiklaTextBox);
            this.Controls.Add(this.artikliDataGridView);
            this.Controls.Add(this.artikliBindingNavigator);
            this.Name = "frmUnosArtikla";
            this.Text = "Unos_artikla";
            this.Load += new System.EventHandler(this.frmUnosArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingNavigator)).EndInit();
            this.artikliBindingNavigator.ResumeLayout(false);
            this.artikliBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator artikliBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton artikliBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iD_artiklaTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox jedinicna_cijenaTextBox;
        private System.Windows.Forms.TextBox jedinica_mjereTextBox;
        private System.Windows.Forms.TextBox opis_artiklaTextBox;
    }
}