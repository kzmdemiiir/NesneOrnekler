using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKareAl_Click(object sender, EventArgs e)
        {
            int sayi, karesi;
            sayi = Convert.ToInt32(txtSayi.Text);
            karesi = sayi * sayi;
            MessageBox.Show("Girilen sayının karesi: " + karesi.ToString());
        }
    }
}
