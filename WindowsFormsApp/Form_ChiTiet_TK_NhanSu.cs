using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp2
{
    public partial class Form_ChiTiet_TK_NhanSu : Form
    {
        
        public Form_ChiTiet_TK_NhanSu(string nvID)
        {
            InitializeComponent();
            cb_cnhanvien(nvID);
            giatri_cb_chucvu();
        }
        private void cb_cnhanvien(string nvID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NhanVienID, HoTenNV FROM NhanVien", con);
                DataTable dtb = new DataTable();
                da.Fill(dtb);
                con.Close();
                cb_chonnv.DisplayMember = "HoTenNV";
                cb_chonnv.ValueMember = "NhanVienID";
                cb_chonnv.DataSource = dtb;
                cb_chonnv.SelectedValue = nvID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void giatri_cb_chucvu()
        {
            cb_chucvu.Items.Clear();
            cb_chucvu.Items.Add("quanly");
            cb_chucvu.Items.Add("letan");
            cb_chucvu.Items.Add("pt");
        }
        private void bt_hienthi_Click(object sender, EventArgs e)
        {
          
            hienthi();
        }
        private void Form_ChiTiet_TK_NhanSu_Load(object sender, EventArgs e)
        {

            hienthi();
            
        }
        private void hienthi()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "hienthinv";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@NhanVienID", SqlDbType.Char).Value = cb_chonnv.SelectedValue;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    tb_nvID.Text = row["NhanVienID"].ToString();
                    tb_hoten.Text = row["HoTenNV"].ToString();
                    tb_namsinh.Text = row["NgaySinhNV"].ToString();
                    tb_sdt.Text = row["SDT"].ToString();
                    tb_diachi.Text = row["QueQuanNV"].ToString();
                    tb_matkhau.Text = row["MatKhauNV"].ToString();
                    string gt = row["GioiTinhNV"].ToString().Trim();
                    if (gt.Equals("nam", StringComparison.OrdinalIgnoreCase))
                    {
                        rb_nam.Checked = true;
                        rb_nu.Checked = false;
                    }
                    else if (gt.Equals("nu", StringComparison.OrdinalIgnoreCase))
                    {
                        rb_nam.Checked = false;
                        rb_nu.Checked = true;
                    }
                    string chucvu = row["ChucVuNV"].ToString().Trim();
                    
                    if (chucvu.Equals("quanly", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_chucvu.SelectedItem = "quanly";
                    }
                    else if (chucvu.Equals("letan", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_chucvu.SelectedItem = "letan";
                    }
                    else if (chucvu.Equals("pt", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_chucvu.SelectedItem = "pt";
                    }
                    
                    tb_chuyenmon.Text = row["chuyenMon"].ToString();
                    tb_level.Text = row["LevelPT"].ToString();
                    
                    
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị cho nhân viên này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn xác nhận muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (check_textbox())
                {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suanv";
                    cmd.Connection = connt;
                    cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = tb_hoten.Text;
                    cmd.Parameters.Add("@NamSinhNV", SqlDbType.Char).Value = tb_namsinh.Text;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tb_diachi.Text;
                    cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = tb_sdt.Text;
                    cmd.Parameters.Add("@NhanvienID", SqlDbType.Char).Value = tb_nvID.Text;
                    cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = tb_matkhau.Text;
                    cmd.Parameters.Add("@ChucVuNV", SqlDbType.Char).Value = cb_chucvu.SelectedItem;
                    cmd.Parameters.Add("@gioitinh", SqlDbType.Char).Value = chon_gt();
                    cmd.Parameters.Add("@levelpt", SqlDbType.Int).Value = tb_level_Default(tb_level) ?? (object)DBNull.Value;
                    cmd.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = tb_chuyenmon_Default(tb_chuyenmon) ?? (object)DBNull.Value;

                    connt.Open();
                    cmd.ExecuteNonQuery();
                    connt.Close();
                        
                    MessageBox.Show("Đã Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

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
            else if (cb_chucvu.SelectedItem == null || String.IsNullOrEmpty(cb_chucvu.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_chucvu.Focus();
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
            else return "lgpt";
        }
        private string tb_chuyenmon_Default(TextBox tb_chuyenmon)
        {
            // Trả về null nếu TextBox rỗng hoặc chỉ chứa khoảng trắng
            return string.IsNullOrWhiteSpace(tb_chuyenmon.Text) ? null : tb_chuyenmon.Text;
        }
        private int? tb_level_Default(TextBox tb_level)
        {
            // Trả về null nếu TextBox rỗng hoặc chỉ chứa khoảng trắng, ngược lại trả về giá trị của TextBox dưới dạng int
            return string.IsNullOrWhiteSpace(tb_level.Text) ? (int?)null : Convert.ToInt32(tb_level.Text);
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

        private void tb_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_chuyenmon.Focus();
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
        private void tb_chuyenmon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_level.Focus();
            }
        }

        

       

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connt = new SqlConnection();
                connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoanv";
                cmd.Connection = connt;

                cmd.Parameters.Add("@NhanvienID", SqlDbType.Char).Value = tb_nvID.Text;

                
                connt.Open();
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
                connt.Close();
                reset();
                MessageBox.Show("Đã xoá nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            cb_chucvu.SelectedIndex = -1;
            tb_chuyenmon.Text = "";
            tb_level.Text = "";
            cb_chonnv.SelectedIndex = -1;
        }
    }
}
