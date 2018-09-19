using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duomenu_tyryba_1uzd_test
{
    public partial class Form1 : Form
    {
       

        List<Viesbutis> viesbuciaiAll = new List<Viesbutis>() {
                new Viesbutis("Congress", 3 , 0.1, 94),
                new Viesbutis("Embassy", 2, 3, 60),
                new Viesbutis("Europa", 4, 1, 300),
                new Viesbutis("Radisson", 5, 1, 320)

            };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Viesbutis> pagrindinis = viesbuciaiAll.ToList();
            foreach (var tekstas in pagrindinis)
            {
                groupBox1.Text = groupBox1.Text +"\n" + tekstas.Pavadinimas+ " "+ tekstas.Zvaigzdutes +" žvaigždutės "+ tekstas.Atstumas_iki_centro+ " km "+tekstas.Vidutine_kaina+ " €"+"\n";
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            double kainos_kofas = Convert.ToDouble(TB_priceKofas.Text)/100;
            double zvaigzduciu_kofas = Convert.ToDouble(TB_rateKofas.Text);
            double atstumo_kofas = Convert.ToDouble(TB_distanceKofas.Text);

            optimalOut.Text = "";
            double vartKaina = Convert.ToInt32(vartotojoKaina.Text);
            double vartAtstumas = Convert.ToInt32(vartotojoAtstumas.Text);
            int vartRate = Convert.ToInt32(vartotojoRate.Text);

            List<double> calculations = new List<double>();
            //double kA = 1 - kainos_kofas;
            //double zA = 1 - zvaigzduciu_kofas;
            //double aA = 1 - atstumo_kofas;

            foreach (var vies in viesbuciaiAll)
            {
                double calc = vies.calculateOptimal(vartKaina, vartAtstumas, vartRate, vies, kainos_kofas, atstumo_kofas, zvaigzduciu_kofas);
                //double calc = vies.calculateOptimal(vartKaina, vartAtstumas, vartRate, vies, kA, zA, aA);
                vies.d = calc;
                calculations.Add(calc);
            }
            double index = calculations.Min();
            List<Viesbutis> optimals = viesbuciaiAll.Where(viesbutis => viesbutis.d.Equals(index)).ToList();
            foreach (var optimal in optimals)
            {
                optimalOut.Text = optimalOut.Text + optimal.Pavadinimas + "\n";
            }
        }


    }
}
