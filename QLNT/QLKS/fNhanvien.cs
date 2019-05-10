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
    public partial class fNhanvien : Form
    {
        public fNhanvien()
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

        private void fNhanvien_Load(object sender, EventArgs e)
        {
            //connect
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                OracleCommand cmd = new OracleCommand("Select * from VIEW_NHANVIEN", conn);
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

            tbMatkhau.Text = "111111111111";

            tbQuequan.DataBindings.Clear();
            tbQuequan.DataBindings.Add("Text", dtgvNhanvien.DataSource, "QUEQUAN");

            tbDienthoai.DataBindings.Clear();
            tbDienthoai.DataBindings.Add("Text", dtgvNhanvien.DataSource, "DIENTHOAI");

            tbQuyen.DataBindings.Clear();
            tbQuyen.DataBindings.Add("Text", dtgvNhanvien.DataSource, "QUYEN");


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
            tbQuyen.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbManv.Text == "")
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string insert = "INSERT INTO NHANVIEN (HOTEN, GIOITINH, NGAYSINH, CHUCVU, LUONG, TAIKHOAN, MATKHAU, QUEQUAN, DIENTHOAI) VALUES ('" + tbHoten.Text + "', N'" + tbGioitinh.Text + "', TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), '" + tbChucvu.Text + "', '" + tbLuong.Text + "', '" + tbTaikhoan.Text + "', '" + tbMatkhau.Text + "', '" + tbQuequan.Text + "', '" + tbDienthoai.Text + "') ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(insert, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    fNhanvien_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string delete = "DELETE FROM NHANVIEN WHERE MANV = '" + tbManv.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fNhanvien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE NHANVIEN SET HOTEN = N'" + tbHoten.Text + "', GIOITINH = N'" + tbGioitinh.Text + "', NGAYSINH = TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), CHUCVU = N'" + tbChucvu.Text + "', LUONG = '" + tbLuong.Text + "', TAIKHOAN = '" + tbTaikhoan.Text + "', QUEQUAN = N'" + tbQuequan.Text + "', DIENTHOAI = '" + tbDienthoai.Text + "', QUYEN = '"+ tbQuyen.Text +"' WHERE MANV = '" + tbManv.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fNhanvien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            fNhanvien_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE NHANVIEN SET MATKHAU = '" + tbMatkhau.Text + "' WHERE MANV = '" + tbManv.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                fNhanvien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
