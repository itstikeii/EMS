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
    public partial class danhmucthietbi_form : Form
    {
        public danhmucthietbi_form()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlcon = null;
        SqlCommand command = null;
        private void danhmucthietbi_form_Load(object sender, EventArgs e)
        {

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
    }
}
