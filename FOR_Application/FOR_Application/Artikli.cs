using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHelper;

namespace FOR_Application
{
    class Artikli
    {
        public string Naziv { get; set; }
        public float Jedinicna_cijena { get; set; }
        public string Opis_artikla { get; set; }
        public string Jedinica_mjere { get; set; }

        public void DodajArtikl()
        {
            bazaRad.Instance.Query("insert into Artikli (Naziv,Jedinicna_cijena,Opis_artikla,Jedinica_mjere) values ('" + Naziv + "'," + Jedinicna_cijena + ",'" + Opis_artikla + "','" + Jedinica_mjere + "');");
        }

    }
}
