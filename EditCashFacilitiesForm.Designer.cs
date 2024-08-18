namespace FinancialManager
{
    partial class EditCashFacilitiesForm
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
            cancelButton = new Button();
            deleteButton = new Button();
            refreshButton = new Button();
            saveButton = new Button();
            editButton = new Button();
            addButton = new Button();
            currencyComboBox = new ComboBox();
            currencyLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            titleLabel = new Label();
            listView = new ListView();
            nameColumnHeader = new ColumnHeader();
            currencyColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(466, 783);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(253, 835);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(466, 835);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 21;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(253, 783);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(40, 783);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 19;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(40, 835);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 18;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(40, 344);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(454, 40);
            currencyComboBox.TabIndex = 17;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(40, 300);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 16;
            currencyLabel.Text = "Currency";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(40, 166);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(454, 39);
            nameTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(40, 131);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(215, 32);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Cash Facility Name";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(40, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(342, 65);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Cash Facilities";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, currencyColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(662, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(566, 869);
            listView.TabIndex = 12;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 200;
            // 
            // currencyColumnHeader
            // 
            currencyColumnHeader.Text = "Currency";
            currencyColumnHeader.Width = 200;
            // 
            // EditCashFacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 921);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(currencyComboBox);
            Controls.Add(currencyLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Controls.Add(listView);
            Name = "EditCashFacilitiesForm";
            Text = "EditCashFacilitiesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button deleteButton;
        private Button refreshButton;
        private Button saveButton;
        private Button editButton;
        private Button addButton;
        private ComboBox currencyComboBox;
        private Label currencyLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label titleLabel;
        private ListView listView;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader currencyColumnHeader;
    }
}