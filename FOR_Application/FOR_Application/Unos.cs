using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR_Application
{
    public partial class frmUnos : Form
    {
        public frmUnos()
        {
            InitializeComponent();
        }

        private void artikliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);

        }

        private void Unos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
