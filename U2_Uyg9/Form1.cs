using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama;
            ortalama = Convert.ToInt32(textBox1.Text);

            if (ortalama > 100)
            {
                label2.Text = "Hatalı Not Girdiniz...";
            }
            else if (ortalama < 0)
            {
                label2.Text = "0'dan Küçük Ortalama Değeri olamaz.";
            }
            else if (ortalama > 50)
            {
                if (ortalama >= 85)
                {
                    label2.Text = "TAKDİR Aldınız";
                }
                else if (ortalama >= 70)
                {
                    label2.Text = "TEŞEKKÜR Aldınız";
                }
                else
                {
                    label2.Text = "Belge melge alamadınız";
                }
            }
            else
            {
                label2.Text = "Sınıfta KALDINIZ";
            }
        }
    }
}
