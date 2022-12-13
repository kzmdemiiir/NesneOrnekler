using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSoru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Matematik : ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Türkçe : ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Nesne Tabanlama : ";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Robotik Kodlama : ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1, x2, x3, c;
                x1 = Convert.ToDouble(textBox1.Text);
                x2 = Convert.ToDouble(textBox2.Text);
                x3 = Convert.ToDouble(textBox3.Text);
                if ((x1 > 100 || x1 < 0)|| (x2 > 100 || x2 < 0)|| (x3 > 100 || x3 < 0))
                {
                    
                    MessageBox.Show("Lütfen 0 - 100 arasında sayı giriniz");
                }
                else
                {
                    c = (x1 + x2 + x3) / 4;
                    label5.Text = c.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sayı giriniz");
            }
        }

      
    }
}
