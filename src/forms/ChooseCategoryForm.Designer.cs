namespace FinancialManager
{
    partial class ChooseCategoryForm
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
            treeView = new TreeView();
            chooseButton = new Button();
            cancelButton = new Button();
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(235, 130);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Choose\r\nCategory";
            // 
            // treeView
            // 
            treeView.FullRowSelect = true;
            treeView.Location = new Point(333, 12);
            treeView.MinimumSize = new Size(350, 210);
            treeView.Name = "treeView";
            treeView.Size = new Size(550, 410);
            treeView.TabIndex = 1;
            treeView.AfterCollapse += treeView_AfterCollapse;
            treeView.BeforeExpand += treeView_BeforeExpand;
            // 
            // chooseButton
            // 
            chooseButton.Location = new Point(3, 3);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(150, 46);
            chooseButton.TabIndex = 2;
            chooseButton.Text = "Choose";
            chooseButton.UseVisualStyleBackColor = true;
            chooseButton.Click += chooseButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(159, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(315, 155);
            controlsPanel.TabIndex = 4;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(chooseButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Location = new Point(12, 373);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(315, 56);
            buttonsPanel.TabIndex = 5;
            // 
            // ChooseCategoryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 439);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(treeView);
            MinimumSize = new Size(720, 310);
            Name = "ChooseCategoryForm";
            Text = "Choose Category";
            Resize += ChooseCategoryForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private TreeView treeView;
        private Button chooseButton;
        private Button cancelButton;
        private Panel controlsPanel;
        private Panel buttonsPanel;
    }
}