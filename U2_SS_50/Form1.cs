using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sicaklik;
            sicaklik = Convert.ToDouble(textBox1.Text);

            if (sicaklik<10)
            {
                MessageBox.Show("Hava SOĞUK", "Hava Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sicaklik<25)
            {
                MessageBox.Show("Hava Hafif Sıcak", "Hava Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hava SICAK", "Hava Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
