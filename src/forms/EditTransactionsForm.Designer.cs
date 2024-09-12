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
            components = new System.ComponentModel.Container();
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
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            sumErrorProvider = new ErrorProvider(components);
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sumErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(308, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Transactions";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(3, 77);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 1;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionComboBox
            // 
            transactionComboBox.FormattingEnabled = true;
            transactionComboBox.Location = new Point(3, 112);
            transactionComboBox.Name = "transactionComboBox";
            transactionComboBox.Size = new Size(344, 40);
            transactionComboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(3, 209);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(344, 39);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.Value = new DateTime(2024, 8, 21, 17, 1, 55, 0);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(3, 174);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(64, 32);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new Point(3, 265);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(62, 32);
            sumLabel.TabIndex = 5;
            sumLabel.Text = "Sum";
            // 
            // cashComboBox
            // 
            cashComboBox.FormattingEnabled = true;
            cashComboBox.Location = new Point(400, 300);
            cashComboBox.Name = "cashComboBox";
            cashComboBox.Size = new Size(377, 40);
            cashComboBox.TabIndex = 8;
            // 
            // cashFacilityLabel
            // 
            cashFacilityLabel.AutoSize = true;
            cashFacilityLabel.Location = new Point(400, 265);
            cashFacilityLabel.Name = "cashFacilityLabel";
            cashFacilityLabel.Size = new Size(144, 32);
            cashFacilityLabel.TabIndex = 7;
            cashFacilityLabel.Text = "Cash Facility";
            // 
            // placeComboBox
            // 
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(400, 208);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(377, 40);
            placeComboBox.TabIndex = 10;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new Point(400, 174);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(69, 32);
            placeLabel.TabIndex = 9;
            placeLabel.Text = "Place";
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(400, 112);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(377, 40);
            currencyComboBox.TabIndex = 12;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(400, 77);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 11;
            currencyLabel.Text = "Currency";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(3, 356);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(135, 32);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(3, 391);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(774, 98);
            descriptionRichTextBox.TabIndex = 14;
            descriptionRichTextBox.Text = "";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { transactionColumnHeader, dateColumnHeader, sumColumnHeader, currencyColumnHeader, cashColumnHeader, placeColumnHeader, descriptionColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(803, 12);
            listView.MinimumSize = new Size(500, 600);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(1000, 800);
            listView.TabIndex = 15;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.DoubleClick += listView_DoubleClick;
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
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(200, 46);
            addButton.TabIndex = 16;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(200, 46);
            editButton.TabIndex = 17;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(279, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 46);
            saveButton.TabIndex = 19;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(279, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(200, 46);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(577, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 46);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(577, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(200, 46);
            refreshButton.TabIndex = 20;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // sumTextBox
            // 
            sumTextBox.Location = new Point(3, 300);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(344, 39);
            sumTextBox.TabIndex = 6;
            sumTextBox.Text = "0";
            sumTextBox.Validating += sumTextBox_Validating;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(transactionTypeLabel);
            controlsPanel.Controls.Add(transactionComboBox);
            controlsPanel.Controls.Add(dateTimePicker);
            controlsPanel.Controls.Add(dateLabel);
            controlsPanel.Controls.Add(sumLabel);
            controlsPanel.Controls.Add(sumTextBox);
            controlsPanel.Controls.Add(currencyLabel);
            controlsPanel.Controls.Add(descriptionRichTextBox);
            controlsPanel.Controls.Add(cashFacilityLabel);
            controlsPanel.Controls.Add(descriptionLabel);
            controlsPanel.Controls.Add(cashComboBox);
            controlsPanel.Controls.Add(currencyComboBox);
            controlsPanel.Controls.Add(placeLabel);
            controlsPanel.Controls.Add(placeComboBox);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(785, 496);
            controlsPanel.TabIndex = 22;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Location = new Point(12, 714);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(785, 106);
            buttonsPanel.TabIndex = 23;
            // 
            // sumErrorProvider
            // 
            sumErrorProvider.ContainerControl = this;
            // 
            // EditTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 829);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(1340, 700);
            Name = "EditTransactionsForm";
            Text = "Edit Transactions";
            ResizeEnd += EditTransactionsForm_ResizeEnd;
            Resize += EditTransactionsForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sumErrorProvider).EndInit();
            ResumeLayout(false);
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
        private Panel controlsPanel;
        private Panel buttonsPanel;
        private ErrorProvider sumErrorProvider;
    }
}