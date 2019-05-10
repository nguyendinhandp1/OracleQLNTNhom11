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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
    
        OracleConnection conn = new OracleConnection("Data Source = (DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                             "(CONNECT_DATA =" +
                             "(SERVER = DEDICATED)" +
                             "(SERVICE_NAME = orcl)" +
                             ")" +
                             ");User Id = system;password=Cna424001;");

        // ham lay QUYEN cua tai khoan dang nhap
        private string getPER(string username, string pass)
        {
          
            string per = "";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' AND MATKHAU ='" + pass + "'", conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        per = dr["QUYEN"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return per;
        }

        // lay ID user
        private string getID(string username, string pass)
        {

            string ID = "";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM NHANVIEN WHERE TAIKHOAN ='" + username + "' AND MATKHAU ='" + pass + "'", conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ID = dr["MANV"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return ID;
        }

        // tao bien public luu QUYEN
        public static string PER_USER = "";
        public static string ID_USER = "";

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                PER_USER = getPER(tbTendangnhap.Text, tbMatkhau.Text);
                ID_USER = getID(tbTendangnhap.Text, tbMatkhau.Text);
                if (PER_USER != "")
                {
                    fManager man = new fManager();
                    this.Hide();
                    man.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
