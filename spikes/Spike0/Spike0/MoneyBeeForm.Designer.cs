namespace Spike0
{
    partial class MoneyBeeForm
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
            this.tcHeaderTabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tbTotalExpenses = new System.Windows.Forms.TextBox();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.tbActualIncome = new System.Windows.Forms.TextBox();
            this.lblActualIncome = new System.Windows.Forms.Label();
            this.tbProjectedIncome = new System.Windows.Forms.TextBox();
            this.lblProjectedIncome = new System.Windows.Forms.Label();
            this.bNewTransaction = new System.Windows.Forms.Button();
            this.bEditTransaction = new System.Windows.Forms.Button();
            this.listboxTransactionHistory = new System.Windows.Forms.ListBox();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.lblTotalBalanceValue = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.tabExpenditures = new System.Windows.Forms.TabPage();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCreateExpenditure = new System.Windows.Forms.Button();
            this.tcExpenditures = new System.Windows.Forms.TabControl();
            this.tpSample = new System.Windows.Forms.TabPage();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.lbMonthlyReport = new System.Windows.Forms.ListBox();
            this.lblDaysUntilReport = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.bPersonalSettings = new System.Windows.Forms.Button();
            this.bPaySettings = new System.Windows.Forms.Button();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.clbNotifications = new System.Windows.Forms.CheckedListBox();
            this.bLogOut = new System.Windows.Forms.Button();
            this.bDeleteAccount = new System.Windows.Forms.Button();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.lbExpenditures = new System.Windows.Forms.ListBox();
            this.tcHeaderTabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabExpenditures.SuspendLayout();
            this.tcExpenditures.SuspendLayout();
            this.tpSample.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHeaderTabs
            // 
            this.tcHeaderTabs.Controls.Add(this.tabMain);
            this.tcHeaderTabs.Controls.Add(this.tabExpenditures);
            this.tcHeaderTabs.Controls.Add(this.tabMonthlyReport);
            this.tcHeaderTabs.Controls.Add(this.tabSettings);
            this.tcHeaderTabs.Location = new System.Drawing.Point(12, 12);
            this.tcHeaderTabs.Name = "tcHeaderTabs";
            this.tcHeaderTabs.SelectedIndex = 0;
            this.tcHeaderTabs.Size = new System.Drawing.Size(850, 421);
            this.tcHeaderTabs.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbTotalExpenses);
            this.tabMain.Controls.Add(this.lblTotalExpenses);
            this.tabMain.Controls.Add(this.tbActualIncome);
            this.tabMain.Controls.Add(this.lblActualIncome);
            this.tabMain.Controls.Add(this.tbProjectedIncome);
            this.tabMain.Controls.Add(this.lblProjectedIncome);
            this.tabMain.Controls.Add(this.bNewTransaction);
            this.tabMain.Controls.Add(this.bEditTransaction);
            this.tabMain.Controls.Add(this.listboxTransactionHistory);
            this.tabMain.Controls.Add(this.lblTransactionHistory);
            this.tabMain.Controls.Add(this.lblTotalBalanceValue);
            this.tabMain.Controls.Add(this.lblTotalBalance);
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(842, 388);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tbTotalExpenses
            // 
            this.tbTotalExpenses.Location = new System.Drawing.Point(285, 34);
            this.tbTotalExpenses.Name = "tbTotalExpenses";
            this.tbTotalExpenses.Size = new System.Drawing.Size(129, 26);
            this.tbTotalExpenses.TabIndex = 12;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Location = new System.Drawing.Point(281, 11);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(118, 20);
            this.lblTotalExpenses.TabIndex = 11;
            this.lblTotalExpenses.Text = "Total Expenses";
            // 
            // tbActualIncome
            // 
            this.tbActualIncome.Location = new System.Drawing.Point(150, 34);
            this.tbActualIncome.Name = "tbActualIncome";
            this.tbActualIncome.Size = new System.Drawing.Size(129, 26);
            this.tbActualIncome.TabIndex = 10;
            // 
            // lblActualIncome
            // 
            this.lblActualIncome.AutoSize = true;
            this.lblActualIncome.Location = new System.Drawing.Point(150, 11);
            this.lblActualIncome.Name = "lblActualIncome";
            this.lblActualIncome.Size = new System.Drawing.Size(111, 20);
            this.lblActualIncome.TabIndex = 9;
            this.lblActualIncome.Text = "Actual Income";
            // 
            // tbProjectedIncome
            // 
            this.tbProjectedIncome.Location = new System.Drawing.Point(15, 34);
            this.tbProjectedIncome.Name = "tbProjectedIncome";
            this.tbProjectedIncome.Size = new System.Drawing.Size(129, 26);
            this.tbProjectedIncome.TabIndex = 8;
            // 
            // lblProjectedIncome
            // 
            this.lblProjectedIncome.AutoSize = true;
            this.lblProjectedIncome.Location = new System.Drawing.Point(11, 11);
            this.lblProjectedIncome.Name = "lblProjectedIncome";
            this.lblProjectedIncome.Size = new System.Drawing.Size(133, 20);
            this.lblProjectedIncome.TabIndex = 7;
            this.lblProjectedIncome.Text = "Projected Income";
            // 
            // bNewTransaction
            // 
            this.bNewTransaction.Location = new System.Drawing.Point(15, 345);
            this.bNewTransaction.Name = "bNewTransaction";
            this.bNewTransaction.Size = new System.Drawing.Size(174, 35);
            this.bNewTransaction.TabIndex = 6;
            this.bNewTransaction.Text = "New Transaction";
            this.bNewTransaction.UseVisualStyleBackColor = true;
            // 
            // bEditTransaction
            // 
            this.bEditTransaction.Location = new System.Drawing.Point(15, 304);
            this.bEditTransaction.Name = "bEditTransaction";
            this.bEditTransaction.Size = new System.Drawing.Size(141, 35);
            this.bEditTransaction.TabIndex = 4;
            this.bEditTransaction.Text = "Edit Transaction";
            this.bEditTransaction.UseVisualStyleBackColor = true;
            // 
            // listboxTransactionHistory
            // 
            this.listboxTransactionHistory.FormattingEnabled = true;
            this.listboxTransactionHistory.ItemHeight = 20;
            this.listboxTransactionHistory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listboxTransactionHistory.Location = new System.Drawing.Point(15, 94);
            this.listboxTransactionHistory.Name = "listboxTransactionHistory";
            this.listboxTransactionHistory.Size = new System.Drawing.Size(120, 204);
            this.listboxTransactionHistory.TabIndex = 3;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Location = new System.Drawing.Point(11, 70);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(145, 20);
            this.lblTransactionHistory.TabIndex = 2;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // lblTotalBalanceValue
            // 
            this.lblTotalBalanceValue.AutoSize = true;
            this.lblTotalBalanceValue.Location = new System.Drawing.Point(420, 34);
            this.lblTotalBalanceValue.Name = "lblTotalBalanceValue";
            this.lblTotalBalanceValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalBalanceValue.TabIndex = 1;
            this.lblTotalBalanceValue.Text = "0";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Location = new System.Drawing.Point(417, 11);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(106, 20);
            this.lblTotalBalance.TabIndex = 0;
            this.lblTotalBalance.Text = "Total Balance";
            // 
            // tabExpenditures
            // 
            this.tabExpenditures.Controls.Add(this.bDelete);
            this.tabExpenditures.Controls.Add(this.bCreateExpenditure);
            this.tabExpenditures.Controls.Add(this.tcExpenditures);
            this.tabExpenditures.Location = new System.Drawing.Point(4, 29);
            this.tabExpenditures.Name = "tabExpenditures";
            this.tabExpenditures.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenditures.Size = new System.Drawing.Size(842, 388);
            this.tabExpenditures.TabIndex = 1;
            this.tabExpenditures.Text = "Expenditures";
            this.tabExpenditures.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(191, 24);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(178, 39);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bCreateExpenditure
            // 
            this.bCreateExpenditure.Location = new System.Drawing.Point(7, 24);
            this.bCreateExpenditure.Name = "bCreateExpenditure";
            this.bCreateExpenditure.Size = new System.Drawing.Size(178, 39);
            this.bCreateExpenditure.TabIndex = 1;
            this.bCreateExpenditure.Text = "Create";
            this.bCreateExpenditure.UseVisualStyleBackColor = true;
            // 
            // tcExpenditures
            // 
            this.tcExpenditures.Controls.Add(this.tpSample);
            this.tcExpenditures.Location = new System.Drawing.Point(7, 69);
            this.tcExpenditures.Name = "tcExpenditures";
            this.tcExpenditures.SelectedIndex = 0;
            this.tcExpenditures.Size = new System.Drawing.Size(826, 313);
            this.tcExpenditures.TabIndex = 0;
            // 
            // tpSample
            // 
            this.tpSample.Controls.Add(this.lbExpenditures);
            this.tpSample.Location = new System.Drawing.Point(4, 29);
            this.tpSample.Name = "tpSample";
            this.tpSample.Size = new System.Drawing.Size(818, 280);
            this.tpSample.TabIndex = 0;
            this.tpSample.Text = "Sample";
            this.tpSample.UseVisualStyleBackColor = true;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Controls.Add(this.lbMonthlyReport);
            this.tabMonthlyReport.Controls.Add(this.lblDaysUntilReport);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 29);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Size = new System.Drawing.Size(842, 388);
            this.tabMonthlyReport.TabIndex = 2;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // lbMonthlyReport
            // 
            this.lbMonthlyReport.FormattingEnabled = true;
            this.lbMonthlyReport.ItemHeight = 20;
            this.lbMonthlyReport.Items.AddRange(new object[] {
            "Sample1",
            "Sample2",
            "Sample3"});
            this.lbMonthlyReport.Location = new System.Drawing.Point(8, 28);
            this.lbMonthlyReport.Name = "lbMonthlyReport";
            this.lbMonthlyReport.Size = new System.Drawing.Size(825, 344);
            this.lbMonthlyReport.TabIndex = 1;
            // 
            // lblDaysUntilReport
            // 
            this.lblDaysUntilReport.AutoSize = true;
            this.lblDaysUntilReport.Location = new System.Drawing.Point(4, 4);
            this.lblDaysUntilReport.Name = "lblDaysUntilReport";
            this.lblDaysUntilReport.Size = new System.Drawing.Size(208, 20);
            this.lblDaysUntilReport.TabIndex = 0;
            this.lblDaysUntilReport.Text = "X Days Until Monthly Report";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.bPersonalSettings);
            this.tabSettings.Controls.Add(this.bPaySettings);
            this.tabSettings.Controls.Add(this.lblNotifications);
            this.tabSettings.Controls.Add(this.clbNotifications);
            this.tabSettings.Controls.Add(this.bLogOut);
            this.tabSettings.Controls.Add(this.bDeleteAccount);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(842, 388);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // bPersonalSettings
            // 
            this.bPersonalSettings.Location = new System.Drawing.Point(8, 282);
            this.bPersonalSettings.Name = "bPersonalSettings";
            this.bPersonalSettings.Size = new System.Drawing.Size(146, 46);
            this.bPersonalSettings.TabIndex = 5;
            this.bPersonalSettings.Text = "Personal Settings";
            this.bPersonalSettings.UseVisualStyleBackColor = true;
            // 
            // bPaySettings
            // 
            this.bPaySettings.Location = new System.Drawing.Point(7, 230);
            this.bPaySettings.Name = "bPaySettings";
            this.bPaySettings.Size = new System.Drawing.Size(146, 46);
            this.bPaySettings.TabIndex = 4;
            this.bPaySettings.Text = "Pay Settings";
            this.bPaySettings.UseVisualStyleBackColor = true;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(3, 132);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(96, 20);
            this.lblNotifications.TabIndex = 3;
            this.lblNotifications.Text = "Notifications";
            // 
            // clbNotifications
            // 
            this.clbNotifications.FormattingEnabled = true;
            this.clbNotifications.Items.AddRange(new object[] {
            "email",
            "push"});
            this.clbNotifications.Location = new System.Drawing.Point(3, 155);
            this.clbNotifications.Name = "clbNotifications";
            this.clbNotifications.Size = new System.Drawing.Size(150, 67);
            this.clbNotifications.TabIndex = 2;
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(4, 50);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(150, 40);
            this.bLogOut.TabIndex = 1;
            this.bLogOut.Text = "Log Out";
            this.bLogOut.UseVisualStyleBackColor = true;
            // 
            // bDeleteAccount
            // 
            this.bDeleteAccount.Location = new System.Drawing.Point(4, 4);
            this.bDeleteAccount.Name = "bDeleteAccount";
            this.bDeleteAccount.Size = new System.Drawing.Size(150, 40);
            this.bDeleteAccount.TabIndex = 0;
            this.bDeleteAccount.Text = "Delete Account";
            this.bDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // lblTestDate
            // 
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Location = new System.Drawing.Point(12, 448);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(79, 20);
            this.lblTestDate.TabIndex = 5;
            this.lblTestDate.Text = "Test Date";
            // 
            // lbExpenditures
            // 
            this.lbExpenditures.FormattingEnabled = true;
            this.lbExpenditures.ItemHeight = 20;
            this.lbExpenditures.Items.AddRange(new object[] {
            "Sample Expenditure",
            "Sample Expenditure 2"});
            this.lbExpenditures.Location = new System.Drawing.Point(4, 4);
            this.lbExpenditures.Name = "lbExpenditures";
            this.lbExpenditures.Size = new System.Drawing.Size(212, 84);
            this.lbExpenditures.TabIndex = 0;
            // 
            // MoneyBeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 477);
            this.Controls.Add(this.tcHeaderTabs);
            this.Controls.Add(this.lblTestDate);
            this.Name = "MoneyBeeForm";
            this.Text = "Money Bee";
            this.tcHeaderTabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabExpenditures.ResumeLayout(false);
            this.tcExpenditures.ResumeLayout(false);
            this.tpSample.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabMonthlyReport.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcHeaderTabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabExpenditures;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Label lblTotalBalanceValue;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Button bNewTransaction;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.Button bEditTransaction;
        private System.Windows.Forms.ListBox listboxTransactionHistory;
        private System.Windows.Forms.TextBox tbTotalExpenses;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.TextBox tbActualIncome;
        private System.Windows.Forms.Label lblActualIncome;
        private System.Windows.Forms.TextBox tbProjectedIncome;
        private System.Windows.Forms.Label lblProjectedIncome;
        private System.Windows.Forms.TabControl tcExpenditures;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCreateExpenditure;
        private System.Windows.Forms.TabPage tpSample;
        private System.Windows.Forms.Label lblDaysUntilReport;
        private System.Windows.Forms.ListBox lbMonthlyReport;
        private System.Windows.Forms.Button bPersonalSettings;
        private System.Windows.Forms.Button bPaySettings;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.CheckedListBox clbNotifications;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bDeleteAccount;
        private System.Windows.Forms.ListBox lbExpenditures;
    }
}

