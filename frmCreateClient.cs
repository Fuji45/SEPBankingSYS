using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Requirements_Engineering_BankingSYS
{
    public partial class frmCreateClient : Form
    {
        public frmCreateClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtForename.Text))
            {
                MessageBox.Show("Please enter an forename", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Please enter a surname", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter an phonenumber", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate ALL the input data

            //Create an instance of Product and instantiate with values from form controls
            Clients clientInfo = new Clients(
                txtForename.Text,
                txtSurname.Text,
                txtEmail.Text,
                Convert.ToInt32(txtPhoneNumber.Text));

            //invoke the method to add the data to the Products table
            clientInfo.addClients();

            //display confirmation message
            MessageBox.Show("Client " + txtClientId.Text + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtClientId.Text = Clients.getNextClientId().ToString("0000");
            txtForename.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            










        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
