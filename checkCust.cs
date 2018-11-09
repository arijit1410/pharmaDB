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
    public partial class checkCust : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public checkCust()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void checkCustbutton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();            
            comm.CommandText = "select * from customer";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "customer");
            dt = ds.Tables["customer"];
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customer";
            conn.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }       
    }
}
