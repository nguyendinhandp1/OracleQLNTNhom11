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
    public partial class fDichvu : Form
    {
        public fDichvu()
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

        private void fPhong_Dichvu_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);

                OracleCommand cmd = new OracleCommand("Select * from DICHVU", conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dtgvDichvu.DataSource = ds.Tables[0];
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
            tbGiadichvu.DataBindings.Clear();
            tbGiadichvu.DataBindings.Add("Text", dtgvDichvu.DataSource, "GIADV");

            tbTendichvu.DataBindings.Clear();
            tbTendichvu.DataBindings.Add("Text", dtgvDichvu.DataSource, "TENDICHVU");

            tbMadichvu.DataBindings.Clear();
            tbMadichvu.DataBindings.Add("Text", dtgvDichvu.DataSource, "MADV");
        }

        private void btXoaTextbox_Click(object sender, EventArgs e)
        {
            tbGiadichvu.Text = "";
            tbMadichvu.Text = "";
            tbTendichvu.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbMadichvu.Text != "")
            {
                try
                {
                    OracleConnection conn = new OracleConnection(constring);
                    string insert = "INSERT INTO DICHVU VALUES ('" + tbMadichvu.Text + "', N'" + tbTendichvu.Text + "', '" + tbGiadichvu.Text + "') ";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(insert, conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    fPhong_Dichvu_Load(sender, e);

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
                string delete = "DELETE FROM DICHVU WHERE MADV = '" + tbMadichvu.Text + "'";
                conn.Open();
                OracleCommand cmd = new OracleCommand(delete, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Dichvu_Load(sender, e);

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
                string update = "UPDATE DICHVU SET TENDICHVU = N'" + tbTendichvu.Text + "', GIADV = '"+ tbGiadichvu.Text +"' WHERE MADV = '" + tbMadichvu.Text + "' ";
                conn.Open();
                OracleCommand cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                fPhong_Dichvu_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbLoad_Click(object sender, EventArgs e)
        {
            fPhong_Dichvu_Load(sender, e);
        }
    }
}
