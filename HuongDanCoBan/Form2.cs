using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDanCoBan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rNu.Checked)
            MessageBox.Show("Ban dang chon gioi tinh nu","Thong bao");
        }

        private void rNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rNam.Checked)
            MessageBox.Show("Ban dang chon gioi tinh nam","Thong bao");
        }
    }
}
