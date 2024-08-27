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
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(27, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(235, 130);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Choose\r\nCategory";
            // 
            // treeView
            // 
            treeView.FullRowSelect = true;
            treeView.Location = new Point(426, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(578, 711);
            treeView.TabIndex = 1;
            treeView.AfterCollapse += treeView_AfterCollapse;
            treeView.BeforeExpand += treeView_BeforeExpand;
            // 
            // chooseButton
            // 
            chooseButton.Location = new Point(27, 677);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(150, 46);
            chooseButton.TabIndex = 2;
            chooseButton.Text = "Choose";
            chooseButton.UseVisualStyleBackColor = true;
            chooseButton.Click += chooseButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(218, 677);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ChooseCategoryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 755);
            Controls.Add(cancelButton);
            Controls.Add(chooseButton);
            Controls.Add(treeView);
            Controls.Add(titleLabel);
            Name = "ChooseCategoryForm";
            Text = "ChooseCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TreeView treeView;
        private Button chooseButton;
        private Button cancelButton;
    }
}