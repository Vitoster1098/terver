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

        double matOzid, otkonenie;
        int steps;

        bool setValues()
        {
            try
            {
                matOzid = Convert.ToDouble(textBox1.Text);
                otkonenie = Convert.ToDouble(textBox2.Text);
                steps = Convert.ToInt32(textBox3.Text);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Рассчитать
        {
            if (!setValues()) 
            { 
                return; 
            }
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            double shag = (5 * otkonenie) / 1000;
            
            List<double> list = new List<double>();
            Random r = new Random();

            for (int i = 0; i < steps; i++)
            {
                double x = r.NextDouble();
                double y0 = 0;
                double S = 0;
                double h = matOzid - 5 * otkonenie;

                while (S <= x * otkonenie * Math.Sqrt(2 * Math.PI))
                {
                    double y = Math.Exp(-1 * Math.Pow((h - matOzid), 2) / (2 * Math.Pow(otkonenie, 2))); // расчет части с exp
                    y0 = h;
                    S += y * shag;
                    h += shag;
                }
                double Y = (y0 + h) / 2;
                list.Add(Y);
            }

            double max = list.Max();
            double min = list.Min();
            double range = (max - min) / 20;
            double a = min;
            double b = min + range;

            for (double i = min; i <= max; i += range)
            {
                int count = list.Where(x => x > a && x <= b).ToArray().Count();
                double chastota = count / (steps * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, chastota);
                chart1.Series[1].Points.AddXY((a + b) / 2, (1 / (otkonenie * Math.Sqrt(2 * Math.PI))) * 
                    Math.Exp(-1 * (Math.Pow((((a + b) / 2) - matOzid), 2)) / (2 * Math.Pow(otkonenie, 2))));
                a += range;
                b += range;
            }

        }
    }
}