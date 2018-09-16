﻿using System;
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
                new Viesbutis("Congress", 3, 12.6, 40),
                new Viesbutis("Embassy", 4, 2, 150),
                new Viesbutis("Europa", 3, 0.6, 100),
                new Viesbutis("LR Seimo", 1, 0.5, 5)

            };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
