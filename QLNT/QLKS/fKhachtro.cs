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
    public partial class fKhachtro : Form
    {
        public fKhachtro()
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


        private void fKhachtro_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                // Load thong tin khach tro
                conn.Open();
                OracleCommand cmd = new OracleCommand("Select * from VIEW_KHACHTRO", conn);

                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da1 = new OracleDataAdapter();
                da1.SelectCommand = cmd;
                da1.Fill(ds);
                dtgvKhachtro.DataSource = ds.Tables[0];



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
            tbMakt.DataBindings.Clear();
            tbMakt.DataBindings.Add("Text", dtgvKhachtro.DataSource, "MAKT");

            tbHoten.DataBindings.Clear();
            tbHoten.DataBindings.Add("Text", dtgvKhachtro.DataSource, "HOTENKT");

            tbGioitinh.DataBindings.Clear();
            tbGioitinh.DataBindings.Add("Text", dtgvKhachtro.DataSource, "GIOITINH");

            tbQuequan.DataBindings.Clear();
            tbQuequan.DataBindings.Add("Text", dtgvKhachtro.DataSource, "QUEQUAN");

            tbCMND.DataBindings.Clear();
            tbCMND.DataBindings.Add("Text", dtgvKhachtro.DataSource, "CMND");

            tbDienthoai.DataBindings.Clear();
            tbDienthoai.DataBindings.Add("Text", dtgvKhachtro.DataSource, "DIENTHOAI");

            tbNghenghiep.DataBindings.Clear();
            tbNghenghiep.DataBindings.Add("Text", dtgvKhachtro.DataSource, "NGHENGHIEP");

            dtpkNgaysinh.DataBindings.Clear();
            dtpkNgaysinh.DataBindings.Add("Value", dtgvKhachtro.DataSource, "NGAYSINH");
        }

        private void btXoatextbox_Click(object sender, EventArgs e)
        {
            tbMakt.Text = "";
            tbHoten.Text = "";
            tbGioitinh.Text = "";
            tbQuequan.Text = "";
            tbDienthoai.Text = "";
            tbCMND.Text = "";
            tbNghenghiep.Text = "";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string delete = "DELETE FROM KHACHTRO WHERE MAKT = '" + tbMakt.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fKhachtro_Load(sender, e);

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
                string update = "UPDATE KHACHTRO SET HOTENKT = N'" + tbHoten.Text + "', GIOITINH = N'" + tbGioitinh.Text + "', NGAYSINH = TO_DATE('" + dtpkNgaysinh.Value.ToShortDateString() + "', 'yyyy/MM/dd'), CMND = '" + tbCMND.Text + "', QUEQUAN = N'" + tbQuequan.Text + "', DIENTHOAI = '" + tbDienthoai.Text + "', NGHENGHIEP = N'" + tbNghenghiep.Text + "'  WHERE MAKT = '" + tbMakt.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fKhachtro_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbLoad_Click(object sender, EventArgs e)
        {
            fKhachtro_Load(sender, e);
        }

       
      




       }
        
        
    
}
