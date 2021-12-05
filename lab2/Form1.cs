using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //double param = 0;
        ///int counts = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            Random mo = new Random();
            double param = Convert.ToDouble(textBox1.Text);
            int counts = Convert.ToInt32(textBox2.Text);
            List<double> list1 = new List<double>();
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < counts; i++)
            {
                
                var y = (-1 / param) * Math.Log(1 - mo.NextDouble());
                if (y != 1) list1.Add(y);

            }

            double max = list1.Max();
            double range = max / 20;
            double a = 0;
            double b = range;
            for (int i = 0; i < 20; i++)
            {
                var count = list1.Where(x => x > a && x <= b).ToArray().Count();
                var ch = count / (counts * range);
                chart1.Series[0].Points.AddXY((a + b) / 2, ch);
                chart1.Series[1].Points.AddXY((a + b) / 2, param * Math.Exp(-param * ((a + b) / 2)));
                a += range;
                b += range;
            }


        }

       
        }
    }

}
    









 