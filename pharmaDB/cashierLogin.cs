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
    public partial class cashierLogin : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public cashierLogin()
        {
            
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void casLoginButton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from cashier where username ='" + textBox1.Text + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds,"cashier");
            dt = ds.Tables["cashier"];
            int t = dt.Rows.Count;
            try
            {
                dr = dt.Rows[i];
                if (textBox2.Text.ToString().Equals(dr["password"].ToString()))
                {
                    cashier cf = new cashier();
                    cf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username");
                textBox1.Clear();
                textBox2.Clear();
            }
            
            
            //MessageBox.Show(dr["password"].ToString());
            //if (textBox2.Text.ToString().Equals(dr["password"].ToString()))
            //{
            //    cashier cf = new cashier();
            //    cf.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Password");
            //}
            
        }

        private void cashierLogin_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
