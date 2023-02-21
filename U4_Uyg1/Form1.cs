using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                isimler[index] = textBox1.Text;
                index++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("yavaşş   ");
            }
            catch(FormatException)
            {
                MessageBox.Show("bir harf giriniz ");
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
