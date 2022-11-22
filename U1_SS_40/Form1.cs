using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 3, sayi2 = 6, sonuc;

            sonuc = (sayi1 + sayi2) * 2 + 5;
            MessageBox.Show("İşlem Sonucunuz: " + sonuc.ToString());
        }
    }
}
