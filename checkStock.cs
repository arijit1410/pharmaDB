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
using Oracle.DataAccess.Types;

namespace pharmaDB
{
    public partial class checkStock : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public checkStock()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void drugnameBox_TextChanged(object sender, EventArgs e)
        {
            searchNamebutton.Show();
            searchIdButton.Hide();
        }

        private void checkStock_Load(object sender, EventArgs e)
        {
            searchNamebutton.Hide();
            searchIdButton.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchIdButton.Show();
            searchNamebutton.Hide();
        }

        private void searchNamebutton_Click(object sender, EventArgs e)
        {
            
                DB_Connect();
                comm = new OracleCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from stock where drug_name ='" + drugnameBox.Text + "'";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "stock");
                dt = ds.Tables["stock"];
                int t = dt.Rows.Count;
                try
                {
                    dr = dt.Rows[i];
                    MessageBox.Show("Drug Name " + drugnameBox.Text + "\n" + "Drug ID " + dr["S_ID"] + "\n" + "Drug Quantity " + dr["Quantity"]);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Drug not found");
                }

        }

        private void searchIdButton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from stock where S_ID ='" + drugIDBox.Text + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "stock");
            dt = ds.Tables["stock"];
            int t = dt.Rows.Count;
            try
            {
                dr = dt.Rows[i];
                MessageBox.Show("Drug Name " + dr["drug_name"] + "\n" + "Drug ID " + dr["S_ID"] + "\n" + "Drug Quantity " + dr["Quantity"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drug not found");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}