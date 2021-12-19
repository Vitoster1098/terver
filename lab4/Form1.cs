using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double matOzid, otkonenie;
        int steps;

        bool setValues() //Установка значений
        {
            try
            {
                matOzid = Convert.ToDouble(textBox1.Text);
                otkonenie = Convert.ToDouble(textBox2.Text);
                steps = Convert.ToInt32(textBox3.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Очистить
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void button1_Click(object sender, EventArgs e) //Расчитать
        {
            if (!setValues())
            {
                return;
            }
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();           

            Random r = new Random();
            Random x = new Random(r.Next(10000));
            Random y = new Random(r.Next(10000));
            List<double> list = new List<double>();

            for (int i = 0; i < steps; i++)
            {
                double u = Math.Cos(2 * Math.PI * x.NextDouble()) * Math.Sqrt(-2 * Math.Log(y.NextDouble()));
                double z = otkonenie * u + matOzid;
                list.Add(z);
            }

            double max = list.Max();
            double min = list.Min();
            double range = (max - min) / 20;
            double a = min;
            double b = min + range;

            for (double i = min; i <= max; i += range)
            {
                int count = list.Where(p => p > a && p <= b).ToArray().Count();
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