using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex + 1;
            label2.Text = comboBox1.Text + " harfi, alfabenin " + secim + ". harfidir.";
        }
    }
}
