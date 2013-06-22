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

        private void btnSpremiOdabirJela_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow b in this.dbNaruceno.Rows)
            {
                a.dgv1.Rows.Add(b.Cells[0].Value, b.Cells[1].Value, b.Cells[2].Value);
            }
            frmOdabirJela.ActiveForm.Close();
            
            
        }

        private void dbListaJela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void frmOdabirJela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.FillByOpisArtikla2(this.pi2013FastOrderdbDataSet.Artikli);
          
            
        }

        private void lstOdabranaJela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var a = this.dbListaJela.SelectedRows[0];
            var b = a;
            this.dbNaruceno.Rows.Add(a.Cells[1].Value, a.Cells[2].Value, a.Cells[3].Value);
        }

        

       
    }
}
