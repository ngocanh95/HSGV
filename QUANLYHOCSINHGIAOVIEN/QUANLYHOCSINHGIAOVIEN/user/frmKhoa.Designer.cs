namespace QUANLYHOCSINHGIAOVIEN.user
{
    partial class frmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblKHOABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
             
            this.tblKHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamSach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            
            this.dgrKhoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource2)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource1)).BeginInit();
           
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblKHOABindingSource
            // 
            this.tblKHOABindingSource.DataMember = "tblKHOA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrKhoa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 366);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // tblKHOABindingSource2
            // 
            this.tblKHOABindingSource2.DataMember = "tblKHOA";
           
            // 
            // quanlydiemDataSet9
            // 
           
            // tblKHOABindingSource1
            // 
            this.tblKHOABindingSource1.DataMember = "tblKHOA";
             
            // quanlykhoa
            // 
            
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamSach);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 366);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // btnLamSach
            // 
            this.btnLamSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLamSach.Location = new System.Drawing.Point(214, 13);
            this.btnLamSach.Name = "btnLamSach";
            this.btnLamSach.Size = new System.Drawing.Size(75, 23);
            this.btnLamSach.TabIndex = 43;
            this.btnLamSach.Text = "Làm sạch";
            this.btnLamSach.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(165, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 29;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(165, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 28;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(33, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(33, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(103, 67);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(179, 22);
            this.txtKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(103, 117);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(179, 22);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khoa";
            // 
            // tblKHOATableAdapter
            // 
              
            // tblKHOATableAdapter1
            // 
              
            // dgrKhoa
            // 
            this.dgrKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKhoa.Location = new System.Drawing.Point(7, 22);
            this.dgrKhoa.Name = "dgrKhoa";
            this.dgrKhoa.Size = new System.Drawing.Size(402, 338);
            this.dgrKhoa.TabIndex = 0;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhoa";
            this.Size = new System.Drawing.Size(729, 446);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource2)).EndInit();
             
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource1)).EndInit();
             
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tblKHOABindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tblKHOABindingSource1;
        
        private System.Windows.Forms.BindingSource tblKHOABindingSource2;
        
        private System.Windows.Forms.Button btnLamSach;
        private System.Windows.Forms.DataGridView dgrKhoa;
    }
}
