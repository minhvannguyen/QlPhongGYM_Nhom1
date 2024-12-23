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
    public partial class Form_QL_NhanSu : Form
    {
        public Form_QL_NhanSu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_DK_TK_NhanSu Form_Them = new Form_DK_TK_NhanSu();
            Form_Them.Show();
            
        }

        private void Form_QL_NhanSu_Load(object sender, EventArgs e)
        {
            dsNhanSu();
        }
        private void dsNhanSu()
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
                da.SelectCommand.CommandText = "datagridview";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                dataGridView1.Columns[0].Width = 160;
                dataGridView1.Columns[0].HeaderText = "Họ Tên NV";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nhân Viên ID";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Năm sinh";
                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[3].HeaderText = "Chức vụ";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Quê quán";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dsPT()
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
                da.SelectCommand.CommandText = "datagridviewPT";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                dataGridView1.Columns[0].Width = 160;
                dataGridView1.Columns[0].HeaderText = "Họ Tên NV";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nhân Viên ID";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Năm sinh";
                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[3].HeaderText = "Chức vụ";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Chuyên môn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PerformButtonClick()
        {
            bt_dsPT.PerformClick();
        }

        private void bt_dsNhanSu_Click(object sender, EventArgs e)
        {
            dsNhanSu();
        }
        
        private void bt_dsPT_Click(object sender, EventArgs e)
        {
            dsPT();
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
            string nvID = Convert.ToString(row.Cells["NhanVienID"].Value);
            Form_ChiTiet_TK_NhanSu Form_ChiTiet = new Form_ChiTiet_TK_NhanSu(nvID);
            Form_ChiTiet.Show();
            Form_ChiTiet.Owner = this;
            }
         
        }

        
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
