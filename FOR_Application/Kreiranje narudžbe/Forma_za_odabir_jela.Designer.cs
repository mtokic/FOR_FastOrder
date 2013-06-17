namespace Kreiranje_narudžbe
{
    partial class frmOdabirJela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdabirJela));
            this.btnSpremiOdabirJela = new System.Windows.Forms.Button();
            this.lstOdabranaJela = new System.Windows.Forms.ListBox();
            this.dbListaJela = new System.Windows.Forms.DataGridView();
            this.lblOdabranaJela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbListaJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremiOdabirJela
            // 
            this.btnSpremiOdabirJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremiOdabirJela.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiOdabirJela.Location = new System.Drawing.Point(422, 402);
            this.btnSpremiOdabirJela.Name = "btnSpremiOdabirJela";
            this.btnSpremiOdabirJela.Size = new System.Drawing.Size(213, 44);
            this.btnSpremiOdabirJela.TabIndex = 0;
            this.btnSpremiOdabirJela.Text = "Spremi odabir";
            this.btnSpremiOdabirJela.UseVisualStyleBackColor = true;
            this.btnSpremiOdabirJela.Click += new System.EventHandler(this.btnSpremiOdabirJela_Click);
            // 
            // lstOdabranaJela
            // 
            this.lstOdabranaJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOdabranaJela.FormattingEnabled = true;
            this.lstOdabranaJela.Location = new System.Drawing.Point(336, 180);
            this.lstOdabranaJela.Name = "lstOdabranaJela";
            this.lstOdabranaJela.Size = new System.Drawing.Size(389, 199);
            this.lstOdabranaJela.TabIndex = 2;
            // 
            // dbListaJela
            // 
            this.dbListaJela.AllowUserToAddRows = false;
            this.dbListaJela.AllowUserToDeleteRows = false;
            this.dbListaJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbListaJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbListaJela.Location = new System.Drawing.Point(12, 9);
            this.dbListaJela.Name = "dbListaJela";
            this.dbListaJela.ReadOnly = true;
            this.dbListaJela.Size = new System.Drawing.Size(301, 437);
            this.dbListaJela.TabIndex = 3;
            // 
            // lblOdabranaJela
            // 
            this.lblOdabranaJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdabranaJela.AutoSize = true;
            this.lblOdabranaJela.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabranaJela.ForeColor = System.Drawing.Color.White;
            this.lblOdabranaJela.Location = new System.Drawing.Point(330, 136);
            this.lblOdabranaJela.Name = "lblOdabranaJela";
            this.lblOdabranaJela.Size = new System.Drawing.Size(201, 34);
            this.lblOdabranaJela.TabIndex = 4;
            this.lblOdabranaJela.Text = "Odabrane stavke";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmOdabirJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(755, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOdabranaJela);
            this.Controls.Add(this.dbListaJela);
            this.Controls.Add(this.lstOdabranaJela);
            this.Controls.Add(this.btnSpremiOdabirJela);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdabirJela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponuda jela";
            ((System.ComponentModel.ISupportInitialize)(this.dbListaJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiOdabirJela;
        private System.Windows.Forms.ListBox lstOdabranaJela;
        private System.Windows.Forms.DataGridView dbListaJela;
        private System.Windows.Forms.Label lblOdabranaJela;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}