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
            this.btnIspisRacuna = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 317);
            this.panel1.TabIndex = 1;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIspisRacuna);
            this.Name = "frmRacun";
            this.Text = "Račun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIspisRacuna;
        private System.Windows.Forms.Panel panel1;
    }
}