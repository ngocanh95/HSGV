
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
        private static frmDangNhap _instance;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static frmDangNhap Instance
        {
            get
            {
                _instance = new frmDangNhap();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
        HSGVDbContext context = new HSGVDbContext();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }
            

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu còn trống");
                return;
            }

            else
            {
                var list = context.tblLOGINs.Where(p => p.TenDN == txtTenDN.Text && p.MatKhau == txtMatKhau.Text).ToList();
                if (list.Count == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    txtMatKhau.Clear(); txtTenDN.Clear();
                }
                else
                {
                    DialogResult = MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OKCancel);
                    this.Hide();
                    frmMain ql = new frmMain();
                    ql.ShowDialog();
                }
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }
