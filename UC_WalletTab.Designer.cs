namespace CoincubineWallet
{
  partial class UC_WalletTab
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBoxDaemonLog = new LongTech.UI.Controls.GroupBox();
      this.TextBoxDaemon = new LongTech.UI.Controls.TextBox();
      this.groupBoxWallet = new LongTech.UI.Controls.GroupBox();
      this.label2 = new LongTech.UI.Controls.Label();
      this.TextBoxAddress = new LongTech.UI.Controls.TextBox();
      this.LabelUnlockedBalance = new LongTech.UI.Controls.Label();
      this.label5 = new LongTech.UI.Controls.Label();
      this.ButtonExportKeys = new LongTech.UI.Controls.Button();
      this.LabelBalance = new LongTech.UI.Controls.Label();
      this.label3 = new LongTech.UI.Controls.Label();
      this.ButtonImportKeys = new LongTech.UI.Controls.Button();
      this.ButtonOpenWallet = new LongTech.UI.Controls.Button();
      this.TextBoxPassword = new LongTech.UI.Controls.TextBox();
      this.label1 = new LongTech.UI.Controls.Label();
      this.groupBoxTransactions = new LongTech.UI.Controls.GroupBox();
      this.DataGridViewTransactions = new LongTech.UI.Controls.DataGridView();
      this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.GroupBoxTransfer = new LongTech.UI.Controls.GroupBox();
      this.LabelTotalAmount = new LongTech.UI.Controls.Label();
      this.label4 = new LongTech.UI.Controls.Label();
      this.buttonDonate = new LongTech.UI.Controls.Button();
      this.ButtonSend = new LongTech.UI.Controls.Button();
      this.label11 = new LongTech.UI.Controls.Label();
      this.TextBoxPaymentId = new LongTech.UI.Controls.TextBox();
      this.label10 = new LongTech.UI.Controls.Label();
      this.TextBoxMixinCount = new LongTech.UI.Controls.TextBox();
      this.label9 = new LongTech.UI.Controls.Label();
      this.TextBoxAmount = new LongTech.UI.Controls.TextBox();
      this.label8 = new LongTech.UI.Controls.Label();
      this.TextBoxDestinationAddress = new LongTech.UI.Controls.TextBox();
      this.label7 = new LongTech.UI.Controls.Label();
      this.groupBoxDaemonLog.SuspendLayout();
      this.groupBoxWallet.SuspendLayout();
      this.groupBoxTransactions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).BeginInit();
      this.GroupBoxTransfer.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxDaemonLog
      // 
      this.groupBoxDaemonLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
      this.groupBoxDaemonLog.Controls.Add(this.TextBoxDaemon);
      this.groupBoxDaemonLog.Location = new System.Drawing.Point(3, 407);
      this.groupBoxDaemonLog.Name = "groupBoxDaemonLog";
      this.groupBoxDaemonLog.Size = new System.Drawing.Size(875, 151);
      this.groupBoxDaemonLog.TabIndex = 9;
      this.groupBoxDaemonLog.TabStop = false;
      this.groupBoxDaemonLog.Text = "Daemon Log";
      // 
      // TextBoxDaemon
      // 
      this.TextBoxDaemon.BackColor = System.Drawing.SystemColors.Window;
      this.TextBoxDaemon.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxDaemon.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TextBoxDaemon.Location = new System.Drawing.Point(3, 16);
      this.TextBoxDaemon.MaxLength = 1000000;
      this.TextBoxDaemon.Multiline = true;
      this.TextBoxDaemon.Name = "TextBoxDaemon";
      this.TextBoxDaemon.ReadOnly = true;
      this.TextBoxDaemon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TextBoxDaemon.Size = new System.Drawing.Size(869, 132);
      this.TextBoxDaemon.TabIndex = 0;
      this.TextBoxDaemon.WordWrap = false;
      // 
      // groupBoxWallet
      // 
      this.groupBoxWallet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
      this.groupBoxWallet.Controls.Add(this.label2);
      this.groupBoxWallet.Controls.Add(this.TextBoxAddress);
      this.groupBoxWallet.Controls.Add(this.LabelUnlockedBalance);
      this.groupBoxWallet.Controls.Add(this.label5);
      this.groupBoxWallet.Controls.Add(this.ButtonExportKeys);
      this.groupBoxWallet.Controls.Add(this.LabelBalance);
      this.groupBoxWallet.Controls.Add(this.label3);
      this.groupBoxWallet.Controls.Add(this.ButtonImportKeys);
      this.groupBoxWallet.Controls.Add(this.ButtonOpenWallet);
      this.groupBoxWallet.Controls.Add(this.TextBoxPassword);
      this.groupBoxWallet.Controls.Add(this.label1);
      this.groupBoxWallet.Location = new System.Drawing.Point(3, 3);
      this.groupBoxWallet.Name = "groupBoxWallet";
      this.groupBoxWallet.Size = new System.Drawing.Size(878, 122);
      this.groupBoxWallet.TabIndex = 6;
      this.groupBoxWallet.TabStop = false;
      this.groupBoxWallet.Text = "My Wallet";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(98, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "My Wallet Address:";
      // 
      // TextBoxAddress
      // 
      this.TextBoxAddress.Location = new System.Drawing.Point(127, 87);
      this.TextBoxAddress.Name = "TextBoxAddress";
      this.TextBoxAddress.ReadOnly = true;
      this.TextBoxAddress.Size = new System.Drawing.Size(712, 20);
      this.TextBoxAddress.TabIndex = 8;
      this.TextBoxAddress.Visible = false;
      // 
      // LabelUnlockedBalance
      // 
      this.LabelUnlockedBalance.AutoSize = true;
      this.LabelUnlockedBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelUnlockedBalance.Location = new System.Drawing.Point(516, 58);
      this.LabelUnlockedBalance.Name = "LabelUnlockedBalance";
      this.LabelUnlockedBalance.Size = new System.Drawing.Size(193, 13);
      this.LabelUnlockedBalance.TabIndex = 4;
      this.LabelUnlockedBalance.Text = "0000000000.000000000000 XXX";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(414, 58);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(97, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Unlocked balance:";
      // 
      // ButtonExportKeys
      // 
      this.ButtonExportKeys.Enabled = false;
      this.ButtonExportKeys.Location = new System.Drawing.Point(680, 19);
      this.ButtonExportKeys.Name = "ButtonExportKeys";
      this.ButtonExportKeys.Size = new System.Drawing.Size(94, 23);
      this.ButtonExportKeys.TabIndex = 5;
      this.ButtonExportKeys.Text = "Export Keys";
      this.ButtonExportKeys.UseVisualStyleBackColor = true;
      this.ButtonExportKeys.Click += new System.EventHandler(this.ButtonExportKeys_Click);
      // 
      // LabelBalance
      // 
      this.LabelBalance.AutoSize = true;
      this.LabelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelBalance.Location = new System.Drawing.Point(204, 58);
      this.LabelBalance.Name = "LabelBalance";
      this.LabelBalance.Size = new System.Drawing.Size(193, 13);
      this.LabelBalance.TabIndex = 2;
      this.LabelBalance.Text = "0000000000.000000000000 XXX";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(149, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Balance:";
      // 
      // ButtonImportKeys
      // 
      this.ButtonImportKeys.Location = new System.Drawing.Point(583, 19);
      this.ButtonImportKeys.Name = "ButtonImportKeys";
      this.ButtonImportKeys.Size = new System.Drawing.Size(91, 23);
      this.ButtonImportKeys.TabIndex = 4;
      this.ButtonImportKeys.Text = "Import Keys";
      this.ButtonImportKeys.UseVisualStyleBackColor = true;
      this.ButtonImportKeys.Click += new System.EventHandler(this.ButtonImportKeys_Click);
      // 
      // ButtonOpenWallet
      // 
      this.ButtonOpenWallet.Location = new System.Drawing.Point(67, 19);
      this.ButtonOpenWallet.Name = "ButtonOpenWallet";
      this.ButtonOpenWallet.Size = new System.Drawing.Size(93, 23);
      this.ButtonOpenWallet.TabIndex = 3;
      this.ButtonOpenWallet.Text = "Open Wallet";
      this.ButtonOpenWallet.UseVisualStyleBackColor = true;
      this.ButtonOpenWallet.Click += new System.EventHandler(this.ButtonOpenWallet_Click);
      // 
      // TextBoxPassword
      // 
      this.TextBoxPassword.Location = new System.Drawing.Point(236, 21);
      this.TextBoxPassword.Name = "TextBoxPassword";
      this.TextBoxPassword.Size = new System.Drawing.Size(341, 20);
      this.TextBoxPassword.TabIndex = 1;
      this.TextBoxPassword.UseSystemPasswordChar = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(174, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Password:";
      // 
      // groupBoxTransactions
      // 
      this.groupBoxTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
      this.groupBoxTransactions.Controls.Add(this.DataGridViewTransactions);
      this.groupBoxTransactions.Location = new System.Drawing.Point(3, 291);
      this.groupBoxTransactions.Name = "groupBoxTransactions";
      this.groupBoxTransactions.Size = new System.Drawing.Size(878, 110);
      this.groupBoxTransactions.TabIndex = 8;
      this.groupBoxTransactions.TabStop = false;
      this.groupBoxTransactions.Text = "My Transactions";
      // 
      // DataGridViewTransactions
      // 
      this.DataGridViewTransactions.AllowUserToAddRows = false;
      this.DataGridViewTransactions.AllowUserToDeleteRows = false;
      this.DataGridViewTransactions.AllowUserToResizeRows = false;
      this.DataGridViewTransactions.BackgroundColor = System.Drawing.SystemColors.Window;
      this.DataGridViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DataGridViewTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.DataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAmount,
            this.ColumnType,
            this.ColumnTransactionId});
      this.DataGridViewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridViewTransactions.EnableHeadersVisualStyles = false;
      this.DataGridViewTransactions.Location = new System.Drawing.Point(3, 16);
      this.DataGridViewTransactions.Name = "DataGridViewTransactions";
      this.DataGridViewTransactions.ReadOnly = true;
      this.DataGridViewTransactions.Size = new System.Drawing.Size(872, 91);
      this.DataGridViewTransactions.TabIndex = 12;
      // 
      // ColumnAmount
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle2;
      this.ColumnAmount.HeaderText = "Amount";
      this.ColumnAmount.Name = "ColumnAmount";
      this.ColumnAmount.ReadOnly = true;
      this.ColumnAmount.Width = 200;
      // 
      // ColumnType
      // 
      this.ColumnType.HeaderText = "Type";
      this.ColumnType.Name = "ColumnType";
      this.ColumnType.ReadOnly = true;
      // 
      // ColumnTransactionId
      // 
      this.ColumnTransactionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnTransactionId.HeaderText = "Transaction id";
      this.ColumnTransactionId.Name = "ColumnTransactionId";
      this.ColumnTransactionId.ReadOnly = true;
      // 
      // GroupBoxTransfer
      // 
      this.GroupBoxTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
      this.GroupBoxTransfer.Controls.Add(this.LabelTotalAmount);
      this.GroupBoxTransfer.Controls.Add(this.label4);
      this.GroupBoxTransfer.Controls.Add(this.buttonDonate);
      this.GroupBoxTransfer.Controls.Add(this.ButtonSend);
      this.GroupBoxTransfer.Controls.Add(this.label11);
      this.GroupBoxTransfer.Controls.Add(this.TextBoxPaymentId);
      this.GroupBoxTransfer.Controls.Add(this.label10);
      this.GroupBoxTransfer.Controls.Add(this.TextBoxMixinCount);
      this.GroupBoxTransfer.Controls.Add(this.label9);
      this.GroupBoxTransfer.Controls.Add(this.TextBoxAmount);
      this.GroupBoxTransfer.Controls.Add(this.label8);
      this.GroupBoxTransfer.Controls.Add(this.TextBoxDestinationAddress);
      this.GroupBoxTransfer.Controls.Add(this.label7);
      this.GroupBoxTransfer.Enabled = false;
      this.GroupBoxTransfer.Location = new System.Drawing.Point(3, 131);
      this.GroupBoxTransfer.Name = "GroupBoxTransfer";
      this.GroupBoxTransfer.Size = new System.Drawing.Size(878, 154);
      this.GroupBoxTransfer.TabIndex = 7;
      this.GroupBoxTransfer.TabStop = false;
      this.GroupBoxTransfer.Text = "Transfer";
      // 
      // LabelTotalAmount
      // 
      this.LabelTotalAmount.AutoSize = true;
      this.LabelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelTotalAmount.Location = new System.Drawing.Point(429, 123);
      this.LabelTotalAmount.Name = "LabelTotalAmount";
      this.LabelTotalAmount.Size = new System.Drawing.Size(193, 13);
      this.LabelTotalAmount.TabIndex = 12;
      this.LabelTotalAmount.Text = "0000000000.000000000000 XXX";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(279, 123);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(144, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Total (including network fee):";
      // 
      // buttonDonate
      // 
      this.buttonDonate.Location = new System.Drawing.Point(116, 118);
      this.buttonDonate.Name = "buttonDonate";
      this.buttonDonate.Size = new System.Drawing.Size(91, 23);
      this.buttonDonate.TabIndex = 11;
      this.buttonDonate.Text = "Donate...";
      this.buttonDonate.UseVisualStyleBackColor = true;
      this.buttonDonate.Click += new System.EventHandler(this.ButtonDonate_Click);
      // 
      // ButtonSend
      // 
      this.ButtonSend.Enabled = false;
      this.ButtonSend.Location = new System.Drawing.Point(16, 118);
      this.ButtonSend.Name = "ButtonSend";
      this.ButtonSend.Size = new System.Drawing.Size(93, 23);
      this.ButtonSend.TabIndex = 10;
      this.ButtonSend.Text = "Send";
      this.ButtonSend.UseVisualStyleBackColor = true;
      this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(474, 88);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(52, 13);
      this.label11.TabIndex = 8;
      this.label11.Text = "(Optional)";
      // 
      // TextBoxPaymentId
      // 
      this.TextBoxPaymentId.Location = new System.Drawing.Point(127, 85);
      this.TextBoxPaymentId.Name = "TextBoxPaymentId";
      this.TextBoxPaymentId.Size = new System.Drawing.Size(341, 20);
      this.TextBoxPaymentId.TabIndex = 9;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(56, 88);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(65, 13);
      this.label10.TabIndex = 6;
      this.label10.Text = "Payment ID:";
      // 
      // TextBoxMixinCount
      // 
      this.TextBoxMixinCount.Location = new System.Drawing.Point(407, 55);
      this.TextBoxMixinCount.Name = "TextBoxMixinCount";
      this.TextBoxMixinCount.Size = new System.Drawing.Size(61, 20);
      this.TextBoxMixinCount.TabIndex = 8;
      this.TextBoxMixinCount.Text = "0";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(337, 58);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(64, 13);
      this.label9.TabIndex = 4;
      this.label9.Text = "Mixin count:";
      // 
      // TextBoxAmount
      // 
      this.TextBoxAmount.Location = new System.Drawing.Point(127, 55);
      this.TextBoxAmount.Name = "TextBoxAmount";
      this.TextBoxAmount.Size = new System.Drawing.Size(181, 20);
      this.TextBoxAmount.TabIndex = 7;
      this.TextBoxAmount.TextChanged += new System.EventHandler(this.TextBoxAmount_TextChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(75, 58);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(46, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "Amount:";
      // 
      // TextBoxDestinationAddress
      // 
      this.TextBoxDestinationAddress.Location = new System.Drawing.Point(127, 27);
      this.TextBoxDestinationAddress.Name = "TextBoxDestinationAddress";
      this.TextBoxDestinationAddress.Size = new System.Drawing.Size(712, 20);
      this.TextBoxDestinationAddress.TabIndex = 6;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(18, 30);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(103, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Destination address:";
      // 
      // UC_WalletTab
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBoxDaemonLog);
      this.Controls.Add(this.groupBoxWallet);
      this.Controls.Add(this.groupBoxTransactions);
      this.Controls.Add(this.GroupBoxTransfer);
      this.Name = "UC_WalletTab";
      this.Size = new System.Drawing.Size(884, 561);
      this.groupBoxDaemonLog.ResumeLayout(false);
      this.groupBoxDaemonLog.PerformLayout();
      this.groupBoxWallet.ResumeLayout(false);
      this.groupBoxWallet.PerformLayout();
      this.groupBoxTransactions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransactions)).EndInit();
      this.GroupBoxTransfer.ResumeLayout(false);
      this.GroupBoxTransfer.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private LongTech.UI.Controls.GroupBox groupBoxDaemonLog;
    private LongTech.UI.Controls.TextBox TextBoxDaemon;
    private LongTech.UI.Controls.GroupBox groupBoxWallet;
    private LongTech.UI.Controls.Label label2;
    private LongTech.UI.Controls.TextBox TextBoxAddress;
    private LongTech.UI.Controls.Label LabelUnlockedBalance;
    private LongTech.UI.Controls.Label label5;
    private LongTech.UI.Controls.Button ButtonExportKeys;
    private LongTech.UI.Controls.Label LabelBalance;
    private LongTech.UI.Controls.Label label3;
    private LongTech.UI.Controls.Button ButtonImportKeys;
    private LongTech.UI.Controls.Button ButtonOpenWallet;
    private LongTech.UI.Controls.TextBox TextBoxPassword;
    private LongTech.UI.Controls.Label label1;
    private LongTech.UI.Controls.GroupBox groupBoxTransactions;
    private LongTech.UI.Controls.DataGridView DataGridViewTransactions;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionId;
    private LongTech.UI.Controls.GroupBox GroupBoxTransfer;
    private LongTech.UI.Controls.Label LabelTotalAmount;
    private LongTech.UI.Controls.Label label4;
    private LongTech.UI.Controls.Button buttonDonate;
    private LongTech.UI.Controls.Button ButtonSend;
    private LongTech.UI.Controls.Label label11;
    private LongTech.UI.Controls.TextBox TextBoxPaymentId;
    private LongTech.UI.Controls.Label label10;
    private LongTech.UI.Controls.TextBox TextBoxMixinCount;
    private LongTech.UI.Controls.Label label9;
    private LongTech.UI.Controls.TextBox TextBoxAmount;
    private LongTech.UI.Controls.Label label8;
    private LongTech.UI.Controls.TextBox TextBoxDestinationAddress;
    private LongTech.UI.Controls.Label label7;
  }
}
