namespace FinancialManager
{
    partial class EditTransactionsForm
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
            transactionTypeLabel = new Label();
            transactionComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            sumLabel = new Label();
            cashComboBox = new ComboBox();
            cashFacilityLabel = new Label();
            placeComboBox = new ComboBox();
            placeLabel = new Label();
            currencyComboBox = new ComboBox();
            currencyLabel = new Label();
            descriptionLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            listView = new ListView();
            transactionColumnHeader = new ColumnHeader();
            dateColumnHeader = new ColumnHeader();
            sumColumnHeader = new ColumnHeader();
            currencyColumnHeader = new ColumnHeader();
            cashColumnHeader = new ColumnHeader();
            placeColumnHeader = new ColumnHeader();
            descriptionColumnHeader = new ColumnHeader();
            addButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            sumTextBox = new TextBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(41, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(308, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Transactions";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(41, 112);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 1;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionComboBox
            // 
            transactionComboBox.FormattingEnabled = true;
            transactionComboBox.Location = new Point(41, 156);
            transactionComboBox.Name = "transactionComboBox";
            transactionComboBox.Size = new Size(379, 40);
            transactionComboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(41, 270);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(379, 39);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.Value = new DateTime(2024, 8, 21, 17, 1, 55, 0);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(41, 235);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(64, 32);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new Point(41, 369);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(62, 32);
            sumLabel.TabIndex = 5;
            sumLabel.Text = "Sum";
            // 
            // cashComboBox
            // 
            cashComboBox.FormattingEnabled = true;
            cashComboBox.Location = new Point(483, 147);
            cashComboBox.Name = "cashComboBox";
            cashComboBox.Size = new Size(377, 40);
            cashComboBox.TabIndex = 8;
            // 
            // cashFacilityLabel
            // 
            cashFacilityLabel.AutoSize = true;
            cashFacilityLabel.Location = new Point(483, 112);
            cashFacilityLabel.Name = "cashFacilityLabel";
            cashFacilityLabel.Size = new Size(144, 32);
            cashFacilityLabel.TabIndex = 7;
            cashFacilityLabel.Text = "Cash Facility";
            // 
            // placeComboBox
            // 
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(483, 269);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(377, 40);
            placeComboBox.TabIndex = 10;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new Point(483, 235);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(69, 32);
            placeLabel.TabIndex = 9;
            placeLabel.Text = "Place";
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(483, 404);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(377, 40);
            currencyComboBox.TabIndex = 12;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(483, 369);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 11;
            currencyLabel.Text = "Currency";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(41, 486);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(135, 32);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(41, 521);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(819, 255);
            descriptionRichTextBox.TabIndex = 14;
            descriptionRichTextBox.Text = "";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { transactionColumnHeader, dateColumnHeader, sumColumnHeader, currencyColumnHeader, cashColumnHeader, placeColumnHeader, descriptionColumnHeader });
            listView.Location = new Point(901, 12);
            listView.Name = "listView";
            listView.Size = new Size(1211, 959);
            listView.TabIndex = 15;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // transactionColumnHeader
            // 
            transactionColumnHeader.Text = "Transaction Type";
            transactionColumnHeader.Width = 120;
            // 
            // dateColumnHeader
            // 
            dateColumnHeader.Text = "Date";
            dateColumnHeader.Width = 100;
            // 
            // sumColumnHeader
            // 
            sumColumnHeader.Text = "Sum";
            sumColumnHeader.Width = 100;
            // 
            // currencyColumnHeader
            // 
            currencyColumnHeader.Text = "Currency";
            currencyColumnHeader.Width = 100;
            // 
            // cashColumnHeader
            // 
            cashColumnHeader.Text = "Cash Facility";
            cashColumnHeader.Width = 100;
            // 
            // placeColumnHeader
            // 
            placeColumnHeader.Text = "Place";
            placeColumnHeader.Width = 100;
            // 
            // descriptionColumnHeader
            // 
            descriptionColumnHeader.Text = "Description";
            descriptionColumnHeader.Width = 100;
            // 
            // addButton
            // 
            addButton.Location = new Point(41, 925);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 16;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(41, 873);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 17;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(234, 873);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 19;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(234, 925);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(426, 873);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(426, 925);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 20;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // sumTextBox
            // 
            sumTextBox.Location = new Point(41, 404);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(379, 39);
            sumTextBox.TabIndex = 6;
            sumTextBox.Text = "0.0";
            // 
            // EditTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2124, 992);
            Controls.Add(cancelButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(listView);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(currencyComboBox);
            Controls.Add(currencyLabel);
            Controls.Add(placeComboBox);
            Controls.Add(placeLabel);
            Controls.Add(cashComboBox);
            Controls.Add(cashFacilityLabel);
            Controls.Add(sumTextBox);
            Controls.Add(sumLabel);
            Controls.Add(dateLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(transactionComboBox);
            Controls.Add(transactionTypeLabel);
            Controls.Add(titleLabel);
            Name = "EditTransactionsForm";
            Text = "EditTransactionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label transactionTypeLabel;
        private ComboBox transactionComboBox;
        private DateTimePicker dateTimePicker;
        private Label dateLabel;
        private Label sumLabel;
        private ComboBox cashComboBox;
        private Label cashFacilityLabel;
        private ComboBox placeComboBox;
        private Label placeLabel;
        private ComboBox currencyComboBox;
        private Label currencyLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private ListView listView;
        private Button addButton;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private Button cancelButton;
        private Button refreshButton;
        private TextBox sumTextBox;
        private ColumnHeader transactionColumnHeader;
        private ColumnHeader dateColumnHeader;
        private ColumnHeader sumColumnHeader;
        private ColumnHeader currencyColumnHeader;
        private ColumnHeader cashColumnHeader;
        private ColumnHeader placeColumnHeader;
        private ColumnHeader descriptionColumnHeader;
    }
}