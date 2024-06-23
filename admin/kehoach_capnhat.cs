﻿using System;
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
    public partial class kehoach_capnhat : Form
    {
        public kehoach_capnhat()
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

        private void kehoach_capnhat_Load(object sender, EventArgs e)
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
                    // dữ liệu cho combobox
                    tb_trangthaiKH.Text = reader["trangthaikehoach_sua"].ToString();
                    cbx_data();
                   
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

        private void cbx_data()
        {
            List<string> items = new List<string> { "Chưa thực hiện", "Đang thực hiện", "Đã thực hiện", "Bỏ qua" };

            // Gán danh sách dữ liệu vào ComboBox
            tb_trangthaiKH_up.DataSource = items;

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

        private void tb_suachua_luu_Click(object sender, EventArgs e)
        {
            DateTime ngaythuchien = tb_suachua_ngaythuchien.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngaythuchienfx = new DateTime(ngaythuchien.Year, ngaythuchien.Month, ngaythuchien.Day);

            // Thêm tham số hình ảnh vào lệnh SQL
            string query = "UPDATE chitietsua " +
                "SET id_sua = @id_kh," +
                "ngaysua_chitietsua = @ngaythuchien, " +
                "id_kythuatvien = @id_ktv, " +
                "mota_chitietsua = @mota, " +
                "trangthaitruoc_chitietsua = @tt_truoc, " +  // Thêm dấu phẩy
                "trangthaisau_chitietsua = @tt_sau " +        // Thêm khoảng trắng
                "WHERE id_chitietsua = @id";

            SqlCommand command = new SqlCommand(query, sqlcon);

            // Thêm các tham số vào lệnh SQL
            command.Parameters.AddWithValue("@ngaythuchien", ngaythuchienfx);
            command.Parameters.AddWithValue("@id_ktv", tb_suachua_IDKythuat.Text);
            command.Parameters.AddWithValue("@mota", tb_suachua_mota.Text);
            command.Parameters.AddWithValue("@tt_truoc", tb_suachua_truoc.Text);
            command.Parameters.AddWithValue("@tt_sau", tb_suachua_sau.Text);
            command.Parameters.AddWithValue("@id", id.ToString());
            command.Parameters.AddWithValue("@id_kh", id.ToString());

            string query2 = "UPDATE suachua " +
                "SET trangthaikehoach_sua = @tt_kh " +
                "WHERE id_sua = @id";

            SqlCommand command2 = new SqlCommand(query2, sqlcon);
            command2.Parameters.AddWithValue("@id", id.ToString());
            command2.Parameters.AddWithValue("@tt_kh", tb_trangthaiKH_up.SelectedValue);


            OpenConnection();
            try
            {
                int rowsAffected1 = command.ExecuteNonQuery();
                int rowsAffected2 = command2.ExecuteNonQuery();
                if (rowsAffected1 > 0 && rowsAffected2 > 0)
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Không lưu được dữ liệu.");
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

        private void phutung_sudung_them_Click(object sender, EventArgs e)
        {
            try
            {
                string CmdString2 = "INSERT INTO phutung_sudung(id_chitietsua,id_phutung,soluong_phutung) VALUES (@id,@id_phutung,@soluong)";
                SqlCommand command = new SqlCommand(CmdString2, sqlcon);
                command.Parameters.AddWithValue("@id", id.ToString());
                command.Parameters.AddWithValue("@soluong", phutung_sudung_soluong.Text);
                command.Parameters.AddWithValue("@id_phutung", phutung_sudung_id.Text);
                int RowsAffected2 = command.ExecuteNonQuery();
                if (RowsAffected2 > 0)
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        loadData_phutung(id.ToString());
                        // Đã thêm thành công, làm mới và tải lại dữ liệu
                        this.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
