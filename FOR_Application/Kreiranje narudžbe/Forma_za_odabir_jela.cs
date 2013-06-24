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
    public partial class frmOdabirJela : Form
    {
        frmKreiranjeNarudzbeGlavna a = new frmKreiranjeNarudzbeGlavna();
        public frmOdabirJela(frmKreiranjeNarudzbeGlavna Forma)
        {
            InitializeComponent();
            a = Forma;
        }
        /// <summary>
        /// Spremanje odabranih jela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiOdabirJela_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow b in this.dgvNarucenaJela.Rows)
            {
                if (b.Cells[0].Value != null) a.dgvNaruceneStavke.Rows.Add(b.Cells[0].Value, b.Cells[1].Value, b.Cells[2].Value, b.Cells[3].Value);
            }
            frmOdabirJela.ActiveForm.Close();
            
        }

        /// <summary>
        /// Prikaz jela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOdabirJela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.FillByOpisArtikla2(this.pi2013FastOrderdbDataSet.Artikli);
          
        }
        /// <summary>
        /// Dodaje jelo u popis narucenih jela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajJelo_Click(object sender, EventArgs e)
        {
            var a = this.dgvListaJela.SelectedRows[0];
            var b = a;
            this.dgvNarucenaJela.Rows.Add(a.Cells[0].Value, a.Cells[1].Value, a.Cells[2].Value, a.Cells[4].Value);
        }
        /// <summary>
        /// Brise jelo iz popisa narucenih jela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiJelo_Click(object sender, EventArgs e)
        {
            if (this.dgvNarucenaJela.SelectedRows.Count > 0)
            {
                dgvNarucenaJela.Rows.RemoveAt(this.dgvNarucenaJela.SelectedRows[0].Index);
            }     
        }

    }
}
