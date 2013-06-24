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
    public partial class frmPovratneInfo : Form
    {
        public frmPovratneInfo()
        {
            InitializeComponent();
        }

        private void PovratnaInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet1.Narudzba' table. You can move, or remove it, as needed.
            this.narudzbaTableAdapter.Fill(this.pi2013FastOrderdbDataSet1.Narudzba);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet1.Evidencija_o_zaposlenima' table. You can move, or remove it, as needed.
            this.evidencija_o_zaposlenimaTableAdapter.Fill(this.pi2013FastOrderdbDataSet1.Evidencija_o_zaposlenima);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Povratna_informacija' table. You can move, or remove it, as needed.
            this.povratna_informacijaTableAdapter.FillByNarudzbaDatum(this.pi2013FastOrderdbDataSet.Povratna_informacija);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
