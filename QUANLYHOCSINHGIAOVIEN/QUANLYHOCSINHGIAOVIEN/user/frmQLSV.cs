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
    public partial class frmQLSV : UserControl
    {
        private static frmQLSV _instance;
        private HSGVDbContext context;
        public frmQLSV()
        {
            InitializeComponent();
            context = new HSGVDbContext();
        }

        public static frmQLSV Instance
        {
            get
            {
                _instance = new frmQLSV();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
        private void loadMaLop()
        {
            List<tblLOP> list = new List<tblLOP>();
            list = context.tblLOPs.ToList();
            cboMalop.DataSource = list;
            cboMalop.DisplayMember = "MaLop";
            cboMalop.ValueMember = "MaLop";
        }
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            dgrDSSV.DataSource = context.tblSINH_VIEN.ToList();
            context = new HSGVDbContext();
            loadMaLop();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã sinh viên", "Thông báo");
            }
            else
            {
                if (context.tblSINH_VIEN.Find(txtMaSV.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại ", "Thông báo");
                }
                else
                {
                    SINHVIENF f = new SINHVIENF();
                    tblSINH_VIEN g = new tblSINH_VIEN();
                    g.MaSv = txtMaSV.Text;
                    g.HoTen = txtHoTen.Text;
                    g.NgaySinh = dateNgaysinh.Value.ToString();
                    g.DiaChi = txtDiaChi.Text;
                    g.GioiTinh = cboGioiTinh.Text;
                    g.MaLop = cboMalop.Text;
                    f.Insert(g);
                    dgrDSSV.DataSource = context.tblSINH_VIEN.ToList();
                    txtMaSV.Clear();
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                    dateNgaysinh.Text = "";
                    cboGioiTinh.Text = "";
                    cboMalop.Text = "";
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtMaSV.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa sinh viên có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblSINH_VIEN g = new tblSINH_VIEN();
                g.MaSv = txtMaSV.Text;
                g.HoTen = txtHoTen.Text;
                g.NgaySinh = dateNgaysinh.Text;
                g.DiaChi = txtDiaChi.Text;
                g.GioiTinh = cboGioiTinh.Text;
                g.MaLop = cboMalop.Text;
                SINHVIENF f = new SINHVIENF();
                f.Update(g);
                context = new HSGVDbContext();
                dgrDSSV.DataSource = context.tblSINH_VIEN.ToList();
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaSV.Text.Trim();
            if (MessageBox.Show(string.Format("Xóa sinh viên có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblSINH_VIEN g = new tblSINH_VIEN();
                g.MaSv = txtMaSV.Text;

                SINHVIENF f = new SINHVIENF();
                f.Delete(g);
                context = new HSGVDbContext();
                dgrDSSV.DataSource = context.tblSINH_VIEN.ToList();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bd = new BindingSource();
            //bd.DataSource = dgrDSSV.DataSource;
            if (cmbtruongtk.Text == "Mã sinh viên")
            {
                var bd = context.tblSINH_VIEN.Where(x => x.MaSv.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "MaSv like '%" + txttimkiem.Text + "%'";
                dgrDSSV.DataSource = bd;
            }
            if (cmbtruongtk.Text == "Tên sinh viên")
            {
                var bd = context.tblSINH_VIEN.Where(x => x.MaSv.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "HoTen like '%" + txttimkiem.Text + "%'";
                dgrDSSV.DataSource = bd;
            }
            if (cmbtruongtk.Text == "Mã lớp")
            {
                var bd = context.tblSINH_VIEN.Where(x => x.MaSv.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "MaLop like '%" + txttimkiem.Text + "%'";
                dgrDSSV.DataSource = bd;
            }
        }

       

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            dateNgaysinh.Text = "";
            cboGioiTinh.Text = "";
            cboMalop.Text = "";
        }

        private void dgrDSSV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgrDSSV.CurrentRow.Cells["MaSv"].Value.ToString();
            txtHoTen.Text = dgrDSSV.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dgrDSSV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboGioiTinh.Text = dgrDSSV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cboMalop.Text = dgrDSSV.CurrentRow.Cells["MaLop"].Value.ToString();
            dateNgaysinh.Text = dgrDSSV.CurrentRow.Cells["NgaySinh"].Value.ToString();
        }

        private void dgrDSSV_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrDSSV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
