using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_LeTan : Form
    {
        public Form_LeTan()
        {
            InitializeComponent();
        }

        private void bt_qlthe_Click(object sender, EventArgs e)
        {
            Form_QL_TheTV form_the = new Form_QL_TheTV();
            form_the.Show();
        }

        private void bt_QL_KhoaTap_Click(object sender, EventArgs e)
        {
            Form_QL_KhoaTap form_KT = new Form_QL_KhoaTap();
            form_KT.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_QL_HD formqlhd = new Form_QL_HD();
            formqlhd.Show();
        }
    }
}
