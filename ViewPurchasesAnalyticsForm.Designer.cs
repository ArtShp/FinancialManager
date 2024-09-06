namespace FinancialManager
{
    partial class ViewPurchasesAnalyticsForm
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
            categoryLabel = new Label();
            chooseCategoryButton = new Button();
            clearCategoryButton = new Button();
            categoryTextBox = new TextBox();
            categoryColumnHeader = new ColumnHeader();
            dateColumnHeader = new ColumnHeader();
            sumColumnHeader = new ColumnHeader();
            mainSumColumnHeader = new ColumnHeader();
            placeColumnHeader = new ColumnHeader();
            transactionTypeColumnHeader = new ColumnHeader();
            tagsColumnHeader = new ColumnHeader();
            transactionTypeLabel = new Label();
            transactionTypeComboBox = new ComboBox();
            fromDateLabel = new Label();
            fromDateTimePicker = new DateTimePicker();
            toDateLabel = new Label();
            toDateTimePicker = new DateTimePicker();
            placeLabel = new Label();
            placeComboBox = new ComboBox();
            getButton = new Button();
            clearFromDateButton = new Button();
            clearToDateButton = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { categoryColumnHeader, dateColumnHeader, sumColumnHeader, mainSumColumnHeader, placeColumnHeader, transactionTypeColumnHeader, tagsColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(543, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(1162, 881);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(24, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(442, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Analyze Purchases";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(24, 94);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";
            // 
            // chooseCategoryButton
            // 
            chooseCategoryButton.Location = new Point(24, 174);
            chooseCategoryButton.Name = "chooseCategoryButton";
            chooseCategoryButton.Size = new Size(115, 46);
            chooseCategoryButton.TabIndex = 3;
            chooseCategoryButton.Text = "Choose";
            chooseCategoryButton.UseVisualStyleBackColor = true;
            // 
            // clearCategoryButton
            // 
            clearCategoryButton.Location = new Point(145, 174);
            clearCategoryButton.Name = "clearCategoryButton";
            clearCategoryButton.Size = new Size(115, 46);
            clearCategoryButton.TabIndex = 4;
            clearCategoryButton.Text = "Clear";
            clearCategoryButton.UseVisualStyleBackColor = true;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(24, 129);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(400, 39);
            categoryTextBox.TabIndex = 5;
            // 
            // categoryColumnHeader
            // 
            categoryColumnHeader.Text = "Category";
            // 
            // dateColumnHeader
            // 
            dateColumnHeader.Text = "Date";
            // 
            // sumColumnHeader
            // 
            sumColumnHeader.Text = "Sum";
            // 
            // mainSumColumnHeader
            // 
            mainSumColumnHeader.Text = "Sum (Main)";
            // 
            // placeColumnHeader
            // 
            placeColumnHeader.Text = "Place";
            // 
            // transactionTypeColumnHeader
            // 
            transactionTypeColumnHeader.Text = "Transaction Type";
            // 
            // tagsColumnHeader
            // 
            tagsColumnHeader.Text = "Tags";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(24, 245);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 6;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionTypeComboBox
            // 
            transactionTypeComboBox.FormattingEnabled = true;
            transactionTypeComboBox.Location = new Point(24, 280);
            transactionTypeComboBox.Name = "transactionTypeComboBox";
            transactionTypeComboBox.Size = new Size(400, 40);
            transactionTypeComboBox.TabIndex = 7;
            // 
            // fromDateLabel
            // 
            fromDateLabel.AutoSize = true;
            fromDateLabel.Location = new Point(24, 374);
            fromDateLabel.Name = "fromDateLabel";
            fromDateLabel.Size = new Size(131, 32);
            fromDateLabel.TabIndex = 8;
            fromDateLabel.Text = "Date: From";
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.CustomFormat = "dd.MM.yyyy";
            fromDateTimePicker.Format = DateTimePickerFormat.Custom;
            fromDateTimePicker.Location = new Point(24, 409);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(400, 39);
            fromDateTimePicker.TabIndex = 9;
            // 
            // toDateLabel
            // 
            toDateLabel.AutoSize = true;
            toDateLabel.Location = new Point(24, 523);
            toDateLabel.Name = "toDateLabel";
            toDateLabel.Size = new Size(101, 32);
            toDateLabel.TabIndex = 10;
            toDateLabel.Text = "Date: To";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.CustomFormat = "dd.MM.yyyy";
            toDateTimePicker.Format = DateTimePickerFormat.Custom;
            toDateTimePicker.Location = new Point(24, 558);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(400, 39);
            toDateTimePicker.TabIndex = 11;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new Point(24, 697);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(69, 32);
            placeLabel.TabIndex = 12;
            placeLabel.Text = "Place";
            // 
            // placeComboBox
            // 
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(24, 732);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(400, 40);
            placeComboBox.TabIndex = 13;
            // 
            // getButton
            // 
            getButton.Location = new Point(24, 847);
            getButton.Name = "getButton";
            getButton.Size = new Size(150, 46);
            getButton.TabIndex = 14;
            getButton.Text = "Get";
            getButton.UseVisualStyleBackColor = true;
            // 
            // clearFromDateButton
            // 
            clearFromDateButton.Location = new Point(24, 454);
            clearFromDateButton.Name = "clearFromDateButton";
            clearFromDateButton.Size = new Size(115, 46);
            clearFromDateButton.TabIndex = 15;
            clearFromDateButton.Text = "Clear";
            clearFromDateButton.UseVisualStyleBackColor = true;
            // 
            // clearToDateButton
            // 
            clearToDateButton.Location = new Point(24, 603);
            clearToDateButton.Name = "clearToDateButton";
            clearToDateButton.Size = new Size(115, 46);
            clearToDateButton.TabIndex = 16;
            clearToDateButton.Text = "Clear";
            clearToDateButton.UseVisualStyleBackColor = true;
            // 
            // ViewPurchasesAnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 933);
            Controls.Add(clearToDateButton);
            Controls.Add(clearFromDateButton);
            Controls.Add(getButton);
            Controls.Add(placeComboBox);
            Controls.Add(placeLabel);
            Controls.Add(toDateTimePicker);
            Controls.Add(toDateLabel);
            Controls.Add(fromDateTimePicker);
            Controls.Add(fromDateLabel);
            Controls.Add(transactionTypeComboBox);
            Controls.Add(transactionTypeLabel);
            Controls.Add(categoryTextBox);
            Controls.Add(clearCategoryButton);
            Controls.Add(chooseCategoryButton);
            Controls.Add(categoryLabel);
            Controls.Add(titleLabel);
            Controls.Add(listView);
            Name = "ViewPurchasesAnalyticsForm";
            Text = "ViewPurchasesAnalyticsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private Label titleLabel;
        private Label categoryLabel;
        private Button chooseCategoryButton;
        private Button clearCategoryButton;
        private TextBox categoryTextBox;
        private ColumnHeader categoryColumnHeader;
        private ColumnHeader dateColumnHeader;
        private ColumnHeader sumColumnHeader;
        private ColumnHeader mainSumColumnHeader;
        private ColumnHeader placeColumnHeader;
        private ColumnHeader transactionTypeColumnHeader;
        private ColumnHeader tagsColumnHeader;
        private Label transactionTypeLabel;
        private ComboBox transactionTypeComboBox;
        private Label fromDateLabel;
        private DateTimePicker fromDateTimePicker;
        private Label toDateLabel;
        private DateTimePicker toDateTimePicker;
        private Label placeLabel;
        private ComboBox placeComboBox;
        private Button getButton;
        private Button clearFromDateButton;
        private Button clearToDateButton;
    }
}