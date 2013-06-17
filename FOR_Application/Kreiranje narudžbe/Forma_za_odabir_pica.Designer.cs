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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdabirPica));
            this.dbListaPica = new System.Windows.Forms.DataGridView();
            this.lstOdabranaPica = new System.Windows.Forms.ListBox();
            this.lblOdabranaPica = new System.Windows.Forms.Label();
            this.btnSpremiOdabirPica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbListaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbListaPica
            // 
            this.dbListaPica.AllowUserToAddRows = false;
            this.dbListaPica.AllowUserToDeleteRows = false;
            this.dbListaPica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbListaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbListaPica.Location = new System.Drawing.Point(12, 9);
            this.dbListaPica.Name = "dbListaPica";
            this.dbListaPica.ReadOnly = true;
            this.dbListaPica.Size = new System.Drawing.Size(298, 437);
            this.dbListaPica.TabIndex = 0;
            // 
            // lstOdabranaPica
            // 
            this.lstOdabranaPica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOdabranaPica.FormattingEnabled = true;
            this.lstOdabranaPica.Location = new System.Drawing.Point(339, 179);
            this.lstOdabranaPica.Name = "lstOdabranaPica";
            this.lstOdabranaPica.Size = new System.Drawing.Size(405, 199);
            this.lstOdabranaPica.TabIndex = 1;
            // 
            // lblOdabranaPica
            // 
            this.lblOdabranaPica.AutoSize = true;
            this.lblOdabranaPica.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabranaPica.ForeColor = System.Drawing.Color.White;
            this.lblOdabranaPica.Location = new System.Drawing.Point(333, 139);
            this.lblOdabranaPica.Name = "lblOdabranaPica";
            this.lblOdabranaPica.Size = new System.Drawing.Size(201, 34);
            this.lblOdabranaPica.TabIndex = 5;
            this.lblOdabranaPica.Text = "Odabrane stavke";
            // 
            // btnSpremiOdabirPica
            // 
            this.btnSpremiOdabirPica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremiOdabirPica.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiOdabirPica.Location = new System.Drawing.Point(427, 403);
            this.btnSpremiOdabirPica.Name = "btnSpremiOdabirPica";
            this.btnSpremiOdabirPica.Size = new System.Drawing.Size(207, 43);
            this.btnSpremiOdabirPica.TabIndex = 6;
            this.btnSpremiOdabirPica.Text = "Spremi odabir";
            this.btnSpremiOdabirPica.UseVisualStyleBackColor = true;
            this.btnSpremiOdabirPica.Click += new System.EventHandler(this.btnSpremiOdabirPica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmOdabirPica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(769, 458);
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
            ((System.ComponentModel.ISupportInitialize)(this.dbListaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbListaPica;
        private System.Windows.Forms.ListBox lstOdabranaPica;
        private System.Windows.Forms.Label lblOdabranaPica;
        private System.Windows.Forms.Button btnSpremiOdabirPica;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}