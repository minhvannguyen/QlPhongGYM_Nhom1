using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form_DK_TK_NhanSu : Form
    {
        public Form_DK_TK_NhanSu()
        {
            InitializeComponent();
            giatricombobox();
        }
        private void giatricombobox()
        {
            cb_quyenhan.Items.Add("quanly");
            cb_quyenhan.Items.Add("letan");
            cb_quyenhan.Items.Add("pt");
        }

        private void Form_DK_TK_NhanSu_Load(object sender, EventArgs e)
        {

        }
        private bool check_textbox()
        {
            if (String.IsNullOrEmpty(tb_namsinh.Text))
            {
                MessageBox.Show("Vui lòng nhập năm sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_namsinh.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_sdt.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_diachi.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_matkhau.Focus();
                return false;
            }
            else if (cb_quyenhan.SelectedItem == null || String.IsNullOrEmpty(cb_quyenhan.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_quyenhan.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_nvID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_nvID.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hoten.Focus();
                return false;
            }

            return true;
        }

        private string chon_gt()
        {
            if (rb_nam.Checked)
            {
                return "nam";
            }
            else if (rb_nu.Checked)
            {
                return "nu";
            }
            else return "lgbt";
        }
        private void reset()
        {
            tb_diachi.Text = "";
            tb_hoten.Text = "";
            tb_matkhau.Text = "";
            tb_namsinh.Text = "";
            tb_nvID.Text = "";
            tb_sdt.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            cb_quyenhan.SelectedIndex = -1;
        }

        private void buttondk_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themnv";
                    cmd.Connection = connt;
                    cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = tb_hoten.Text;
                    cmd.Parameters.Add("@NamSinhNV", SqlDbType.Char).Value = tb_namsinh.Text;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tb_diachi.Text;
                    cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = tb_sdt.Text;
                    cmd.Parameters.Add("@NhanvienID", SqlDbType.Char).Value = tb_nvID.Text;
                    cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = tb_matkhau.Text;
                    cmd.Parameters.Add("@ChucVuNV", SqlDbType.Char).Value = cb_quyenhan.SelectedItem;
                    cmd.Parameters.Add("@gioitinh", SqlDbType.Char).Value = chon_gt();

                    connt.Open();
                    cmd.ExecuteNonQuery();
                    connt.Close();
                    reset();
                    MessageBox.Show("Đã thêm mới nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tb_nvID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_hoten.Focus();
            }
        }

        private void tb_hoten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_namsinh.Focus();
            }
        }

        private void tb_namsinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_diachi.Focus();
            }
        }

        private void tb_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_matkhau.Focus();
            }
        }

        private void tb_diachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_sdt.Focus();
            }
        }
    }
}