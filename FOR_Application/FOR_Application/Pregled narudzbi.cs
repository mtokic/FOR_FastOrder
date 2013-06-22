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
        public static ToolStripStatusLabel _status;
        private Timer timer = new Timer();
        private string loggedUser = "";
        noviZahtjev nZ;

        public frmPregledNarudzbi()
        {
            InitializeComponent();
            _status = status;
         //  if(loggedUser =! null)
          //     loggedUser = loggedUser.


        }

        private void frmPregledNarudzbi_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Stavke_narudzbe' table. You can move, or remove it, as needed.
            this.stavke_narudzbeTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Stavke_narudzbe);
            // TODO: This line of code loads data into the 'pi2013FastOrderdbDataSet.Narudžba' table. You can move, or remove it, as needed.
            this.narudžbaTableAdapter.Fill(this.pi2013FastOrderdbDataSet.Narudžba);

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
         
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnos frmUnos = new frmUnos();
            frmUnos.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

     

       
    }
}
