using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru6
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
                int s1, s2, s3,c;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                s3 = Convert.ToInt32(textBox3.Text);
                if ((s1 > 100 || s1 < 0) || (s2 > 100 || s2 < 0) || (s3 > 100 || s3 < 0))
                {

                    MessageBox.Show("Lütfen 0 - 100 arasında sayı giriniz");
                }
                else
                {
                    c = (s1 + s2 + s3) / 3;
                    label5.Text = c.ToString();
                    if (radioButton1.Checked == true)
                    {
                        progressBar1.Value = c;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        progressBar2.Value = c;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        progressBar3.Value = c;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        progressBar4.Value = c;
                    }
                    
                }

            }
            catch (Exception)
            {
                
            }
        }
    }
}
