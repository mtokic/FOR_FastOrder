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
    public partial class frmEvidencija : Form
    {
        Zaposlenik zaposlenik;
        public frmEvidencija()
        {
            InitializeComponent();
            zaposlenik = new Zaposlenik();

        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenik.Radno_mjesto = txtRadnoMjesto.Text;
            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime = txtPrezime.Text;
            zaposlenik.Adresa = txtAdresa.Text;
            zaposlenik.DodajZaposlenika();

        }


    }
}
