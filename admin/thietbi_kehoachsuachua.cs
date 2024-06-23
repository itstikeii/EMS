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
using System.Windows.Input;

namespace EMS.admin
{
    public partial class thietbi_kehoachsuachua : Form
    {
        public thietbi_kehoachsuachua()
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
        private void tb_suachua_luu_Click(object sender, EventArgs e)
        {
            OpenConnection();
            DateTime ngaymua = tb_suachua_ngaydukien.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngaydukienfx = new DateTime(ngaymua.Year, ngaymua.Month, ngaymua.Day);

            DateTime ngaylen = tb_suachua_ngaylenKH.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngaylenfx = new DateTime(ngaylen.Year, ngaylen.Month, ngaylen.Day);

            string query = "INSERT INTO suachua (id_sua, id_thietbi, ngaylenkehoach_sua, ngaythuchien_sua, sukien_sua, loaisukien_sua, trangthaikehoach_sua) " +
                           "VALUES (@id_sua, @id, @ngaylen, @ngay, @sukien, @loaisua, @tt_kh)";
            command = new SqlCommand(query, sqlcon);
            // Thêm các tham số vào lệnh SQL

            command.Parameters.AddWithValue("@id_sua", tb_suachua_idKehoach.Text);
            command.Parameters.AddWithValue("@id", tb_suachua_id.Text);
            command.Parameters.AddWithValue("@ngaylen", ngaylenfx);
            command.Parameters.AddWithValue("@ngay", ngaydukienfx);
            command.Parameters.AddWithValue("@sukien", tb_suachua_mota.Text);
            command.Parameters.AddWithValue("@loaisua", tb_suachua_loai.Text);
            command.Parameters.AddWithValue("@tt_kh", "Chưa thực hiện");
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lên lịch thành công!");
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

        }

        private void thietbi_kehoachsuachua_Load(object sender, EventArgs e)
        {
            tb_suachua_id.Text = id.ToString();
        }
    }
}
