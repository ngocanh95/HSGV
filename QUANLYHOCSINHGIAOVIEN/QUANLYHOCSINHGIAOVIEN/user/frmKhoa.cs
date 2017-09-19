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
    public partial class frmKhoa : UserControl
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        private HSGVDbContext context;
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            dgrKhoa.DataSource = context.tblKHOAs.ToList();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã khoa", "Thông báo");
            }else
            {
                if (context.tblKHOAs.Find(txtKhoa.Text.Trim()) != null){
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo");
                }else
                {
                    tblKHOA k = new tblKHOA();
                    k.MaKhoa = txtKhoa.Text;
                    k.TenKhoa = txtTenKhoa.Text;
                    KHOAF f = new KHOAF();
                    f.Insert(k);
                    txtKhoa.Clear();
                    txtTenKhoa.Clear();
                    this.tblKHOATableAdapter1.Fill(this.quanlydiemDataSet9.tblKHOA);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtKhoa.Text.Trim();
            if (MessageBox.Show(string.Format("Xóa khoa có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblKHOA k = new tblKHOA();
                k.MaKhoa = txtKhoa.Text;
                k.TenKhoa = txtTenKhoa.Text;
                KHOAF f = new KHOAF();
                f.Delete(k);
                txtKhoa.Clear();
                txtTenKhoa.Clear();
                this.tblKHOATableAdapter1.Fill(this.quanlydiemDataSet9.tblKHOA);
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtKhoa.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa khoa có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblKHOA k = new tblKHOA();
                k.MaKhoa = txtKhoa.Text;
                k.TenKhoa = txtTenKhoa.Text;
                KHOAF f = new KHOAF();
                f.Update(k);
                this.tblKHOATableAdapter1.Fill(this.quanlydiemDataSet9.tblKHOA);
            }
                
        }

       
        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtKhoa.Enabled = true;
            txtKhoa.Clear();
            txtTenKhoa.Clear();
        }

        private void dgrKhoa_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrKhoa.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgrKhoa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtKhoa.Enabled = false;
            txtKhoa.Text = dgrKhoa.CurrentRow.Cells[1].Value.ToString();
            txtTenKhoa.Text = dgrKhoa.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
