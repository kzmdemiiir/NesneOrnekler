using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1234
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
                    for (int i = s1; i < s2; i++)
                    {
                        if (i % 2 == 0) 
                        {
                            listBox1.Items.Add(i);
                        }
                        else if (i % 5 == 0)
                        {
                            listBox3.Items.Add(i);
                        }
                        else
                        {
                            listBox2.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("geçerli bir sayı giiniz");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("2. sayıyı büyük giriniz");
            }
        }
    }
}
