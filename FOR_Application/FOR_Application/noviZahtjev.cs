using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBHelper;

namespace FOR_Application
{
    class noviZahtjev : bazaRad
    {
        string upit = "Select ID_narudzbe from Narudzba where IDstatus = 1;";
        frmPregledNarudzbi pregled;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Pregled"></param>
        public noviZahtjev(frmPregledNarudzbi Pregled)
        {
            this.pregled = Pregled;
        }

        public void pregledajNoveZahtjeve()
        {



        }


    }
}
