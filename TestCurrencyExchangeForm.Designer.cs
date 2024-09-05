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
            fromCurrencyTextBox = new TextBox();
            toCurrencyTextBox = new TextBox();
            convertButton = new Button();
            dateLabel = new Label();
            dateTimePicker = new DateTimePicker();
            moneyLabel = new Label();
            moneyTextBox = new TextBox();
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
            fromCurrencyLabel.Size = new Size(248, 32);
            fromCurrencyLabel.TabIndex = 1;
            fromCurrencyLabel.Text = "From Currency (Code)";
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.Location = new Point(371, 225);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(218, 32);
            toCurrencyLabel.TabIndex = 2;
            toCurrencyLabel.Text = "To Currency (Code)";
            // 
            // fromCurrencyTextBox
            // 
            fromCurrencyTextBox.Location = new Point(31, 260);
            fromCurrencyTextBox.Name = "fromCurrencyTextBox";
            fromCurrencyTextBox.Size = new Size(257, 39);
            fromCurrencyTextBox.TabIndex = 3;
            // 
            // toCurrencyTextBox
            // 
            toCurrencyTextBox.Location = new Point(371, 260);
            toCurrencyTextBox.Name = "toCurrencyTextBox";
            toCurrencyTextBox.Size = new Size(257, 39);
            toCurrencyTextBox.TabIndex = 4;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(31, 473);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(150, 46);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
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
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
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
            // TestCurrencyExchangeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 543);
            Controls.Add(moneyTextBox);
            Controls.Add(moneyLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(convertButton);
            Controls.Add(toCurrencyTextBox);
            Controls.Add(fromCurrencyTextBox);
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
        private TextBox fromCurrencyTextBox;
        private TextBox toCurrencyTextBox;
        private Button convertButton;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Label moneyLabel;
        private TextBox moneyTextBox;
    }
}