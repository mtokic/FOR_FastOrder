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
    public partial class frmOdabirJela : Form
    {
        public frmOdabirJela()
        {
            InitializeComponent();
        }

        private void btnSpremiOdabirJela_Click(object sender, EventArgs e)
        {
            frmOdabirJela.ActiveForm.Close();
        }

        private void dbListaJela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bazaRad bazaRad = new bazaRad();
            bazaRad.OpenConnection();
        }

       
    }
}
