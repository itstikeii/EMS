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
    public partial class thietbi_baotrisuachua : Form
    {
        public thietbi_baotrisuachua()
        {
            InitializeComponent();
            LoadData();
        }

        SqlCommand command = null;
        SqlConnection sqlcon = null;
        sql_commands classConnect = new sql_commands();
        string id;
        public void funData(string txtForm1) { id = txtForm1; }
        public delegate void delPassData(string text);

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


        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void thietbi_baotrisuachua_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            sqlcon = classConnect.getConnect();
            OpenConnection();
            if (sqlcon.State == ConnectionState.Open)
            {
                //-------------- data source cho tab Danh sách thiết bị ------------------------
                         // Kết nối thành công, tiếp tục thực hiện truy vấn.
                SqlDataAdapter adapter;
                string sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, tinhtrang_thietbi, trangthai_thietbi, qrcode_thietbi, noidat " +
                    "FROM thietbi WHERE tinhtrang_thietbi NOT Like '%H%'";
                adapter = new SqlDataAdapter(sql_q1, sqlcon);
                adapter.Fill(dt);
                ds_thietbi.DataSource = dt;
                DataGridViewTextBoxColumn dateColumn = (DataGridViewTextBoxColumn)ds_thietbi.Columns["thietbi"];
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
                //------------------------------------------------------------------------------
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1;
                string sql_q2 = "SELECT * FROM suachua";
                adapter1 = new SqlDataAdapter(sql_q2, sqlcon);
                adapter1.Fill(dt1);
                sc_danhsach.DataSource = dt1;
                DataGridViewTextBoxColumn dateColumn1 = (DataGridViewTextBoxColumn)sc_danhsach.Columns["suachua"];
                sc_danhsach.Columns[0].HeaderText = "ID Kế Hoạch";
                sc_danhsach.Columns[1].HeaderText = "ID Thiết bị";
                sc_danhsach.Columns[2].HeaderText = "Ngày dự kiến thực hiện";
                sc_danhsach.Columns[3].HeaderText = "Mô tả";
                sc_danhsach.Columns[4].HeaderText = "Loại";
                sc_danhsach.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                sc_danhsach.EnableHeadersVisualStyles = false;
                sc_danhsach.ColumnHeadersHeight = 40;
                sc_danhsach.ColumnHeadersVisible = true;
                sc_danhsach.AllowUserToResizeColumns = false;
                sc_danhsach.AllowUserToResizeRows = false;
                foreach (DataGridViewColumn column in ds_thietbi.Columns)
                {
                    column.ReadOnly = true; // Chặn tất cả các cột
                }
            }

        }

        private void LoadData()
        {

            DataTable dt = new DataTable();
            sqlcon = classConnect.getConnect();
            OpenConnection();
            if (sqlcon.State == ConnectionState.Open)
            {
                //-------------- data source cho tab Danh sách thiết bị ------------------------
                // Kết nối thành công, tiếp tục thực hiện truy vấn.
                SqlDataAdapter adapter;
                string sql_q1 = "SELECT id_thietbi, ten_thietbi, model_thietbi, tinhtrang_thietbi, trangthai_thietbi, qrcode_thietbi, noidat " +
                    "FROM thietbi WHERE tinhtrang_thietbi NOT Like '%H%'";
                adapter = new SqlDataAdapter(sql_q1, sqlcon);
                adapter.Fill(dt);
                ds_thietbi.DataSource = dt;
                DataGridViewTextBoxColumn dateColumn = (DataGridViewTextBoxColumn)ds_thietbi.Columns["thietbi"];
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
                //------------------------------------------------------------------------------
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1;
                string sql_q2 = "SELECT * FROM suachua";
                adapter1 = new SqlDataAdapter(sql_q2, sqlcon);
                adapter1.Fill(dt1);
                sc_danhsach.DataSource = dt1;
                DataGridViewTextBoxColumn dateColumn1 = (DataGridViewTextBoxColumn)sc_danhsach.Columns["suachua"];
                sc_danhsach.Columns[0].HeaderText = "ID Kế Hoạch";
                sc_danhsach.Columns[1].HeaderText = "ID Thiết bị";
                sc_danhsach.Columns[2].HeaderText = "Ngày dự kiến thực hiện";
                sc_danhsach.Columns[3].HeaderText = "Mô tả";
                sc_danhsach.Columns[4].HeaderText = "Loại";
                sc_danhsach.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                sc_danhsach.EnableHeadersVisualStyles = false;
                sc_danhsach.ColumnHeadersHeight = 40;
                sc_danhsach.ColumnHeadersVisible = true;
                sc_danhsach.AllowUserToResizeColumns = false;
                sc_danhsach.AllowUserToResizeRows = false;
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
                if (row.Cells["tinhtrang_thietbi"].Value.ToString() != "Hoạt động")
                {

                }
                thietbi_maloi.Text = row.Cells["tinhtrang_thietbi"].Value.ToString();
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
            // Thêm các TextBox khác tương ứng với các cột khác
        }


        private void dstb_chinhsua_Click(object sender, EventArgs e)
        {
            string id = tb_hien_id.Text;
            thietbi_kehoachsuachua next = new thietbi_kehoachsuachua();
            delPassData del = new delPassData(next.funData);
            del(id);
            next.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tinhtrang_huy_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = MessageBox.Show(
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
                    string CmdString = "DELETE FROM suachua WHERE id_sua = @id";
                    command = new SqlCommand(CmdString, sqlcon);
                    command.Parameters.AddWithValue("@id", tb_suachua_id.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");

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
            }*/
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo là hàng hợp lệ
            {
                DataGridViewRow row = sc_danhsach.Rows[e.RowIndex];
                // Giả sử bạn có các TextBox với tên textBox1, textBox2, ...
                kehoach_id.Text = row.Cells["id_sua"].Value.ToString();
                kehoach_thietbi_id.Text = row.Cells["id_thietbi"].Value.ToString();
                kehoach_ngaylen.Text = row.Cells["ngaylenkehoach_sua"].Value.ToString();
                kehoach_ngaydukien.Text = row.Cells["ngaythuchien_sua"].Value.ToString();
                kehoach_mota.Text = row.Cells["sukien_sua"].Value.ToString();
                tb_suachua_trangthai.Text = row.Cells["trangthaikehoach_sua"].Value.ToString();
            }
        }

        private void tinhtrang_luu_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO chitietsua (id_chitietsua) " +
              "VALUES (@id_chitietsua)";
            command = new SqlCommand(query, sqlcon);
            // Thêm các tham số vào lệnh SQL
            command.Parameters.AddWithValue("@id_chitietsua", kehoach_id.Text);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Khởi tạo thành công");
                    CloseConnection();
                }
                else
                {
                    MessageBox.Show("Đã xãy ra lỗi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string id = kehoach_id.Text;
            kehoach_thuchien next = new kehoach_thuchien();
            delPassData del = new delPassData(next.funData);
            del(id); // gửi đi
            this.Hide();
            next.FormClosed += this.SecondForm_FormClosed; // Lắng nghe sự kiện FormClosed
            next.Show();
        }
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hiển thị lại MainForm khi SecondForm đóng
            this.Show();
            LoadData(); // Làm mới dữ liệu
        }

        private void tb_suachua_chitietKH_Click(object sender, EventArgs e)
        {
            string id = kehoach_id.Text;
            kehoach_chitiet next = new kehoach_chitiet();
            delPassData del = new delPassData(next.funData);
            del(id); // gửi đi
            this.Hide();
            next.FormClosed += SecondForm_FormClosed; // Lắng nghe sự kiện FormClosed
            next.Show();
        }


        private void kehoach_capnhat_Click(object sender, EventArgs e)
        {
            string id = kehoach_id.Text;
            kehoach_capnhat next = new kehoach_capnhat();
            delPassData del = new delPassData(next.funData);
            del(id); // gửi đi
            this.Hide();
            next.FormClosed += SecondForm_FormClosed; // Lắng nghe sự kiện FormClosed
            next.Show();
        }

        private void kehoach_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
