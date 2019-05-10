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
    public partial class fTaikhoanNV : Form
    {
        public fTaikhoanNV()
        {
            InitializeComponent();
        }
        string constring = "Data Source = (DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                             "(CONNECT_DATA =" +
                             "(SERVER = DEDICATED)" +
                             "(SERVICE_NAME = orcl)" +
                             ")" +
                             ");User Id = system;password=Cna424001;";

        
        private void fTaikhoanNV_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                OracleCommand cmd = new OracleCommand("Select * from VIEW_NHANVIEN WHERE MANV = '"+ fLogin.ID_USER +"'", conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dtgvNhanvien.DataSource = ds.Tables[0];
                conn.Close();
                binding();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void binding()
        {
            tbManv.DataBindings.Clear();
            tbManv.DataBindings.Add("Text", dtgvNhanvien.DataSource, "MANV");

            tbHoten.DataBindings.Clear();
            tbHoten.DataBindings.Add("Text", dtgvNhanvien.DataSource, "HOTEN");

            tbGioitinh.DataBindings.Clear();
            tbGioitinh.DataBindings.Add("Text", dtgvNhanvien.DataSource, "GIOITINH");

            dtpkNgaysinh.DataBindings.Clear();
            dtpkNgaysinh.DataBindings.Add("Value", dtgvNhanvien.DataSource, "NGAYSINH");

            tbChucvu.DataBindings.Clear();
            tbChucvu.DataBindings.Add("Text", dtgvNhanvien.DataSource, "CHUCVU");

            tbLuong.DataBindings.Clear();
            tbLuong.DataBindings.Add("Text", dtgvNhanvien.DataSource, "LUONG");

            tbTaikhoan.DataBindings.Clear();
            tbTaikhoan.DataBindings.Add("Text", dtgvNhanvien.DataSource, "TAIKHOAN");

            tbMatkhau.Text = "111111111111111";

            tbQuequan.DataBindings.Clear();
            tbQuequan.DataBindings.Add("Text", dtgvNhanvien.DataSource, "QUEQUAN");

            tbDienthoai.DataBindings.Clear();
            tbDienthoai.DataBindings.Add("Text", dtgvNhanvien.DataSource, "DIENTHOAI");


        }

        private void btXoaTextbox_Click(object sender, EventArgs e)
        {
            tbManv.Text = "";
            tbHoten.Text = "";
            tbGioitinh.Text = "";
            tbDienthoai.Text = "";
            tbQuequan.Text = "";
            tbChucvu.Text = "";
            tbLuong.Text = "";
            tbTaikhoan.Text = "";
            tbMatkhau.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE NHANVIEN SET HOTEN = N'" + tbHoten.Text + "', GIOITINH = N'" + tbGioitinh.Text + "', NGAYSINH = TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), CHUCVU = N'" + tbChucvu.Text + "', LUONG = '" + tbLuong.Text + "', TAIKHOAN = '" + tbTaikhoan.Text + "', QUEQUAN = N'" + tbQuequan.Text + "', DIENTHOAI = '" + tbDienthoai.Text + "' WHERE MANV = '" + tbManv.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fTaikhoanNV_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            fTaikhoanNV_Load(sender, e);
        }

        private void btSuamatkhau_Click(object sender, EventArgs e)
        {
            fSuamatkhau sua = new fSuamatkhau();
            sua.Show();
        }
        
       

    }
}
