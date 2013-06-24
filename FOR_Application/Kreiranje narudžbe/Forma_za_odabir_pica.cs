using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;
using System.Collections;

namespace Kreiranje_narudžbe
{
    public partial class frmOdabirPica : Form
    {
        frmKreiranjeNarudzbeGlavna a = new frmKreiranjeNarudzbeGlavna();
        public frmOdabirPica(frmKreiranjeNarudzbeGlavna Forma)
        {
            InitializeComponent();
            a = Forma;
        }
        /// <summary>
        /// Sprema odabrana pica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiOdabirPica_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow b in this.dgvNarucenaPica.Rows)
            {
                if (b.Cells[0].Value != null) a.dgvNaruceneStavke.Rows.Add(b.Cells[0].Value, b.Cells[1].Value, b.Cells[2].Value, b.Cells[3].Value);
            }

            frmOdabirPica.ActiveForm.Close();
        }
             
        /// <summary>
        /// Prikazuje popis pica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOdabirPica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.FillByOpisArtikla1(this.pi2013FastOrderdbDataSet.Artikli);

        }
        /// <summary>
        /// Dodaje pice na popis odabranih pica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajPice_Click(object sender, EventArgs e)
        {
            var a = this.dgvListaPica.SelectedRows[0];
            var b = a;
            this.dgvNarucenaPica.Rows.Add(a.Cells[0].Value, a.Cells[1].Value, a.Cells[2].Value, a.Cells[4].Value);
        }
        /// <summary>
        /// Brise pice iz popisa odabranih pica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiPice_Click(object sender, EventArgs e)
        {
            if (this.dgvNarucenaPica.SelectedRows.Count > 0)
            {
                dgvNarucenaPica.Rows.RemoveAt(this.dgvNarucenaPica.SelectedRows[0].Index);
            }     
            
        }


    }
        
}
