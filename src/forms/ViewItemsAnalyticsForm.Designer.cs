namespace FinancialManager
{
    partial class ViewItemsAnalyticsForm
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
            categoryColumnHeader = new ColumnHeader();
            dateColumnHeader = new ColumnHeader();
            sumColumnHeader = new ColumnHeader();
            mainSumColumnHeader = new ColumnHeader();
            placeColumnHeader = new ColumnHeader();
            tagsColumnHeader = new ColumnHeader();
            titleLabel = new Label();
            categoryLabel = new Label();
            chooseCategoryButton = new Button();
            clearCategoryButton = new Button();
            categoryTextBox = new TextBox();
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
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { categoryColumnHeader, dateColumnHeader, sumColumnHeader, mainSumColumnHeader, placeColumnHeader, tagsColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(427, 12);
            listView.MinimumSize = new Size(400, 780);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(1100, 880);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
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
            // tagsColumnHeader
            // 
            tagsColumnHeader.Text = "Tags";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(344, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Analyze Items";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(3, 85);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";
            // 
            // chooseCategoryButton
            // 
            chooseCategoryButton.Location = new Point(3, 165);
            chooseCategoryButton.Name = "chooseCategoryButton";
            chooseCategoryButton.Size = new Size(115, 46);
            chooseCategoryButton.TabIndex = 3;
            chooseCategoryButton.Text = "Choose";
            chooseCategoryButton.UseVisualStyleBackColor = true;
            chooseCategoryButton.Click += chooseCategoryButton_Click;
            // 
            // clearCategoryButton
            // 
            clearCategoryButton.Location = new Point(124, 165);
            clearCategoryButton.Name = "clearCategoryButton";
            clearCategoryButton.Size = new Size(115, 46);
            clearCategoryButton.TabIndex = 4;
            clearCategoryButton.Text = "Clear";
            clearCategoryButton.UseVisualStyleBackColor = true;
            clearCategoryButton.Click += clearCategoryButton_Click;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(3, 120);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(400, 39);
            categoryTextBox.TabIndex = 5;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new Point(3, 236);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(192, 32);
            transactionTypeLabel.TabIndex = 6;
            transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionTypeComboBox
            // 
            transactionTypeComboBox.FormattingEnabled = true;
            transactionTypeComboBox.Location = new Point(3, 271);
            transactionTypeComboBox.Name = "transactionTypeComboBox";
            transactionTypeComboBox.Size = new Size(400, 40);
            transactionTypeComboBox.TabIndex = 7;
            // 
            // fromDateLabel
            // 
            fromDateLabel.AutoSize = true;
            fromDateLabel.Location = new Point(3, 338);
            fromDateLabel.Name = "fromDateLabel";
            fromDateLabel.Size = new Size(131, 32);
            fromDateLabel.TabIndex = 8;
            fromDateLabel.Text = "Date: From";
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.CustomFormat = "dd.MM.yyyy";
            fromDateTimePicker.Format = DateTimePickerFormat.Custom;
            fromDateTimePicker.Location = new Point(3, 373);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(400, 39);
            fromDateTimePicker.TabIndex = 9;
            fromDateTimePicker.DropDown += fromDateTimePicker_DropDown;
            // 
            // toDateLabel
            // 
            toDateLabel.AutoSize = true;
            toDateLabel.Location = new Point(3, 497);
            toDateLabel.Name = "toDateLabel";
            toDateLabel.Size = new Size(101, 32);
            toDateLabel.TabIndex = 10;
            toDateLabel.Text = "Date: To";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.CustomFormat = "dd.MM.yyyy";
            toDateTimePicker.Format = DateTimePickerFormat.Custom;
            toDateTimePicker.Location = new Point(3, 532);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(400, 39);
            toDateTimePicker.TabIndex = 11;
            toDateTimePicker.DropDown += toDateTimePicker_DropDown;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new Point(3, 642);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(69, 32);
            placeLabel.TabIndex = 12;
            placeLabel.Text = "Place";
            // 
            // placeComboBox
            // 
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(3, 677);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(400, 40);
            placeComboBox.TabIndex = 13;
            // 
            // getButton
            // 
            getButton.Location = new Point(3, 3);
            getButton.Name = "getButton";
            getButton.Size = new Size(150, 46);
            getButton.TabIndex = 14;
            getButton.Text = "Get";
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += getButton_Click;
            // 
            // clearFromDateButton
            // 
            clearFromDateButton.Location = new Point(3, 418);
            clearFromDateButton.Name = "clearFromDateButton";
            clearFromDateButton.Size = new Size(115, 46);
            clearFromDateButton.TabIndex = 15;
            clearFromDateButton.Text = "Clear";
            clearFromDateButton.UseVisualStyleBackColor = true;
            clearFromDateButton.Click += clearFromDateButton_Click;
            // 
            // clearToDateButton
            // 
            clearToDateButton.Location = new Point(3, 577);
            clearToDateButton.Name = "clearToDateButton";
            clearToDateButton.Size = new Size(115, 46);
            clearToDateButton.TabIndex = 16;
            clearToDateButton.Text = "Clear";
            clearToDateButton.UseVisualStyleBackColor = true;
            clearToDateButton.Click += clearToDateButton_Click;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(clearToDateButton);
            controlsPanel.Controls.Add(categoryLabel);
            controlsPanel.Controls.Add(clearFromDateButton);
            controlsPanel.Controls.Add(chooseCategoryButton);
            controlsPanel.Controls.Add(clearCategoryButton);
            controlsPanel.Controls.Add(placeComboBox);
            controlsPanel.Controls.Add(categoryTextBox);
            controlsPanel.Controls.Add(placeLabel);
            controlsPanel.Controls.Add(transactionTypeLabel);
            controlsPanel.Controls.Add(toDateTimePicker);
            controlsPanel.Controls.Add(transactionTypeComboBox);
            controlsPanel.Controls.Add(toDateLabel);
            controlsPanel.Controls.Add(fromDateLabel);
            controlsPanel.Controls.Add(fromDateTimePicker);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(409, 725);
            controlsPanel.TabIndex = 17;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(getButton);
            buttonsPanel.Location = new Point(12, 843);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(409, 55);
            buttonsPanel.TabIndex = 18;
            // 
            // ViewItemsAnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 909);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(870, 880);
            Name = "ViewItemsAnalyticsForm";
            Text = "Items Analytics";
            ResizeEnd += ViewItemsAnalyticsForm_ResizeEnd;
            Resize += ViewItemsAnalyticsForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel controlsPanel;
        private Panel buttonsPanel;
    }
}