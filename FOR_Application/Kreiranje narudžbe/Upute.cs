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
    public partial class frmUpute : Form
    {
        public frmUpute()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUpute.ActiveForm.Close();
        }
    }
}
