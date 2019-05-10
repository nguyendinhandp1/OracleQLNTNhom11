namespace QLNT
{
    partial class fSuamatkhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatkhaucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatkhaumoi1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMatkhaumoi2 = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu củ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMatkhaucu
            // 
            this.tbMatkhaucu.Location = new System.Drawing.Point(175, 34);
            this.tbMatkhaucu.Name = "tbMatkhaucu";
            this.tbMatkhaucu.PasswordChar = '*';
            this.tbMatkhaucu.Size = new System.Drawing.Size(217, 20);
            this.tbMatkhaucu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới:";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMatkhaumoi1
            // 
            this.tbMatkhaumoi1.Location = new System.Drawing.Point(175, 74);
            this.tbMatkhaumoi1.Name = "tbMatkhaumoi1";
            this.tbMatkhaumoi1.PasswordChar = '*';
            this.tbMatkhaumoi1.Size = new System.Drawing.Size(217, 20);
            this.tbMatkhaumoi1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại MK mới:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMatkhaumoi2
            // 
            this.tbMatkhaumoi2.Location = new System.Drawing.Point(175, 113);
            this.tbMatkhaumoi2.Name = "tbMatkhaumoi2";
            this.tbMatkhaumoi2.PasswordChar = '*';
            this.tbMatkhaumoi2.Size = new System.Drawing.Size(217, 20);
            this.tbMatkhaumoi2.TabIndex = 2;
            // 
            // btCapnhat
            // 
            this.btCapnhat.Location = new System.Drawing.Point(287, 162);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(105, 23);
            this.btCapnhat.TabIndex = 3;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // fSuamatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 212);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.tbMatkhaumoi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMatkhaumoi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatkhaucu);
            this.Controls.Add(this.label2);
            this.Name = "fSuamatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT MẬT KHẨU";
            this.Load += new System.EventHandler(this.fSuamatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatkhaucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatkhaumoi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMatkhaumoi2;
        private System.Windows.Forms.Button btCapnhat;
    }
}