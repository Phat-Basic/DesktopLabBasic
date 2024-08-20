using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        private void textDongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfmXanh_CheckedChanged(object sender, EventArgs e)
        {
            textDongia.Text = "22000";

        }

        private void rfmDo_CheckedChanged(object sender, EventArgs e)
        {
            textDongia.Text = "21000";

        }

        private void rfmVang_CheckedChanged(object sender, EventArgs e)
        {
            textDongia.Text = "20000";

        }
    }
}
