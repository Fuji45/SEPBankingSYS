namespace Requirements_Engineering_BankingSYS
{
    partial class frmCreateMortgage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMortgageAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMortgageAmount
            // 
            this.lblMortgageAmount.AutoSize = true;
            this.lblMortgageAmount.Location = new System.Drawing.Point(25, 93);
            this.lblMortgageAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMortgageAmount.Name = "lblMortgageAmount";
            this.lblMortgageAmount.Size = new System.Drawing.Size(43, 13);
            this.lblMortgageAmount.TabIndex = 9;
            this.lblMortgageAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 89);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(25, 49);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 13);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "ClientId";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(112, 46);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(76, 20);
            this.txtClientId.TabIndex = 5;
            // 
            // frmCreateMortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 269);
            this.Controls.Add(this.lblMortgageAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtClientId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateMortgage";
            this.Text = "frmCreateMortgage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMortgageAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClientId;
    }
}