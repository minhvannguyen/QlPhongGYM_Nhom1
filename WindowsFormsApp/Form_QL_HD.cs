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
using static WindowsFormsApp2.Form_DangNhap;

namespace WindowsFormsApp2
{
    public partial class Form_QL_HD : Form
    {
        public Form_QL_HD()
        {
            InitializeComponent();
            dshd();
        }
        private void dshd()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataGrid dtg = new DataGrid();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand("select HoaDonID, LoaiHD, Gia, NgayLap from HoaDon", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderText = "Hoá Đơn ID";
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[1].HeaderText = "Loại Hoá đơn";
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[2].HeaderText = "Giá tiền";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[3].HeaderText = "Ngày lập";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dshd_Click(object sender, EventArgs e)
        {
            dshd();
        }

        private void bt_tao_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_HD formhd = new Form_ChiTiet_HD("");
            formhd.Show();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if(Session.nvIDcurrent == "minh029875")
            {
                xoahd();
            }
            else
            {
                MessageBox.Show("Lễ tân xoá làm gì? ăn chặn à?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Kích chuột nhầm rồi kích lại đê!");
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                string hdid = Convert.ToString(row.Cells["HoaDonID"].Value);
                Form_ChiTiet_HD Form_ChiTiet = new Form_ChiTiet_HD(hdid);
                Form_ChiTiet.Show();
                Form_ChiTiet.Owner = this;
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = tb_search.Text;
            bool valueFound = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            // Kiểm tra DataGridView có dữ liệu không
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra ô KhoaTapID có giá trị null không
                if (row.Cells["HoaDonID"].Value != null)
                {
                    string cellValue = row.Cells["HoaDonID"].Value.ToString().Trim(); // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
                    Console.WriteLine($"Row {row.Index}: HoaDonID = {cellValue}");
                    if (cellValue.Equals(searchValue, StringComparison.OrdinalIgnoreCase)) // So sánh không phân biệt chữ hoa/chữ thường
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        valueFound = true;
                        break;
                    }
                }
            }

            if (!valueFound)
            {
                MessageBox.Show("Không tìm thấy hoá đơn bạn cần!");
            }

        }
        private void xoahd()
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoahd";
                    cmd.Connection = connt;

                    cmd.Parameters.Add("@HoaDonID", SqlDbType.Char).Value = tb_search.Text;


                    connt.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connt.Close();
                    dshd();
                    MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool KiemTraThongTin()
        {

            if (tb_search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_search.Focus();
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Kích chuột nhầm rồi kích lại đê!THẦN ĐẰNG");
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                tb_search.Text = Convert.ToString(row.Cells["HoaDonID"].Value);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra nếu hàng được chọn hợp lệ
                if (dataGridView1.CurrentRow != null)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow row = dataGridView1.CurrentRow;

                    // Kiểm tra ô có tên "HoaDonID" có tồn tại
                    if (row.Cells["HoaDonID"] != null)
                    {
                        // Lấy giá trị từ ô "HoaDonID" và đặt vào TextBox
                        tb_search.Text = Convert.ToString(row.Cells["HoaDonID"].Value);

                        // Ngăn chặn âm báo lỗi
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }
}
