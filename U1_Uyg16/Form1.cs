using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;

            turkceDogru = Convert.ToDouble(txtTürkceD.Text);
            turkceYanlis = Convert.ToDouble(txtTürkceY.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));

            txtTürkceN.Text = turkceNet.ToString();

            matDogru = Convert.ToDouble(txtMatD.Text);
            matYanlis = Convert.ToDouble(txtMatY.Text);
            matNet = (matDogru - (matYanlis / 4));

            txtMatN.Text = matNet.ToString();

        }
    }
}
