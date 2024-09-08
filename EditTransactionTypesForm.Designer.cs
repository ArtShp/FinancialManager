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
            nameColumnHeader = new ColumnHeader();
            addButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            nameTextBox = new TextBox();
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(192, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Transaction Type";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(429, 65);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Transaction Types";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(461, 12);
            listView.MinimumSize = new Size(350, 290);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(550, 390);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 120;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 46);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(149, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 46);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(149, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 46);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
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
            // cancelButton
            // 
            cancelButton.Location = new Point(295, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 46);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
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
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 135);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(429, 39);
            nameTextBox.TabIndex = 10;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(nameTextBox);
            controlsPanel.Controls.Add(nameLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(443, 183);
            controlsPanel.TabIndex = 11;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Location = new Point(12, 301);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(443, 109);
            buttonsPanel.TabIndex = 12;
            // 
            // EditTransactionTypesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 419);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(850, 390);
            Name = "EditTransactionTypesForm";
            Text = "Edit Transaction Types";
            ResizeEnd += EditTransactionTypesForm_ResizeEnd;
            Resize += EditTransactionTypesForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private ColumnHeader nameColumnHeader;
        private Panel controlsPanel;
        private Panel buttonsPanel;
    }
}