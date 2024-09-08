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
            controlsPanel = new Panel();
            panel1 = new Panel();
            controlsPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(457, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Currency Exchange";
            // 
            // fromCurrencyLabel
            // 
            fromCurrencyLabel.AutoSize = true;
            fromCurrencyLabel.Location = new Point(3, 160);
            fromCurrencyLabel.Name = "fromCurrencyLabel";
            fromCurrencyLabel.Size = new Size(171, 32);
            fromCurrencyLabel.TabIndex = 1;
            fromCurrencyLabel.Text = "From Currency";
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.Location = new Point(343, 160);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(141, 32);
            toCurrencyLabel.TabIndex = 2;
            toCurrencyLabel.Text = "To Currency";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(3, 3);
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
            dateLabel.Location = new Point(3, 256);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(64, 32);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(3, 291);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(400, 39);
            dateTimePicker.TabIndex = 7;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new Point(3, 68);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(89, 32);
            moneyLabel.TabIndex = 8;
            moneyLabel.Text = "Money";
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(3, 103);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(257, 39);
            moneyTextBox.TabIndex = 9;
            // 
            // fromCurrencyComboBox
            // 
            fromCurrencyComboBox.FormattingEnabled = true;
            fromCurrencyComboBox.Location = new Point(3, 195);
            fromCurrencyComboBox.Name = "fromCurrencyComboBox";
            fromCurrencyComboBox.Size = new Size(257, 40);
            fromCurrencyComboBox.TabIndex = 10;
            // 
            // toCurrencyComboBox
            // 
            toCurrencyComboBox.FormattingEnabled = true;
            toCurrencyComboBox.Location = new Point(343, 195);
            toCurrencyComboBox.Name = "toCurrencyComboBox";
            toCurrencyComboBox.Size = new Size(257, 40);
            toCurrencyComboBox.TabIndex = 11;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(toCurrencyComboBox);
            controlsPanel.Controls.Add(fromCurrencyLabel);
            controlsPanel.Controls.Add(fromCurrencyComboBox);
            controlsPanel.Controls.Add(toCurrencyLabel);
            controlsPanel.Controls.Add(moneyTextBox);
            controlsPanel.Controls.Add(dateLabel);
            controlsPanel.Controls.Add(moneyLabel);
            controlsPanel.Controls.Add(dateTimePicker);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(610, 337);
            controlsPanel.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(convertButton);
            panel1.Location = new Point(12, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 55);
            panel1.TabIndex = 13;
            // 
            // TestCurrencyExchangeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 419);
            Controls.Add(panel1);
            Controls.Add(controlsPanel);
            MinimumSize = new Size(660, 490);
            Name = "TestCurrencyExchangeForm";
            Text = "Test Currency Exchange";
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel controlsPanel;
        private Panel panel1;
    }
}