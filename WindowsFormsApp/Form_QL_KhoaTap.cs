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
    public partial class Form_QL_KhoaTap : Form
    {
        public Form_QL_KhoaTap()
        {
            InitializeComponent();
        }

        private void Form_QL_KhoaTap_Load(object sender, EventArgs e)
        {
            dsKhoaTap();
        }
        private void dsKhoaTap()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataGrid dtg = new DataGrid();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand("select KhoaTapID, LoaiKhoaTap, NhanVienID, TheTVID from KhoaTap", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderText = "Khoá tập ID";
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[1].HeaderText = "Loại khoá tập";
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[2].HeaderText = "Nhân viên ID";
                dataGridView1.Columns[3].Width = 130;
                dataGridView1.Columns[3].HeaderText = "Khách hàng ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsKhoaTap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Phieu_DK_KT form_taoKT = new Form_Phieu_DK_KT();
            form_taoKT.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Kích chuột nhầm rồi kích lại đê!TH");
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                string KTID = Convert.ToString(row.Cells["KhoaTapID"].Value);
                Form_ChiTietKTcs Form_ChiTiet = new Form_ChiTietKTcs(KTID);
                Form_ChiTiet.Show();
                Form_ChiTiet.Owner = this;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string searchValue = tb_timkiem.Text;
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
                if (row.Cells["KhoaTapID"].Value != null)
                {
                    string cellValue = row.Cells["KhoaTapID"].Value.ToString().Trim(); // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
                    Console.WriteLine($"Row {row.Index}: KhoaTapID = {cellValue}");
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
                    MessageBox.Show("Không tìm thấy khoá tập bạn cần!");
                }
        }

        
        private void xoakt()
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection connt = new SqlConnection();
                    connt.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoaKT";
                    cmd.Connection = connt;

                    cmd.Parameters.Add("@KhoaTapID", SqlDbType.Char).Value = tb_timkiem.Text;


                    connt.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connt.Close();
                    dsKhoaTap();
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

            if (tb_timkiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id khoá tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_timkiem.Focus();
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
                tb_timkiem.Text = Convert.ToString(row.Cells["KhoaTapID"].Value);
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
                    if (row.Cells["KhoaTapID"] != null)
                    {
                        // Lấy giá trị từ ô "HoaDonID" và đặt vào TextBox
                        tb_timkiem.Text = Convert.ToString(row.Cells["KhoaTapID"].Value);

                        // Ngăn chặn âm báo lỗi
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            if (Session.nvIDcurrent == "minh029875")
            {
                xoakt();
            }
            else
            {
                MessageBox.Show("Lễ tân xoá làm gì? ăn chặn à?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
