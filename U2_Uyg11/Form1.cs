using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    MessageBox.Show("Hafta İçi");
                    break;
                case 6:
                case 0:
                    MessageBox.Show("Hafta Sonu");
                    break;
                default:
                    MessageBox.Show("Hata oluştu");
                    break;
            }
        }
    }
}
