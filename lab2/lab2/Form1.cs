using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double lamb = 0;
        int steps = 0;

        public bool validator()
        {
            try
            {
                lamb = Convert.ToDouble(textBox1.Text);
                steps = Convert.ToInt32(textBox2.Text);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validator())
                return;
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            Random ma = new Random();
            List<double> list = new List<double>();
            double[] y = new double[steps];
            double[] F = new double[steps];
            double x = 0;

            for (int i = 0; i < steps; ++i)
            {
                Random m0 = new Random(ma.Next(10000));
                x = m0.NextDouble();
                y[i] = -(1 / lamb) * Math.Log(1 - x);
                list.Add(y[i]);            
            }
            list.Sort();

            for (int i = 0; i < list.Count; ++i)
            {
                F[i] = lamb * Math.Exp((-lamb) * list[i]);
                chart1.Series[1].Points.AddXY(list[i], F[i]);
            }

            int parts = 20;
            double dy = (list[steps - 1] - list[0]) / parts;
            int[] chastota = new int[parts];

            for(int i = 0; i < parts; ++i)
            {
                foreach(var da in list)
                {
                    if(da > i * dy + list.ElementAt(0) && da <= (i+1) * dy + list.ElementAt(0))
                    {
                        chastota[i]++;
                    }
                }                
            }
            for(int i = 0; i < parts; ++i)
            {
                chart1.Series[0].Points.AddXY(((2 * i + 1) * dy) / 2 + list.ElementAt(0), chastota[i] / (steps * dy));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}