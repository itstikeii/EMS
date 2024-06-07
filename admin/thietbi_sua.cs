using Guna.UI.WinForms;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.admin
{
    public partial class thietbi_sua : Form
    {
        public thietbi_sua()
        {
            InitializeComponent();
        }
        string id;
        public void funData(string txtForm1) { id = txtForm1; }
        public delegate void delPassData(string text);


        string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlcon = null;
        SqlCommand command = null;
        sql_commands classConnect = new sql_commands();
        private void OpenConnection()
        {
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
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(conStr);
            }
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }

        private byte[] ImageToByteArray(GunaPictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                throw new ArgumentNullException("Image", "PictureBox does not contain an image.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void tb_them_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_sua_luu_Click(object sender, EventArgs e)
        {
            DateTime ngaymua = tb_sua_ngaymua.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngaymuafx = new DateTime(ngaymua.Year, ngaymua.Month, ngaymua.Day);

            DateTime ngayhhbh = tb_sua_nhhbh.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngayhhbhfx = new DateTime(ngayhhbh.Year, ngayhhbh.Month, ngayhhbh.Day);

            byte[] imageBytes = ImageToByteArray(tb_sua_qrcode);

            // Thêm tham số hình ảnh vào lệnh SQL
            string query = "UPDATE thietbi " +
                           "SET ten_thietbi = @ten, " +
                           "loai_thietbi = @loai, " +
                           "chucnang_thietbi = @chucnang, " +
                           "model_thietbi = @model, " +
                           "mota_thietbi = @mota, " +
                           "nhacungcap_thietbi = @ncc, " +
                           "ngaymua_thietbi = @ngaymua, " +
                           "giathue_thietbi = @gia, " +
                           "tinhtrang_thietbi = @tinhtrang, " +
                           "soluong_thietbi = @soluong, " +
                           "ngayhetbaohanh_thietbi = @ngayhetbaohanh, " +
                           "noidat = @noidat, " +
                           "qrcode_thietbi = @qr " +
                           "WHERE id_thietbi = @id";

            SqlCommand command = new SqlCommand(query, sqlcon);

            // Thêm các tham số vào lệnh SQL
            command.Parameters.AddWithValue("@id", id.ToString());
            command.Parameters.AddWithValue("@ten", tb_sua_ten.Text);
            command.Parameters.AddWithValue("@loai", tb_sua_loai.Text);
            command.Parameters.AddWithValue("@chucnang", tb_sua_chucnang.Text);
            command.Parameters.AddWithValue("@model", tb_sua_model.Text);
            command.Parameters.AddWithValue("@mota", tb_sua_mota.Text);
            command.Parameters.AddWithValue("@ncc", tb_sua_ncc.Text);
            command.Parameters.AddWithValue("@ngaymua", ngaymuafx); // Đảm bảo định dạng ngày tháng phù hợp
            command.Parameters.AddWithValue("@gia", decimal.Parse(tb_sua_gia.Text)); // Chuyển đổi sang kiểu dữ liệu phù hợp nếu cần
            command.Parameters.AddWithValue("@tinhtrang", tb_sua_tinhtrang.Text);
            command.Parameters.AddWithValue("@soluong", int.Parse(tb_sua_soluong.Text)); // Chuyển đổi sang kiểu dữ liệu phù hợp nếu cần
            command.Parameters.AddWithValue("@ngayhetbaohanh", ngayhhbhfx); // Đảm bảo định dạng ngày tháng phù hợp
            command.Parameters.AddWithValue("@noidat", tb_sua_noidat.Text);
            command.Parameters.AddWithValue("@qr", imageBytes);

            OpenConnection();
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Không cập nhật được dữ liệu.");
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

        private void tb_sua_huy_Click(object sender, EventArgs e)
        {
            tb_sua_id.Text = "";
            tb_sua_mota.Text = "";
            tb_sua_noidat.Text = "";
            tb_sua_chucnang.Text = "";
            tb_sua_loai.Text = "";
            tb_sua_soluong.Text = "";
            tb_sua_tinhtrang.Text = "";
            tb_sua_gia.Text = "";
            tb_sua_ncc.Text = "";
            tb_sua_serial.Text = "";
            tb_sua_model.Text = "";
            tb_sua_ten.Text = "";
        }

        private void tb_sua_taoQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData qrData = qr.CreateQrCode(tb_sua_id.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            tb_sua_qrcode.Image = qrCodeImage;
        }

        private void thietbi_sua_Load(object sender, EventArgs e)
        {
            sqlcon = classConnect.getConnect();
            OpenConnection();

            string sql_q1 = "SELECT * FROM thietbi WHERE id_thietbi = '" + id.ToString() + "'";
            SqlCommand command1 = new SqlCommand(sql_q1, sqlcon);
            // Sử dụng tham số thay vì nối chuỗi
            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                tb_sua_id.Text = reader["id_thietbi"].ToString();
                tb_sua_ten.Text = reader["ten_thietbi"].ToString();
                tb_sua_loai.Text = reader["loai_thietbi"].ToString();
                tb_sua_chucnang.Text = reader["chucnang_thietbi"].ToString();
                tb_sua_model.Text = reader["model_thietbi"].ToString();
                tb_sua_mota.Text = reader["mota_thietbi"].ToString();
                tb_sua_ncc.Text = reader["nhacungcap_thietbi"].ToString();
                tb_sua_gia.Text = reader["giathue_thietbi"].ToString();
                tb_sua_soluong.Text = reader["soluong_thietbi"].ToString();
                tb_sua_noidat.Text = reader["noidat"].ToString();

                // Xử lý DateTime nếu cần
                if (reader["ngaymua_thietbi"] != DBNull.Value)
                {
                    tb_sua_ngaymua.Value = (DateTime)reader["ngaymua_thietbi"];
                }
                if (reader["ngayhetbaohanh_thietbi"] != DBNull.Value)
                {
                    tb_sua_nhhbh.Value = (DateTime)reader["ngayhetbaohanh_thietbi"];
                }



                // Hiển thị hình ảnh QR code nếu có
                if (reader["qrcode_thietbi"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["qrcode_thietbi"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        tb_sua_qrcode.Image = Image.FromStream(ms);
                    }
                }
            }

            reader.Close();
            CloseConnection();
        }

        private void tb_sua_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
