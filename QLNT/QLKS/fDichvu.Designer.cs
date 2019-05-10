namespace QLNT
{
    partial class fDichvu
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMadichvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTendichvu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiadichvu = new System.Windows.Forms.TextBox();
            this.btXoaTextbox = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dtgvDichvu = new System.Windows.Forms.DataGridView();
            this.tbLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // tbMadichvu
            // 
            this.tbMadichvu.Location = new System.Drawing.Point(134, 48);
            this.tbMadichvu.Name = "tbMadichvu";
            this.tbMadichvu.Size = new System.Drawing.Size(275, 20);
            this.tbMadichvu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // tbTendichvu
            // 
            this.tbTendichvu.Location = new System.Drawing.Point(134, 85);
            this.tbTendichvu.Name = "tbTendichvu";
            this.tbTendichvu.Size = new System.Drawing.Size(275, 20);
            this.tbTendichvu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá dịch vụ";
            // 
            // tbGiadichvu
            // 
            this.tbGiadichvu.Location = new System.Drawing.Point(134, 122);
            this.tbGiadichvu.Name = "tbGiadichvu";
            this.tbGiadichvu.Size = new System.Drawing.Size(275, 20);
            this.tbGiadichvu.TabIndex = 2;
            this.tbGiadichvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btXoaTextbox
            // 
            this.btXoaTextbox.Location = new System.Drawing.Point(453, 41);
            this.btXoaTextbox.Name = "btXoaTextbox";
            this.btXoaTextbox.Size = new System.Drawing.Size(75, 23);
            this.btXoaTextbox.TabIndex = 3;
            this.btXoaTextbox.Text = "Xóa Textbox";
            this.btXoaTextbox.UseVisualStyleBackColor = true;
            this.btXoaTextbox.Click += new System.EventHandler(this.btXoaTextbox_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(559, 41);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(453, 86);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(559, 86);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dtgvDichvu
            // 
            this.dtgvDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDichvu.Location = new System.Drawing.Point(49, 171);
            this.dtgvDichvu.Name = "dtgvDichvu";
            this.dtgvDichvu.Size = new System.Drawing.Size(585, 271);
            this.dtgvDichvu.TabIndex = 8;
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(453, 132);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(181, 23);
            this.tbLoad.TabIndex = 7;
            this.tbLoad.Text = "Load";
            this.tbLoad.UseVisualStyleBackColor = true;
            this.tbLoad.Click += new System.EventHandler(this.tbLoad_Click);
            // 
            // fDichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 463);
            this.Controls.Add(this.tbLoad);
            this.Controls.Add(this.dtgvDichvu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btXoaTextbox);
            this.Controls.Add(this.tbGiadichvu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTendichvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMadichvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fDichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DỊCH VỤ";
            this.Load += new System.EventHandler(this.fPhong_Dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMadichvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTendichvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGiadichvu;
        private System.Windows.Forms.Button btXoaTextbox;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dtgvDichvu;
        private System.Windows.Forms.Button tbLoad;
    }
}