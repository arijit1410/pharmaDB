using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace pharmaDB
{
    public partial class cashier : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleCommand comm2;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        OracleDataAdapter da1;
        DataSet ds1;
        DataTable dt1;
        DataRow dr1;
        OracleDataAdapter da2;
        DataSet ds2;
        DataTable dt2;
        DataRow dr2;
        int i = 0;
        int j = 0;
        public cashier()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void CasInvoicebutton_Click(object sender, EventArgs e)
        {

            
            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            //comm.CommandText = "select * from cashier where username ='" + textBox1.Text + "'";
            
            comm.CommandText = "insert into prescription values('" + pIDbox.Text + "','" + cIDbox.Text + "','" + dNamebox.Text + "','" + strengthbox.Text + "','" + dosagebox.Text + "','" + quantbox.Text + "')";
            comm.ExecuteNonQuery();
            MessageBox.Show("Updated stock! Generating invoice...");
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");
            string fileName = @"C:\Temp\" +formattedTime+".txt";
            int price1 = int.Parse(textBox1.Text);
            int price2 = int.Parse(quantbox.Text);
            int total = price1 * price2;
            using (var tw = new StreamWriter(fileName, true))
            {
                tw.WriteLine("**************************************Hello Welcome to pharmaDB**************************************");
                tw.WriteLine("Customer ID :-" + cIDbox.Text);
                tw.WriteLine("Prescription ID :-" + pIDbox.Text);
                tw.WriteLine("Drug Name :-" + dNamebox.Text);
                tw.WriteLine("Strength :-" + strengthbox.Text);
                tw.WriteLine("Dosage :-" + dosagebox.Text);
                tw.WriteLine("Quantity :-" + quantbox.Text);
                tw.WriteLine("Total Price :-" + total);

            }
            

        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            pIDbox.Clear();
            cIDbox.Clear();
            dNamebox.Clear();
            strengthbox.Clear();
            dosagebox.Clear();
            quantbox.Clear();
        }

        private void Cnfrmbutton_Click(object sender, EventArgs e)
        {
        
            DB_Connect();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
           
            comm.CommandText = "select quantity,drug_name from stock where drug_name ='" + dNamebox.Text + "'";
            //comm.CommandText = "update stock set quantity = 785 where drug_name = 'Becosules'";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "stock");
            dt = ds.Tables["stock"];
            int t = dt.Rows.Count;
            try
            {
                dr = dt.Rows[i];
                int quant = int.Parse(quantbox.Text);
                String quant2 = dr["quantity"].ToString();
                int quant1 = int.Parse(quant2);





                if (quant1 > quant)
                {
                    // comm2 = new OracleCommand();
                    DB_Connect();
                    OracleCommand comm2 = new OracleCommand();
                    comm2.Connection = conn;
                    int new_quant = quant1 - quant;
                    comm2.CommandText = "call update_transaction('" + new_quant + "','" + dNamebox.Text + "')";
                    comm2.CommandType = CommandType.Text;
                    comm2.ExecuteNonQuery();
                    MessageBox.Show("Updated Quantity for " + dr["drug_name"] + " = " + new_quant);
                    //conn.Close();
                }
                else
                {
                    MessageBox.Show("Not enough stock");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("P_ID exists. Invalid Data.");
            }
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void CustReceiptbutton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;

            comm.CommandText = "select * from customer where cust_id ='" + cIDbox.Text + "'";
            //comm.CommandText = "update stock set quantity = 785 where drug_name = 'Becosules'";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "customer");
            dt = ds.Tables["customer"];
            int t = dt.Rows.Count;
            dr = dt.Rows[i];

            DB_Connect();
            OracleCommand comm2 = new OracleCommand();
            comm2.Connection = conn;

            comm2.CommandText = "select cost,quantity from stock where drug_name ='" + dNamebox.Text + "'";
            //comm.CommandText = "update stock set quantity = 785 where drug_name = 'Becosules'";
            comm2.CommandType = CommandType.Text;
            comm2.ExecuteNonQuery();
            conn.Close();
            ds1= new DataSet();
            da1 = new OracleDataAdapter(comm.CommandText, conn);
            da1.Fill(ds, "stock");
            dt1 = ds.Tables["stock"];
            int t1 = dt.Rows.Count;
            dr2 = dt.Rows[j];

            MessageBox.Show(dr["cust_name"] + " " + dr2["cost"]);
        


        }        
    }
}
