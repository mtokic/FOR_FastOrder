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
            this.txtJedinicaMjere.Text = "";
            this.txtJedinicnaCijena.Text = "";
            this.txtNazivArtikla.Text = "";
            this.txtOpisArtikla.Text = "";

           
        }
        

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            artikli.Naziv = txtNazivArtikla.Text;
            artikli.Jedinicna_cijena = float.Parse(txtJedinicnaCijena.Text);
            artikli.Opis_artikla = txtOpisArtikla.Text;
            artikli.Jedinica_mjere = txtJedinicaMjere.Text;
            artikli.DodajArtikl();

        }

        private void frmModifikacijaArtikala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListaArtikala.Rows.RemoveAt(dgvListaArtikala.CurrentRow.Index);
            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pi2013FastOrderdbDataSet);
        }

    }
}
