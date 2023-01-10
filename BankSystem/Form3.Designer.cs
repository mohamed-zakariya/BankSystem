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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBalance = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.ShowTransactions = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(586, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // checkBalance
            // 
            this.checkBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.checkBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBalance.ForeColor = System.Drawing.Color.White;
            this.checkBalance.Location = new System.Drawing.Point(409, 110);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(308, 50);
            this.checkBalance.TabIndex = 4;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = false;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(409, 195);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(308, 47);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deposit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.deposit.ForeColor = System.Drawing.Color.White;
            this.deposit.Location = new System.Drawing.Point(409, 279);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(308, 47);
            this.deposit.TabIndex = 6;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposite_Click);
            // 
            // ShowTransactions
            // 
            this.ShowTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ShowTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowTransactions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ShowTransactions.ForeColor = System.Drawing.Color.White;
            this.ShowTransactions.Location = new System.Drawing.Point(409, 424);
            this.ShowTransactions.Name = "ShowTransactions";
            this.ShowTransactions.Size = new System.Drawing.Size(308, 47);
            this.ShowTransactions.TabIndex = 7;
            this.ShowTransactions.Text = "Show Transactions";
            this.ShowTransactions.UseVisualStyleBackColor = false;
            this.ShowTransactions.Click += new System.EventHandler(this.ShowTransactions_Click);
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.transfer.ForeColor = System.Drawing.Color.White;
            this.transfer.Location = new System.Drawing.Point(409, 347);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(308, 47);
            this.transfer.TabIndex = 9;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(8, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(52, 60);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(68, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton2.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(15, 587);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(77, 39);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ChangePassword.ForeColor = System.Drawing.Color.White;
            this.ChangePassword.Location = new System.Drawing.Point(409, 498);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(308, 47);
            this.ChangePassword.TabIndex = 12;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 652);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 284);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(835, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.ShowTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.checkBalance);
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button checkBalance;
        private Button withdraw;
        private Button deposit;
        private Button ShowTransactions;
        private Button transfer;
        private Label label1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button ChangePassword;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}