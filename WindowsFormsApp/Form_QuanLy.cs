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
    public partial class Form_QuanLy : Form
    {
        public Form_QuanLy()
        {
            InitializeComponent();
        }

        private void bt_QL_NhanSu_Click(object sender, EventArgs e)
        {
            Form_QL_NhanSu form_ql_nhansu = new Form_QL_NhanSu();
            form_ql_nhansu.Show();

        }

        private void bt_QL_DungCu_Click(object sender, EventArgs e)
        {
            Form_QL_DungCu form_ql_dungcu = new Form_QL_DungCu();
            form_ql_dungcu.Show();
        }

        private void bt_QL_KhoaTap_Click(object sender, EventArgs e)
        {
            Form_QL_KhoaTap form_KT = new Form_QL_KhoaTap();
            form_KT.Show();
        }

        private void bt_LeTan_Click(object sender, EventArgs e)
        {
            Form_LeTan form_letan = new Form_LeTan();
            form_letan.Show();
        }
    }
}
