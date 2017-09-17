using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYHOCSINHGIAOVIEN.EF;
using QUANLYHOCSINHGIAOVIEN.FUNCTION;

namespace QUANLYHOCSINHGIAOVIEN.user
{
    public partial class frmGiangVien : UserControl
    {
        private static frmGiangVien _instance;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        public static frmGiangVien Instance
        {
            get
            {
                _instance = new frmGiangVien();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private HSGVDbContext context;
        
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
            txtMaGV.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GIANGVIENF f = new GIANGVIENF();
            tblGIANG_VIEN g = new tblGIANG_VIEN();
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã giảng viên", "Thông báo");
            }
            else
            {
                if (context.tblGIANG_VIEN.Find(txtMaGV.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã giảng viên đã  tồn tại", "Thông báo");
                }
                else
                {
                    g.MaGV = txtMaGV.Text;
                    g.TenGV = txtHoTen.Text;
                    g.Phone = txtPhone.Text;
                    g.NgaySInh = dateNgaySinh.Value;
                    g.PhanLoaiGV = cboPhanloai.Text;
                    g.GioiTinh = cboGioiTinh.Text;
                    g.Email = txtEmail.Text;

                    f.Insert(g);

                    //dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
                    dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
                    txtMaGV.Clear();
                    txtHoTen.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();
                    cboGioiTinh.Text = "";
                    cboPhanloai.Text = "";
                }
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tblGIANG_VIEN g = new tblGIANG_VIEN();
            GIANGVIENF f = new GIANGVIENF();
            string id = txtMaGV.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa giảng viên có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                g.MaGV = txtMaGV.Text;
                g.TenGV = txtHoTen.Text;
                g.Phone = txtPhone.Text;
                g.PhanLoaiGV = cboPhanloai.Text;
                g.NgaySInh = dateNgaySinh.Value;
                g.GioiTinh = cboGioiTinh.Text;
                g.Email = txtEmail.Text;
                f.Update(g);
                // dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
                dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
            }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblGIANG_VIEN g = new tblGIANG_VIEN();
            GIANGVIENF f = new GIANGVIENF();
            string id = txtMaGV.Text.Trim();
            if (MessageBox.Show(string.Format("Xóa giảng viên có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                g.MaGV = txtMaGV.Text;
                g.TenGV = txtHoTen.Text;
                g.Phone = txtPhone.Text;
                g.NgaySInh = dateNgaySinh.Value;
                g.PhanLoaiGV = cboPhanloai.Text;
                g.GioiTinh = cboGioiTinh.Text;
                g.Email = txtEmail.Text;
                f.Delete(g);
                dgrDSGV.DataSource = context.tblGIANG_VIEN.ToList();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

       

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            //BindingSource bd = new BindingSource();
            //bd.DataSource = dgrDSGV.DataSource;
            if (cmbtruongtk.Text == "Mã giảng viên")
            {
                //bd.Filter = "MaGV like '%" + txttimkiem.Text + "%'";
                var bd = context.tblGIANG_VIEN.Where(x => x.MaGV.Contains(txttimkiem.Text)).ToList();
                dgrDSGV.DataSource = bd;
            }
            if (cmbtruongtk.Text == "Tên giảng viên")
            {
                var bd = context.tblGIANG_VIEN.Where(x => x.TenGV.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "TenGV like '%" + txttimkiem.Text + "%'";
                dgrDSGV.DataSource = bd;
            }
            if (cmbtruongtk.Text == "Mã khoa")
            {
                var bd = context.tblGIANG_VIEN.Where(x => x.MaKhoa.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "MaKhoa like '%" + txttimkiem.Text + "%'";
                dgrDSGV.DataSource = bd;
            }
          
        }

        

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            DateTime d = new DateTime();
            
            cboGioiTinh.Text="Nam";
            cboPhanloai.Text="";
            txtMaGV.Enabled = true;
        }

        private void dgrDSGV_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrDSGV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgrDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Enabled = false;
            txtHoTen.Text = dgrDSGV.CurrentRow.Cells["TenGV"].Value.ToString();
            txtMaGV.Text = dgrDSGV.CurrentRow.Cells["MaGV"].Value.ToString();
            txtEmail.Text = dgrDSGV.CurrentRow.Cells["Email"].Value.ToString();
            cboGioiTinh.Text = dgrDSGV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cboPhanloai.Text = dgrDSGV.CurrentRow.Cells["PhanLoaiGV"].Value.ToString();
            txtPhone.Text = dgrDSGV.CurrentRow.Cells["Phone"].Value.ToString();
            try { dateNgaySinh.Text = dgrDSGV.CurrentRow.Cells["NgaySInh"].Value.ToString(); }
            catch (Exception ex) { dateNgaySinh.Text = ""; }
        }
    }
}
