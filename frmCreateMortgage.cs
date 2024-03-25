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
    public partial class frmCreateMortgage : Form
    {
        public frmCreateMortgage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Please enter an ClientId", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please Select an AccountType", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
