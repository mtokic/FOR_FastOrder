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

namespace FOR_Application
{
    public partial class frmEvidencijaStolova : Form
    {
        Stol stol;
        public frmEvidencijaStolova()
        {
            InitializeComponent();
            stol = new Stol();
            this.txtOpisStola.Text= "";

        }

        private void frmEvidencijaStolova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Popis_stolova' table. You can move, or remove it, as needed.
            this.popis_stolovaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Popis_stolova);

        }

        private void btnUnoStola_Click(object sender, EventArgs e)
        {
            stol.Opis = txtOpisStola.Text;
            stol.UnosStol();
            this.popis_stolovaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Popis_stolova);

        }

        private void btnObrisiStol_Click(object sender, EventArgs e)
        {
            dgvListaStolova.Rows.RemoveAt(dgvListaStolova.CurrentRow.Index);
            this.Validate();
            this.popis_stolovaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);
        }


    }
}
