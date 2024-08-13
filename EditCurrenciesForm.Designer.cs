namespace FinancialManager
{
    partial class EditCurrenciesForm
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
            currenciesListBox = new ListBox();
            currencyNameTextBox = new TextBox();
            currencyNameLabel = new Label();
            currencyCodeLabel = new Label();
            currencyCodeTextBox = new TextBox();
            currencySymbolLabel = new Label();
            currencySymbolTextBox = new TextBox();
            addCurrencyButton = new Button();
            refreshCurrenciesButton = new Button();
            editCurrencyButton = new Button();
            saveCurrencyButton = new Button();
            SuspendLayout();
            // 
            // currenciesListBox
            // 
            currenciesListBox.FormattingEnabled = true;
            currenciesListBox.Location = new Point(505, 12);
            currenciesListBox.Name = "currenciesListBox";
            currenciesListBox.Size = new Size(657, 772);
            currenciesListBox.TabIndex = 0;
            currenciesListBox.SelectedIndexChanged += currenciesListBox_SelectedIndexChanged;
            // 
            // currencyNameTextBox
            // 
            currencyNameTextBox.Location = new Point(47, 159);
            currencyNameTextBox.Name = "currencyNameTextBox";
            currencyNameTextBox.Size = new Size(295, 39);
            currencyNameTextBox.TabIndex = 1;
            // 
            // currencyNameLabel
            // 
            currencyNameLabel.AutoSize = true;
            currencyNameLabel.Location = new Point(47, 124);
            currencyNameLabel.Name = "currencyNameLabel";
            currencyNameLabel.Size = new Size(180, 32);
            currencyNameLabel.TabIndex = 2;
            currencyNameLabel.Text = "Currency Name";
            // 
            // currencyCodeLabel
            // 
            currencyCodeLabel.AutoSize = true;
            currencyCodeLabel.Location = new Point(47, 247);
            currencyCodeLabel.Name = "currencyCodeLabel";
            currencyCodeLabel.Size = new Size(172, 32);
            currencyCodeLabel.TabIndex = 4;
            currencyCodeLabel.Text = "Currency Code";
            // 
            // currencyCodeTextBox
            // 
            currencyCodeTextBox.Location = new Point(47, 282);
            currencyCodeTextBox.Name = "currencyCodeTextBox";
            currencyCodeTextBox.Size = new Size(295, 39);
            currencyCodeTextBox.TabIndex = 3;
            // 
            // currencySymbolLabel
            // 
            currencySymbolLabel.AutoSize = true;
            currencySymbolLabel.Location = new Point(47, 382);
            currencySymbolLabel.Name = "currencySymbolLabel";
            currencySymbolLabel.Size = new Size(195, 32);
            currencySymbolLabel.TabIndex = 6;
            currencySymbolLabel.Text = "Currency Symbol";
            // 
            // currencySymbolTextBox
            // 
            currencySymbolTextBox.Location = new Point(47, 417);
            currencySymbolTextBox.Name = "currencySymbolTextBox";
            currencySymbolTextBox.Size = new Size(295, 39);
            currencySymbolTextBox.TabIndex = 5;
            // 
            // addCurrencyButton
            // 
            addCurrencyButton.Location = new Point(47, 738);
            addCurrencyButton.Name = "addCurrencyButton";
            addCurrencyButton.Size = new Size(150, 46);
            addCurrencyButton.TabIndex = 7;
            addCurrencyButton.Text = "Add";
            addCurrencyButton.UseVisualStyleBackColor = true;
            addCurrencyButton.Click += addCurrencyButton_Click;
            // 
            // refreshCurrenciesButton
            // 
            refreshCurrenciesButton.Location = new Point(245, 738);
            refreshCurrenciesButton.Name = "refreshCurrenciesButton";
            refreshCurrenciesButton.Size = new Size(150, 46);
            refreshCurrenciesButton.TabIndex = 8;
            refreshCurrenciesButton.Text = "Refresh";
            refreshCurrenciesButton.UseVisualStyleBackColor = true;
            refreshCurrenciesButton.Click += refreshCurrenciesButton_Click;
            // 
            // editCurrencyButton
            // 
            editCurrencyButton.Location = new Point(47, 686);
            editCurrencyButton.Name = "editCurrencyButton";
            editCurrencyButton.Size = new Size(150, 46);
            editCurrencyButton.TabIndex = 9;
            editCurrencyButton.Text = "Edit";
            editCurrencyButton.UseVisualStyleBackColor = true;
            editCurrencyButton.Click += editCurrencyButton_Click;
            // 
            // saveCurrencyButton
            // 
            saveCurrencyButton.Location = new Point(245, 686);
            saveCurrencyButton.Name = "saveCurrencyButton";
            saveCurrencyButton.Size = new Size(150, 46);
            saveCurrencyButton.TabIndex = 10;
            saveCurrencyButton.Text = "Save";
            saveCurrencyButton.UseVisualStyleBackColor = true;
            saveCurrencyButton.Click += saveCurrencyButton_Click;
            // 
            // EditCurrenciesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 815);
            Controls.Add(saveCurrencyButton);
            Controls.Add(editCurrencyButton);
            Controls.Add(refreshCurrenciesButton);
            Controls.Add(addCurrencyButton);
            Controls.Add(currencySymbolLabel);
            Controls.Add(currencySymbolTextBox);
            Controls.Add(currencyCodeLabel);
            Controls.Add(currencyCodeTextBox);
            Controls.Add(currencyNameLabel);
            Controls.Add(currencyNameTextBox);
            Controls.Add(currenciesListBox);
            Name = "EditCurrenciesForm";
            Text = "Edit Currencies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox currenciesListBox;
        private TextBox currencyNameTextBox;
        private Label currencyNameLabel;
        private Label currencyCodeLabel;
        private TextBox currencyCodeTextBox;
        private Label currencySymbolLabel;
        private TextBox currencySymbolTextBox;
        private Button addCurrencyButton;
        private Button refreshCurrenciesButton;
        private Button editCurrencyButton;
        private Button saveCurrencyButton;
    }
}