using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIndirimYap_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimOrani, indirimliFiyat;

            etiketFiyati = Convert.ToInt32(txtEtiket.Text);
            indirimOrani = Convert.ToDouble(txtIndirimOrani.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * indirimOrani / 100;
            label3.Text = indirimliFiyat.ToString();
        }
    }
}
