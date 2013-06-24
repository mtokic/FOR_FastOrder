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
    public partial class frmModifikacijaArtikala : Form
    {
        Artikli artikli;
        public frmModifikacijaArtikala()
        {
            InitializeComponent();
            artikli = new Artikli();
           
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            artikli.Naziv = txtNazivArtikla.Text;
            artikli.Jedinicna_cijena = float.Parse(txtJedinicnaCijena.Text);
            artikli.Opis_artikla = txtOpisArtikla.Text;
            artikli.Jedinica_mjere = txtJedinicaMjere.Text;
            artikli.DodajArtikl();

        }

    }
}
