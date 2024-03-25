using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Requirements_Engineering_BankingSYS
{

    class Clients {

        private int clientId;
        private string forename;
        private string surname;
        private string email;
        private int phoneNo;

        
        public Clients() {

            this.clientId = 0;
            this.forename = "";
            this.surname = "";
            this.email = "";
            this.phoneNo = 0;

        }

        public void addClient()
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Clients Values (" +
                this.clientId + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.email + "'," +
                this.phoneNo + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();


        }


    }

    class Accounts
    {

        private int accountId;
        private float balance;
        private string status;
        private string accountType;
        private int clientId;


        public Accounts()
        {

            this.accountId = 0;
            this.balance = 0;
            this.status = "";
            this.accountType = "";
            this.clientId = 0;

        }

        public void addAccount()
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Accounts Values (" +
                this.accountId + ",'" +
                this.balance + "','" +
                this.status + "','" +
                this.accountType + "'," +
                this.clientId + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();


        }

        class Transaction
        {

            private int transactionId;
            private float amount;
            private string transactionType;
            private string dateOn;
            private int accountId;


            public Transaction()
            {

                this.transactionId = 0;
                this.amount = 0;
                this.transactionType = "";
                this.dateOn = "";
                this.accountId = 0;

            }

            public void addTransaction()
            {

                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //Define the SQL query to be executed
                String sqlQuery = "INSERT INTO Transactions Values (" +
                    this.transactionId + ",'" +
                    this.amount + "','" +
                    this.transactionType + "','" +
                    this.dateOn + "'," +
                    this.accountId + "')";

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();


            }


        }


    }


}
