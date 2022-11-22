using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email;
            email = textBox1.Text;

            if (email == "123@123.com")
            {
                MessageBox.Show("Email adresiniz sistemimizde kayıtlıdır");
            }
            else
            {
                MessageBox.Show("Email kayıtlı DEĞİLDİR", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
