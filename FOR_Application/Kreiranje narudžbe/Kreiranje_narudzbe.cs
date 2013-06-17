using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreiranje_narudžbe
{
    public partial class frmKreiranjeNarudzbeGlavna : Form
    {
        public frmKreiranjeNarudzbeGlavna()
        {
            InitializeComponent();
        }

        private void btnOdaberiJelo_Click(object sender, EventArgs e)
        {
            frmOdabirJela odabir_jela = new frmOdabirJela();
            odabir_jela.Show();
        }

        private void btnOdaberiPice_Click(object sender, EventArgs e)
        {
            frmOdabirPica odabir_pica = new frmOdabirPica();
            odabir_pica.Show();
        }

        private void croatianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpute odaberi_upute = new frmUpute();
            odaberi_upute.Show();
        }

        

     
        
    }
}
