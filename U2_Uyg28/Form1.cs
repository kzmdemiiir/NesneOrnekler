using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 1, toplam = 0;
            while (toplam<=1000)
            {
                toplam = toplam + say;
                say+=1;
            }
            MessageBox.Show("Döngü Toplam " + say.ToString() + "Kez Çalıştı");
        }
    }
}
