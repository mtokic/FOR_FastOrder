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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Forma_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtKorisnicko_ime.Text == ("konobar") && txtLozinka.Text == ("konobar")) || (txtKorisnicko_ime.Text == ("kuhar") && txtLozinka.Text == ("kuhar")))
            {
                frmPregledNarudzbi frmPregled = new frmPregledNarudzbi();
                frmPregled.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niste upisali točne podatke.\nPokušajte ponovno!", "Greška kod prijave!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKorisnicko_ime.Text = "";
                txtLozinka.Text = "";
            }
        }
    }
}
