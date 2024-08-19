namespace FinancialManager
{
    partial class EditCategoriesForm
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
            treeView = new TreeView();
            titleLabel = new Label();
            nameLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            nameTextBox = new TextBox();
            categoryLabel = new Label();
            categoryTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.FullRowSelect = true;
            treeView.Location = new Point(708, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(609, 916);
            treeView.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(41, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(268, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Categories";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(41, 155);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(181, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Category Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(41, 882);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(41, 830);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(253, 830);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(253, 882);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(470, 830);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(470, 882);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(41, 190);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(457, 39);
            nameTextBox.TabIndex = 9;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(41, 323);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(184, 32);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "Parent Category";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(41, 358);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(457, 39);
            categoryTextBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(41, 403);
            button1.Name = "button1";
            button1.Size = new Size(101, 46);
            button1.TabIndex = 12;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(148, 403);
            button2.Name = "button2";
            button2.Size = new Size(101, 46);
            button2.TabIndex = 13;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 967);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(categoryTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(nameTextBox);
            Controls.Add(cancelButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Controls.Add(treeView);
            Name = "EditCategoriesForm";
            Text = "EditCategoriesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private Label titleLabel;
        private Label nameLabel;
        private Button addButton;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private Button cancelButton;
        private Button refreshButton;
        private TextBox nameTextBox;
        private Label categoryLabel;
        private TextBox categoryTextBox;
        private Button button1;
        private Button button2;
    }
}