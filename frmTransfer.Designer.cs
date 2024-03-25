namespace Requirements_Engineering_BankingSYS
{
    partial class frmTransfer
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSenderID = new System.Windows.Forms.TextBox();
            this.txtRecieverID = new System.Windows.Forms.TextBox();
            this.lblRecieverID = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSenderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSenderID
            // 
            this.txtSenderID.Location = new System.Drawing.Point(83, 24);
            this.txtSenderID.Name = "txtSenderID";
            this.txtSenderID.Size = new System.Drawing.Size(121, 20);
            this.txtSenderID.TabIndex = 21;
            // 
            // txtRecieverID
            // 
            this.txtRecieverID.Location = new System.Drawing.Point(83, 91);
            this.txtRecieverID.Name = "txtRecieverID";
            this.txtRecieverID.Size = new System.Drawing.Size(121, 20);
            this.txtRecieverID.TabIndex = 20;
            // 
            // lblRecieverID
            // 
            this.lblRecieverID.AutoSize = true;
            this.lblRecieverID.Location = new System.Drawing.Point(19, 94);
            this.lblRecieverID.Name = "lblRecieverID";
            this.lblRecieverID.Size = new System.Drawing.Size(61, 13);
            this.lblRecieverID.TabIndex = 19;
            this.lblRecieverID.Text = "RecieverID";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(22, 134);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(19, 62);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(83, 59);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // lblSenderID
            // 
            this.lblSenderID.AutoSize = true;
            this.lblSenderID.Location = new System.Drawing.Point(19, 27);
            this.lblSenderID.Name = "lblSenderID";
            this.lblSenderID.Size = new System.Drawing.Size(52, 13);
            this.lblSenderID.TabIndex = 15;
            this.lblSenderID.Text = "SenderID";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 187);
            this.Controls.Add(this.txtSenderID);
            this.Controls.Add(this.txtRecieverID);
            this.Controls.Add(this.lblRecieverID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblSenderID);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSenderID;
        private System.Windows.Forms.TextBox txtRecieverID;
        private System.Windows.Forms.Label lblRecieverID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSenderID;
    }
}