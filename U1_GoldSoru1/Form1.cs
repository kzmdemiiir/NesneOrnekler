using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad, soyad, no, sinif;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            no = txtNo.Text;
            sinif = cbSinifi.Text;
            MessageBox.Show(sinif + " sınıfında " + no + " numaralı " + ad + " " + soyad);
        }
    }
}
