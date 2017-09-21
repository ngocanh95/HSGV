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
    public partial class frmLop : UserControl
    {
        public frmLop()
        {
            InitializeComponent();
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
        private void frmLop_Load(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            dgrLop.DataSource = context.tblLOPs.ToList();
            loadkhoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã lớp", "Thông báo");
            }
            else
            {
                if (context.tblLOPs.Find(txtMaLop.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo");
                }
                else
                {
                    tblLOP g = new tblLOP();
                    g.MaLop = txtMaLop.Text;
                    g.MaKhoa = cboKhoa.Text;
                    g.TenLop = txtTenlop.Text;
                    var result = new LOPF().Insert(g);
                    this.tblLOPTableAdapter.Fill(this.quanlydiemDataSet7.tblLOP);
                    txtMaLop.Clear();
                    txtTenlop.Clear();
                    cboKhoa.Text = "";
                }
            }
           
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtMaLop.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa lớp có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblLOP g = new tblLOP();
                g.MaLop = txtMaLop.Text;
                g.MaKhoa = cboKhoa.Text;
                g.TenLop = txtTenlop.Text;
                var result = new LOPF().Update(g);
                this.tblLOPTableAdapter.Fill(this.quanlydiemDataSet7.tblLOP);
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtMaLop.Text.Trim();
            if (MessageBox.Show(string.Format("Xóa lớp có mã '{0}'?", id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblLOP g = new tblLOP();
                g.MaLop = txtMaLop.Text;
                g.MaKhoa = cboKhoa.Text;
                g.TenLop = txtTenlop.Text;

                var result = new LOPF().Delete(g);
                context = new HSGVDbContext();
                this.tblLOPTableAdapter.Fill(this.quanlydiemDataSet7.tblLOP);
                txtMaLop.Clear();
                txtTenlop.Clear();
                cboKhoa.Text = "";
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
            txtMaLop.Text = "";
            txtTenlop.Text = "";
            cboKhoa.Text = "";
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrLop.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgrLop_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Enabled = false;
            txtMaLop.Text = dgrLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenlop.Text = dgrLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cboKhoa.Text = dgrLop.CurrentRow.Cells["MaKhoa"].Value.ToString();
        }
    }
}
