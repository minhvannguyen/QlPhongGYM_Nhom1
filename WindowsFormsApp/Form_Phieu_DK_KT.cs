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
    public partial class Form_Phieu_DK_KT : Form
    {
        public Form_Phieu_DK_KT()
        {
            InitializeComponent();
            GiaTri_cb_LoaiKT();
            GiaTri_cb_PTid();
        }
        private void GiaTri_cb_LoaiKT()
        {
            cb_LoaiKT.Items.Add("Cơ bản");
            cb_LoaiKT.Items.Add("Helthy, thon gọn");
            cb_LoaiKT.Items.Add("Giảm cân thần tốc");
            cb_LoaiKT.Items.Add("Body 6 múi");
            cb_LoaiKT.Items.Add("Vòng 3 và eo");
        }
        private void GiaTri_cb_PTid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NhanVienID, HoTenNV FROM NhanVien where ChucVuNV = 'pt'", con);
                DataTable dtb = new DataTable();
                da.Fill(dtb);
                con.Close();
                cb_PTid.DisplayMember = "HoTenNV";
                cb_PTid.ValueMember = "NhanVienID";
                cb_PTid.DataSource = dtb;
                cb_PTid.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool check_textbox()
        {
            
            if (String.IsNullOrEmpty(tb_theTVid.Text))
            {
                MessageBox.Show("Vui lòng nhập id thẻ TV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_theTVid.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_khoatapID.Text))
            {
                MessageBox.Show("Vui lòng nhập id khoá tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_khoatapID.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_SoBuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng buổi tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SoBuoi.Focus();
                return false;
            }
            else if (cb_LoaiKT.SelectedItem == null || String.IsNullOrEmpty(cb_LoaiKT.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn loại khoá tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_LoaiKT.Focus();
                return false;
            }
            else if (cb_PTid.SelectedItem == null || String.IsNullOrEmpty(cb_PTid.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn pt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_PTid.Focus();
                return false;
            }
            return true;
        }
        private void reset()
        {
            tb_khoatapID.Text = "";
            tb_theTVid.Text = "";
            cb_PTid.SelectedValue = "";
            cb_LoaiKT.SelectedIndex = -1;
            tb_SoBuoi.Text = "";
            tb_hoadon.Text = "";
        }

        private void bt_TaoKT_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TaoKhoaTap";
                    cmd.Connection = connt;
                    cmd.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_khoatapID.Text;
                    cmd.Parameters.Add("@TheTVID", SqlDbType.Char).Value = tb_theTVid.Text;
                    cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;
                    cmd.Parameters.Add("@TongSoBuoi", SqlDbType.Int).Value = Convert.ToInt32(tb_SoBuoi.Text);
                    cmd.Parameters.Add("@NhanVienID", SqlDbType.Char).Value = cb_PTid.SelectedValue;
                    cmd.Parameters.Add("@LoaiKhoaTap", SqlDbType.NVarChar).Value = cb_LoaiKT.SelectedItem;

                    connt.Open();
                    cmd.ExecuteNonQuery();
                    connt.Close();
                    reset();
                    MessageBox.Show("Đã tạo khoá tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void bt_dsPT_Click(object sender, EventArgs e)
        {
            Form_QL_NhanSu form_dsPT = new Form_QL_NhanSu();            
            form_dsPT.Show();
            form_dsPT.PerformButtonClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_HD formhd = new Form_ChiTiet_HD("");
            formhd.Show();
        }

        private void tb_khoatapID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_theTVid.Focus();
            }
        }

        private void tb_theTVid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_hoadon.Focus();
            }
        }

        private void tb_hoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_SoBuoi.Focus();
            }
        }
    }
}
