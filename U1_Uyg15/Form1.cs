using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYuzde10_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiket.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label3.Text = indirimliFiyat.ToString();
        }

        private void btnYuzde25_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiket.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            label3.Text = indirimliFiyat.ToString();
        }

        private void btnYuzde50_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiket.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            label3.Text = indirimliFiyat.ToString();
        }

        private void btnYuzde75_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiket.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;
            label3.Text = indirimliFiyat.ToString();
        }
    }
}
