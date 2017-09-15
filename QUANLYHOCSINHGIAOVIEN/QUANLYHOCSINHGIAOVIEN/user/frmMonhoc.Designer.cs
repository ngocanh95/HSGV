namespace QUANLYHOCSINHGIAOVIEN.user
{
    partial class frmMonhoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonhoc));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamSach = new System.Windows.Forms.Button();
            this.numsdvht = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
          
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgrMON = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMONBindingSource)).BeginInit();
           
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsdvht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrMON);
            this.groupBox2.Location = new System.Drawing.Point(267, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 395);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // tblMONBindingSource
            // 
            this.tblMONBindingSource.DataMember = "tblMON";
            
            // quanlydiemDataSet8
            // 
            
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamSach);
            this.groupBox1.Controls.Add(this.numsdvht);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(262, 395);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnLamSach
            // 
            this.btnLamSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLamSach.Location = new System.Drawing.Point(186, 9);
            this.btnLamSach.Name = "btnLamSach";
            this.btnLamSach.Size = new System.Drawing.Size(75, 23);
            this.btnLamSach.TabIndex = 45;
            this.btnLamSach.Text = "Làm sạch";
            this.btnLamSach.UseVisualStyleBackColor = false;
            // 
            // numsdvht
            // 
            this.numsdvht.Location = new System.Drawing.Point(106, 138);
            this.numsdvht.Name = "numsdvht";
            this.numsdvht.Size = new System.Drawing.Size(120, 22);
            this.numsdvht.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(151, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 27;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(151, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 26;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(35, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(106, 222);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(145, 23);
            this.cboKhoa.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã khoa";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(106, 180);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(145, 22);
            this.txtHocKy.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số ĐVHT";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(106, 97);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(145, 22);
            this.txtTenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(106, 51);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(145, 22);
            this.txtMaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn";
            // 
            // tblMONTableAdapter
            // 
            
            // 
            // dgrMON
            // 
            this.dgrMON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMON.Location = new System.Drawing.Point(18, 19);
            this.dgrMON.Name = "dgrMON";
            this.dgrMON.Size = new System.Drawing.Size(441, 359);
            this.dgrMON.TabIndex = 0;
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMonhoc";
            this.Size = new System.Drawing.Size(729, 446);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMONBindingSource)).EndInit();
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsdvht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblMONBindingSource;
         
        private System.Windows.Forms.NumericUpDown numsdvht;
        private System.Windows.Forms.Button btnLamSach;
        private System.Windows.Forms.DataGridView dgrMON;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
