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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter an Account ID", "Missing Account ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text != "admin" )
            {
                MessageBox.Show("Please enter the correct username.", "Incorrect username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter an ammount", "Missing Ammount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (txtPassword.Text != "1234")
            {
                MessageBox.Show("Please enter the correct password.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var newForm = new frmMainMenu();
            newForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
