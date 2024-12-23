using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_QL_DungCu : Form
    {
        public Form_QL_DungCu()
        {
            InitializeComponent();
            
        }

        private void Form_QL_DungCu_Load(object sender, EventArgs e)
        {
            dsDungCu();
        }
        private void dsDungCu()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataGrid dtg = new DataGrid();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        try
        {
            con.Open();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "dsdungcu";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Dụng cụ ID";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Tên dụng cụ";
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[3].HeaderText = "Tình trạng";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Giá trị";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        }

        private void bt_dsdungcu_Click(object sender, EventArgs e)
        {
           dsDungCu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            themdungcu();
            dsDungCu();
        }
        private void themdungcu()
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "themdungcu";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenDungCu", SqlDbType.NVarChar).Value = tb_tendungcu.Text;
                    cmd.Parameters.Add("@DungCuID", SqlDbType.NVarChar).Value = tb_dungcuid.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tb_tinhtrang.Text;
                    cmd.Parameters.Add("@GiaTri", SqlDbType.Money).Value = Convert.ToDecimal(tb_giatri.Text);
                    cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dsDungCu();
                  
                    MessageBox.Show("Đã thêm mới dụng cụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool KiemTraThongTin()
        {

            if (tb_dungcuid.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id dụng cụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_dungcuid.Focus();
                return false;
            }
            if (tb_tendungcu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên dụng cụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_tendungcu.Focus();
                return false;
            }
            if (tb_tinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trình trạng dụng cụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_tinhtrang.Focus();
                return false;
            }
            if (tb_giatri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị dụng cụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_giatri.Focus();
                return false;
            }
            if (tb_hoadon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hoadon.Focus();
                return false;
            }
            return true;
        }
        private void reset()
        {
            tb_tinhtrang.Text = "";
            tb_tendungcu.Text = "";
            tb_giatri.Text = "";
            tb_dungcuid.Text = "";
            tb_hoadon.Text = "";
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            suadungcu();
            dsDungCu();
        }
        private void suadungcu()
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "suadungcu";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenDungCu", SqlDbType.NVarChar).Value = tb_tendungcu.Text;
                    cmd.Parameters.Add("@DungCuID", SqlDbType.NVarChar).Value = tb_dungcuid.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tb_tinhtrang.Text;
                    cmd.Parameters.Add("@GiaTri", SqlDbType.Money).Value = Convert.ToDecimal(tb_giatri.Text);
                    cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_hoadon.Text;

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dsDungCu();

                    MessageBox.Show("Đã sửa dụng cụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tb_dungcuid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_tendungcu.Focus();
            }
        }

        private void tb_tendungcu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_tinhtrang.Focus();
            }
        }

        private void tb_tinhtrang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_giatri.Focus();
            }
        }

        private void tb_giatri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn không cho âm báo lỗi hệ thống phát ra
                tb_hoadon.Focus();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            xoadc();
            reset();
            dsDungCu();
        }
        private void xoadc()
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoadc";
                    cmd.Connection = connt;

                    cmd.Parameters.Add("@DungCuID", SqlDbType.Char).Value = tb_dungcuid.Text;


                    connt.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connt.Close();
                    reset();
                    MessageBox.Show("Đã xoá dụng cụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Kích chuột nhầm rồi kích lại đê!THẦN ĐẰNG");
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            tb_dungcuid.Text = Convert.ToString(row.Cells["DungCuID"].Value);
            tb_tendungcu.Text = Convert.ToString(row.Cells["TenDungCu"].Value);
            tb_tinhtrang.Text = Convert.ToString(row.Cells["TinhTrang"].Value);
            tb_giatri.Text = Convert.ToString(row.Cells["GiaTri"].Value);
            tb_hoadon.Text = Convert.ToString(row.Cells["HoaDonID"].Value);
            }
            
        }

      

        private void bt_taohd_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_HD formhd = new Form_ChiTiet_HD("");
            formhd.Show();
        }
    }
    
}
