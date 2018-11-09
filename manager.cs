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
    public partial class manager : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public manager()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            string oradb = "Data Source =LAPTOP-G3T7LJ1N; User ID =SYSTEM; Password =agcmssn";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            AddMedLabel.Hide();
            deleteMedLabel.Hide();
            checkStockLabel.Hide();
            drugnameBox.Hide();
            drugnameLabel.Hide();
            categoryBox.Hide();
            categoryLabel.Hide();
            updateStocklabel.Hide();
            descBox.Hide();
            descLabel.Hide();
            companyBox.Hide();
            companyLabel.Hide();
            supplierBox.Hide();
            supplierLabel.Hide();
            quantityBox.Hide();
            quantityLabel.Hide();
            costBox.Hide();
            costLabel.Hide();
            drugIDLabel.Hide();
            drugIDBox.Hide();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Hide();
            dateLabel.Hide();
            AddButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            updateButton.Hide();
            backButton.Hide();
            clearButton.Hide();
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            
            addStockButton.Hide();
            delStockButton.Hide();
            checkStockbutton.Hide();
            updateStockButton.Hide();
            AddMedLabel.Show();
            deleteMedLabel.Hide();
            checkStockLabel.Hide();
            updateStocklabel.Hide();
            drugnameBox.Show();
            drugnameLabel.Show();
            categoryBox.Show();
            categoryLabel.Show();
            descBox.Show();
            descLabel.Show();
            companyBox.Show();
            companyLabel.Show();
            supplierBox.Show();
            supplierLabel.Show();
            quantityBox.Show();
            quantityLabel.Show();
            costBox.Show();
            costLabel.Show();
            drugIDLabel.Show();
            drugIDBox.Show();
            statusLabel.Show();
            statusBox.Show();
            dateBox.Show();
            dateLabel.Show();
            AddButton.Show();
            deleteButton.Hide();
            checkButton.Hide();
            updateButton.Hide();
            backButton.Show();
            clearButton.Show();
        }

        private void delStockButton_Click(object sender, EventArgs e)
        {
            addStockButton.Hide();
            delStockButton.Hide();
            checkStockbutton.Hide();
            updateStockButton.Hide();
            AddMedLabel.Hide();
            deleteMedLabel.Show();
            checkStockLabel.Hide();
            updateStocklabel.Hide();
            drugnameBox.Show();
            drugnameLabel.Show();
            categoryBox.Hide();
            categoryLabel.Hide();
            descBox.Hide();
            descLabel.Hide();
            companyBox.Hide();
            companyLabel.Hide();
            supplierBox.Hide();
            supplierLabel.Hide();
            quantityBox.Hide();
            quantityLabel.Hide();
            costBox.Hide();
            costLabel.Hide();
            drugIDLabel.Show();
            drugIDBox.Show();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Hide();
            dateLabel.Hide();
            AddButton.Hide();
            deleteButton.Show();
            checkButton.Hide();
            updateButton.Hide();
            backButton.Show();
            clearButton.Show();
        }

        private void checkStockbutton_Click(object sender, EventArgs e)
        {
            addStockButton.Hide();
            delStockButton.Hide();
            checkStockbutton.Hide();
            updateStockButton.Hide();
            AddMedLabel.Hide();
            deleteMedLabel.Hide();
            checkStockLabel.Show();
            updateStocklabel.Hide();
            drugnameBox.Show();
            drugnameLabel.Show();
            categoryBox.Show();
            categoryLabel.Show();
            descBox.Show();
            descLabel.Show();
            companyBox.Show();
            companyLabel.Show();
            supplierBox.Show();
            supplierLabel.Show();
            quantityBox.Show();
            quantityLabel.Show();
            costBox.Show();
            costLabel.Show();
            drugIDLabel.Show();
            drugIDBox.Show();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Show();
            dateLabel.Show();
            AddButton.Hide();
            deleteButton.Hide();
            checkButton.Show();
            updateButton.Hide();
            backButton.Show();
            checkStock cs = new checkStock();
            cs.Show();
            this.Hide();
        }

        private void updateStockButton_Click(object sender, EventArgs e)
        {
            addStockButton.Hide();
            delStockButton.Hide();
            checkStockbutton.Hide();
            updateStockButton.Hide();
            AddMedLabel.Hide();
            deleteMedLabel.Hide();
            checkStockLabel.Hide();
            updateStocklabel.Show();
            drugnameBox.Show();
            drugnameLabel.Show();
            categoryBox.Hide();
            categoryLabel.Hide();
            descBox.Hide();
            descLabel.Hide();
            companyBox.Hide();
            companyLabel.Hide();
            supplierBox.Hide();
            supplierLabel.Hide();
            quantityBox.Show();
            quantityLabel.Show();
            costBox.Hide();
            costLabel.Hide();
            drugIDLabel.Hide();
            drugIDBox.Hide();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Hide();
            dateLabel.Hide();
            AddButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            updateButton.Show();
            backButton.Show();

            clearButton.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            int quant = int.Parse(quantityBox.Text);
            comm.CommandText = "call update_stock(" + quant + ",'" + drugnameBox.Text + "')"; 
            
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Updated stock.");
                comm.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Medicine name does not exists");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "call insert_stock('" + drugIDBox.Text + "','" + drugnameBox.Text + "','" + categoryBox.Text + "','" + descBox.Text + "','" + companyBox.Text + "','" + supplierBox.Text + "','" + quantityBox.Text + "','" + costBox.Text + "','" + statusBox.Text + "','" + dateBox.Text + "')";
            
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Added into stock.");
                comm.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock ID exists/Data Invalid");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            DB_Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "Delete from stock where drug_name = '" + drugnameBox.Text + "' and S_ID = '" + drugIDBox.Text + "'";
            comm.ExecuteNonQuery();
            MessageBox.Show(drugnameBox.Text +" removed from stock");
            comm.CommandType = CommandType.Text;
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            addStockButton.Show();
            delStockButton.Show();
            checkStockbutton.Show();
            updateStockButton.Show();
            AddMedLabel.Hide();
            deleteMedLabel.Hide();
            checkStockLabel.Hide();
            drugnameBox.Hide();
            drugnameLabel.Hide();
            categoryBox.Hide();
            categoryLabel.Hide();
            updateStocklabel.Hide();
            descBox.Hide();
            descLabel.Hide();
            companyBox.Hide();
            companyLabel.Hide();
            supplierBox.Hide();
            supplierLabel.Hide();
            quantityBox.Hide();
            quantityLabel.Hide();
            costBox.Hide();
            costLabel.Hide();
            drugIDLabel.Hide();
            drugIDBox.Hide();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Hide();
            dateLabel.Hide();
            AddButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            updateButton.Hide(); 
            AddMedLabel.Hide();
            deleteMedLabel.Hide();
            checkStockLabel.Hide();
            drugnameBox.Hide();
            drugnameLabel.Hide();
            categoryBox.Hide();
            categoryLabel.Hide();
            updateStocklabel.Hide();
            descBox.Hide();
            descLabel.Hide();
            companyBox.Hide();
            companyLabel.Hide();
            supplierBox.Hide();
            supplierLabel.Hide();
            quantityBox.Hide();
            quantityLabel.Hide();
            costBox.Hide();
            costLabel.Hide();
            drugIDLabel.Hide();
            drugIDBox.Hide();
            statusLabel.Hide();
            statusBox.Hide();
            dateBox.Hide();
            dateLabel.Hide();
            AddButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            updateButton.Hide();
            backButton.Hide();
            clearButton.Hide();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            drugnameBox.Clear();
            drugIDBox.Clear();
            categoryBox.Clear();
            descBox.Clear();
            companyBox.Clear();
            supplierBox.Clear();
            quantityBox.Clear();
            costBox.Clear();
            statusBox.Clear();
            dateBox.Clear();
        }
    }
}
