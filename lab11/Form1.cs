using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1.Text);
            double d2 = Convert.ToDouble(textBox2.Text);
            double d3 = d1 + d2;
            textBox3.Text = d3.ToString();
        }
        bool myText = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myText == false)
            {
                this.Text = "Калькулятор";
                myText = true;
            }
            else
            {
                this.Text = "Calculator";
                myText = false;
            }
            Microsoft.VisualBasic.Interaction.Beep();
        }
        bool OffOn = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (OffOn == false)
            {
                timer1.Enabled = false;
                OffOn = true;
            }
            else
            {
                timer1.Enabled = true;
                OffOn = false;
            }
        }
    }
}
