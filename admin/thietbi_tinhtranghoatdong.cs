using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.admin
{
    public partial class thietbi_tinhtranghoatdong : Form
    {
        public thietbi_tinhtranghoatdong()
        {
            InitializeComponent();
        }
        SqlCommand command = null;
        SqlConnection sqlcon = null;
        sql_commands classConnect = new sql_commands();

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

        private void thietbi_tinhtranghoatdong_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sqlcon = classConnect.getConnect();
            OpenConnection();
            if (sqlcon.State == ConnectionState.Open)
            {
                // Kết nối thành công, tiếp tục thực hiện truy vấn.
                SqlDataAdapter adapter;
                string sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, tinhtrang_thietbi, trangthai_thietbi, qrcode_thietbi, noidat " +
                    "FROM thietbi";

                adapter = new SqlDataAdapter(sql_q1, sqlcon);
                adapter.Fill(dt);
                ds_thietbi.DataSource = dt;
                DataGridViewTextBoxColumn dateColumn = (DataGridViewTextBoxColumn)ds_thietbi.Columns["thietbi"]; // Thay "YourDateColumnName" bằng tên thực của cột ngày
                ds_thietbi.Columns[0].HeaderText = "ID thiết bị";
                ds_thietbi.Columns[1].HeaderText = "Tên thiết bị";
                ds_thietbi.Columns[2].HeaderText = "Model thiết bị";
                ds_thietbi.Columns[3].HeaderText = "Tình trạng";
                ds_thietbi.Columns[4].HeaderText = "Trạng Thái";
                ds_thietbi.Columns[5].Visible = false;
                ds_thietbi.Columns[6].Visible = false;
                ds_thietbi.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                ds_thietbi.EnableHeadersVisualStyles = false;
                ds_thietbi.ColumnHeadersHeight = 40;
                ds_thietbi.ColumnHeadersVisible = true;
                ds_thietbi.AllowUserToResizeColumns = false;
                ds_thietbi.AllowUserToResizeRows = false;
                foreach (DataGridViewColumn column in ds_thietbi.Columns)
                {
                    column.ReadOnly = true; // Chặn tất cả các cột
                }

                

            }
        }

        private void ds_thietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo là hàng hợp lệ
            {
                DataGridViewRow row = ds_thietbi.Rows[e.RowIndex];

                // Giả sử bạn có các TextBox với tên textBox1, textBox2, ...
                tb_hien_id.Text = row.Cells["id_thietbi"].Value.ToString();
                tb_hien_ten.Text = row.Cells["ten_thietbi"].Value.ToString();
                tb_hien_model.Text = row.Cells["model_thietbi"].Value.ToString();
                tb_hien_noidat.Text = row.Cells["noidat"].Value.ToString();
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


                if (row.Cells["trangthai_thietbi"].Value.ToString().Equals("Online"))
                {
                    offline_thietbi.Visible = false;
                    online_thietbi.Visible = true;
                    gunaLabel6.Text = "Online";
                }
                else
                {
                    online_thietbi.Visible = false;
                    offline_thietbi.Visible = true;
                    gunaLabel6.Text = "Offline";
                }
                if (row.Cells["tinhtrang_thietbi"].Value.ToString().Equals("Hoạt động"))
                {
                    error_thietbi.Visible = false;
                    active_thietbi.Visible = true;
                }
                else
                {
                    active_thietbi.Visible = false;
                    if (row.Cells["tinhtrang_thietbi"].Value.ToString().Equals("Tắt"))
                    {
                        error_thietbi.Visible = true;
                        active_thietbi.Visible = false;
                    }
                    else
                    {
                        error_thietbi.Visible = true;
                        error_thietbi.Text = row.Cells["tinhtrang_thietbi"].Value.ToString();
                        active_thietbi.Visible = false;
                    } 
                    
                }

                }
                // Thêm các TextBox khác tương ứng với các cột khác
               
                
            
        }
        

        private void dstb_qrtb_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {

        }

        private void tb_hien_id_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_sua_taoQR_Click(object sender, EventArgs e)
        {

        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void tinhtrang_luu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE thietbi " +
               "SET trangthai_thietbi = @trangthai, " +
               "tinhtrang_thietbi = @tinhtrang " +
               "WHERE id_thietbi = @id";

            SqlCommand command = new SqlCommand(query, sqlcon);

            // Thêm tham số @id
            command.Parameters.AddWithValue("@id", tb_hien_id.Text);

            // Thêm tham số @tinhtrang
            if (switchTinhtrang_thietbi.Checked)
            {
                command.Parameters.AddWithValue("@tinhtrang", "Hoạt động");
                
            }
            else
            {
               if (maloi_thietbi != null)
                {
                    command.Parameters.AddWithValue("@tinhtrang", maloi_thietbi.Text);
                } 
                else
                {
                    command.Parameters.AddWithValue("@tinhtrang", "Tắt");
                }

            }

            // Thêm tham số @trangthai
            if (switchNet_thietbi.Checked)
            {
                command.Parameters.AddWithValue("@trangthai", "Online");
                
            }
            else
            {
                command.Parameters.AddWithValue("@trangthai", "Offline");
               
            }

            OpenConnection();
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không cập nhật được dữ liệu."+tb_hien_id.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void LoadData()
        {
            string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;
                            Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                string query = "SELECT id_thietbi, ten_thietbi, model_thietbi, tinhtrang_thietbi, trangthai_thietbi, qrcode_thietbi, noidat " +
                    "FROM thietbi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                ds_thietbi.DataSource = dataTable;
            }
        }


        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void switchTinhtrang_thietbi_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTinhtrang_thietbi.Checked)
            {
                maloi_thietbi.Enabled = false;
                

            }
            else
            {
                maloi_thietbi.Enabled = true;
            }

        }
    }
}
