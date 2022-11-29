using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random;
            random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(500);
                pictureBox1.Left = pictureBox1.Left + random.Next(1,10);
                pictureBox2.Left = pictureBox2.Left + random.Next(1, 10);
            } 
        }
    }
}
