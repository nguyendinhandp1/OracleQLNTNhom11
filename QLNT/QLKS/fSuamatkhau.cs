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
    public partial class fSuamatkhau : Form
    {
        public fSuamatkhau()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // kiểm tra mật khẩu cũ
        private bool checkTK(string ID, string pass)
        {
            string taikhoan = "";
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM NHANVIEN WHERE MANV ='" + ID + "' AND MATKHAU = '"+ tbMatkhaucu.Text +"'", conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        taikhoan = dr["TAIKHOAN"].ToString();

                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (taikhoan != "")
            {
                return true;
            }
            else return false;
           
        }
       
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            
            if (tbMatkhaumoi1.Text == tbMatkhaumoi2.Text && checkTK(fLogin.ID_USER, tbMatkhaucu.Text))
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string update = "UPDATE NHANVIEN SET MATKHAU = '" + tbMatkhaumoi2.Text + "' WHERE MANV = '" + fLogin.ID_USER + "' ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(update, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Cập nhật mật khẩu thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else MessageBox.Show("Vui lòng kiểm tra lại mật khẩu vừa nhập");
           
        }


        private void fSuamatkhau_Load(object sender, EventArgs e)
        {
            
              

        }
    }
}
