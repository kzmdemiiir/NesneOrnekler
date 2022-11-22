using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not;
            not = Convert.ToInt32(textBox1.Text);

            if (not<0)
            {
                MessageBox.Show("Puan 0'dan küçük olamaz");
            }
            else if (not<25)
            {
                MessageBox.Show("Notunuz 0");
            }
            else if (not<45)
            {
                MessageBox.Show("Notunuz 1");
            }
            else if (not<55)
            {
                MessageBox.Show("Notunuz 2");
            }
            else if (not<70)
            {
                MessageBox.Show("Notunuz 3");
            }
            else if (not<85)
            {
                MessageBox.Show("Notunuz 4");
            }
            else if (not<=100)
            {
                MessageBox.Show("Notunuz 5");
            }
            else
            {
                MessageBox.Show("Adam gibi not giriniz :(((");
            }
        }
    }
}
