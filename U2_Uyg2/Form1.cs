using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(txtYas.Text);

            if (yas > 17)
            {
                MessageBox.Show("Ehliyete başvurunuz onaylandı", "Başvuru Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
