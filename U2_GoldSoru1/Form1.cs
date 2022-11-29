using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random;
            random = new Random();
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(random.Next(1, 1000));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("Lütfen ilk önce doldur butonuna tıklayınız", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 5 == 0)
                    {
                        listBox4.Items.Add(listBox1.Items[i]);
                    }
                    else if (Convert.ToInt32(listBox1.Items[i]) % 5 == 0)
                    {
                        listBox3.Items.Add(listBox1.Items[i]);
                    }
                    else if (Convert.ToInt32(listBox1.Items[i]) % 5 == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }
                    else
                    {
                        listBox5.Items.Add(listBox1.Items[i]);
                    }
                }
            }
           
        }
    }
}
