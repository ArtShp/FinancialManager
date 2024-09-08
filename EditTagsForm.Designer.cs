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
            nameColumnHeader = new ColumnHeader();
            transactionTypeColumnHeader = new ColumnHeader();
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, transactionTypeColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(460, 12);
            listView.MinimumSize = new Size(400, 390);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(600, 490);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
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
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(129, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Tags";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(121, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Tag Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 113);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(432, 39);
            nameTextBox.TabIndex = 3;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(3, 178);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 4;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionTypeComboBox
            // 
            transactionTypeComboBox.FormattingEnabled = true;
            transactionTypeComboBox.Location = new Point(3, 222);
            transactionTypeComboBox.Name = "transactionTypeComboBox";
            transactionTypeComboBox.Size = new Size(432, 40);
            transactionTypeComboBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 46);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 46);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(149, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 46);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(295, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(140, 46);
            refreshButton.TabIndex = 9;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(149, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 46);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(295, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 46);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(transactionTypeLabel);
            panel1.Controls.Add(transactionTypeComboBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 283);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(saveButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(refreshButton);
            panel2.Location = new Point(12, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 110);
            panel2.TabIndex = 13;
            // 
            // EditTagsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView);
            MinimumSize = new Size(900, 490);
            Name = "EditTagsForm";
            Text = "Edit Tags";
            ResizeEnd += EditTagsForm_ResizeEnd;
            Resize += EditTagsForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
    }
}