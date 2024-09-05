namespace FinancialManager
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            openDBDialog = new OpenFileDialog();
            dbStatusStrip = new StatusStrip();
            DBStatus = new ToolStripStatusLabel();
            createDBDialog = new SaveFileDialog();
            mainWindowTabControl = new TabControl();
            startTabPage = new TabPage();
            fillDBTabPage = new TabPage();
            editTransactionsButton = new Button();
            editCategoriesButton = new Button();
            editCashFacilitiesButton = new Button();
            editTagsButton = new Button();
            editPlacesOfPurchasesButton = new Button();
            editTransactionTypesButton = new Button();
            editCurrenciesButton = new Button();
            analyticsTabPage = new TabPage();
            settingsTabPage = new TabPage();
            currencyApiButton = new Button();
            testsTabPage = new TabPage();
            currencyExchangeButton = new Button();
            currencyApiToolTip = new ToolTip(components);
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createDbToolStripMenuItem = new ToolStripMenuItem();
            openDbToolStripMenuItem = new ToolStripMenuItem();
            closeDbToolStripMenuItem = new ToolStripMenuItem();
            dbStatusStrip.SuspendLayout();
            mainWindowTabControl.SuspendLayout();
            fillDBTabPage.SuspendLayout();
            settingsTabPage.SuspendLayout();
            testsTabPage.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // openDBDialog
            // 
            openDBDialog.Filter = "DB files|*.db";
            openDBDialog.Title = "Open DB";
            // 
            // dbStatusStrip
            // 
            dbStatusStrip.ImageScalingSize = new Size(32, 32);
            dbStatusStrip.Items.AddRange(new ToolStripItem[] { DBStatus });
            dbStatusStrip.Location = new Point(0, 836);
            dbStatusStrip.Name = "dbStatusStrip";
            dbStatusStrip.Size = new Size(1504, 22);
            dbStatusStrip.TabIndex = 2;
            // 
            // DBStatus
            // 
            DBStatus.Name = "DBStatus";
            DBStatus.Size = new Size(0, 12);
            // 
            // createDBDialog
            // 
            createDBDialog.Filter = "DB files|*.db";
            createDBDialog.Title = "Create DB";
            // 
            // mainWindowTabControl
            // 
            mainWindowTabControl.Controls.Add(startTabPage);
            mainWindowTabControl.Controls.Add(fillDBTabPage);
            mainWindowTabControl.Controls.Add(analyticsTabPage);
            mainWindowTabControl.Controls.Add(settingsTabPage);
            mainWindowTabControl.Controls.Add(testsTabPage);
            mainWindowTabControl.Dock = DockStyle.Fill;
            mainWindowTabControl.Location = new Point(0, 40);
            mainWindowTabControl.Name = "mainWindowTabControl";
            mainWindowTabControl.SelectedIndex = 0;
            mainWindowTabControl.Size = new Size(1504, 796);
            mainWindowTabControl.TabIndex = 5;
            // 
            // startTabPage
            // 
            startTabPage.Location = new Point(8, 46);
            startTabPage.Name = "startTabPage";
            startTabPage.Padding = new Padding(3);
            startTabPage.Size = new Size(1488, 742);
            startTabPage.TabIndex = 0;
            startTabPage.Text = "Start";
            startTabPage.UseVisualStyleBackColor = true;
            // 
            // fillDBTabPage
            // 
            fillDBTabPage.Controls.Add(editTransactionsButton);
            fillDBTabPage.Controls.Add(editCategoriesButton);
            fillDBTabPage.Controls.Add(editCashFacilitiesButton);
            fillDBTabPage.Controls.Add(editTagsButton);
            fillDBTabPage.Controls.Add(editPlacesOfPurchasesButton);
            fillDBTabPage.Controls.Add(editTransactionTypesButton);
            fillDBTabPage.Controls.Add(editCurrenciesButton);
            fillDBTabPage.Location = new Point(8, 46);
            fillDBTabPage.Name = "fillDBTabPage";
            fillDBTabPage.Padding = new Padding(3);
            fillDBTabPage.Size = new Size(1488, 742);
            fillDBTabPage.TabIndex = 1;
            fillDBTabPage.Text = "Fill Data";
            fillDBTabPage.UseVisualStyleBackColor = true;
            // 
            // editTransactionsButton
            // 
            editTransactionsButton.Location = new Point(1138, 318);
            editTransactionsButton.Name = "editTransactionsButton";
            editTransactionsButton.Size = new Size(344, 46);
            editTransactionsButton.TabIndex = 6;
            editTransactionsButton.Text = "Edit Transactions";
            editTransactionsButton.UseVisualStyleBackColor = true;
            editTransactionsButton.Click += editTransactionsButton_Click;
            // 
            // editCategoriesButton
            // 
            editCategoriesButton.Location = new Point(1138, 266);
            editCategoriesButton.Name = "editCategoriesButton";
            editCategoriesButton.Size = new Size(344, 46);
            editCategoriesButton.TabIndex = 5;
            editCategoriesButton.Text = "Edit Categories";
            editCategoriesButton.UseVisualStyleBackColor = true;
            editCategoriesButton.Click += editCategoriesButton_Click;
            // 
            // editCashFacilitiesButton
            // 
            editCashFacilitiesButton.Location = new Point(1138, 214);
            editCashFacilitiesButton.Name = "editCashFacilitiesButton";
            editCashFacilitiesButton.Size = new Size(344, 46);
            editCashFacilitiesButton.TabIndex = 4;
            editCashFacilitiesButton.Text = "Edit Cash Facilities";
            editCashFacilitiesButton.UseVisualStyleBackColor = true;
            editCashFacilitiesButton.Click += editCashFacilitiesButton_Click;
            // 
            // editTagsButton
            // 
            editTagsButton.Location = new Point(1138, 162);
            editTagsButton.Name = "editTagsButton";
            editTagsButton.Size = new Size(344, 46);
            editTagsButton.TabIndex = 3;
            editTagsButton.Text = "Edit Tags";
            editTagsButton.UseVisualStyleBackColor = true;
            editTagsButton.Click += editTagsButton_Click;
            // 
            // editPlacesOfPurchasesButton
            // 
            editPlacesOfPurchasesButton.Location = new Point(1138, 110);
            editPlacesOfPurchasesButton.Name = "editPlacesOfPurchasesButton";
            editPlacesOfPurchasesButton.Size = new Size(344, 46);
            editPlacesOfPurchasesButton.TabIndex = 2;
            editPlacesOfPurchasesButton.Text = "Edit Places Of Purchases";
            editPlacesOfPurchasesButton.UseVisualStyleBackColor = true;
            editPlacesOfPurchasesButton.Click += editPlacesOfPurchasesButton_Click;
            // 
            // editTransactionTypesButton
            // 
            editTransactionTypesButton.Location = new Point(1138, 58);
            editTransactionTypesButton.Name = "editTransactionTypesButton";
            editTransactionTypesButton.Size = new Size(344, 46);
            editTransactionTypesButton.TabIndex = 1;
            editTransactionTypesButton.Text = "Edit Transaction Types";
            editTransactionTypesButton.UseVisualStyleBackColor = true;
            editTransactionTypesButton.Click += editTransactionTypesButton_Click;
            // 
            // editCurrenciesButton
            // 
            editCurrenciesButton.Location = new Point(1138, 6);
            editCurrenciesButton.Name = "editCurrenciesButton";
            editCurrenciesButton.Size = new Size(344, 46);
            editCurrenciesButton.TabIndex = 0;
            editCurrenciesButton.Text = "Edit Currencies";
            editCurrenciesButton.UseVisualStyleBackColor = true;
            editCurrenciesButton.Click += editCurrenciesButton_Click;
            // 
            // analyticsTabPage
            // 
            analyticsTabPage.Location = new Point(8, 46);
            analyticsTabPage.Name = "analyticsTabPage";
            analyticsTabPage.Padding = new Padding(3);
            analyticsTabPage.Size = new Size(1488, 742);
            analyticsTabPage.TabIndex = 2;
            analyticsTabPage.Text = "Analytics";
            analyticsTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            settingsTabPage.Controls.Add(currencyApiButton);
            settingsTabPage.Location = new Point(8, 46);
            settingsTabPage.Name = "settingsTabPage";
            settingsTabPage.Padding = new Padding(3);
            settingsTabPage.Size = new Size(1488, 742);
            settingsTabPage.TabIndex = 3;
            settingsTabPage.Text = "Settings";
            settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // currencyApiButton
            // 
            currencyApiButton.Location = new Point(1086, 6);
            currencyApiButton.Name = "currencyApiButton";
            currencyApiButton.Size = new Size(396, 46);
            currencyApiButton.TabIndex = 0;
            currencyApiButton.Text = "CurrencyAPI Key";
            currencyApiToolTip.SetToolTip(currencyApiButton, "Setup API key for CurrencyAPI service\r\nThis service is used for currency exchange");
            currencyApiButton.UseVisualStyleBackColor = true;
            currencyApiButton.Click += currencyApiButton_Click;
            // 
            // testsTabPage
            // 
            testsTabPage.Controls.Add(currencyExchangeButton);
            testsTabPage.Location = new Point(8, 46);
            testsTabPage.Name = "testsTabPage";
            testsTabPage.Padding = new Padding(3);
            testsTabPage.Size = new Size(1488, 742);
            testsTabPage.TabIndex = 4;
            testsTabPage.Text = "Tests";
            testsTabPage.UseVisualStyleBackColor = true;
            // 
            // currencyExchangeButton
            // 
            currencyExchangeButton.Location = new Point(1074, 6);
            currencyExchangeButton.Name = "currencyExchangeButton";
            currencyExchangeButton.Size = new Size(408, 46);
            currencyExchangeButton.TabIndex = 0;
            currencyExchangeButton.Text = "Currency Exchange";
            currencyExchangeButton.UseVisualStyleBackColor = true;
            currencyExchangeButton.Click += currencyExchangeButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1504, 40);
            menuStrip.TabIndex = 6;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createDbToolStripMenuItem, openDbToolStripMenuItem, closeDbToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // createDbToolStripMenuItem
            // 
            createDbToolStripMenuItem.Name = "createDbToolStripMenuItem";
            createDbToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            createDbToolStripMenuItem.Size = new Size(339, 44);
            createDbToolStripMenuItem.Text = "Create DB";
            createDbToolStripMenuItem.Click += createDbToolStripMenuItem_Click;
            // 
            // openDbToolStripMenuItem
            // 
            openDbToolStripMenuItem.Name = "openDbToolStripMenuItem";
            openDbToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openDbToolStripMenuItem.Size = new Size(339, 44);
            openDbToolStripMenuItem.Text = "Open DB";
            openDbToolStripMenuItem.Click += openDbToolStripMenuItem_Click;
            // 
            // closeDbToolStripMenuItem
            // 
            closeDbToolStripMenuItem.Name = "closeDbToolStripMenuItem";
            closeDbToolStripMenuItem.Size = new Size(339, 44);
            closeDbToolStripMenuItem.Text = "Close DB";
            closeDbToolStripMenuItem.Click += closeDbToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 858);
            Controls.Add(mainWindowTabControl);
            Controls.Add(dbStatusStrip);
            Controls.Add(menuStrip);
            Name = "MainWindow";
            Text = "Financial Manager";
            Shown += MainWindow_Shown;
            dbStatusStrip.ResumeLayout(false);
            dbStatusStrip.PerformLayout();
            mainWindowTabControl.ResumeLayout(false);
            fillDBTabPage.ResumeLayout(false);
            settingsTabPage.ResumeLayout(false);
            testsTabPage.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openDBDialog;
        private StatusStrip dbStatusStrip;
        private ToolStripStatusLabel DBStatus;
        private SaveFileDialog createDBDialog;
        private TabControl mainWindowTabControl;
        private TabPage startTabPage;
        private TabPage fillDBTabPage;
        private Button editCurrenciesButton;
        private Button editTransactionTypesButton;
        private Button editPlacesOfPurchasesButton;
        private Button editTagsButton;
        private Button editCashFacilitiesButton;
        private Button editCategoriesButton;
        private Button editTransactionsButton;
        private TabPage analyticsTabPage;
        private TabPage settingsTabPage;
        private Button currencyApiButton;
        private ToolTip currencyApiToolTip;
        private TabPage testsTabPage;
        private Button currencyExchangeButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createDbToolStripMenuItem;
        private ToolStripMenuItem openDbToolStripMenuItem;
        private ToolStripMenuItem closeDbToolStripMenuItem;
    }
}
