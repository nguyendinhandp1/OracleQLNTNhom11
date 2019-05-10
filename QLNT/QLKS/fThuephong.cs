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
    public partial class fThuephong : Form
    {
        public fThuephong()
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

        private void fThuephong_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                // Load thong tin khach tro
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("Select * from VIEW_KHACHTRO", conn);
                
                cmd1.CommandType = CommandType.Text;
                DataSet ds1 = new DataSet();
                OracleDataAdapter da1 = new OracleDataAdapter();
                da1.SelectCommand = cmd1;
                da1.Fill(ds1);
                dtgvThuephong.DataSource = ds1.Tables[0];


                // Show thong tin Phong
                OracleCommand cmd2 = new OracleCommand("Select * from VIEW_PHONG", conn);

                cmd2.CommandType = CommandType.Text;
                DataSet ds2 = new DataSet();
                OracleDataAdapter da2 = new OracleDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(ds2);

                cbbDanhsachphong.DisplayMember = "MAPHONG";
                cbbDanhsachphong.ValueMember = "MAPHONG";
                cbbDanhsachphong.DataSource = ds2.Tables[0];


                // Show thong tin Dichvu
                OracleCommand cmd3 = new OracleCommand("Select * from DICHVU", conn);

                cmd3.CommandType = CommandType.Text;
                DataSet ds3 = new DataSet();
                OracleDataAdapter da3 = new OracleDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(ds3);

                cbbDichvu.DisplayMember = "TENDICHVU";
                cbbDichvu.ValueMember = "TENDICHVU";
                cbbDichvu.DataSource = ds3.Tables[0];

                // Load 
                OracleCommand cmd4 = new OracleCommand("Select * from VIEW_PHONGTRONG", conn);

                cmd4.CommandType = CommandType.Text;
                DataSet ds4 = new DataSet();
                OracleDataAdapter da4 = new OracleDataAdapter();
                da4.SelectCommand = cmd4;
                da4.Fill(ds4);

                cbbPhongtrong.DisplayMember = "MAPHONG";
                cbbPhongtrong.ValueMember = "MAPHONG";
                cbbPhongtrong.DataSource = ds4.Tables[0];

                conn.Close();

                binding();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            fThuephong_Load(sender, e);
        }

        void binding()
        {
            tbMaKT.DataBindings.Clear();
            tbMaKT.DataBindings.Add("Text", dtgvThuephong.DataSource, "MAKT");

            tbHoten.DataBindings.Clear();
            tbHoten.DataBindings.Add("Text", dtgvThuephong.DataSource, "HOTENKT");

            tbGioitinh.DataBindings.Clear();
            tbGioitinh.DataBindings.Add("Text", dtgvThuephong.DataSource, "GIOITINH");

            dtpkNgaysinh.DataBindings.Clear();
            dtpkNgaysinh.DataBindings.Add("Value", dtgvThuephong.DataSource, "NGAYSINH");

            tbCMnd.DataBindings.Clear();
            tbCMnd.DataBindings.Add("Text", dtgvThuephong.DataSource, "CMND");

            tbQuequan.DataBindings.Clear();
            tbQuequan.DataBindings.Add("Text", dtgvThuephong.DataSource, "QUEQUAN");

            tbDienthoai.DataBindings.Clear();
            tbDienthoai.DataBindings.Add("Text", dtgvThuephong.DataSource, "DIENTHOAI");

            tbNghenghiep.DataBindings.Clear();
            tbNghenghiep.DataBindings.Add("Text", dtgvThuephong.DataSource, "NGHENGHIEP");

            dtpkNgaythue.DataBindings.Clear();
            dtpkNgaythue.DataBindings.Add("Value", dtgvThuephong.DataSource, "NGAYTHUE");

            dtpkNgayhethan.DataBindings.Clear();
            dtpkNgayhethan.DataBindings.Add("Value", dtgvThuephong.DataSource, "NGAYHETHAN");

            //
            tbLoaiphong.DataBindings.Clear();
            tbLoaiphong.DataBindings.Add("Text", cbbDanhsachphong.DataSource, "LOAIPHONG");

            tbSoluong.DataBindings.Clear();
            tbSoluong.DataBindings.Add("Text", cbbDanhsachphong.DataSource, "SOLUONGTOIDA");

            tbGiaphong.DataBindings.Clear();
            tbGiaphong.DataBindings.Add("Text", cbbDanhsachphong.DataSource, "GIAPHONG");

            // 
            tbMadv.DataBindings.Clear();
            tbMadv.DataBindings.Add("Text", cbbDichvu.DataSource, "MADV");

            tbGiadv.DataBindings.Clear();
            tbGiadv.DataBindings.Add("Text", cbbDichvu.DataSource, "GIADV");

        }

        private void btXoatextbox_Click(object sender, EventArgs e)
        {
            tbMaKT.Text = "";
            tbHoten.Text = "";
            tbGioitinh.Text = "";
            tbCMnd.Text = "";
            tbQuequan.Text = "";
            tbDienthoai.Text = "";
            tbNghenghiep.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbMaKT.Text == "")
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string insert = "INSERT INTO KHACHTRO (HOTENKT, GIOITINH, NGAYSINH, CMND, QUEQUAN, DIENTHOAI, NGHENGHIEP, NGAYTHUE, NGAYHETHAN, MADV, MAPHONG) VALUES (N'" + tbHoten.Text + "', N'" + tbGioitinh.Text + "', TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), '" + tbCMnd.Text + "', N'" + tbQuequan.Text + "', '" + tbDienthoai.Text + "', N'" + tbNghenghiep.Text + "', TO_DATE('" + dtpkNgaythue.Value.ToShortDateString() + "', 'yyyy/MM/dd'), TO_DATE('" + dtpkNgayhethan.Value.ToShortDateString() + "', 'yyyy/MM/dd'), '"+ tbMadv.Text +"', '"+ cbbDanhsachphong.Text +"') ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(insert, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    fThuephong_Load(sender, e);

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
                string delete = "DELETE FROM KHACHTRO WHERE MAKT = '" + tbMaKT.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fThuephong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvThuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE KHACHTRO SET HOTENKT = N'" + tbHoten.Text + "', GIOITINH = N'" + tbGioitinh.Text + "', NGAYSINH = TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), CMND = '" + tbCMnd.Text + "', QUEQUAN = N'" + tbQuequan.Text + "', DIENTHOAI = '" + tbDienthoai.Text + "', NGHENGHIEP = N'" + tbNghenghiep.Text + "', NGAYTHUE = TO_DATE('" + dtpkNgaythue.Value.ToShortDateString() + "', 'yyyy/MM/dd'), NGAYHETHAN = TO_DATE('" + dtpkNgayhethan.Value.ToShortDateString() + "', 'yyyy/MM/dd'), MADV = '" + tbMadv.Text + "', MAPHONG = '" + cbbDanhsachphong.Text + "' WHERE MAKT = '" + tbMaKT.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                fThuephong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbDanhsachphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
