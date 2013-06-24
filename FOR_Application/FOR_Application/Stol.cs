using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHelper;

namespace FOR_Application
{
    class Stol
    {
        public string Opis { get; set; }

        public void UnosStol() {

            bazaRad.Instance.Query("insert into [Popis stolova] (Opis) values ('" + Opis + "');");

        }

    }
}
