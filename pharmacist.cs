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
    public partial class pharmacist : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public pharmacist()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void pharmacist_Load(object sender, EventArgs e)
        {
            AddManLabel.Hide();
            AddCasLabel.Hide();
            fnameBox.Hide();
            fnameLabel.Hide();
            lnameBox.Hide();
            lnameLabel.Hide();
            staffIDBox.Hide();
            staffIDLabel.Hide();
            addressBox.Hide();
            addressLabel.Hide();
            phoneBox.Hide();
            phoneLabel.Hide();
            emailBox.Hide();
            emailLabel.Hide();
            unameBox.Hide();
            unameLabel.Hide();
            pswdBox.Hide();
            pswdLabel.Hide();
            ManAddButton.Hide();
            CasAddbutton.Hide();
            backButton.Hide();
            clearButton.Hide();
        }

        private void addManButton_Click(object sender, EventArgs e)
        {
            addManButton.Hide();
            addCasButton.Hide();
            checkStockButton.Hide();
            checkCustButton.Hide();
            checkPreButton.Hide();
            AddManLabel.Show();
            AddCasLabel.Hide();
            fnameBox.Show();
            fnameLabel.Show();
            lnameBox.Show();
            lnameLabel.Show();
            staffIDBox.Show();
            staffIDLabel.Show();
            addressBox.Show();
            addressLabel.Show();
            phoneBox.Show();
            phoneLabel.Show();
            emailBox.Show();
            emailLabel.Show();
            unameBox.Show();
            unameLabel.Show();
            pswdBox.Show();
            pswdLabel.Show();
            ManAddButton.Show();
            CasAddbutton.Hide();
            backButton.Show();

            clearButton.Show();
        }

        private void addCasButton_Click(object sender, EventArgs e)
        {
            addManButton.Hide();
            addCasButton.Hide();
            checkStockButton.Hide();
            checkCustButton.Hide();
            checkPreButton.Hide();
            AddManLabel.Hide();
            AddCasLabel.Show();
            fnameBox.Show();
            fnameLabel.Show();
            lnameBox.Show();
            lnameLabel.Show();
            staffIDBox.Show();
            staffIDLabel.Show();
            addressBox.Show();
            addressLabel.Show();
            phoneBox.Show();
            phoneLabel.Show();
            emailBox.Show();
            emailLabel.Show();
            unameBox.Show();
            unameLabel.Show();
            pswdBox.Show();
            pswdLabel.Show();
            CasAddbutton.Show();
            ManAddButton.Hide();
            backButton.Show();

            clearButton.Show();
        }
        private void ManAddButton_Click(object sender, EventArgs e)
        {
            DB_Connect();            
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "call insert_manager('" + staffIDBox.Text + "','" + fnameBox.Text + "','" + lnameBox.Text + "','" + addressBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','"+unameBox.Text+"','"+pswdBox.Text+"')";
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Added Manager");
                comm.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Staff ID exists/Data Invalid");
            }

        }

        private void CasAddbutton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "call insert_cashier('" + staffIDBox.Text + "','" + fnameBox.Text + "','" + lnameBox.Text + "','" + addressBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','" + unameBox.Text + "','" + pswdBox.Text + "')";
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Added Cashier");
                comm.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Staff ID exists/Data Invalid");
            }
        }

        private void checkStockButton_Click(object sender, EventArgs e)
        {
            checkStock cs = new checkStock();
            cs.Show();
            this.Hide();
        }

        private void checkCustButton_Click(object sender, EventArgs e)
        {
            checkCust cc = new checkCust();
            cc.Show();
            this.Hide();
        }

        private void checkPreButton_Click(object sender, EventArgs e)
        {
            checkPrescription cp = new checkPrescription();
            cp.Show();
            this.Hide();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            addManButton.Show();
            addCasButton.Show();
            checkStockButton.Show();
            checkCustButton.Show();
            checkPreButton.Show();
            AddManLabel.Hide();
            AddCasLabel.Hide();
            fnameBox.Hide();
            fnameLabel.Hide();
            lnameBox.Hide();
            lnameLabel.Hide();
            staffIDBox.Hide();
            staffIDLabel.Hide();
            addressBox.Hide();
            addressLabel.Hide();
            phoneBox.Hide();
            phoneLabel.Hide();
            emailBox.Hide();
            emailLabel.Hide();
            unameBox.Hide();
            unameLabel.Hide();
            pswdBox.Hide();
            pswdLabel.Hide();
            ManAddButton.Hide();
            CasAddbutton.Hide();
            backButton.Hide();
            clearButton.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fnameBox.Clear();
            lnameBox.Clear();
            staffIDBox.Clear();
            addressBox.Clear();
            phoneBox.Clear();
            emailBox.Clear();
            unameBox.Clear();
            pswdBox.Clear();
        }
    }
}
