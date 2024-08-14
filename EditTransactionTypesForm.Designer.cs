namespace FinancialManager
{
    partial class EditTransactionTypesForm
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
            nameLabel = new Label();
            titleLabel = new Label();
            listView = new ListView();
            addButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(26, 130);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(192, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Transaction Type";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(26, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(429, 65);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Transaction Types";
            // 
            // listView
            // 
            listView.Location = new Point(664, 12);
            listView.Name = "listView";
            listView.Size = new Size(449, 854);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(26, 820);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(250, 768);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(250, 820);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(26, 768);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(480, 768);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(480, 820);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 9;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(26, 180);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(380, 39);
            nameTextBox.TabIndex = 10;
            // 
            // EditTransactionTypesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 899);
            Controls.Add(nameTextBox);
            Controls.Add(refreshButton);
            Controls.Add(cancelButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(listView);
            Controls.Add(titleLabel);
            Controls.Add(nameLabel);
            Name = "EditTransactionTypesForm";
            Text = "EditTransactionTypesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private Label titleLabel;
        private ListView listView;
        private Button addButton;
        private Button saveButton;
        private Button deleteButton;
        private Button editButton;
        private Button cancelButton;
        private Button refreshButton;
        private TextBox nameTextBox;
    }
}