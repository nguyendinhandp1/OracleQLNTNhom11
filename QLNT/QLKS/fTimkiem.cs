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
    public partial class fTimkiem : Form
    {
        public fTimkiem()
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

        private void ccbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fTimkiem_Load(sender, e);
        }

        private void fTimkiem_Load(object sender, EventArgs e)
        {

            if (rdoKhachtro.Checked)
            {
                cbbLoai.Items.Clear();
                cbbLoai.Items.Add("MA KT");
                cbbLoai.Items.Add("HO TEN");
                cbbLoai.Items.Add("QUE QUAN");
                cbbLoai.Items.Add("NGHE NGHIEP");
                cbbLoai.Items.Add("PHONG");
              
            }
            else if (rdoNhanvien.Checked)
            {
                cbbLoai.Items.Clear();
                cbbLoai.Items.Add("MA NV");
                cbbLoai.Items.Add("HO TEN");
                cbbLoai.Items.Add("CHUC VU");
                cbbLoai.Items.Add("QUE QUAN"); 
            }
           

        }

        private void rdoNhanvien_CheckedChanged(object sender, EventArgs e)
        {
            fTimkiem_Load(sender, e);
            
        }

        private void butLammoi_Click(object sender, EventArgs e)
        {
            tbNoidung.Text = "";
            
        }
        void ShowKQ(string query)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                conn.Open();

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dtgvKetqua.DataSource = ds.Tables[0];

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btTim_Click(object sender, EventArgs e)
        {
            if (tbNoidung.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP THÔNG TIN TÌM KIẾM!", "Thông Báo");
            }
            else
            {
                if (rdoKhachtro.Checked)
                {
                    if (cbbLoai.Text == "MA KT")
                    {
                        ShowKQ("select * from VIEW_KHACHTRO where MAKT like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "HO TEN")
                    {
                        ShowKQ("select * from VIEW_KHACHTRO where HOTENKT like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "QUE QUAN")
                    {
                        ShowKQ("select * from VIEW_KHACHTRO where QUEQUAN like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "NGHE NGHIEP")
                    {
                        ShowKQ("select * from VIEW_KHACHTRO where NGHENGHIEP like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "PHONG")
                    {
                        ShowKQ("select * from VIEW_KHACHTRO where MAPHONG like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                }
                else if (rdoNhanvien.Checked)
                {
                    if (cbbLoai.Text == "MA NV")
                    {
                        ShowKQ("select * from VIEW_NHANVIEN where MANV like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "HO TEN")
                    {
                        ShowKQ("select * from VIEW_NHANVIEN where HOTEN like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "QUE QUAN")
                    {
                        ShowKQ("select * from VIEW_NHANVIEN where QUEQUAN like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                    if (cbbLoai.Text == "CHUC VU")
                    {
                        ShowKQ("select * from VIEW_NHANVIEN where CHUCVU like '%" + tbNoidung.Text.Trim() + "%'");
                    }
                   
                }
                else MessageBox.Show("Vui lòng kiểm tra lại thông tin cần tìm !!!");
        
                
                
            }
        }
    }
}
