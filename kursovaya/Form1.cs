using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kursovaya_BoxMuller
{
    public partial class Form1 : Form
    {
        double Mx, My, QX, QY;
        int steps;
        public Form1()
        {
            InitializeComponent();
        }

        public bool SetValues()
        {
            try
            {
                Mx = Convert.ToDouble(textBox1.Text);
                My = Convert.ToDouble(textBox2.Text);
                QY = Convert.ToDouble(textBox3.Text);
                QX = Convert.ToDouble(textBox4.Text);
                steps = Convert.ToInt32(textBox5.Text);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        public double Formula(double x, double y)
        {
            return (x + y) * Math.Exp(x) * Math.Cos(y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!SetValues()) { return; }

            chart1.Series[0].Points.Clear();

            Random r = new Random();
            Random rx1 = new Random(r.Next());
            Random ry1 = new Random(r.Next());
            Random rx2 = new Random(r.Next());
            Random ry2 = new Random(r.Next());            

            List<double> list = new List<double>();
            double u1, u2, u12;

            for (int i = 0; i < steps; i++)
            {
                u1 = QX * (Math.Cos(2 * Math.PI * rx1.NextDouble()) * Math.Sqrt(-2 * Math.Log(ry1.NextDouble(), Math.E))) + Mx;
                u2 = QY * (Math.Cos(2 * Math.PI * rx2.NextDouble()) * Math.Sqrt(-2 * Math.Log(ry2.NextDouble(), Math.E))) + My;
                u12 = Formula(u1, u2);
                list.Add(u12);
            }

            double max = list.Max();
            double min = list.Min();
            double range = (max - min) / 20;
            double a = min;
            double b = min + range;

            for (double i = min; i <= max; i += range)
            {
                int count = list.Where(p => p > a && p <= b).ToArray().Count();
                double result = count / (steps * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, result);
                a += range;
                b += range;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            chart1.Series[0].Points.Clear();
        }
    }
}
