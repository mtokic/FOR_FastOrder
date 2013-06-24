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
    public partial class frmPregledNarudzbi : Form
    {
        public static ToolStripStatusLabel _status;
        private Timer timer = new Timer();
        private string loggedUser = "";
        noviZahtjev nZ;
        

        /// <summary>
        /// kreiramo metodu(dretvu) koja ce pratiti status novopristiglih narudzbi
        /// </summary>
        public frmPregledNarudzbi()
        {
            InitializeComponent();
            ///_status = status;
            if (loggedUser != null)

                timer.Tick += new EventHandler(timer_Tick); // svaki put kad timer ticka poziva se event timer_Tick
            timer.Interval = (3000) * (1);              // ticka svaku sekundu
            timer.Enabled = true;                       // omoguci timer
            timer.Start();
            nZ = new noviZahtjev(this);
            nZ.pregledajNoveZahtjeve();

        }

        /// <summary>
        /// metoda koja ce se pozivati tijekom Tick event timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            nZ.pregledajNoveZahtjeve();
        }

        /// <summary>
        /// metoda kojom cemo postaviti tekst u statusnu traku
        /// </summary>
        /// <param name="text"></param>
        public static void napisiNoviStatus(string text)
        {
            _status.Text = text;

        }
        /// <summary>
        /// metoda kojom mijenjamo vrijednost listboxa  koji nam sluzi za prikaz novih zahtjeva 
        /// klikom na pojedini zahtjev moci cemo vidjeti sve atribute neke narudzbe gosta
        /// </summary>
        /// <param name="value"></param>
        public void izmjenaStanja(string value)
        {
            this.lstStatus.Text = "(" + value + ") zahtjeva";
        }

        private void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Artikli);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Stavke_narudzbe' table. You can move, or remove it, as needed.
            this.stavke_narudzbeTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Stavke_narudzbe);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Narudzba' table. You can move, or remove it, as needed.
            this.narudzbaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Narudzba);

        }

        

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEvidencija evidencija = new frmEvidencija();
            evidencija.Show();
        }

        private void unosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUnosArtikla frmUnos = new frmUnosArtikla();
            frmUnos.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
