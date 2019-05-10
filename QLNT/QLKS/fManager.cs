using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace QLNT
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }
        
        private void mThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                this.Hide();
                fLogin Log = new fLogin();
                Log.ShowDialog();
            }
        }

        private void mPhong_Click(object sender, EventArgs e)
        {
            fPhong p = new fPhong();
            p.MdiParent = this;
            p.Show();
        }

        private void fManager_Load(object sender, EventArgs e)
        {
           
        }

        private void mDichvu_Click(object sender, EventArgs e)
        {
            fDichvu d = new fDichvu();
            d.MdiParent = this;
            d.Show();
        }

        private void mKhachhang_Click(object sender, EventArgs e)
        {
            fKhachtro kt = new fKhachtro();
            kt.MdiParent = this;
            kt.Show();
        }

        private void đăngKýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThuephong tp = new fThuephong();
            tp.MdiParent = this;
            tp.Show();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTimkiem tk = new fTimkiem();
            tk.MdiParent = this;
            tk.Show();
            
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThanhtoan tt = new fThanhtoan();
            tt.MdiParent = this;
            tt.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fLogin.PER_USER == "0")
            {
                fNhanvien nv = new fNhanvien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
            {
                MessageBox.Show("Chỉ ADMIN mới được quyền truy cập vào mục này!!");
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mThongtinTK_Click(object sender, EventArgs e)
        {
            fTaikhoanNV tknv = new fTaikhoanNV();
            tknv.MdiParent = this;
            tknv.Show();
        }

        
    }
}
