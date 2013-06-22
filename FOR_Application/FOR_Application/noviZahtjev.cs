using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBHelper;

namespace FOR_Application
{
    class noviZahtjev : bazaRad
    {
        /// <summary>
        /// s ovim SQL upitom testirati cemo ID stanje, ako je ono strogo vece od prethodnog onda smo zaprimili novu naruzdbu
        /// test cemo osvjezavati uz pomoc tickera (klasa pregledavanje narudzbi)
        /// </summary>
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
            try
            {
                SqlDataReader reader = QueryReader(upit);
                while (reader.Read())
                {
                    //postavljamo novu vrijednost na button kako bi prikazivali broj novih zahtjeva
                    //moram dodati jos jednu metodu u pregled naruzdbi-->ispod tickera.....
                   // pregled.changebtnNotification(reader.GetValue(0).ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


    }
}
