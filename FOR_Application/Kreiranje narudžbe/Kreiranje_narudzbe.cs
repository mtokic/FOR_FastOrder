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


namespace Kreiranje_narudžbe
{
    public partial class frmKreiranjeNarudzbeGlavna : Form
    {
        Narudzba narudzba;
        public frmKreiranjeNarudzbeGlavna()
        {
            InitializeComponent();
            narudzba = new Narudzba();
            int c = (int)bazaRad.Instance.DohvatiVrijednost("select ID_stola from [Popis stolova];");
            this.lblStol.Text = c.ToString();

            string zaposlenik = (string)bazaRad.Instance.DohvatiVrijednost("select Prezime, Ime from [Evidencija o zaposlenima];");
            this.lblZaposlenik.Text = zaposlenik;



        }

        private void izracunaj_sumu()
        {
            int sum = 0;
            for (int i = 0; i < dgvNaruceneStavke.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvNaruceneStavke.Rows[i].Cells[1].Value);
            }
            this.label2.Text = sum.ToString()+" kn";
        }

        private void btnOdaberiJelo_Click(object sender, EventArgs e)
        {
            frmOdabirJela odabir_jela = new frmOdabirJela(this);
            odabir_jela.Show();
        }

        private void btnOdaberiPice_Click(object sender, EventArgs e)
        {
            frmOdabirPica odabir_pica = new frmOdabirPica(this);

            odabir_pica.Show();
        }

        private void croatianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpute odaberi_upute = new frmUpute();
            odaberi_upute.Show();
        }

        private void btnObrisiStavke_Click(object sender, EventArgs e)
        {
            if (this.dgvNaruceneStavke.SelectedRows.Count > 0)
            {
                dgvNaruceneStavke.Rows.RemoveAt(this.dgvNaruceneStavke.SelectedRows[0].Index);
            }

            izracunaj_sumu();
        }

 

        public int ID_status = 0;
        public bool klik = false;
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            klik = true;
            if (klik)
            {
                ID_status = 1;
            }
            narudzba.Datum = datum.Value.ToShortDateString();
            narudzba.Vrijeme = vrijeme.Value.ToShortTimeString();
            narudzba.Zahtjevi_narudzbe = txtZahtjevi_naruzdbe.Text;
            narudzba.FK_ID_stola = Convert.ToInt32(lblStol.Text);
            narudzba.IDStatus = (int)ID_status;
            narudzba.SpremiNarudzbu();
            this.Close();
        }

        private void frmKreiranjeNarudzbeGlavna_Load(object sender, EventArgs e)
        {
            izracunaj_sumu();
        }

        private void dgvNaruceneStavke_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            izracunaj_sumu();
        }

      

        
        

     
        
    }
}
