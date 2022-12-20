using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();

            for (int i = 0; i <= 10; i++ )
            {
                listBox1.Items.Add(random.Next(1,100));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kucuk, buyuk;
            kucuk = Convert.ToInt32(listBox1.Items[0]);
            buyuk = Convert.ToInt32(listBox1.Items[0]);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);
                if (buyuk > sayi)
                {
                    buyuk = sayi;
                    label4.Text = buyuk.ToString();
                }
                if (kucuk < sayi)
                {
                    kucuk = sayi;
                    label2.Text = kucuk.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }
    }
}
