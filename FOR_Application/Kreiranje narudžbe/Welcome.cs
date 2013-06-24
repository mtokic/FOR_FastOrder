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
    public partial class frmPocetniZaslon : Form
    {
        public frmPocetniZaslon()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Otvara se forma za kreiranje narudzbi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUlaz_Click(object sender, EventArgs e)
        {
            frmKreiranjeNarudzbeGlavna kreiranje_narudzbe = new frmKreiranjeNarudzbeGlavna();
            kreiranje_narudzbe.Show();
        }

        
    }
}
