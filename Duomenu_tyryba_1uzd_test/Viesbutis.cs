using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duomenu_tyryba_1uzd_test
{
    class Viesbutis
    {
        public string Pavadinimas { get; set; }
        public int Zvaigzdutes { get; set; }
        public double Atstumas_iki_centro { get; set; }
        public double Vidutine_kaina { get; set; }

        public Viesbutis(string Pavadinimas, int Zvaigzdutes, double Atstumas_iki_centro, double Vidutine_kaina )
        {
            this.Pavadinimas = Pavadinimas;
            this.Zvaigzdutes = Zvaigzdutes;
            this.Atstumas_iki_centro = Atstumas_iki_centro;
            this.Vidutine_kaina = Vidutine_kaina;
        }
        //test
    }
}
