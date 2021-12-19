using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double koef;
        int steps;

        bool setValues()
        {
            try
            {
                koef = Convert.ToDouble(textBox1.Text);
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
            if (!setValues()) 
            { 
                return; 
            }
            Random mo = new Random();

            List<double> list1 = new List<double>();
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < steps; i++)
            {                
                double y = (-1 / koef) * Math.Log(1 - mo.NextDouble());
                if (y != 1) list1.Add(y);
            }

            double range = list1.Max() / 20;
            double a = 0;
            double b = range;

            for (int i = 0; i < 20; i++)
            {
                int count = list1.Where(x => x > a && x <= b).ToArray().Count();
                double chastota = count / (steps * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, chastota);
                chart1.Series[1].Points.AddXY((a + b) / 2, koef * Math.Exp(-koef * ((a + b) / 2)));
                a += range;
                b += range;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}