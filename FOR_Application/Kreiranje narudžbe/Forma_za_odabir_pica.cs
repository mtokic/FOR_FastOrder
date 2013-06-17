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
    }
        
}
