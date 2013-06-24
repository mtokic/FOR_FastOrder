namespace FOR_Application
{
    partial class frmRacun
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacun));
            this.btnIspisRacuna = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pi2013FastOrderdbDataSet = new FOR_Application.pi2013FastOrderdbDataSet();
            this.ArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArtikliTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.Stavke_narudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stavke_narudzbeTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.NarudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NarudzbaTableAdapter = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pi2013FastOrderdbDataSet1 = new FOR_Application.pi2013FastOrderdbDataSet();
            this.artikliTableAdapter1 = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter();
            this.stavke_narudzbeTableAdapter1 = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter();
            this.narudzbaTableAdapter1 = new FOR_Application.pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeNarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stavke_narudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIspisRacuna
            // 
            this.btnIspisRacuna.Location = new System.Drawing.Point(153, 335);
            this.btnIspisRacuna.Name = "btnIspisRacuna";
            this.btnIspisRacuna.Size = new System.Drawing.Size(75, 33);
            this.btnIspisRacuna.TabIndex = 0;
            this.btnIspisRacuna.Text = "Ispis";
            this.btnIspisRacuna.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.artikliBindingSource1;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.stavkeNarudzbeBindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.narudzbaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FOR_Application.Racun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(460, 246);
            this.reportViewer1.TabIndex = 1;
            // 
            // pi2013FastOrderdbDataSet
            // 
            this.pi2013FastOrderdbDataSet.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArtikliBindingSource
            // 
            this.ArtikliBindingSource.DataMember = "Artikli";
            this.ArtikliBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // ArtikliTableAdapter
            // 
            this.ArtikliTableAdapter.ClearBeforeFill = true;
            // 
            // Stavke_narudzbeBindingSource
            // 
            this.Stavke_narudzbeBindingSource.DataMember = "Stavke narudzbe";
            this.Stavke_narudzbeBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // Stavke_narudzbeTableAdapter
            // 
            this.Stavke_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // NarudzbaBindingSource
            // 
            this.NarudzbaBindingSource.DataMember = "Narudzba";
            this.NarudzbaBindingSource.DataSource = this.pi2013FastOrderdbDataSet;
            // 
            // NarudzbaTableAdapter
            // 
            this.NarudzbaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.NarudzbaBindingSource;
            this.comboBox1.DisplayMember = "ID_narudzbe";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_narudzbe";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // pi2013FastOrderdbDataSet1
            // 
            this.pi2013FastOrderdbDataSet1.DataSetName = "pi2013FastOrderdbDataSet";
            this.pi2013FastOrderdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter1
            // 
            this.artikliTableAdapter1.ClearBeforeFill = true;
            // 
            // stavke_narudzbeTableAdapter1
            // 
            this.stavke_narudzbeTableAdapter1.ClearBeforeFill = true;
            // 
            // narudzbaTableAdapter1
            // 
            this.narudzbaTableAdapter1.ClearBeforeFill = true;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this.pi2013FastOrderdbDataSet1;
            // 
            // stavkeNarudzbeBindingSource
            // 
            this.stavkeNarudzbeBindingSource.DataMember = "Stavke narudzbe";
            this.stavkeNarudzbeBindingSource.DataSource = this.pi2013FastOrderdbDataSet1;
            // 
            // narudzbaBindingSource1
            // 
            this.narudzbaBindingSource1.DataSource = ((object)(resources.GetObject("narudzbaBindingSource1.DataSource")));
            this.narudzbaBindingSource1.Position = 0;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnIspisRacuna);
            this.Name = "frmRacun";
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stavke_narudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013FastOrderdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIspisRacuna;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArtikliBindingSource;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet;
        private System.Windows.Forms.BindingSource Stavke_narudzbeBindingSource;
        private System.Windows.Forms.BindingSource NarudzbaBindingSource;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter ArtikliTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter Stavke_narudzbeTableAdapter;
        private pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter NarudzbaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private pi2013FastOrderdbDataSet pi2013FastOrderdbDataSet1;
        private System.Windows.Forms.BindingSource stavkeNarudzbeBindingSource;
        private System.Windows.Forms.BindingSource narudzbaBindingSource1;
        private pi2013FastOrderdbDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter1;
        private pi2013FastOrderdbDataSetTableAdapters.Stavke_narudzbeTableAdapter stavke_narudzbeTableAdapter1;
        private pi2013FastOrderdbDataSetTableAdapters.NarudzbaTableAdapter narudzbaTableAdapter1;
    }
}