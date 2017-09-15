
using QUANLYHOCSINHGIAOVIEN.EF;
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

namespace QUANLYHOCSINHGIAOVIEN
{
    public partial class frmDangNhap : Form
    {
        private HSGVDbContext context;
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            if(context.tblLOGINs.Where(x=>x.TenDN==txtTenDN.Text && x.MatKhau == txtMatKhau.Text).SingleOrDefault() == null)
            {
                MessageBox.Show("Tài khoản không đúng", "Thông báo");
            }
            else
            {
                DialogResult = MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OKCancel);
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

    }
