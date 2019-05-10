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
    public partial class fPhong : Form
    {
        public fPhong()
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
        private void tbLoaiphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fPhong_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);

                OracleCommand cmd1 = new OracleCommand("Select * from LOAIPHONG", conn);
                OracleCommand cmd2 = new OracleCommand("Select * from PHONG", conn);
                conn.Open();

                cmd1.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                OracleDataAdapter da1 = new OracleDataAdapter();
                OracleDataAdapter da2 = new OracleDataAdapter();
                da1.SelectCommand = cmd1;
                da2.SelectCommand = cmd2;
                da1.Fill(ds1);
                da2.Fill(ds2);

                dtgvLoaip.DataSource = ds1.Tables[0];
                dtgvPhong.DataSource = ds2.Tables[0];


                cbbMaloai.DisplayMember = "MALOAIPHONG";
                cbbMaloai.ValueMember = "MALOAIPHONG";
                cbbMaloai.DataSource = ds1.Tables[0];

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
            tbMaloaiphong.DataBindings.Clear();
            tbMaloaiphong.DataBindings.Add("Text", dtgvLoaip.DataSource, "MALOAIPHONG");

            tbLoaiphong.DataBindings.Clear();
            tbLoaiphong.DataBindings.Add("Text", dtgvLoaip.DataSource, "LOAIPHONG");

            tbSoluong.DataBindings.Clear();
            tbSoluong.DataBindings.Add("Text", dtgvLoaip.DataSource, "SOLUONGTOIDA");

            tbMaphong.DataBindings.Clear();
            tbMaphong.DataBindings.Add("Text", dtgvPhong.DataSource, "MAPHONG");

            tbTenphong.DataBindings.Clear();
            tbTenphong.DataBindings.Add("Text", dtgvPhong.DataSource, "TENPHONG");

            tbGiaphong.DataBindings.Clear();
            tbGiaphong.DataBindings.Add("Text", dtgvPhong.DataSource, "GIAPHONG");
        }

        private void btThemlp_Click(object sender, EventArgs e)
        {
            if (tbMaloaiphong.Text != "")
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string insert = "INSERT INTO LOAIPHONG VALUES ('" + tbMaloaiphong.Text + "', N'" + tbLoaiphong.Text + "', '" + tbSoluong.Text + "') ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(insert, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    fPhong_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu");
        }

        private void btXoalp_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string delete = "DELETE FROM LOAIPHONG WHERE MALOAIPHONG = '" + tbMaloaiphong.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSualp_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE LOAIPHONG SET LOAIPHONG = '" + tbLoaiphong.Text + "', SOLUONGTOIDA = '" + tbSoluong.Text + "' WHERE MALOAIPHONG = '" + tbMaloaiphong.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            fPhong_Load(sender, e);
        }

        private void btThemp_Click(object sender, EventArgs e)
        {
            if (tbMaphong.Text != "")
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string insert = "INSERT INTO PHONG VALUES ('" + tbMaphong.Text + "', N'" + tbTenphong.Text + "', '" + tbGiaphong.Text + "', '"+ cbbMaloai.Text + "') ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(insert, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    fPhong_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu");
        }

        private void btXoap_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string delete = "DELETE FROM PHONG WHERE MAPHONG = '" + tbMaphong.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuap_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                string update = "UPDATE PHONG SET TENPHONG = '" + tbTenphong.Text + "', GIAPHONG = '" + tbGiaphong.Text + "', MALOAIPHONG = '"+ cbbMaloai.Text +"' WHERE MAPHONG = '" + tbMaphong.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}
