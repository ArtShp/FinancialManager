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
            keyLabel = new Label();
            controlsPanel = new Panel();
            keyTextBox = new RichTextBox();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(3, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(170, 46);
            okButton.TabIndex = 0;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(179, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(170, 46);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(374, 45);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Setup Currency API Key";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(3, 82);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(94, 32);
            keyLabel.TabIndex = 4;
            keyLabel.Text = "API Key";
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(keyTextBox);
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(keyLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(412, 283);
            controlsPanel.TabIndex = 5;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(3, 117);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(400, 163);
            keyTextBox.TabIndex = 5;
            keyTextBox.Text = "";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(okButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Location = new Point(12, 301);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(412, 56);
            buttonsPanel.TabIndex = 6;
            // 
            // SetupCurrencyApiForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 369);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            MinimumSize = new Size(460, 440);
            Name = "SetupCurrencyApiForm";
            Text = "Setup Currency API";
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label titleLabel;
        private Label keyLabel;
        private Panel controlsPanel;
        private Panel buttonsPanel;
        private RichTextBox keyTextBox;
    }
}