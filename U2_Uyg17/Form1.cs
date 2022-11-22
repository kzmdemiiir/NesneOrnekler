using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
            }

            if (!radioButton1.Checked)
            {
                this.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }
        }
    }
}
