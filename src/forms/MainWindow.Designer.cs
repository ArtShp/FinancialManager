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
            createDBDialog = new SaveFileDialog();
            editTransactionsButton = new Button();
            editCategoriesButton = new Button();
            editCashFacilitiesButton = new Button();
            editTagsButton = new Button();
            editPlacesOfPurchasesButton = new Button();
            editTransactionTypesButton = new Button();
            editCurrenciesButton = new Button();
            analyzeItemsButton = new Button();
            currencyApiButton = new Button();
            currencyExchangeButton = new Button();
            currencyApiToolTip = new ToolTip(components);
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createDbToolStripMenuItem = new ToolStripMenuItem();
            openDbToolStripMenuItem = new ToolStripMenuItem();
            closeDbToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editCurrenciesToolStripMenuItem = new ToolStripMenuItem();
            editTransactionTypesToolStripMenuItem = new ToolStripMenuItem();
            editPlacesOfPurchasesToolStripMenuItem = new ToolStripMenuItem();
            editTagsToolStripMenuItem = new ToolStripMenuItem();
            editCashFacilitiesToolStripMenuItem = new ToolStripMenuItem();
            editCategoriesToolStripMenuItem = new ToolStripMenuItem();
            editTransactionsToolStripMenuItem = new ToolStripMenuItem();
            analyticsToolStripMenuItem = new ToolStripMenuItem();
            analyzeItemsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            setCurrencyAPIKeyToolStripMenuItem = new ToolStripMenuItem();
            testsToolStripMenuItem = new ToolStripMenuItem();
            currencyExchangeToolStripMenuItem = new ToolStripMenuItem();
            editGroupBox = new GroupBox();
            analyticsGroupBox = new GroupBox();
            settingsGroupBox = new GroupBox();
            testsGroupBox = new GroupBox();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            editGroupBox.SuspendLayout();
            analyticsGroupBox.SuspendLayout();
            settingsGroupBox.SuspendLayout();
            testsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // openDBDialog
            // 
            openDBDialog.Filter = "DB files|*.db";
            openDBDialog.Title = "Open DB";
            // 
            // createDBDialog
            // 
            createDBDialog.Filter = "DB files|*.db";
            createDBDialog.Title = "Create DB";
            // 
            // editTransactionsButton
            // 
            editTransactionsButton.Location = new Point(6, 350);
            editTransactionsButton.Name = "editTransactionsButton";
            editTransactionsButton.Size = new Size(344, 46);
            editTransactionsButton.TabIndex = 6;
            editTransactionsButton.Text = "Edit Transactions";
            editTransactionsButton.UseVisualStyleBackColor = true;
            editTransactionsButton.Click += editTransactionsButton_Click;
            // 
            // editCategoriesButton
            // 
            editCategoriesButton.Location = new Point(6, 298);
            editCategoriesButton.Name = "editCategoriesButton";
            editCategoriesButton.Size = new Size(344, 46);
            editCategoriesButton.TabIndex = 5;
            editCategoriesButton.Text = "Edit Categories";
            editCategoriesButton.UseVisualStyleBackColor = true;
            editCategoriesButton.Click += editCategoriesButton_Click;
            // 
            // editCashFacilitiesButton
            // 
            editCashFacilitiesButton.Location = new Point(6, 246);
            editCashFacilitiesButton.Name = "editCashFacilitiesButton";
            editCashFacilitiesButton.Size = new Size(344, 46);
            editCashFacilitiesButton.TabIndex = 4;
            editCashFacilitiesButton.Text = "Edit Cash Facilities";
            editCashFacilitiesButton.UseVisualStyleBackColor = true;
            editCashFacilitiesButton.Click += editCashFacilitiesButton_Click;
            // 
            // editTagsButton
            // 
            editTagsButton.Location = new Point(6, 194);
            editTagsButton.Name = "editTagsButton";
            editTagsButton.Size = new Size(344, 46);
            editTagsButton.TabIndex = 3;
            editTagsButton.Text = "Edit Tags";
            editTagsButton.UseVisualStyleBackColor = true;
            editTagsButton.Click += editTagsButton_Click;
            // 
            // editPlacesOfPurchasesButton
            // 
            editPlacesOfPurchasesButton.Location = new Point(6, 142);
            editPlacesOfPurchasesButton.Name = "editPlacesOfPurchasesButton";
            editPlacesOfPurchasesButton.Size = new Size(344, 46);
            editPlacesOfPurchasesButton.TabIndex = 2;
            editPlacesOfPurchasesButton.Text = "Edit Places Of Purchases";
            editPlacesOfPurchasesButton.UseVisualStyleBackColor = true;
            editPlacesOfPurchasesButton.Click += editPlacesOfPurchasesButton_Click;
            // 
            // editTransactionTypesButton
            // 
            editTransactionTypesButton.Location = new Point(6, 90);
            editTransactionTypesButton.Name = "editTransactionTypesButton";
            editTransactionTypesButton.Size = new Size(344, 46);
            editTransactionTypesButton.TabIndex = 1;
            editTransactionTypesButton.Text = "Edit Transaction Types";
            editTransactionTypesButton.UseVisualStyleBackColor = true;
            editTransactionTypesButton.Click += editTransactionTypesButton_Click;
            // 
            // editCurrenciesButton
            // 
            editCurrenciesButton.Location = new Point(6, 38);
            editCurrenciesButton.Name = "editCurrenciesButton";
            editCurrenciesButton.Size = new Size(344, 46);
            editCurrenciesButton.TabIndex = 0;
            editCurrenciesButton.Text = "Edit Currencies";
            editCurrenciesButton.UseVisualStyleBackColor = true;
            editCurrenciesButton.Click += editCurrenciesButton_Click;
            // 
            // analyzeItemsButton
            // 
            analyzeItemsButton.Location = new Point(6, 38);
            analyzeItemsButton.Name = "analyzeItemsButton";
            analyzeItemsButton.Size = new Size(344, 46);
            analyzeItemsButton.TabIndex = 0;
            analyzeItemsButton.Text = "Analyze Items";
            analyzeItemsButton.UseVisualStyleBackColor = true;
            analyzeItemsButton.Click += analyzeItemsButton_Click;
            // 
            // currencyApiButton
            // 
            currencyApiButton.Location = new Point(6, 38);
            currencyApiButton.Name = "currencyApiButton";
            currencyApiButton.Size = new Size(344, 46);
            currencyApiButton.TabIndex = 0;
            currencyApiButton.Text = "CurrencyAPI Key";
            currencyApiToolTip.SetToolTip(currencyApiButton, "Setup API key for CurrencyAPI service\r\nThis service is used for currency exchange");
            currencyApiButton.UseVisualStyleBackColor = true;
            currencyApiButton.Click += currencyApiButton_Click;
            // 
            // currencyExchangeButton
            // 
            currencyExchangeButton.Location = new Point(6, 38);
            currencyExchangeButton.Name = "currencyExchangeButton";
            currencyExchangeButton.Size = new Size(344, 46);
            currencyExchangeButton.TabIndex = 0;
            currencyExchangeButton.Text = "Currency Exchange";
            currencyExchangeButton.UseVisualStyleBackColor = true;
            currencyExchangeButton.Click += currencyExchangeButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, analyticsToolStripMenuItem, settingsToolStripMenuItem, testsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1124, 42);
            menuStrip.TabIndex = 6;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createDbToolStripMenuItem, openDbToolStripMenuItem, closeDbToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 38);
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
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editCurrenciesToolStripMenuItem, editTransactionTypesToolStripMenuItem, editPlacesOfPurchasesToolStripMenuItem, editTagsToolStripMenuItem, editCashFacilitiesToolStripMenuItem, editCategoriesToolStripMenuItem, editTransactionsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 38);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editCurrenciesToolStripMenuItem
            // 
            editCurrenciesToolStripMenuItem.Name = "editCurrenciesToolStripMenuItem";
            editCurrenciesToolStripMenuItem.Size = new Size(404, 44);
            editCurrenciesToolStripMenuItem.Text = "Edit Currencies";
            editCurrenciesToolStripMenuItem.Click += editCurrenciesToolStripMenuItem_Click;
            // 
            // editTransactionTypesToolStripMenuItem
            // 
            editTransactionTypesToolStripMenuItem.Name = "editTransactionTypesToolStripMenuItem";
            editTransactionTypesToolStripMenuItem.Size = new Size(404, 44);
            editTransactionTypesToolStripMenuItem.Text = "Edit Transaction Types";
            editTransactionTypesToolStripMenuItem.Click += editTransactionTypesToolStripMenuItem_Click;
            // 
            // editPlacesOfPurchasesToolStripMenuItem
            // 
            editPlacesOfPurchasesToolStripMenuItem.Name = "editPlacesOfPurchasesToolStripMenuItem";
            editPlacesOfPurchasesToolStripMenuItem.Size = new Size(404, 44);
            editPlacesOfPurchasesToolStripMenuItem.Text = "Edit Places Of Purchases";
            editPlacesOfPurchasesToolStripMenuItem.Click += editPlacesOfPurchasesToolStripMenuItem_Click;
            // 
            // editTagsToolStripMenuItem
            // 
            editTagsToolStripMenuItem.Name = "editTagsToolStripMenuItem";
            editTagsToolStripMenuItem.Size = new Size(404, 44);
            editTagsToolStripMenuItem.Text = "Edit Tags";
            editTagsToolStripMenuItem.Click += editTagsToolStripMenuItem_Click;
            // 
            // editCashFacilitiesToolStripMenuItem
            // 
            editCashFacilitiesToolStripMenuItem.Name = "editCashFacilitiesToolStripMenuItem";
            editCashFacilitiesToolStripMenuItem.Size = new Size(404, 44);
            editCashFacilitiesToolStripMenuItem.Text = "Edit Cash Facilities";
            editCashFacilitiesToolStripMenuItem.Click += editCashFacilitiesToolStripMenuItem_Click;
            // 
            // editCategoriesToolStripMenuItem
            // 
            editCategoriesToolStripMenuItem.Name = "editCategoriesToolStripMenuItem";
            editCategoriesToolStripMenuItem.Size = new Size(404, 44);
            editCategoriesToolStripMenuItem.Text = "Edit Categories";
            editCategoriesToolStripMenuItem.Click += editCategoriesToolStripMenuItem_Click;
            // 
            // editTransactionsToolStripMenuItem
            // 
            editTransactionsToolStripMenuItem.Name = "editTransactionsToolStripMenuItem";
            editTransactionsToolStripMenuItem.Size = new Size(404, 44);
            editTransactionsToolStripMenuItem.Text = "Edit Transactions";
            editTransactionsToolStripMenuItem.Click += editTransactionsToolStripMenuItem_Click;
            // 
            // analyticsToolStripMenuItem
            // 
            analyticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { analyzeItemsToolStripMenuItem });
            analyticsToolStripMenuItem.Name = "analyticsToolStripMenuItem";
            analyticsToolStripMenuItem.Size = new Size(128, 38);
            analyticsToolStripMenuItem.Text = "Analytics";
            // 
            // analyzeItemsToolStripMenuItem
            // 
            analyzeItemsToolStripMenuItem.Name = "analyzeItemsToolStripMenuItem";
            analyzeItemsToolStripMenuItem.Size = new Size(295, 44);
            analyzeItemsToolStripMenuItem.Text = "Analyze Items";
            analyzeItemsToolStripMenuItem.Click += analyzeItemsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setCurrencyAPIKeyToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(120, 38);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // setCurrencyAPIKeyToolStripMenuItem
            // 
            setCurrencyAPIKeyToolStripMenuItem.Name = "setCurrencyAPIKeyToolStripMenuItem";
            setCurrencyAPIKeyToolStripMenuItem.Size = new Size(363, 44);
            setCurrencyAPIKeyToolStripMenuItem.Text = "Set CurrencyAPI Key";
            setCurrencyAPIKeyToolStripMenuItem.Click += setCurrencyAPIKeyToolStripMenuItem_Click;
            // 
            // testsToolStripMenuItem
            // 
            testsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currencyExchangeToolStripMenuItem });
            testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            testsToolStripMenuItem.Size = new Size(86, 38);
            testsToolStripMenuItem.Text = "Tests";
            // 
            // currencyExchangeToolStripMenuItem
            // 
            currencyExchangeToolStripMenuItem.Name = "currencyExchangeToolStripMenuItem";
            currencyExchangeToolStripMenuItem.Size = new Size(350, 44);
            currencyExchangeToolStripMenuItem.Text = "Currency Exchange";
            currencyExchangeToolStripMenuItem.Click += currencyExchangeToolStripMenuItem_Click;
            // 
            // editGroupBox
            // 
            editGroupBox.Controls.Add(editCurrenciesButton);
            editGroupBox.Controls.Add(editPlacesOfPurchasesButton);
            editGroupBox.Controls.Add(editTransactionTypesButton);
            editGroupBox.Controls.Add(editTagsButton);
            editGroupBox.Controls.Add(editTransactionsButton);
            editGroupBox.Controls.Add(editCashFacilitiesButton);
            editGroupBox.Controls.Add(editCategoriesButton);
            editGroupBox.Location = new Point(12, 43);
            editGroupBox.Name = "editGroupBox";
            editGroupBox.Size = new Size(358, 404);
            editGroupBox.TabIndex = 7;
            editGroupBox.TabStop = false;
            editGroupBox.Text = "Edit";
            // 
            // analyticsGroupBox
            // 
            analyticsGroupBox.Controls.Add(analyzeItemsButton);
            analyticsGroupBox.Location = new Point(376, 43);
            analyticsGroupBox.Name = "analyticsGroupBox";
            analyticsGroupBox.Size = new Size(358, 94);
            analyticsGroupBox.TabIndex = 8;
            analyticsGroupBox.TabStop = false;
            analyticsGroupBox.Text = "Analytics";
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.Controls.Add(currencyApiButton);
            settingsGroupBox.Location = new Point(376, 189);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(358, 94);
            settingsGroupBox.TabIndex = 1;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // testsGroupBox
            // 
            testsGroupBox.Controls.Add(currencyExchangeButton);
            testsGroupBox.Location = new Point(376, 353);
            testsGroupBox.Name = "testsGroupBox";
            testsGroupBox.Size = new Size(358, 94);
            testsGroupBox.TabIndex = 9;
            testsGroupBox.TabStop = false;
            testsGroupBox.Text = "Tests";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gitHubToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(99, 38);
            aboutToolStripMenuItem.Text = "About";
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(359, 44);
            gitHubToolStripMenuItem.Text = "GitHub";
            gitHubToolStripMenuItem.Click += gitHubToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 479);
            Controls.Add(testsGroupBox);
            Controls.Add(settingsGroupBox);
            Controls.Add(analyticsGroupBox);
            Controls.Add(editGroupBox);
            Controls.Add(menuStrip);
            MinimumSize = new Size(770, 530);
            Name = "MainWindow";
            Text = "Financial Manager";
            Shown += MainWindow_Shown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            editGroupBox.ResumeLayout(false);
            analyticsGroupBox.ResumeLayout(false);
            settingsGroupBox.ResumeLayout(false);
            testsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openDBDialog;
        private SaveFileDialog createDBDialog;
        private Button editCurrenciesButton;
        private Button editTransactionTypesButton;
        private Button editPlacesOfPurchasesButton;
        private Button editTagsButton;
        private Button editCashFacilitiesButton;
        private Button editCategoriesButton;
        private Button editTransactionsButton;
        private Button currencyApiButton;
        private ToolTip currencyApiToolTip;
        private Button currencyExchangeButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createDbToolStripMenuItem;
        private ToolStripMenuItem openDbToolStripMenuItem;
        private ToolStripMenuItem closeDbToolStripMenuItem;
        private Button analyzeItemsButton;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editCurrenciesToolStripMenuItem;
        private ToolStripMenuItem editTransactionTypesToolStripMenuItem;
        private ToolStripMenuItem editPlacesOfPurchasesToolStripMenuItem;
        private ToolStripMenuItem editTagsToolStripMenuItem;
        private ToolStripMenuItem editCashFacilitiesToolStripMenuItem;
        private ToolStripMenuItem editCategoriesToolStripMenuItem;
        private ToolStripMenuItem editTransactionsToolStripMenuItem;
        private ToolStripMenuItem analyticsToolStripMenuItem;
        private ToolStripMenuItem analyzeItemsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem setCurrencyAPIKeyToolStripMenuItem;
        private ToolStripMenuItem testsToolStripMenuItem;
        private ToolStripMenuItem currencyExchangeToolStripMenuItem;
        private GroupBox editGroupBox;
        private GroupBox analyticsGroupBox;
        private GroupBox settingsGroupBox;
        private GroupBox testsGroupBox;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
    }
}
