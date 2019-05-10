namespace QLNT
{
    partial class fTimkiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.tbNoidung = new System.Windows.Forms.TextBox();
            this.butLammoi = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.dtgvKetqua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoKhachtro = new System.Windows.Forms.RadioButton();
            this.rdoNhanvien = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetqua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(278, 34);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(189, 21);
            this.cbbLoai.TabIndex = 1;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.ccbLoai_SelectedIndexChanged);
            // 
            // tbNoidung
            // 
            this.tbNoidung.Location = new System.Drawing.Point(278, 76);
            this.tbNoidung.Name = "tbNoidung";
            this.tbNoidung.Size = new System.Drawing.Size(189, 20);
            this.tbNoidung.TabIndex = 2;
            // 
            // butLammoi
            // 
            this.butLammoi.Location = new System.Drawing.Point(507, 38);
            this.butLammoi.Name = "butLammoi";
            this.butLammoi.Size = new System.Drawing.Size(104, 23);
            this.butLammoi.TabIndex = 3;
            this.butLammoi.Text = "Làm mới";
            this.butLammoi.UseVisualStyleBackColor = true;
            this.butLammoi.Click += new System.EventHandler(this.butLammoi_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(507, 74);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(104, 23);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // dtgvKetqua
            // 
            this.dtgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKetqua.Location = new System.Drawing.Point(12, 129);
            this.dtgvKetqua.Name = "dtgvKetqua";
            this.dtgvKetqua.Size = new System.Drawing.Size(621, 256);
            this.dtgvKetqua.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa:";
            // 
            // rdoKhachtro
            // 
            this.rdoKhachtro.AutoSize = true;
            this.rdoKhachtro.Checked = true;
            this.rdoKhachtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhachtro.ForeColor = System.Drawing.Color.Blue;
            this.rdoKhachtro.Location = new System.Drawing.Point(42, 38);
            this.rdoKhachtro.Name = "rdoKhachtro";
            this.rdoKhachtro.Size = new System.Drawing.Size(90, 20);
            this.rdoKhachtro.TabIndex = 5;
            this.rdoKhachtro.TabStop = true;
            this.rdoKhachtro.Text = "Khách trọ";
            this.rdoKhachtro.UseVisualStyleBackColor = true;
            this.rdoKhachtro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoNhanvien
            // 
            this.rdoNhanvien.AutoSize = true;
            this.rdoNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhanvien.ForeColor = System.Drawing.Color.Blue;
            this.rdoNhanvien.Location = new System.Drawing.Point(42, 76);
            this.rdoNhanvien.Name = "rdoNhanvien";
            this.rdoNhanvien.Size = new System.Drawing.Size(95, 20);
            this.rdoNhanvien.TabIndex = 5;
            this.rdoNhanvien.Text = "Nhân viên";
            this.rdoNhanvien.UseVisualStyleBackColor = true;
            this.rdoNhanvien.CheckedChanged += new System.EventHandler(this.rdoNhanvien_CheckedChanged);
            // 
            // fTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.rdoNhanvien);
            this.Controls.Add(this.rdoKhachtro);
            this.Controls.Add(this.dtgvKetqua);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.butLammoi);
            this.Controls.Add(this.tbNoidung);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM";
            this.Load += new System.EventHandler(this.fTimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.TextBox tbNoidung;
        private System.Windows.Forms.Button butLammoi;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridView dtgvKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoKhachtro;
        private System.Windows.Forms.RadioButton rdoNhanvien;
    }
}