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
    public partial class frmMonhoc : UserControl
    {
        private static frmMonhoc _instance;
        public frmMonhoc()
        {
            InitializeComponent();
        }

        public static frmMonhoc Instance
        {
            get
            {
                _instance = new frmMonhoc();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
        private HSGVDbContext context;
        private void loadkhoa()
        {
            List<tblKHOA> list = new List<tblKHOA>();
            list = context.tblKHOAs.ToList();
            cboKhoa.DataSource = list;
            cboKhoa.DisplayMember = "MaKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }
        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            dgrMON.DataSource = context.tblMONs.ToList();
            loadkhoa();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp chưa nhập", "Thông báo");

            }
            else
            {
                if (context.tblMONs.Find(txtMaMon.Text) != null)
                {
                    MessageBox.Show("Mã môn đã tồn tại", "Thông báo");
                }else
                {
                    tblMON m = new tblMON();
                    m.TenMon = txtTenMon.Text;
                    m.SoDVHT = Convert.ToInt32(numsdvht.Text);
                    m.MaMon = txtMaMon.Text;
                    m.MaKhoa = cboKhoa.Text;
                    m.HocKi = txtHocKy.Text;
                    MONHOCF mh = new MONHOCF();
                    mh.Insert(m);
                    dgrMON.DataSource = context.tblMONs.ToList();
                    txtHocKy.Clear();
                    txtMaMon.Clear();
                    numsdvht.Value = 0;
                    txtTenMon.Clear();
                    cboKhoa.Text = "";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtMaMon.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa môn học có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblMON m = new tblMON();
                m.TenMon = txtTenMon.Text;
                m.SoDVHT = Convert.ToInt32(numsdvht.Text);
                m.MaMon = txtMaMon.Text;
                m.MaKhoa = cboKhoa.Text;
                m.HocKi = txtHocKy.Text;
                MONHOCF mh = new MONHOCF();
                mh.Update(m);
                dgrMON.DataSource = context.tblMONs.ToList();
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtMaMon.Text.Trim();
            if (MessageBox.Show(string.Format("Xóa môn học có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblMON m = new tblMON();
                m.TenMon = txtTenMon.Text;
                m.SoDVHT = Convert.ToInt32(numsdvht.Text);
                m.MaMon = txtMaMon.Text;
                m.MaKhoa = cboKhoa.Text;
                m.HocKi = txtHocKy.Text;
                MONHOCF mh = new MONHOCF();
                mh.Delete(m);
                dgrMON.DataSource = context.tblMONs.ToList();
                txtHocKy.Clear();
                txtMaMon.Clear();
                numsdvht.Value = 0;
                txtTenMon.Clear();
                cboKhoa.Text = "";
            }
                
        }

        
        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtMaMon.Enabled = true;
            txtHocKy.Text = "";
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            cboKhoa.Text = "";
            numsdvht.Value = 0;
        }

        private void dgrMON_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Enabled = false;
            txtHocKy.Text = dgrMON.CurrentRow.Cells["HocKi"].Value.ToString();
            txtMaMon.Text = dgrMON.CurrentRow.Cells["MaMon"].Value.ToString();
            numsdvht.Text = dgrMON.CurrentRow.Cells["SoDVHT"].Value.ToString();
            txtTenMon.Text = dgrMON.CurrentRow.Cells["TenMon"].Value.ToString();
            cboKhoa.Text = dgrMON.CurrentRow.Cells["MaKhoa"].Value.ToString();
        }

        private void dgrMON_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrMON.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
