using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Requirements_Engineering_BankingSYS
{
    public partial class frmMainMenu : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oraDB);
        public frmMainMenu()
        {
            InitializeComponent();
        }
        class DBConnect
        {

            public const String oraDB = "Data Source = studentoracle:1521/orcl; User ID = T00217285; Password = kfd!4w3tudN7;";
            

        }

        private void withToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeTxt_Click(object sender, EventArgs e)
        {

        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmCreateClient();
            newForm.ShowDialog();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmUpdateClient();
            newForm.ShowDialog();
        }

        private void createAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newForm = new frmCreateAccount();
            newForm.ShowDialog();
        }

        private void updateAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newForm = new frmUpdateAccount();
            newForm.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmCloseAccount();
            newForm.ShowDialog();
        }

        private void printStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmStatements();
            newForm.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmDeposit();
            newForm.ShowDialog();
        }

        private void withdrawalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newForm = new frmWithdrawal();
            newForm.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new frmTransfer();
            newForm.ShowDialog();
        }

        private void createMortgageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newForm = new frmCreateMortgage();
            newForm.ShowDialog();
        }

        private void depositMortgageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newForm = new frmDepositMortgage();
            newForm.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                lblStatus.Text = "CLOSED";
                lblStatus.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                conn.Open();
                lblStatus.Text = "OPEN";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
