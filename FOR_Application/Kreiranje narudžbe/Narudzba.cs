using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHelper;

namespace Kreiranje_narudžbe
{
    class Narudzba
    {
        public string Datum { get; set; }
        public string Vrijeme { get; set; }
        public string Zahtjevi_narudzbe { get; set; }
        public int FK_ID_stola { get; set; }
        public int IDStatus { get; set; }

        public void SpremiNarudzbu()
        {
            bazaRad.Instance.Query("insert into Narudzba (Datum, Vrijeme, Zahtjevi_narudzbe,FK_ID_stola,IDStatus) values ('" + Datum + "','" + Vrijeme + "','" + Zahtjevi_narudzbe + "'," + FK_ID_stola + "," + IDStatus + ");");
        }

    }
}
