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
            int narudzbaID = frmPregledNarudzbi.narID;
            this.ArtikliTableAdapter.FillBy(this.pi2013FastOrderdbDataSet.Artikli, narudzbaID);
            this.artikliTableAdapter1.FillBy(this.pi2013FastOrderdbDataSet1.Artikli, narudzbaID);
            this.Stavke_narudzbeTableAdapter.FillByIDnar(this.pi2013FastOrderdbDataSet.Stavke_narudzbe, narudzbaID);
            this.stavke_narudzbeTableAdapter1.FillByIDnar(this.pi2013FastOrderdbDataSet1.Stavke_narudzbe, narudzbaID);
            this.NarudzbaTableAdapter.FillBy(this.pi2013FastOrderdbDataSet.Narudzba, narudzbaID);
            this.narudzbaTableAdapter1.FillBy(this.pi2013FastOrderdbDataSet1.Narudzba, narudzbaID);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
