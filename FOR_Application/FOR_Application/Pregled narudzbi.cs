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
    public partial class frmPregledNarudzbi : Form
    {
        public frmPregledNarudzbi()
        {
            InitializeComponent();
        }

        private void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet1.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet1.Artikli);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Stavke_narudzbe' table. You can move, or remove it, as needed.
            this.stavke_narudzbeTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Stavke_narudzbe);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Narudžba' table. You can move, or remove it, as needed.
            this.narudžbaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Narudžba);

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                int ID_narudzbe = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                this.stavke_narudzbeTableAdapter.FillBy(this.pi2013FastOrderdbDataSet.Stavke_narudzbe, ID_narudzbe);
            }
        }

     

       
    }
}
