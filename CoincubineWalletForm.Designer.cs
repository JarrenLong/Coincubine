namespace CoincubineWallet
{
    partial class CoincubineWalletForm
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
      this.TabControlWallet = new LongTech.UI.Controls.TabControl();
      this.TabPageStart = new LongTech.UI.Controls.TabPage();
      this.ButtonManageCurrencies = new LongTech.UI.Controls.Button();
      this.label4 = new LongTech.UI.Controls.Label();
      this.ButtonNewCurrency = new LongTech.UI.Controls.Button();
      this.label3 = new LongTech.UI.Controls.Label();
      this.label2 = new LongTech.UI.Controls.Label();
      this.label1 = new LongTech.UI.Controls.Label();
      this.PictureBoxLogo = new LongTech.UI.Controls.PictureBox();
      this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
      this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.NewCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ManageCurrenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutCoincubineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
      this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.TabControlWallet.SuspendLayout();
      this.TabPageStart.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
      this.MenuStrip1.SuspendLayout();
      this.StatusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // TabControlWallet
      // 
      this.TabControlWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TabControlWallet.Controls.Add(this.TabPageStart);
      this.TabControlWallet.Location = new System.Drawing.Point(0, 24);
      this.TabControlWallet.Name = "TabControlWallet";
      this.TabControlWallet.SelectedIndex = 0;
      this.TabControlWallet.Size = new System.Drawing.Size(884, 552);
      this.TabControlWallet.TabIndex = 0;
      // 
      // TabPageStart
      // 
      this.TabPageStart.Controls.Add(this.ButtonManageCurrencies);
      this.TabPageStart.Controls.Add(this.label4);
      this.TabPageStart.Controls.Add(this.ButtonNewCurrency);
      this.TabPageStart.Controls.Add(this.label3);
      this.TabPageStart.Controls.Add(this.label2);
      this.TabPageStart.Controls.Add(this.label1);
      this.TabPageStart.Controls.Add(this.PictureBoxLogo);
      this.TabPageStart.Location = new System.Drawing.Point(4, 22);
      this.TabPageStart.Name = "TabPageStart";
      this.TabPageStart.Size = new System.Drawing.Size(876, 526);
      this.TabPageStart.TabIndex = 0;
      this.TabPageStart.Text = "Welcome";
      this.TabPageStart.UseVisualStyleBackColor = true;
      // 
      // ButtonManageCurrencies
      // 
      this.ButtonManageCurrencies.Location = new System.Drawing.Point(361, 442);
      this.ButtonManageCurrencies.Name = "ButtonManageCurrencies";
      this.ButtonManageCurrencies.Size = new System.Drawing.Size(155, 23);
      this.ButtonManageCurrencies.TabIndex = 6;
      this.ButtonManageCurrencies.Text = "Manage Currencies";
      this.ButtonManageCurrencies.UseVisualStyleBackColor = true;
      this.ButtonManageCurrencies.Click += new System.EventHandler(this.ButtonManageCurrencies_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(240, 419);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(397, 20);
      this.label4.TabIndex = 5;
      this.label4.Text = "Or, manage the currencies you already have configured";
      // 
      // ButtonNewCurrency
      // 
      this.ButtonNewCurrency.Location = new System.Drawing.Point(361, 384);
      this.ButtonNewCurrency.Name = "ButtonNewCurrency";
      this.ButtonNewCurrency.Size = new System.Drawing.Size(155, 23);
      this.ButtonNewCurrency.TabIndex = 4;
      this.ButtonNewCurrency.Text = "Add A Currency";
      this.ButtonNewCurrency.UseVisualStyleBackColor = true;
      this.ButtonNewCurrency.Click += new System.EventHandler(this.ButtonNewCurrency_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(217, 361);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(443, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "To get started, configure a crypto currency daemon and wallet";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(236, 299);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(405, 24);
      this.label2.TabIndex = 2;
      this.label2.Text = "Run your coin wallets single, or ready to mingle";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(301, 262);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(275, 37);
      this.label1.TabIndex = 1;
      this.label1.Text = "Coincubine Wallet";
      // 
      // PictureBoxLogo
      // 
      this.PictureBoxLogo.Location = new System.Drawing.Point(310, 3);
      this.PictureBoxLogo.Name = "PictureBoxLogo";
      this.PictureBoxLogo.Size = new System.Drawing.Size(256, 256);
      this.PictureBoxLogo.TabIndex = 0;
      this.PictureBoxLogo.TabStop = false;
      // 
      // MenuStrip1
      // 
      this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
      this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
      this.MenuStrip1.Name = "MenuStrip1";
      this.MenuStrip1.Size = new System.Drawing.Size(884, 24);
      this.MenuStrip1.TabIndex = 1;
      this.MenuStrip1.Text = "menuStrip1";
      // 
      // FileToolStripMenuItem
      // 
      this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCurrencyToolStripMenuItem,
            this.ManageCurrenciesToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
      this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
      this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.FileToolStripMenuItem.Text = "File";
      // 
      // NewCurrencyToolStripMenuItem
      // 
      this.NewCurrencyToolStripMenuItem.Name = "NewCurrencyToolStripMenuItem";
      this.NewCurrencyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
      this.NewCurrencyToolStripMenuItem.Text = "New Currency";
      this.NewCurrencyToolStripMenuItem.Click += new System.EventHandler(this.ButtonNewCurrency_Click);
      // 
      // ManageCurrenciesToolStripMenuItem
      // 
      this.ManageCurrenciesToolStripMenuItem.Name = "ManageCurrenciesToolStripMenuItem";
      this.ManageCurrenciesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
      this.ManageCurrenciesToolStripMenuItem.Text = "Manage Currencies";
      this.ManageCurrenciesToolStripMenuItem.Click += new System.EventHandler(this.ButtonManageCurrencies_Click);
      // 
      // ToolStripSeparator1
      // 
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      this.ToolStripSeparator1.Size = new System.Drawing.Size(173, 6);
      // 
      // ExitToolStripMenuItem
      // 
      this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
      this.ExitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
      this.ExitToolStripMenuItem.Text = "Exit";
      // 
      // HelpToolStripMenuItem
      // 
      this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCoincubineToolStripMenuItem});
      this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
      this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.HelpToolStripMenuItem.Text = "Help";
      // 
      // AboutCoincubineToolStripMenuItem
      // 
      this.AboutCoincubineToolStripMenuItem.Name = "AboutCoincubineToolStripMenuItem";
      this.AboutCoincubineToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
      this.AboutCoincubineToolStripMenuItem.Text = "About Coincubine ...";
      this.AboutCoincubineToolStripMenuItem.Click += new System.EventHandler(this.AboutCoincubineToolStripMenuItem_Click);
      // 
      // StatusStrip1
      // 
      this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar1,
            this.ToolStripStatusLabel1});
      this.StatusStrip1.Location = new System.Drawing.Point(0, 579);
      this.StatusStrip1.Name = "StatusStrip1";
      this.StatusStrip1.Size = new System.Drawing.Size(884, 22);
      this.StatusStrip1.TabIndex = 2;
      this.StatusStrip1.Text = "statusStrip1";
      // 
      // ToolStripProgressBar1
      // 
      this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
      this.ToolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
      // 
      // ToolStripStatusLabel1
      // 
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      this.ToolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
      this.ToolStripStatusLabel1.Text = "Status messages will show up here ...";
      // 
      // CoincubineWalletForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 601);
      this.Controls.Add(this.StatusStrip1);
      this.Controls.Add(this.TabControlWallet);
      this.Controls.Add(this.MenuStrip1);
      this.MainMenuStrip = this.MenuStrip1;
      this.Name = "CoincubineWalletForm";
      this.Text = "Coincubine Wallet";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWallet_FormClosing);
      this.Shown += new System.EventHandler(this.CoincubineWalletForm_Shown);
      this.TabControlWallet.ResumeLayout(false);
      this.TabPageStart.ResumeLayout(false);
      this.TabPageStart.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
      this.MenuStrip1.ResumeLayout(false);
      this.MenuStrip1.PerformLayout();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private LongTech.UI.Controls.TabControl TabControlWallet;
    private System.Windows.Forms.MenuStrip MenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem NewCurrencyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AboutCoincubineToolStripMenuItem;
    private System.Windows.Forms.StatusStrip StatusStrip1;
    private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
    private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    private LongTech.UI.Controls.TabPage TabPageStart;
    private LongTech.UI.Controls.Button ButtonNewCurrency;
    private LongTech.UI.Controls.Label label3;
    private LongTech.UI.Controls.Label label2;
    private LongTech.UI.Controls.Label label1;
    private LongTech.UI.Controls.PictureBox PictureBoxLogo;
    private LongTech.UI.Controls.Button ButtonManageCurrencies;
    private LongTech.UI.Controls.Label label4;
    private System.Windows.Forms.ToolStripMenuItem ManageCurrenciesToolStripMenuItem;
  }
}

