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
using static WindowsFormsApp2.Form_DangNhap;

namespace WindowsFormsApp2
{
    public partial class Form_ChiTiet_HD : Form
    {
       
        public Form_ChiTiet_HD(string hdid)
        {
            InitializeComponent();
            cb_KTT_giatri();
            cb_LHD_giatri();
            reset();
            tb_hoadon.Text = hdid;
            hienthi();
            tb_nvID.Text = Session.nvIDcurrent;
            
        }
        private void cb_LHD_giatri()
        {
            cb_LoaiHĐ.Items.Clear();
            cb_LoaiHĐ.Items.Add("khoatap");
            cb_LoaiHĐ.Items.Add("thetv");
            cb_LoaiHĐ.Items.Add("dungcu");

        }
        private void cb_KTT_giatri()
        {
            cb_KieuThanhToan.Items.Clear();
            cb_KieuThanhToan.Items.Add("banking");
            cb_KieuThanhToan.Items.Add("cash");
        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            
                if (KiemTraThongTin())
                {

                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "taohd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.Add("@Gia", SqlDbType.Char).Value = tb_Gia.Text;
                        cmd.Parameters.Add("@NhanVienID", SqlDbType.Char).Value = tb_nvID.Text;
                        cmd.Parameters.Add("@KM", SqlDbType.Char).Value = tb_km.Text;
                        cmd.Parameters.Add("@KieuThanhToan", SqlDbType.Char).Value = cb_KieuThanhToan.SelectedItem;
                        cmd.Parameters.Add("@LoaiHD", SqlDbType.NVarChar).Value = cb_LoaiHĐ.SelectedItem;

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        reset();
                        MessageBox.Show("Xuất hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }
        public bool KiemTraThongTin()
        {
            
            if (cb_LoaiHĐ.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_LoaiHĐ.Focus();
                return false;
            }
            if (cb_KieuThanhToan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_KieuThanhToan.Focus();
                return false;
            }
              return true;
        }

        private void hienthi()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlDataAdapter daa = new SqlDataAdapter();
            DataTable dat = new DataTable();

            try
            {
                con.Open();
                daa.SelectCommand = new SqlCommand();
                daa.SelectCommand.CommandText = "hienthihd";
                daa.SelectCommand.CommandType = CommandType.StoredProcedure;
                daa.SelectCommand.Connection = con;
                daa.SelectCommand.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;
                daa.Fill(dat);
                con.Close();
                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];

                    tb_Gia.Text = row["Gia"].ToString();
                    tb_km.Text = row["KhuyenMai"].ToString();
                    tb_NgayLap.Text = row["NgayLap"].ToString();
                    tb_nv.Text = row["NhanVienID"].ToString();

                    string Ktt = row["KieuThanhToan"].ToString().Trim();
                    if (Ktt.Equals("banking", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_KieuThanhToan.SelectedItem = "banking";
                    }
                    else if (Ktt.Equals("cash", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_KieuThanhToan.SelectedItem = "cash";
                    }

                    string lhd = row["LoaiHD"].ToString().Trim();

                    if (lhd.Equals("khoatap", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_LoaiHĐ.SelectedItem = "khoatap";
                    }
                    else if (lhd.Equals("thetv", StringComparison.OrdinalIgnoreCase))
                    {
                        cb_LoaiHĐ.SelectedItem = "thetv";
                    }
                   
                }
                 else checkvalues = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void reset()
        {
            tb_Gia.Text = "";
            tb_hoadon.Text = "";
            tb_km.Text = "";
            tb_NgayLap.Text = "";
            cb_KieuThanhToan.SelectedItem = null;
            cb_LoaiHĐ.SelectedItem = null;
        }

        private void Form_ChiTiet_HD_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void bt_qlhd_Click(object sender, EventArgs e)
        {
            Form_QL_HD formqlhd = new Form_QL_HD();
            formqlhd.Show();
        }
        public bool checkvalues = true;
        private void bt_search_Click(object sender, EventArgs e)
        {
            hienthi();
            if(checkvalues == false)
            {
                MessageBox.Show("Không tồn tại hoá đơn bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            checkvalues = true;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if(tb_nvID.Text == "minh029875")
            {
                xoahd();
            }
            else
            {
                MessageBox.Show("Lễ tân xoá làm gì? ăn chặn à?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void xoahd()
        {
            try
            {
                SqlConnection connt = new SqlConnection();
                connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoahd";
                cmd.Connection = connt;

                cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;


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
    }
}
