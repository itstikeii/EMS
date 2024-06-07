using Guna.UI.WinForms;
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class thietbi_chitiet : Form
    {
        public thietbi_chitiet()
        {
            InitializeComponent();
        }
        string id;
        public void funData(string txtForm1) { id =txtForm1; }
        public delegate void delPassData(string text);
        SqlConnection sqlcon = null;
        sql_commands classConnect = new sql_commands();
        SqlCommand command = null;
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

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

  
        private void thietbi_chitiet_Load(object sender, EventArgs e)
        {
            gunaLabel2.Equals(id.ToString());
            sqlcon = classConnect.getConnect();
            OpenConnection();

            string sql_q1 = "SELECT * FROM thietbi WHERE id_thietbi = '"+id.ToString()+"'";
            SqlCommand command1 = new SqlCommand(sql_q1, sqlcon);
           // Sử dụng tham số thay vì nối chuỗi
            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                tb_hien_id.Text = reader["id_thietbi"].ToString();
                tb_hien_ten.Text = reader["ten_thietbi"].ToString();
                tb_hien_loai.Text = reader["loai_thietbi"].ToString();
                tb_hien_chucnang.Text = reader["chucnang_thietbi"].ToString();
                tb_hien_model.Text = reader["model_thietbi"].ToString();
                tb_hien_mota.Text = reader["mota_thietbi"].ToString();
                tb_hien_ncc.Text = reader["nhacungcap_thietbi"].ToString();
                tb_hien_gia.Text = reader["giathue_thietbi"].ToString();
                tb_hien_soluong.Text = reader["soluong_thietbi"].ToString();
                tb_hien_noidat.Text = reader["noidat"].ToString();

                // Xử lý DateTime nếu cần
                if (reader["ngaymua_thietbi"] != DBNull.Value)
                {
                    tb_hien_ngaymua.Value = (DateTime)reader["ngaymua_thietbi"];
                }
                if (reader["ngayhetbaohanh_thietbi"] != DBNull.Value)
                {
                    tb_hien_nhhbh.Value = (DateTime)reader["ngayhetbaohanh_thietbi"];
                }

               

                // Hiển thị hình ảnh QR code nếu có
                if (reader["qrcode_thietbi"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["qrcode_thietbi"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        tb_hien_qrcode.Image = Image.FromStream(ms);
                    }
                }
            }

            reader.Close();
            CloseConnection();
        }

        private void cttb_chinhsua_Click(object sender, EventArgs e)
        {
            string id = tb_hien_id.Text;
            thietbi_sua next = new thietbi_sua();
            delPassData del = new delPassData(next.funData);
            del(id);
            next.Show();
        }

        private void cttb_xoa_Click(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@id", tb_hien_id.Text);
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
            }
        }
    }
    }

