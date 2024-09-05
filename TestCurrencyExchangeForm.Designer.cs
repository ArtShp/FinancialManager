namespace FinancialManager
{
    partial class TestCurrencyExchangeForm
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
            titleLabel = new Label();
            fromCurrencyLabel = new Label();
            toCurrencyLabel = new Label();
            convertButton = new Button();
            dateLabel = new Label();
            dateTimePicker = new DateTimePicker();
            moneyLabel = new Label();
            moneyTextBox = new TextBox();
            fromCurrencyComboBox = new ComboBox();
            toCurrencyComboBox = new ComboBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(31, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(457, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Currency Exchange";
            // 
            // fromCurrencyLabel
            // 
            fromCurrencyLabel.AutoSize = true;
            fromCurrencyLabel.Location = new Point(31, 225);
            fromCurrencyLabel.Name = "fromCurrencyLabel";
            fromCurrencyLabel.Size = new Size(171, 32);
            fromCurrencyLabel.TabIndex = 1;
            fromCurrencyLabel.Text = "From Currency";
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.Location = new Point(371, 225);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(141, 32);
            toCurrencyLabel.TabIndex = 2;
            toCurrencyLabel.Text = "To Currency";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(31, 473);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(150, 46);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(31, 341);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(64, 32);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(31, 376);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(400, 39);
            dateTimePicker.TabIndex = 7;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new Point(31, 109);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(89, 32);
            moneyLabel.TabIndex = 8;
            moneyLabel.Text = "Money";
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(31, 144);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(257, 39);
            moneyTextBox.TabIndex = 9;
            // 
            // fromCurrencyComboBox
            // 
            fromCurrencyComboBox.FormattingEnabled = true;
            fromCurrencyComboBox.Location = new Point(31, 260);
            fromCurrencyComboBox.Name = "fromCurrencyComboBox";
            fromCurrencyComboBox.Size = new Size(257, 40);
            fromCurrencyComboBox.TabIndex = 10;
            // 
            // toCurrencyComboBox
            // 
            toCurrencyComboBox.FormattingEnabled = true;
            toCurrencyComboBox.Location = new Point(371, 260);
            toCurrencyComboBox.Name = "toCurrencyComboBox";
            toCurrencyComboBox.Size = new Size(257, 40);
            toCurrencyComboBox.TabIndex = 11;
            // 
            // TestCurrencyExchangeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 543);
            Controls.Add(toCurrencyComboBox);
            Controls.Add(fromCurrencyComboBox);
            Controls.Add(moneyTextBox);
            Controls.Add(moneyLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(convertButton);
            Controls.Add(toCurrencyLabel);
            Controls.Add(fromCurrencyLabel);
            Controls.Add(titleLabel);
            Name = "TestCurrencyExchangeForm";
            Text = "TestCurrencyExchangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label fromCurrencyLabel;
        private Label toCurrencyLabel;
        private Button convertButton;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Label moneyLabel;
        private TextBox moneyTextBox;
        private ComboBox fromCurrencyComboBox;
        private ComboBox toCurrencyComboBox;
    }
}