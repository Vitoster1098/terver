using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ввод переменных + очиста чарта
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double M = Convert.ToDouble(textBox1.Text);
            double Q = Convert.ToDouble(textBox2.Text);
            int k = Convert.ToInt32(textBox3.Text);


            //double shag = (5 * Q) / 1000;

            //рандом + лист
            Random r = new Random();
            Random x = new Random(r.Next(10000));
            Random y = new Random(r.Next(10000));
            List<double> list = new List<double>();

            for (int i = 0; i < k; i++)
            {
                var U = Math.Cos(2 * Math.PI * x.NextDouble()) * Math.Sqrt(-2 * Math.Log(y.NextDouble()));

                var Z = Q * U + M;

                list.Add(Z);
            }

            double max = list.Max();
            double min = list.Min();
            double range = (max - min) / 20;
            double a = min;
            double b = min + range;
            for (double i = min; i <= max; i += range)
            {
                var count = list.Where(p => p > a && p <= b).ToArray().Count();
                var ch = count / (k * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, ch);
                chart1.Series[1].Points.AddXY((a + b) / 2, (1 / (Q * Math.Sqrt(2 * Math.PI))) * Math.Exp(-1 * (Math.Pow((((a + b) / 2) - M), 2)) / (2 * Math.Pow(Q, 2))));
                a += range;
                b += range;
            }
        }
    }
}
