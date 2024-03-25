using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requirements_Engineering_BankingSYS
{
    public partial class frmDepositMortgage : Form
    {
        public frmDepositMortgage()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMortgageId.Text))
            {
                MessageBox.Show("Please enter an Mortgage ID", "Missing Mortgage ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an ammount", "Missing Ammount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else MessageBox.Show("Mortgage Deposit Successfully Made", "Transaction Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
