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
                new Viesbutis("Congress", 4 , 0.1, 94),
                new Viesbutis("Embassy", 4, 3, 60),
                new Viesbutis("Europa", 4, 1, 110),
                new Viesbutis("Radisson", 4, 1.5, 103)

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
            optimalOut.Text = "";
            double vartKaina = Convert.ToInt32(vartotojoKaina.Text);
            double vartAtstumas = Convert.ToInt32(vartotojoAtstumas.Text);
            int vartRate = Convert.ToInt32(vartotojoRate.Text);
            List<double> calculations = new List<double>();
            foreach (var vies in viesbuciaiAll)
            {
                double calc = vies.calculateOptimal(vartKaina, vartAtstumas, vartRate, vies);
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
