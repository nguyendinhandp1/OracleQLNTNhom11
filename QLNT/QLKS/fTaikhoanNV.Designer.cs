namespace QLNT
{
    partial class fTaikhoanNV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLoad = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoaTextbox = new System.Windows.Forms.Button();
            this.dtgvNhanvien = new System.Windows.Forms.DataGridView();
            this.dtpkNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbLuong = new System.Windows.Forms.TextBox();
            this.tbChucvu = new System.Windows.Forms.TextBox();
            this.tbGioitinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbManv = new System.Windows.Forms.TextBox();
            this.tbMatkhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDienthoai = new System.Windows.Forms.TextBox();
            this.tbQuequan = new System.Windows.Forms.TextBox();
            this.tbTaikhoan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSuamatkhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(428, 223);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 42;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(319, 223);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 40;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoaTextbox
            // 
            this.btXoaTextbox.Location = new System.Drawing.Point(211, 223);
            this.btXoaTextbox.Name = "btXoaTextbox";
            this.btXoaTextbox.Size = new System.Drawing.Size(75, 23);
            this.btXoaTextbox.TabIndex = 37;
            this.btXoaTextbox.Text = "Xóa Textbox";
            this.btXoaTextbox.UseVisualStyleBackColor = true;
            this.btXoaTextbox.Click += new System.EventHandler(this.btXoaTextbox_Click);
            // 
            // dtgvNhanvien
            // 
            this.dtgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanvien.Location = new System.Drawing.Point(23, 261);
            this.dtgvNhanvien.Name = "dtgvNhanvien";
            this.dtgvNhanvien.Size = new System.Drawing.Size(639, 78);
            this.dtgvNhanvien.TabIndex = 41;
            // 
            // dtpkNgaysinh
            // 
            this.dtpkNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaysinh.Location = new System.Drawing.Point(97, 110);
            this.dtpkNgaysinh.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpkNgaysinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpkNgaysinh.Name = "dtpkNgaysinh";
            this.dtpkNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgaysinh.TabIndex = 29;
            this.dtpkNgaysinh.Value = new System.DateTime(2019, 5, 8, 11, 13, 58, 0);
            // 
            // tbLuong
            // 
            this.tbLuong.Location = new System.Drawing.Point(97, 182);
            this.tbLuong.Name = "tbLuong";
            this.tbLuong.ReadOnly = true;
            this.tbLuong.Size = new System.Drawing.Size(201, 20);
            this.tbLuong.TabIndex = 31;
            // 
            // tbChucvu
            // 
            this.tbChucvu.Location = new System.Drawing.Point(97, 146);
            this.tbChucvu.Name = "tbChucvu";
            this.tbChucvu.ReadOnly = true;
            this.tbChucvu.Size = new System.Drawing.Size(201, 20);
            this.tbChucvu.TabIndex = 30;
            // 
            // tbGioitinh
            // 
            this.tbGioitinh.Location = new System.Drawing.Point(97, 74);
            this.tbGioitinh.Name = "tbGioitinh";
            this.tbGioitinh.Size = new System.Drawing.Size(201, 20);
            this.tbGioitinh.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chức vụ:";
            // 
            // tbManv
            // 
            this.tbManv.Location = new System.Drawing.Point(446, 182);
            this.tbManv.Name = "tbManv";
            this.tbManv.ReadOnly = true;
            this.tbManv.Size = new System.Drawing.Size(216, 20);
            this.tbManv.TabIndex = 36;
            // 
            // tbMatkhau
            // 
            this.tbMatkhau.Location = new System.Drawing.Point(446, 76);
            this.tbMatkhau.Name = "tbMatkhau";
            this.tbMatkhau.PasswordChar = '*';
            this.tbMatkhau.Size = new System.Drawing.Size(123, 20);
            this.tbMatkhau.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã nhân viên:";
            // 
            // tbDienthoai
            // 
            this.tbDienthoai.Location = new System.Drawing.Point(446, 146);
            this.tbDienthoai.Name = "tbDienthoai";
            this.tbDienthoai.Size = new System.Drawing.Size(216, 20);
            this.tbDienthoai.TabIndex = 35;
            // 
            // tbQuequan
            // 
            this.tbQuequan.Location = new System.Drawing.Point(446, 110);
            this.tbQuequan.Name = "tbQuequan";
            this.tbQuequan.Size = new System.Drawing.Size(216, 20);
            this.tbQuequan.TabIndex = 34;
            // 
            // tbTaikhoan
            // 
            this.tbTaikhoan.Location = new System.Drawing.Point(446, 42);
            this.tbTaikhoan.Name = "tbTaikhoan";
            this.tbTaikhoan.Size = new System.Drawing.Size(216, 20);
            this.tbTaikhoan.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(348, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mật khẩu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(348, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quê quán:";
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(97, 41);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(201, 20);
            this.tbHoten.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // btSuamatkhau
            // 
            this.btSuamatkhau.Location = new System.Drawing.Point(575, 74);
            this.btSuamatkhau.Name = "btSuamatkhau";
            this.btSuamatkhau.Size = new System.Drawing.Size(87, 23);
            this.btSuamatkhau.TabIndex = 43;
            this.btSuamatkhau.Text = "Sửa mật khẩu";
            this.btSuamatkhau.UseVisualStyleBackColor = true;
            this.btSuamatkhau.Click += new System.EventHandler(this.btSuamatkhau_Click);
            // 
            // fTaikhoanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 351);
            this.Controls.Add(this.btSuamatkhau);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoaTextbox);
            this.Controls.Add(this.dtgvNhanvien);
            this.Controls.Add(this.dtpkNgaysinh);
            this.Controls.Add(this.tbLuong);
            this.Controls.Add(this.tbChucvu);
            this.Controls.Add(this.tbGioitinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbManv);
            this.Controls.Add(this.tbMatkhau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDienthoai);
            this.Controls.Add(this.tbQuequan);
            this.Controls.Add(this.tbTaikhoan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTaikhoanNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN CÁ NHÂN";
            this.Load += new System.EventHandler(this.fTaikhoanNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoaTextbox;
        private System.Windows.Forms.DataGridView dtgvNhanvien;
        private System.Windows.Forms.DateTimePicker dtpkNgaysinh;
        private System.Windows.Forms.TextBox tbLuong;
        private System.Windows.Forms.TextBox tbChucvu;
        private System.Windows.Forms.TextBox tbGioitinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbManv;
        private System.Windows.Forms.TextBox tbMatkhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDienthoai;
        private System.Windows.Forms.TextBox tbQuequan;
        private System.Windows.Forms.TextBox tbTaikhoan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuamatkhau;
    }
}