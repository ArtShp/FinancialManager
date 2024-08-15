namespace FinancialManager
{
    partial class EditTagsForm
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
            listView = new ListView();
            titleLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            transactionTypeLabel = new Label();
            transactionTypeComboBox = new ComboBox();
            addButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            refreshButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            nameColumnHeader = new ColumnHeader();
            transactionTypeColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, transactionTypeColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(656, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(566, 869);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(34, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(129, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Tags";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(34, 131);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(121, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Tag Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(34, 166);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(454, 39);
            nameTextBox.TabIndex = 3;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(34, 300);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 4;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionTypeComboBox
            // 
            transactionTypeComboBox.FormattingEnabled = true;
            transactionTypeComboBox.Location = new Point(34, 344);
            transactionTypeComboBox.Name = "transactionTypeComboBox";
            transactionTypeComboBox.Size = new Size(454, 40);
            transactionTypeComboBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(34, 835);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(34, 783);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(247, 783);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(460, 835);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 9;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(247, 835);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(460, 783);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 120;
            // 
            // transactionTypeColumnHeader
            // 
            transactionTypeColumnHeader.Text = "Transaction Type";
            transactionTypeColumnHeader.Width = 200;
            // 
            // EditTagsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 910);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(transactionTypeComboBox);
            Controls.Add(transactionTypeLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Controls.Add(listView);
            Name = "EditTagsForm";
            Text = "EditTagsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label transactionTypeLabel;
        private ComboBox transactionTypeComboBox;
        private Button addButton;
        private Button editButton;
        private Button saveButton;
        private Button refreshButton;
        private Button deleteButton;
        private Button cancelButton;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader transactionTypeColumnHeader;
    }
}