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
    public partial class Form_QL_TheTV : Form
    {
        public Form_QL_TheTV()
        {
            InitializeComponent();
            dsthe();
        }
        private void dsthe()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataGrid dtg = new DataGrid();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand("select TheTVID, HoTenKhach, NgayHan, LoaiThe from TheTV", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderText = "Thẻ TV ID";
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[1].HeaderText = "Họ tên khách hàng";
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[2].HeaderText = "Ngày hết hạn";
                dataGridView1.Columns[3].Width = 130;
                dataGridView1.Columns[3].HeaderText = "Loại thẻ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dsthe_Click(object sender, EventArgs e)
        {
            dsthe();
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
                MessageBox.Show("Nhập id thẻ vào thần đằng");
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
                if (row.Cells["TheTVID"].Value != null)
                {
                    string cellValue = row.Cells["TheTVID"].Value.ToString().Trim(); // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
                    Console.WriteLine($"Row {row.Index}: TheTVID = {cellValue}");
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
                    MessageBox.Show("Không tìm thấy Thẻ mày cần!");
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
                string theid = Convert.ToString(row.Cells["TheTVID"].Value);
                Form_ChiTiet_TheTV Form_ChiTiet = new Form_ChiTiet_TheTV(theid);
                Form_ChiTiet.Show();
                Form_ChiTiet.Owner = this;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_TheTV formthe = new Form_ChiTiet_TheTV("");
            formthe.Show();
        }
    }
}
