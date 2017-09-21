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
    public partial class frmQLDiem : UserControl
    {
        public frmQLDiem()
        {
            InitializeComponent();
        }
        private HSGVDbContext context;
        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            context = new HSGVDbContext();
            dgrDiem.DataSource = context.tblKET_QUA.ToList();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
            }
            else
            {
                if (context.tblKET_QUA.Where(x =>x.MaMon == txtMaMH.Text.Trim() && x.MaSV == txtMaSV.Text.Trim()).SingleOrDefault() != null)
                {
                    MessageBox.Show("Mã sinh viên và mã môn học đã tồn tại", "Thông báo");
                }
                else
                {
                    if (txtDiemTB.Text.Trim() == "") txtDiemTB.Text = "-1";
                    if (txtDiemThi1.Text.Trim() == "") txtDiemThi1.Text = "-1";
                    if (txtdiemthi2.Text.Trim() == "") txtdiemthi2.Text = "-1";
                    if (txtDiemTK.Text.Trim() == "") txtDiemTK.Text = "-1";
                    if (txtHocKi.Text.Trim() == "") txtHocKi.Text = "-1";
                    tblKET_QUA g = new tblKET_QUA();
                    g.MaMon = txtMaMH.Text;
                    g.MaSV = txtMaSV.Text;
                    g.DiemTB = Convert.ToDouble(txtDiemTB.Text);
                    g.DiemThiLan1 = Convert.ToDouble(txtDiemThi1.Text);
                    g.DiemThiLan2 = Convert.ToDouble(txtdiemthi2.Text);
                    g.DiemTongKet = Convert.ToDouble(txtDiemTK.Text);
                    g.HanhKiem = cboHanhKiem.Text;
                    g.HocKi = Convert.ToInt32(txtHocKi.Text.ToString());
                    DIEMF f = new DIEMF();
                    f.Insert(g);
                    context = new HSGVDbContext();
                    this.tblKET_QUATableAdapter.Fill(this.quanlydiemDataSet6.tblKET_QUA);
                    txtMaSV.Clear();
                    txtMaMH.Clear();
                    txtHocKi.Clear();
                    txtDiemTK.Clear();
                    txtDiemThi1.Clear();
                    txtDiemTB.Clear();
                    cboHanhKiem.Text = "";
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtMaSV.Text.Trim();
            string id1 = txtMaMH.Text.Trim();
            if (MessageBox.Show(string.Format("Sửa điểm môn {0} của sinh viên có mã '{1}'?",id1,id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (txtDiemTB.Text.Trim() == "") txtDiemTB.Text = "-1";
                if (txtDiemThi1.Text.Trim() == "") txtDiemThi1.Text = "-1";
                if (txtdiemthi2.Text.Trim() == "") txtdiemthi2.Text = "-1";
                if (txtDiemTK.Text.Trim() == "") txtDiemTK.Text = "-1";
                if (txtHocKi.Text.Trim() == "") txtHocKi.Text = "-1";
                tblKET_QUA g = new tblKET_QUA();
                g.MaMon = txtMaMH.Text;
                g.MaSV = txtMaSV.Text;
                g.DiemTB = Convert.ToDouble(txtDiemTB.Text);
                g.DiemThiLan1 = Convert.ToDouble(txtDiemThi1.Text);
                g.DiemThiLan2 = Convert.ToDouble(txtdiemthi2.Text);
                g.DiemTongKet = Convert.ToDouble(txtDiemTK.Text);
                g.HanhKiem = cboHanhKiem.Text;
                g.HocKi = Convert.ToInt32(txtHocKi.Text.ToString());
                DIEMF f = new DIEMF();
                f.Update(g);
                context = new HSGVDbContext();
                this.tblKET_QUATableAdapter.Fill(this.quanlydiemDataSet6.tblKET_QUA);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtMaSV.Text.Trim();
            string id1 = txtMaMH.Text.Trim();
       
            if (MessageBox.Show(string.Format("Xóa điểm môn {0} của sinh viên có mã '{1}'?", id1, id), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tblKET_QUA g = new tblKET_QUA();
                g.MaMon = txtMaMH.Text;
                g.MaSV = txtMaSV.Text;
                g.DiemTB = Convert.ToDouble(txtDiemTB.Text);
                g.DiemThiLan1 = Convert.ToDouble(txtDiemThi1.Text);
                g.DiemThiLan2 = Convert.ToDouble(txtdiemthi2.Text);
                g.DiemTongKet = Convert.ToDouble(txtDiemTK.Text);
                g.HanhKiem = cboHanhKiem.Text;
                g.HocKi = Convert.ToInt32(txtHocKi.Text.ToString());
                DIEMF f = new DIEMF();
                f.Delete(g);
                context = new HSGVDbContext();
                this.tblKET_QUATableAdapter.Fill(this.quanlydiemDataSet6.tblKET_QUA);
                txtMaSV.Clear();
                txtMaMH.Clear();
                txtHocKi.Clear();
                txtDiemTK.Clear();
                txtDiemThi1.Clear();
                txtdiemthi2.Clear();
                txtDiemTB.Clear();
                cboHanhKiem.Text = "";
            }
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bd = new BindingSource();
            //bd.DataSource = dgrDiem.DataSource;
            if (cmbtruongtk.Text == "Mã sinh viên")
            {
                var bd = context.tblKET_QUA.Where(x => x.MaSV.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "MaSV like '%" + txttimkiem.Text + "%'";
                dgrDiem.DataSource = bd;
            }
            if (cmbtruongtk.Text == "Mã môn học")
            {
                var bd = context.tblKET_QUA.Where(x => x.MaSV.Contains(txttimkiem.Text)).ToList();
                //bd.Filter = "MaMon like '%" + txttimkiem.Text + "%'";
                dgrDiem.DataSource = bd;
            }
        }

    

        

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtDiemTB.Text = "";
            txtDiemThi1.Text = "";
            txtdiemthi2.Text = "";
            txtDiemTK.Text = "";
            txtHocKi.Text = "";
            txtMaMH.Text = "";
            txtMaSV.Text = "";
            cboHanhKiem.Text = "";
        }

        private void dgrDiem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgrDiem.CurrentRow.Cells[1].Value.ToString();
            txtdiemthi2.Text = dgrDiem.CurrentRow.Cells[5].Value.ToString();
            txtDiemTB.Text = dgrDiem.CurrentRow.Cells[3].Value.ToString();
            txtDiemThi1.Text = dgrDiem.CurrentRow.Cells[4].Value.ToString();
            txtDiemTK.Text = dgrDiem.CurrentRow.Cells[6].Value.ToString();
            txtMaMH.Text = dgrDiem.CurrentRow.Cells[2].Value.ToString();
            txtHocKi.Text = dgrDiem.CurrentRow.Cells[8].Value.ToString();
            cboHanhKiem.Text = dgrDiem.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgrDiem_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgrDiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
