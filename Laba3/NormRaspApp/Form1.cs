using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormRaspApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ввод переменных + очиста чарта
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double M = Convert.ToDouble(textBox1.Text);
            double Q = Convert.ToDouble(textBox2.Text);
            int k = Convert.ToInt32(textBox3.Text);


            double shag = (5 * Q) / 1000;

            //рандом + лист
            Random r = new Random();
            List<double> list = new List<double>();

            for (int i = 0; i < k; i++)
            {
                double x = r.NextDouble();
                double y0 = 0;
                double S = 0; 
                double h = M - 5 * Q;  

                while (S <= x * Q * Math.Sqrt(2 * Math.PI))
                {
                    var y = Math.Exp(-1 * Math.Pow((h - M), 2) / (2 * Math.Pow(Q, 2))); // расчет части с exp
                    y0 = h;
                    S += y * shag;
                    h += shag;
                }
                var Y = (y0 + h) / 2;
                list.Add(Y);
            }

            double max = list.Max();
            double min = list.Min();
            double range = (max - min) / 20;
            double a = min;
            double b = min + range;
            for (double i = min; i <= max; i += range)
            {
                var count = list.Where(x => x > a && x <= b).ToArray().Count();
                var ch = count / (k * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, ch);
                chart1.Series[1].Points.AddXY((a + b) / 2, (1 / (Q * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1/2) * (Math.Pow((((a + b) / 2) - M), 2)) / ( Math.Pow(Q, 2))));
                a += range;
                b += range;
            }

        }
    }
}
