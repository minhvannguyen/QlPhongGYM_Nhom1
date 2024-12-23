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
    public partial class Form_ChiTiet_TheTV : Form
    {
        public Form_ChiTiet_TheTV(string theid)
        {
            InitializeComponent();
            giatricombobox();
            hienthi(theid);
        }
        private void giatricombobox()
        {
            cb_loaiThe.Items.Add("Ngày");
            cb_loaiThe.Items.Add("Tháng");
            cb_loaiThe.Items.Add("Năm");
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
            else if (String.IsNullOrEmpty(tb_ngayhethan.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày hết hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_ngayhethan.Focus();
                return false;
            }
            else if (cb_loaiThe.SelectedItem == null || String.IsNullOrEmpty(cb_loaiThe.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn Loại thẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_loaiThe.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hoten.Focus();
                return false;
            }
            
            else if (String.IsNullOrEmpty(tb_hoadon.Text))
            {
                MessageBox.Show("Vui lòng nhập id hoá đơn! Định không trả tiền ư?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hoadon.Focus();
                return false;
            }
            else if(rb_nam.Checked == false && rb_nu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tb_ngayhethan.Text = "";
            tb_namsinh.Text = "";
            tb_sdt.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            cb_loaiThe.SelectedIndex = -1;
            tb_gmail.Text = "";
            tb_ngaylap.Text = "";
            tb_TheTVID.Text = "";
            tb_hoadon.Text = "";
        }

        private void bt_dk_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "themthe";
                    cmd.Connection = connt;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tb_hoten.Text;
                    cmd.Parameters.Add("@NamSinh", SqlDbType.Char).Value = tb_namsinh.Text;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tb_diachi.Text;
                    cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = tb_sdt.Text;
                    cmd.Parameters.Add("@Gmail", SqlDbType.Char).Value = tb_gmail.Text;
                    cmd.Parameters.Add("@NgayHan", SqlDbType.Char).Value = tb_ngayhethan.Text;
                    cmd.Parameters.Add("@LoaiThe", SqlDbType.Char).Value = cb_loaiThe.SelectedItem;
                    cmd.Parameters.Add("@gioitinh", SqlDbType.Char).Value = chon_gt();
                    cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;

                    connt.Open();
                    cmd.ExecuteNonQuery();
                    connt.Close();
                    MessageBox.Show("Đã thêm mới ThẻTV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theid = tb_TheTVID.Text;
            if (tb_TheTVID.Text != "")
            {
                hienthi(theid);
            }
            else
            {
                MessageBox.Show("Nhập ID thẻ TV đã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }
        private void hienthi(string theid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            tb_TheTVID.Text = theid;
            
            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "hienthithe";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@TheTVID", SqlDbType.Char).Value = tb_TheTVID.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    tb_TheTVID.Text = row["TheTVID"].ToString();
                    tb_hoadon.Text = row["HoaDonID"].ToString();
                    tb_hoten.Text = row["HoTenKhach"].ToString();
                    tb_namsinh.Text = row["NgaySinh"].ToString();
                    tb_sdt.Text = row["SDT"].ToString();
                    tb_diachi.Text = row["diachi"].ToString();
                    tb_gmail.Text = row["Gmail"].ToString();
                    string gt = row["GioiTinh"].ToString().Trim();
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
                    string loaithe = row["LoaiThe"].ToString().Trim();

                    if (loaithe.Equals("Ngày", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_loaiThe.SelectedItem = "Ngày";
                    }
                    else if (loaithe.Equals("Tháng", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_loaiThe.SelectedItem = "Tháng";
                    }
                    else if (loaithe.Equals("Năm", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_loaiThe.SelectedItem = "Năm";
                    }

                    tb_ngayhethan.Text = row["NgayHan"].ToString();
                    tb_ngaylap.Text = row["NgayLap"].ToString();


                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "suathe";
                        cmd.Connection = connt;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tb_hoten.Text;
                        cmd.Parameters.Add("@NamSinh", SqlDbType.Char).Value = tb_namsinh.Text;
                        cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tb_diachi.Text;
                        cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = tb_sdt.Text;
                        cmd.Parameters.Add("@TheTVID", SqlDbType.Char).Value = tb_TheTVID.Text;
                        cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;
                        cmd.Parameters.Add("@NgayHan", SqlDbType.Char).Value = tb_ngayhethan.Text;
                        cmd.Parameters.Add("@LoaiThe", SqlDbType.Char).Value = cb_loaiThe.SelectedItem;
                        cmd.Parameters.Add("@gioitinh", SqlDbType.Char).Value = chon_gt();
                        cmd.Parameters.Add("@Gmail", SqlDbType.NVarChar).Value = tb_gmail.Text;

                        connt.Open();
                        if (tb_TheTVID.Text != "")
                        {
                            
                                cmd.ExecuteNonQuery();
                            
                        }
                        else
                        {
                            MessageBox.Show("Nhập ID thẻ TV đã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connt = new SqlConnection();
                connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoathe";
                cmd.Connection = connt;

                cmd.Parameters.Add("@TheTVID", SqlDbType.Char).Value = tb_TheTVID.Text;


                connt.Open();
                if (tb_TheTVID.Text != "")
                {
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập ID thẻ TV đã! THẦN ĐẰNG!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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

        private void bt_taohd_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_HD formhd = new Form_ChiTiet_HD("");
            formhd.Show();
        }

        private void Form_ChiTiet_TheTV_Load(object sender, EventArgs e)
        {

        }

        private void tb_hoten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_diachi.Focus();
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

        private void tb_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_gmail.Focus();
            }
        }

        private void tb_gmail_KeyDown(object sender, KeyEventArgs e)
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
                tb_ngayhethan.Focus();
            }
        }

        private void tb_ngayhethan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_hoadon.Focus();
            }
        }

        private void tb_ngayhethan_Leave(object sender, EventArgs e)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(tb_ngayhethan.Text, out dateValue))
            {
                MessageBox.Show("Nhập sai định dạng ngày rồi! Look at textbox's side?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ngayhethan.Focus(); // Đặt lại con trỏ vào ô nhập
            }
        }
    }
}
