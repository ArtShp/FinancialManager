namespace FinancialManager
{
    partial class SetupMainCurrencyForm
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
            currencyLabel = new Label();
            currencyComboBox = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(34, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(333, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Setup Main Currency";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(34, 82);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 1;
            currencyLabel.Text = "Currency";
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(34, 117);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(463, 40);
            currencyComboBox.TabIndex = 2;
            // 
            // okButton
            // 
            okButton.Location = new Point(34, 198);
            okButton.Name = "okButton";
            okButton.Size = new Size(150, 46);
            okButton.TabIndex = 3;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(217, 198);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // SetupMainCurrencyForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 274);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(currencyComboBox);
            Controls.Add(currencyLabel);
            Controls.Add(titleLabel);
            Name = "SetupMainCurrencyForm";
            Text = "SetupMainCurrencyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label currencyLabel;
        private ComboBox currencyComboBox;
        private Button okButton;
        private Button cancelButton;
    }
}