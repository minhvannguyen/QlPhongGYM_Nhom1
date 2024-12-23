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
using System.Data.Common;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using static WindowsFormsApp2.Form_DangNhap;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp2
{


    public partial class Form_ChiTietKTcs : Form
    {
        private SqlDataAdapter da;
        private DataTable dt;
        public Form_ChiTietKTcs(string KTID)
        {
            InitializeComponent();
            dgv_LichTrinh.EditMode = DataGridViewEditMode.EditOnEnter;
            hienthi(KTID);
            tb_nvID.Text = Session.nvIDcurrent;
        }

        private void Form_ChiTietKTcs_Load(object sender, EventArgs e)
        {
            LichTap();
            
        }
        private void LichTap()
        {
            SqlConnection con = new SqlConnection();
            da = new SqlDataAdapter();
            dt = new DataTable();
            DataGrid dtg = new DataGrid();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand("select LichTrinhID, NDKhoaTap,NgayGioTap, TienDo, ChuThich, KhoaTapID from LichTrinh where KhoaTapID = @KhoaTapID", con);
                da.SelectCommand.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_KhoaTapID.Text;

                da.Fill(dt);
                dgv_LichTrinh.DataSource = dt;
                con.Close();

                dgv_LichTrinh.Columns[0].Width = 50;
                dgv_LichTrinh.Columns[0].HeaderText = "Buổi số";
                dgv_LichTrinh.Columns[1].Width = 160;
                dgv_LichTrinh.Columns[1].HeaderText = "ND khoá tập";
                dgv_LichTrinh.Columns[2].Width = 130;
                dgv_LichTrinh.Columns[2].HeaderText = "Ngày giờ";
                dgv_LichTrinh.Columns[3].Width = 130;
                dgv_LichTrinh.Columns[3].HeaderText = "Tiến độ";
                dgv_LichTrinh.Columns[4].Width = 150;
                dgv_LichTrinh.Columns[4].HeaderText = "Chú Thích";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_LichTrinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_LichTrinh.BeginEdit(true);
        }
        private void luu()
        {
            try
            {
                if (KiemTraThongTin())
                {

                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "suaKT";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_KhoaTapID.Text;
                        cmd.Parameters.Add("@TheTVID", SqlDbType.Char).Value = tb_TheTV.Text;
                        cmd.Parameters.Add("@NhanVienID", SqlDbType.Char).Value = tb_PTID.Text;
                        cmd.Parameters.Add("@LoaiKhoaTap", SqlDbType.NVarChar).Value = tb_LoaiKT.Text;
                        cmd.Parameters.Add("@TongSoBuoi", SqlDbType.Char).Value = tb_TongSo.Text;

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                foreach (DataGridViewRow row in dgv_LichTrinh.Rows)
                {
                    if ((row.Cells["KhoaTapID"].Value == null || string.IsNullOrWhiteSpace(row.Cells["KhoaTapID"].Value.ToString())) && row.Cells["NDKhoaTap"].Value != null)
                    {
                        row.Cells["KhoaTapID"].Value = tb_KhoaTapID.Text;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Update(dt);
                    }
                }

                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    
    private void bt_Luu_Click(object sender, EventArgs e)
    {
            if (tb_nvID.Text == "minh029875")
            {
                luu();
            }
            else
            {
                if (checkdata_dgv(dgv_LichTrinh))
                {
                    luu();
                }
                else
                MessageBox.Show("Lễ tân không được sửa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
            
        private void hienthi(string KTID)
        {
            tb_KhoaTapID.Text = KTID;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlDataAdapter daa = new SqlDataAdapter();
            DataTable dat = new DataTable();

            try
            {
                con.Open();
                daa.SelectCommand = new SqlCommand();
                daa.SelectCommand.CommandText = "hienthiKT";
                daa.SelectCommand.CommandType = CommandType.StoredProcedure;
                daa.SelectCommand.Connection = con;
                daa.SelectCommand.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_KhoaTapID.Text;
                daa.Fill(dat);
                con.Close();
                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];

                    tb_Gmail.Text = row["Gmail"].ToString();
                    tb_HoTenKhach.Text = row["HoTenKhach"].ToString();
                    tb_sdt.Text = row["SDT"].ToString();
                    tb_HoTenPT.Text = row["HoTenNV"].ToString();
                    tb_LoaiKT.Text = row["LoaiKhoaTap"].ToString();
                    tb_PTID.Text = row["NhanVienID"].ToString();
                    tb_TheTV.Text = row["TheTVID"].ToString();
                    tb_TongSo.Text = row["TongSoBuoi"].ToString();
                    tb_HoaDonID.Text = row["HoaDonID"].ToString();


                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị cho khoá tập này! (có thể khoá tập chưa có hoá đơn).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool KiemTraThongTin()
        {

            if (tb_Gmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập gmail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Gmail.Focus();
                return false;
            }
            if (tb_HoaDonID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoaDonID.Focus();
                return false;
            }
            if (tb_HoTenKhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoTenKhach.Focus();
                return false;
            }
            if (tb_HoTenPT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên PT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoTenPT.Focus();
                return false;
            }
            if (tb_KhoaTapID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id khoá tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_KhoaTapID.Focus();
                return false;
            }
            if (tb_LoaiKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại khoá tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_LoaiKT.Focus();
                return false;
            }
            if (tb_PTID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id PT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_PTID.Focus();
                return false;
            }
            if (tb_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sđt khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_sdt.Focus();
                return false;
            }
            if (tb_TheTV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id thẻ TV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_TheTV.Focus();
                return false;
            }
            if (tb_TongSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tổng số buổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_TongSo.Focus();
                return false;
            }

            return true;
        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            string ktid = tb_KhoaTapID.Text;
            hienthi(ktid);
            LichTap();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_nvID.Text == "minh029875")
            {
                xoakt();
            }
            else
            {
                MessageBox.Show("Lễ tân xoá làm gì? ăn chặn à?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void xoakt()
        {
            try
            {
                SqlConnection connt = new SqlConnection();
                connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoakt";
                cmd.Connection = connt;

                cmd.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_KhoaTapID.Text;


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
            tb_Gmail.Text = "";
            tb_HoaDonID.Text = "";
            tb_HoTenKhach.Text = "";
            tb_HoTenPT.Text = "";
            tb_KhoaTapID.Text = "";
            tb_sdt.Text = "";
            tb_LoaiKT.Text = "";
            tb_PTID.Text = "";
            tb_TheTV.Text = "";
            tb_TongSo.Text = "";
            dgv_LichTrinh.DataSource = null;
        }

        private void dgv_LichTrinh_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = dgv_LichTrinh.HitTest(e.X, e.Y);

            // Kiểm tra xem người dùng có nhấn vào một ô hay không
            if (hit.Type != DataGridViewHitTestType.Cell)
            {
                MessageBox.Show("kích nhầm chuột rồi thàng ngu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_HD formhd = new Form_ChiTiet_HD("");
            formhd.Show();
        }
        private bool checkdata_tb()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Focus();
                        return false; // Dừng kiểm tra nếu có ô trống
                    }
                }
            }
            return true; // Tất cả ô đều hợp lệ
        }
        private bool checkdata_dgv(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        dgv.CurrentCell = cell; // Đặt con trỏ vào ô trống
                        return false; // Dừng kiểm tra nếu có ô trống
                    }
                }
            }
            return true; // Tất cả ô đều hợp lệ
        }

    }
}
