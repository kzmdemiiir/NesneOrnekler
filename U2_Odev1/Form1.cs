using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbKare_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtKenar1.Visible = true;
            label2.Visible = false;
            txtKenar2.Visible = false;

            label1.Text = "Kenar: ";
        }

        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtKenar1.Visible = true;
            label2.Visible = false;
            txtKenar2.Visible = false;

            label1.Text = "Yarıçap: ";
        }

        private void rbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            txtKenar1.Visible = true;
            txtKenar2.Visible = true;

            label1.Text = "Kısa Kenar: ";
            label2.Text = "Uzun Kenar: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan;
            int pi = 3;
            if (rbDaire.Checked)
            {
                kenar1 = Convert.ToInt32(txtKenar1.Text);
                alan = kenar1 * pi;
                MessageBox.Show("Dairenin Alanı: " + alan.ToString());
            }

            if (rbDikdortgen.Checked)
            {
                kenar1 = Convert.ToInt32(txtKenar1.Text);
                kenar2 = Convert.ToInt32(txtKenar2.Text);
                alan = kenar1 * kenar2;
                MessageBox.Show("Diködrtgenin Alanı: " + alan.ToString());
            }

            if (rbKare.Checked)
            {
                kenar1 = Convert.ToInt32(txtKenar1.Text);
                alan = kenar1 * kenar1;
                MessageBox.Show("Karenin Alanı: " + alan.ToString());
            }
        }
    }
}
