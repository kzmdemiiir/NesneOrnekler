using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka;
            long sifre;
            try
            {
                ka = textBox1.Text.ToString();
                sifre = long.Parse(textBox1.Text.ToString());
                MessageBox.Show("Giriş Başarılı. Hoşgeldiiz");
            }
            catch (Exception)
            {
                MessageBox.Show("şifreniz sadece sayılardan oluşmalıdır");
                textBox2.Text = "";
                throw;
            }
        }
    }
}
