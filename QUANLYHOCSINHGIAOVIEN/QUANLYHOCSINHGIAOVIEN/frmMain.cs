using QUANLYHOCSINHGIAOVIEN.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINHGIAOVIEN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void LoadUserControl(Control ctrl)
        {
            if (!panel_main.Controls.Contains(ctrl))
            {
                panel_main.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Fill;
            }
            ctrl.BringToFront();


        }
        private void btl1_Click(object sender, EventArgs e)
        {
            frmQLSV f = new frmQLSV();
            LoadUserControl(f);
        }

       

        private void btl2_Click(object sender, EventArgs e)
        {
            frmGiangVien f = new frmGiangVien();
            LoadUserControl(f);
        }

        private void btl3_Click(object sender, EventArgs e)
        {
           
            frmQLDiem f = new frmQLDiem();
            LoadUserControl(f);
        }

        private void btl4_Click(object sender, EventArgs e)
        {
           
            frmKhoa f = new frmKhoa();
            LoadUserControl(f);
         
        }

        private void btl5_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            LoadUserControl(f);
        }

        private void btl6_Click(object sender, EventArgs e)
        {
            
            frmMonhoc f = new frmMonhoc();
            LoadUserControl(f);
           
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void linkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }
    }
}
