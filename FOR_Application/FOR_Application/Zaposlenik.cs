using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHelper;

namespace FOR_Application
{
    class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Radno_mjesto { get; set; }
        public string Adresa { get; set; }

        public void DodajZaposlenika()
        {
            bazaRad.Instance.Query("insert into [Evidencija o zaposlenima] (Radno_mjesto, Ime, Prezime,Adresa) values ('" + Radno_mjesto + "','" + Ime + "','" + Prezime + "','" + Adresa + "');");
        }

    }
}
