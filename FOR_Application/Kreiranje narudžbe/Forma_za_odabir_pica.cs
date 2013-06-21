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

namespace Kreiranje_narudžbe
{
    public partial class frmOdabirPica : Form
    {
        public frmOdabirPica()
        {
            InitializeComponent();
        }

        private void btnSpremiOdabirPica_Click(object sender, EventArgs e)
        {
            frmOdabirPica.ActiveForm.Close();
        }

        private void dbListaPica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bazaRad bazaRad = new bazaRad();
            bazaRad.OpenConnection();

        }

        private void frmOdabirPica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.FillByOpis_artikla1(this.pi2013FastOrderdbDataSet.Artikli);

        }


    }
        
}
