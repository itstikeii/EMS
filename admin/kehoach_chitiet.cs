using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.admin
{
    public partial class kehoach_chitiet : Form
    {
        public kehoach_chitiet()
        {
            InitializeComponent();
        }

        string id;
        public void funData(string txtForm1) { id = txtForm1; }
        public delegate void delPassData(string text);

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

        private void tb_suachua_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kehoach_chitiet_Load(object sender, EventArgs e)
        {
            OpenConnection();
            tb_suachua_idKehoach.Text = id.ToString();
            string sql_q1 = "SELECT * FROM suachua a, chitietsua b, kythuatvien c WHERE a.id_sua = b.id_sua " +
                "AND  b.id_kythuatvien = c.id_kythuatvien " +
                "AND b.id_chitietsua = '" + id.ToString() + "'";
            SqlCommand command1 = new SqlCommand(sql_q1, sqlcon);
            // Sử dụng tham số thay vì nối chuỗi
            SqlDataReader reader = command1.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    tb_suachua_thietbi_id.Text = reader["id_thietbi"].ToString();
                    tb_suachua_loai.Text = reader["loaisukien_sua"].ToString();
                    tb_suachua_ngaylenKH.Text = reader["ngaylenkehoach_sua"].ToString();
                    tb_suachua_IDKythuat.Text = reader["id_kythuatvien"].ToString();
                    tb_suachua_Tenkythuat.Text = reader["ten_kythuatvien"].ToString();
                    tb_suachua_mota.Text = reader["mota_chitietsua"].ToString();
                    tb_suachua_truoc.Text = reader["trangthaitruoc_chitietsua"].ToString();
                    tb_suachua_sau.Text = reader["trangthaisau_chitietsua"].ToString();
                    tb_trangthaiKH.Text = reader["trangthaikehoach_sua"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close(); // Đảm bảo DataReader được đóng
            }

            loadData_phutung(id.ToString());

        }
        private void loadData_phutung(string id_kehoach)
        {
            DataTable dataTable = new DataTable();
            //-------------- data source cho tab Danh sách thiết bị ------------------------
            // Kết nối thành công, tiếp tục thực hiện truy vấn.
            SqlDataAdapter adapter;
            string sql_q1 = "SELECT b.id_chitietsua, b.id_phutung, a.ten_phutung, SUM(b.soluong_phutung) AS total_soluong_phutung FROM phutungthaythe a, phutung_sudung b " +
                "WHERE a.id_phutung = b.id_phutung AND b.id_chitietsua = '" + id_kehoach.ToString() + "' " +
                "GROUP BY b.id_chitietsua, b.id_phutung, a.ten_phutung; ";
            adapter = new SqlDataAdapter(sql_q1, sqlcon);
            adapter.Fill(dataTable);
            danhsach_phutung.DataSource = dataTable;
            DataGridViewTextBoxColumn dateColumn = (DataGridViewTextBoxColumn)danhsach_phutung.Columns["phutungthaythe"];
            danhsach_phutung.Columns[2].HeaderText = "Tên phụ tùng";
            danhsach_phutung.Columns[3].HeaderText = "Số lượng";
            danhsach_phutung.Columns[0].Visible = false;
            danhsach_phutung.Columns[1].Visible = false;
            danhsach_phutung.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            danhsach_phutung.EnableHeadersVisualStyles = false;
            danhsach_phutung.ColumnHeadersHeight = 40;
            danhsach_phutung.ColumnHeadersVisible = true;
            danhsach_phutung.AllowUserToResizeColumns = false;
            danhsach_phutung.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn column in danhsach_phutung.Columns)
            {
                column.ReadOnly = true; // Chặn tất cả các cột
            }
        }

        private void kehoach_xoa_Click(object sender, EventArgs e)
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
                    string CmdString = "DELETE FROM phutung_sudung WHERE id_chitietsua = @id  " +
                                       "DELETE FROM chitietsua WHERE id_chitietsua = @id ; " +
                                       "DELETE FROM suachua WHERE id_sua = @id ;";
                    command = new SqlCommand(CmdString, sqlcon);
                    command.Parameters.AddWithValue("@id", tb_suachua_idKehoach.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        this.Close();                    }
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

        private void kehoach_capnhat_Click(object sender, EventArgs e)
        {
            string id = tb_suachua_idKehoach.Text;
            kehoach_capnhat next = new kehoach_capnhat();
            delPassData del = new delPassData(next.funData);
            del(id); // gửi đi
            next.Show(); //mở 
        }
    }
}
