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
    public partial class fThanhtoan : Form
    {
        public fThanhtoan()
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            string stringload = " SELECT * FROM VIEW_THANHTOAN WHERE MAPHONG = '" + cbbPhong.Text + "' ";
            OracleCommand cmd = new OracleCommand(stringload, conn);

            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dtgvDanhsach.DataSource = ds.Tables[0];

            tbTongtien.DataBindings.Clear();
            tbTongtien.DataBindings.Add("Text", dtgvDanhsach.DataSource, "TONG");

        }

        private void fThanhtoan_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                // Load thong tin khach tro
                conn.Open();
              
                OracleCommand cmd3 = new OracleCommand("SELECT DISTINCT MAPHONG FROM VIEW_THANHTOAN", conn);

                cmd3.CommandType = CommandType.Text;
                DataSet ds3 = new DataSet();
                OracleDataAdapter da3 = new OracleDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(ds3);

                cbbPhong.DisplayMember = "MAPHONG";
                cbbPhong.ValueMember = "MAPHONG";
                cbbPhong.DataSource = ds3.Tables[0];

                conn.Close();

             //   binding();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            fThanhtoan_Load(sender, e);
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE KHACHTRO SET NGAYHETHAN = ADD_MONTHS(NGAYHETHAN, 1) WHERE MAPHONG = '" + cbbPhong.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Thanh toán thành công!");
                fThanhtoan_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
