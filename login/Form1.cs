using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void login_login_Click(object sender, EventArgs e)
        {
            admin.admin_home f1 = new admin.admin_home();
            this.Hide();
            f1.FormClosed += SecondForm_FormClosed; // Lắng nghe sự kiện FormClosed
            f1.Show();
        }
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hiển thị lại MainForm khi SecondForm đóng
            this.Show();
        }
    }
}
