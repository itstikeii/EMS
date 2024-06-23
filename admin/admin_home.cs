using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.admin
{
    public partial class admin_home : Form
    {
        bool slidebarExpand;
        Form currentFormchild;
        public admin_home()
        {
            InitializeComponent();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            timerSlidebar.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timeSlidebar(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slideBar_layout.Width -= 10;
                if (slideBar_layout.Width == slideBar_layout.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    timerSlidebar.Stop();
                }
            }
            else
            {
                slideBar_layout.Width += 10;
                if (slideBar_layout.Width == slideBar_layout.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    timerSlidebar.Stop();
                }
            }
        }

        private void danhmuc_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new admin.danhmucthietbi_form());
        }

        private void lichsu_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void tinhtrang_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new admin.thietbi_tinhtranghoatdong());
        }

        private void baotri_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new admin.thietbi_baotrisuachua());
        }
    }
}
