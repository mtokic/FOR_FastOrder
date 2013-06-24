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
    public partial class frmRacun : Form
    {
        public frmRacun()
        {
            InitializeComponent();
        }

        private void frmRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.ArtikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Stavke_narudzbe' table. You can move, or remove it, as needed.
            this.Stavke_narudzbeTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Stavke_narudzbe);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Narudzba' table. You can move, or remove it, as needed.
            this.NarudzbaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Narudzba);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int narudzbaID = (int)comboBox1.SelectedValue;
                this.ArtikliTableAdapter.FillBy(this.pi2013FastOrderdbDataSet.Artikli, narudzbaID);
                this.artikliTableAdapter1.FillBy(this.pi2013FastOrderdbDataSet1.Artikli, narudzbaID);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
