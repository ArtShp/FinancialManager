namespace FinancialManager
{
    partial class SetupCurrencyApiForm
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
            okButton = new Button();
            cancelButton = new Button();
            titleLabel = new Label();
            keyTextBox = new TextBox();
            keyLabel = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(27, 240);
            okButton.Name = "okButton";
            okButton.Size = new Size(150, 46);
            okButton.TabIndex = 0;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(227, 240);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(27, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(374, 45);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Setup Currency API Key";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(27, 134);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(486, 39);
            keyTextBox.TabIndex = 3;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(27, 99);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(94, 32);
            keyLabel.TabIndex = 4;
            keyLabel.Text = "API Key";
            // 
            // SetupCurrencyApiForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 298);
            Controls.Add(keyLabel);
            Controls.Add(keyTextBox);
            Controls.Add(titleLabel);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Name = "SetupCurrencyApiForm";
            Text = "SetupCurrencyApiForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label titleLabel;
        private TextBox keyTextBox;
        private Label keyLabel;
    }
}