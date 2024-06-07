using Guna.UI.WinForms;
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.admin
{
    public partial class danhmucthietbi_form : Form
    {
        public danhmucthietbi_form()
        {
            InitializeComponent();
        }
        string id;
        public void funData(string txtForm1) { id = txtForm1; }
        public delegate void delPassData(string text);
        SqlCommand command = null;
        private void OpenConnection()
        {
            string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;
                            Integrated Security=True;TrustServerCertificate=True";
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(conStr);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        private void CloseConnection()
        {
            string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;
                            Integrated Security=True;TrustServerCertificate=True";

            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(conStr);
            }
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }

        SqlConnection sqlcon = null;
        sql_commands classConnect = new sql_commands();
        private void danhmucthietbi_form_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            sqlcon = classConnect.getConnect();
            OpenConnection();
            if (sqlcon.State == ConnectionState.Open)
            {
                // Kết nối thành công, tiếp tục thực hiện truy vấn.
                SqlDataAdapter adapter;
                string sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, soluong_thietbi, tinhtrang_thietbi, ngaymua_thietbi, qrcode_thietbi " +
                    "FROM thietbi";

                adapter = new SqlDataAdapter(sql_q1, sqlcon);
                adapter.Fill(dt);
                ds_thietbi.DataSource = dt;
                DataGridViewTextBoxColumn dateColumn = (DataGridViewTextBoxColumn)ds_thietbi.Columns["thietbi"]; // Thay "YourDateColumnName" bằng tên thực của cột ngày
                ds_thietbi.Columns[0].HeaderText = "ID thiết bị";
                ds_thietbi.Columns[1].HeaderText = "Tên thiết bị";
                ds_thietbi.Columns[2].HeaderText = "Model thiết bị";
                ds_thietbi.Columns[3].HeaderText = "Số lượng";
                ds_thietbi.Columns[4].HeaderText = "Tình trạng";
                ds_thietbi.Columns[5].HeaderText = "Ngày mua";
                ds_thietbi.Columns[6].Visible = false;
                ds_thietbi.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                ds_thietbi.ColumnHeadersVisible = true;
                ds_thietbi.AllowUserToResizeColumns = false;
                ds_thietbi.AllowUserToResizeRows = false;
                foreach (DataGridViewColumn column in ds_thietbi.Columns)
                {
                    column.ReadOnly = true; // Chặn tất cả các cột
                }

            }
           cbx_data();
            
        }


        private void cbx_data()
        {
            List<string> items = new List<string> { "Loại thiết bị", "Chức năng", "Vị trí đặt" };

            // Gán danh sách dữ liệu vào ComboBox
            dstb_pl.DataSource = items;

            // Gán danh sách dữ liệu vào ComboBox

            dstb_pl.DataSource = items;
        }

        

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            admin.thietbi_them them = new admin.thietbi_them();
            them.Show();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ds_thietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo là hàng hợp lệ
            {
                DataGridViewRow row = ds_thietbi.Rows[e.RowIndex];

                // Giả sử bạn có các TextBox với tên textBox1, textBox2, ...
                dstb_id.Text = row.Cells["id_thietbi"].Value.ToString();
                dstb_ten.Text = row.Cells["ten_thietbi"].Value.ToString();
                // Thêm các TextBox khác tương ứng với các cột khác
                byte[] imageData = row.Cells["qrcode_thietbi"].Value as byte[];
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        dstb_qrtb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    dstb_qrtb.Image = null;
                }
            }
        }

        private void LoadData()
        {
            string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;
                            Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                string query = "SELECT id_thietbi, ten_thietbi, ngaymua_thietbi, model_thietbi, soluong_thietbi," +
                    " tinhtrang_thietbi, qrcode_thietbi " +
                    "FROM thietbi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                ds_thietbi.DataSource = dataTable;
            }
        }

        private void dstb_chitiet_Click(object sender, EventArgs e)
        {
            string id = dstb_id.Text;
            thietbi_chitiet next = new thietbi_chitiet();
            delPassData del = new delPassData(next.funData);
            del(id);
            next.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
       

        private void dstb_chinhsua_Click(object sender, EventArgs e)
        {
            string id = dstb_id.Text;
            thietbi_sua next = new thietbi_sua();
            delPassData del = new delPassData(next.funData);
            del(id);
            next.Show();
        }

        private void dstb_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
            "Bạn chắc chắn muốn xóa ?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    OpenConnection();
                    string CmdString = "DELETE FROM thietbi WHERE id_thietbi = @id";
                    command = new SqlCommand(CmdString, sqlcon);
                    command.Parameters.AddWithValue("@id", dstb_id.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được dữ liệu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                    CloseConnection(); // Ensure connection is closed even on errors
                }
                finally
                {
                    CloseConnection(); // Optional: Close connection explicitly if needed outside the catch block
                }
            }
            else
            {
                // Hủy bỏ việc xóa dữ liệu
            }
        }

        private void dstb_lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        

        //-------Phân loại-------------
        String pl_query = "SELECT id_thietbi, ten_thietbi, model_thietbi, soluong_thietbi, tinhtrang_thietbi, ngaymua_thietbi, qrcode_thietbi " +
            "FROM thietbi WHERE ";


        
        private void dstb_phanloai_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sqlcon = classConnect.getConnect();
            string sql_q1 = "";
            OpenConnection();

            if (sqlcon.State == ConnectionState.Open)
            {
                // Kết nối thành công, tiếp tục thực hiện truy vấn.
                SqlDataAdapter adapter;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;

                if (dstb_pl.SelectedValue.Equals("Loại thiết bị"))
                {
                    sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, soluong_thietbi, tinhtrang_thietbi, ngaymua_thietbi, qrcode_thietbi, loai_thietbi " +
                             "FROM thietbi WHERE loai_thietbi = @Keyword";
                    cmd.CommandText = sql_q1;
                    cmd.Parameters.AddWithValue("@Keyword", dstb_pl_tukhoa.Text);
                }
                if (dstb_pl.SelectedValue.Equals("Chức năng"))
                {
                    sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, soluong_thietbi, tinhtrang_thietbi, ngaymua_thietbi, qrcode_thietbi, chucnang_thietbi " +
                             "FROM thietbi WHERE chucnang_thietbi = @Keyword";
                    cmd.CommandText = sql_q1;
                    cmd.Parameters.AddWithValue("@Keyword", dstb_pl_tukhoa.Text);
                }
                if (dstb_pl.SelectedValue.Equals("Vị trí đặt"))
                {
                    sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, soluong_thietbi, tinhtrang_thietbi, ngaymua_thietbi, qrcode_thietbi, noidat " +
                             "FROM thietbi WHERE noidat LIKE '%' + @Keyword + '%'";
                    cmd.CommandText = sql_q1;
                    cmd.Parameters.AddWithValue("@Keyword", dstb_pl_tukhoa.Text);
                }

                gunaLabel6.Text = sql_q1;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                ds_thietbi.DataSource = dt;

                ds_thietbi.Columns[0].HeaderText = "ID thiết bị";
                ds_thietbi.Columns[1].HeaderText = "Tên thiết bị";
                ds_thietbi.Columns[2].HeaderText = "Model thiết bị";
                ds_thietbi.Columns[3].HeaderText = "Số lượng";
                ds_thietbi.Columns[4].HeaderText = "Tình trạng";
                ds_thietbi.Columns[5].HeaderText = "Ngày mua";
                ds_thietbi.Columns[6].Visible = false;
                ds_thietbi.Columns[7].Visible = false;

                ds_thietbi.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                ds_thietbi.ColumnHeadersVisible = true;
                ds_thietbi.AllowUserToResizeColumns = false;
                ds_thietbi.AllowUserToResizeRows = false;

                foreach (DataGridViewColumn column in ds_thietbi.Columns)
                {
                    column.ReadOnly = true; // Chặn tất cả các cột
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
            CloseConnection();


        }

    

        private void dstb_pl_huy_Click(object sender, EventArgs e)
        {

        }

        
    }
}
