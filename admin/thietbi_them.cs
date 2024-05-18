using Guna.UI.WinForms;
using Guna.UI2.WinForms.Suite;
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
using static System.Net.Mime.MediaTypeNames;

namespace EMS.admin
{
    public partial class thietbi_them : Form
    {
        public thietbi_them()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlcon = null;
        SqlCommand command = null;
        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_them_taoQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData qrData = qr.CreateQrCode(tb_them_id.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);
            tb_them_qrcode.Image = qrCodeImage;

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


        private void tb_them_huy_Click(object sender, EventArgs e)
        {
            tb_them_id.Text = "";
            tb_them_mota.Text = "";
            tb_them_noidat.Text = "";
            tb_them_chucnang.Text = "";
            tb_them_loai.Text = "";
            tb_them_soluong.Text = "";
            tb_them_tinhtrang.Text = "";
            tb_them_gia.Text = "";
            tb_them_ncc.Text = "";
            tb_them_serial.Text = "";
            tb_add_model.Text = "";
            tb_them_ten.Text = "";
        }

        private void thietbi_them_Load(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

       

        private void tb_them_luu_Click(object sender, EventArgs e)
        {

            //Định dạng ngày NGAYMUA
            DateTime ngaymua = tb_them_ngaymua.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngaymuafx = new DateTime(ngaymua.Year, ngaymua.Month, ngaymua.Day);
            //Định dạng ngày NGAYMUA
            DateTime ngayhhbh = tb_them_nhhbh.Value.Date; // Lấy ngày tháng năm cùng với phần thời gian 00:00:00
            DateTime ngayhhbhfx = new DateTime(ngayhhbh.Year, ngayhhbh.Month, ngayhhbh.Day);

            byte[] imageBytes = ImageToByteArray(tb_them_qrcode);

            // Thêm tham số hình ảnh vào lệnh SQL
            

            string query = "INSERT INTO thietbi (id_thietbi, ten_thietbi, loai_thietbi, chucnang_thietbi, model_thietbi, mota_thietbi, nhacungcap_thietbi, ngaymua_thietbi, giathue_thietbi, tinhtrang_thietbi, soluong_thietbi, ngayhetbaothanh_thietbi, noidat, qrcode_thietbi) " +
                           "VALUES (@id, @ten, @loai, @chucnang, @model, @mota, @ncc, @ngaymua, @gia, @tinhtrang, @soluong, @ngayhetbaohanh, @noidat, @qr)";
            command = new SqlCommand(query, sqlcon);
            // Thêm các tham số vào lệnh SQL
            command.Parameters.AddWithValue("@id", tb_them_id.Text);
            command.Parameters.AddWithValue("@ten", tb_them_ten.Text);
            command.Parameters.AddWithValue("@loai", tb_them_loai.Text);
            command.Parameters.AddWithValue("@chucnang", tb_them_chucnang.Text);
            command.Parameters.AddWithValue("@model", tb_add_model.Text);
            command.Parameters.AddWithValue("@mota", tb_them_mota.Text);
            command.Parameters.AddWithValue("@ncc", tb_them_ncc.Text);
            command.Parameters.AddWithValue("@ngaymua", ngaymuafx); // Đảm bảo định dạng ngày tháng phù hợp
            command.Parameters.AddWithValue("@gia", tb_them_gia.Text); // Chuyển đổi sang kiểu dữ liệu phù hợp nếu cần
            command.Parameters.AddWithValue("@tinhtrang", tb_them_tinhtrang.Text);
            command.Parameters.AddWithValue("@soluong", tb_them_soluong.Text); // Chuyển đổi sang kiểu dữ liệu phù hợp nếu cần
            command.Parameters.AddWithValue("@ngayhetbaohanh", ngayhhbh); // Đảm bảo định dạng ngày tháng phù hợp
            command.Parameters.AddWithValue("@noidat", tb_them_noidat.Text);
            // Thêm tham số hình ảnh vào lệnh SQL
            command.Parameters.AddWithValue("@qr", imageBytes);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    CloseConnection();
                }
                else
                {
                    MessageBox.Show("Không thêm được dữ liệu.");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           

        }

        private void tb_them_qrcode_Click(object sender, EventArgs e)
        {

        }
    }
}
