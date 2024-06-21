namespace BankAccountManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_AddAccount = new Button();
            input_OwnerName = new TextBox();
            inout_Balance = new TextBox();
            input_AccountNumber = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button_Search = new Button();
            input_SearchAccountNumber = new TextBox();
            label5 = new Label();
            output_OwnerName = new Label();
            output_Balance = new Label();
            label6 = new Label();
            label7 = new Label();
            button_Exit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_AddAccount);
            groupBox1.Controls.Add(input_OwnerName);
            groupBox1.Controls.Add(inout_Balance);
            groupBox1.Controls.Add(input_AccountNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add an Account";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button_AddAccount
            // 
            button_AddAccount.Location = new Point(19, 203);
            button_AddAccount.Name = "button_AddAccount";
            button_AddAccount.Size = new Size(535, 48);
            button_AddAccount.TabIndex = 4;
            button_AddAccount.Text = "Add Account";
            button_AddAccount.UseVisualStyleBackColor = true;
            button_AddAccount.Click += button_AddAccount_Click;
            // 
            // input_OwnerName
            // 
            input_OwnerName.BorderStyle = BorderStyle.FixedSingle;
            input_OwnerName.Location = new Point(201, 153);
            input_OwnerName.Name = "input_OwnerName";
            input_OwnerName.Size = new Size(353, 33);
            input_OwnerName.TabIndex = 3;
            // 
            // inout_Balance
            // 
            inout_Balance.BorderStyle = BorderStyle.FixedSingle;
            inout_Balance.Location = new Point(201, 98);
            inout_Balance.Name = "inout_Balance";
            inout_Balance.Size = new Size(353, 33);
            inout_Balance.TabIndex = 2;
            // 
            // input_AccountNumber
            // 
            input_AccountNumber.BorderStyle = BorderStyle.FixedSingle;
            input_AccountNumber.Location = new Point(201, 43);
            input_AccountNumber.Name = "input_AccountNumber";
            input_AccountNumber.Size = new Size(353, 33);
            input_AccountNumber.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 157);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 0;
            label3.Text = "Owner Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 0;
            label2.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Number:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(656, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(565, 554);
            listBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(656, 56);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 2;
            label4.Text = "Accounts List View";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_Search);
            groupBox2.Controls.Add(input_SearchAccountNumber);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(output_OwnerName);
            groupBox2.Controls.Add(output_Balance);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(45, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 272);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search for an Account";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(19, 212);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(535, 48);
            button_Search.TabIndex = 4;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // input_SearchAccountNumber
            // 
            input_SearchAccountNumber.BorderStyle = BorderStyle.FixedSingle;
            input_SearchAccountNumber.Location = new Point(201, 43);
            input_SearchAccountNumber.Name = "input_SearchAccountNumber";
            input_SearchAccountNumber.Size = new Size(353, 33);
            input_SearchAccountNumber.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 157);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 0;
            label5.Text = "Owner Name:";
            // 
            // output_OwnerName
            // 
            output_OwnerName.BorderStyle = BorderStyle.FixedSingle;
            output_OwnerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output_OwnerName.Location = new Point(201, 147);
            output_OwnerName.Name = "output_OwnerName";
            output_OwnerName.Size = new Size(353, 53);
            output_OwnerName.TabIndex = 0;
            output_OwnerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // output_Balance
            // 
            output_Balance.BorderStyle = BorderStyle.FixedSingle;
            output_Balance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output_Balance.Location = new Point(201, 85);
            output_Balance.Name = "output_Balance";
            output_Balance.Size = new Size(353, 53);
            output_Balance.TabIndex = 0;
            output_Balance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 102);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 0;
            label6.Text = "Balance:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 47);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 0;
            label7.Text = "Account Number:";
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(45, 603);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(572, 48);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 687);
            Controls.Add(button_Exit);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Bank Account Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox input_OwnerName;
        private TextBox inout_Balance;
        private TextBox input_AccountNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_AddAccount;
        private ListBox listBox1;
        private Label label4;
        private GroupBox groupBox2;
        private Button button_Search;
        private TextBox input_SearchAccountNumber;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label output_OwnerName;
        private Label output_Balance;
        private Button button_Exit;
    }
}
