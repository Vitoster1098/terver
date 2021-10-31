using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        double pa, pb, pc, pd, pe;
        int step;

        private void button1_Click(object sender, EventArgs e) //Заполнить поля случайными
        {
            Random ra = new Random();
            Random pra = new Random(ra.Next(10000));
            Random prb = new Random(ra.Next(10000));
            Random prc = new Random(ra.Next(10000));
            Random prd = new Random(ra.Next(10000));
            Random pre = new Random(ra.Next(10000));
            PA.Text = pra.NextDouble().ToString();
            PB.Text = prb.NextDouble().ToString();
            PC.Text = prc.NextDouble().ToString();
            PD.Text = prd.NextDouble().ToString();
            PE.Text = pre.NextDouble().ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void SetValues(string pa, string pb, string pc, string pd, string pe, string step)
        {
            try
            {
                this.pa = Convert.ToDouble(pa);
                this.pb = Convert.ToDouble(pb);
                this.pc = Convert.ToDouble(pc);
                this.pd = Convert.ToDouble(pd);
                this.pe = Convert.ToDouble(pe);
                this.step = Convert.ToInt32(step);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
        }

        private void Clear_Click(object sender, EventArgs e) //Очистить все поля
        {
            PA.Text = "";
            PB.Text = "";
            PC.Text = "";
            PD.Text = "";
            PE.Text = "";
            Pmain.Text = "";
            chastota.Text = "";
            steps.Text = "";
        }

        double GetPmain()
        {
            return (1 - (1 - pa) * (1 - pb)) * (1 - (1 - (1 - pc)) * (1 - pd)) * (1 - pe);
        }
        
        private void Model_Click(object sender, EventArgs e) //Моделирование сложного события
        {
            SetValues(PA.Text, PB.Text, PC.Text, PD.Text, PE.Text, steps.Text);
            Pmain.Text = GetPmain().ToString();

            double count = 0;
            Random ra = new Random();
            for (int i = 0; i<step; ++i)
            {                
                Random pra = new Random(ra.Next(10000));
                Random prb = new Random(ra.Next(10000));
                Random prc = new Random(ra.Next(10000));
                Random prd = new Random(ra.Next(10000));
                Random pre = new Random(ra.Next(10000));

                bool a = pra.NextDouble() <= pa;
                bool b = prb.NextDouble() <= pb;
                bool c = prc.NextDouble() <= pc;
                bool d = prd.NextDouble() <= pd;
                bool ee = pre.NextDouble() <= pe;

                if((a || b) && (!c || d) && !ee)
                {
                    count++;
                }
            }
            //MessageBox.Show(count + "/" + step + " = " + count / step).ToString();
            chastota.Text = (count / step).ToString();
        }
    }
}