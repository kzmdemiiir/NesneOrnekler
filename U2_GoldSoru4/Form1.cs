using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSoru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                if (s1 < s2)
                {
                    for (int i = s1; i <= s2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            listBox2.Items.Add(i.ToString());
                        }
                        else
                        {
                            listBox1.Items.Add(i.ToString());
                        }
                    }

                }
                else
                {
                    MessageBox.Show("büyük sayı kısmına büyük bir sayı giriniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz");
            }
        }
    }
}
