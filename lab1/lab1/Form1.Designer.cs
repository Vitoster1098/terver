
namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PA = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pmain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chastota = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.steps = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P(A):";
            // 
            // PA
            // 
            this.PA.Location = new System.Drawing.Point(53, 55);
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(162, 20);
            this.PA.TabIndex = 1;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(53, 90);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(162, 20);
            this.PB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P(B):";
            // 
            // PC
            // 
            this.PC.Location = new System.Drawing.Point(53, 126);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(162, 20);
            this.PC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P(C):";
            // 
            // PD
            // 
            this.PD.Location = new System.Drawing.Point(53, 165);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(162, 20);
            this.PD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "P(D):";
            // 
            // PE
            // 
            this.PE.Location = new System.Drawing.Point(53, 205);
            this.PE.Name = "PE";
            this.PE.Size = new System.Drawing.Size(162, 20);
            this.PE.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "P(E):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сложное событие: (AvB)/\\(!CvD)/\\!E";
            // 
            // Pmain
            // 
            this.Pmain.Location = new System.Drawing.Point(17, 293);
            this.Pmain.Name = "Pmain";
            this.Pmain.ReadOnly = true;
            this.Pmain.Size = new System.Drawing.Size(198, 20);
            this.Pmain.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Вероятность сложного события";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Частота сложного события";
            // 
            // chastota
            // 
            this.chastota.Location = new System.Drawing.Point(17, 340);
            this.chastota.Name = "chastota";
            this.chastota.ReadOnly = true;
            this.chastota.Size = new System.Drawing.Size(198, 20);
            this.chastota.TabIndex = 13;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(92, 376);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(92, 23);
            this.Model.TabIndex = 15;
            this.Model.Text = "Моделировать";
            this.Model.UseVisualStyleBackColor = true;
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(17, 376);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(69, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Число испытаний:";
            // 
            // steps
            // 
            this.steps.Location = new System.Drawing.Point(123, 246);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(92, 20);
            this.steps.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chastota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pmain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PA;
        private System.Windows.Forms.TextBox PB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pmain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox chastota;
        private System.Windows.Forms.Button Model;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox steps;
        private System.Windows.Forms.Button button1;
    }
}

