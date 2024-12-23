using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
            tb_mk.PasswordChar = '*';
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            SqlConnection connt = new SqlConnection();
            connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            connt.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dangnhap";
            cmd.Connection = connt;
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = tb_tk.Text;
            cmd.Parameters.Add("@password", SqlDbType.Char).Value = tb_mk.Text;

            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            if (check_textbox())
            {
                if (code == 0)
                {
                    Session.nvIDcurrent = tb_tk.Text;

                    Form_QuanLy form = new Form_QuanLy();
                    form.Show();
                    this.Hide();
                }
                else if (code == 1)
                {
                    Session.nvIDcurrent = tb_tk.Text;

                    Form_LeTan form = new Form_LeTan();
                    form.Show();
                    this.Hide();
                }
                else if (code == 2)
                {

                }
                else if (code == 3)
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 4)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            connt.Close();
        }
        public static class Session
        {
            public static string nvIDcurrent { get; set; }
            // Thêm các thuộc tính khác nếu cần
        }
        private bool check_textbox()
        {
            if (tb_tk.Text == "")
            {
                MessageBox.Show("nhập tk đã vội thế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tb_mk.Text == "")
            {
                MessageBox.Show("nhập mk đã vội thế! Thần đằng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void checkbox_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_hienmk.Checked)
            {
                tb_mk.PasswordChar = '\0';
            }
            else
            {
                tb_mk.PasswordChar = '*';
            }
        }

        private void Form_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                login();
                // Ngăn không cho tiếng 'ding' phát ra khi nhấn Enter
                e.SuppressKeyPress = true;
            }
        }

        private void tb_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                login();
                // Ngăn không cho tiếng 'ding' phát ra khi nhấn Enter
                e.SuppressKeyPress = true;
            }
        }

        private void tb_tk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_mk.Focus();
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            tb_tk.Focus();

        }
    }
}
