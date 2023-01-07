namespace BankSystem
{
    partial class User
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBalance = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposite = new System.Windows.Forms.Button();
            this.loan = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 78);
            this.panel2.TabIndex = 2;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(560, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(454, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // checkBalance
            // 
            this.checkBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.checkBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBalance.ForeColor = System.Drawing.Color.White;
            this.checkBalance.Location = new System.Drawing.Point(182, 143);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(308, 50);
            this.checkBalance.TabIndex = 4;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = false;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(182, 228);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(308, 47);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            // 
            // deposite
            // 
            this.deposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deposite.ForeColor = System.Drawing.Color.White;
            this.deposite.Location = new System.Drawing.Point(182, 312);
            this.deposite.Name = "deposite";
            this.deposite.Size = new System.Drawing.Size(308, 47);
            this.deposite.TabIndex = 6;
            this.deposite.Text = "Deposite";
            this.deposite.UseVisualStyleBackColor = false;
            // 
            // loan
            // 
            this.loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loan.ForeColor = System.Drawing.Color.White;
            this.loan.Location = new System.Drawing.Point(182, 457);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(308, 47);
            this.loan.TabIndex = 7;
            this.loan.Text = "Take Loan";
            this.loan.UseVisualStyleBackColor = false;
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transfer.ForeColor = System.Drawing.Color.White;
            this.transfer.Location = new System.Drawing.Point(182, 380);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(308, 47);
            this.transfer.TabIndex = 9;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(705, 580);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deposite);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.panel2);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Button checkBalance;
        private Button withdraw;
        private Button deposite;
        private Button loan;
        private Button transfer;
    }
}