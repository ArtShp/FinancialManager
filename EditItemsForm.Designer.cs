namespace FinancialManager
{
    partial class EditItemsForm
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
            listView = new ListView();
            categoryColumnHeader = new ColumnHeader();
            sumColumnHeader = new ColumnHeader();
            mainSumColumnHeader = new ColumnHeader();
            tagsColumnHeader = new ColumnHeader();
            descriptionColumnHeader = new ColumnHeader();
            sumLabel = new Label();
            categoryLabel = new Label();
            descriptionLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            refreshButton = new Button();
            cancelButton = new Button();
            sumTextBox = new TextBox();
            categoryTextBox = new TextBox();
            chooseCategoryButton = new Button();
            clearCategoryButton = new Button();
            currencyLabel = new Label();
            currencyTextBox = new TextBox();
            tagsLabel = new Label();
            tagsListView = new ListView();
            buttonsPanel = new Panel();
            controlsPanel = new Panel();
            sumErrorProvider = new ErrorProvider(components);
            buttonsPanel.SuspendLayout();
            controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sumErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(153, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Items";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { categoryColumnHeader, sumColumnHeader, mainSumColumnHeader, tagsColumnHeader, descriptionColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(458, 12);
            listView.MinimumSize = new Size(450, 880);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(850, 880);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // categoryColumnHeader
            // 
            categoryColumnHeader.Text = "Category";
            categoryColumnHeader.Width = 120;
            // 
            // sumColumnHeader
            // 
            sumColumnHeader.Text = "Sum";
            sumColumnHeader.Width = 100;
            // 
            // mainSumColumnHeader
            // 
            mainSumColumnHeader.Text = "Sum (Main)";
            mainSumColumnHeader.Width = 100;
            // 
            // tagsColumnHeader
            // 
            tagsColumnHeader.Text = "Tags";
            tagsColumnHeader.Width = 100;
            // 
            // descriptionColumnHeader
            // 
            descriptionColumnHeader.Text = "Description";
            descriptionColumnHeader.Width = 120;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new Point(3, 68);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(62, 32);
            sumLabel.TabIndex = 2;
            sumLabel.Text = "Sum";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(2, 257);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(2, 620);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(135, 32);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(3, 655);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(432, 115);
            descriptionRichTextBox.TabIndex = 7;
            descriptionRichTextBox.Text = "";
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 46);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 46);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
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
            // saveButton
            // 
            saveButton.Location = new Point(149, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 46);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(295, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(140, 46);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(295, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 46);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // sumTextBox
            // 
            sumTextBox.Location = new Point(3, 103);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(386, 39);
            sumTextBox.TabIndex = 14;
            sumTextBox.Text = "0";
            sumTextBox.Validating += sumTextBox_Validating;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(2, 292);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(433, 39);
            categoryTextBox.TabIndex = 15;
            // 
            // chooseCategoryButton
            // 
            chooseCategoryButton.Location = new Point(2, 337);
            chooseCategoryButton.Name = "chooseCategoryButton";
            chooseCategoryButton.Size = new Size(110, 46);
            chooseCategoryButton.TabIndex = 16;
            chooseCategoryButton.Text = "Choose";
            chooseCategoryButton.UseVisualStyleBackColor = true;
            chooseCategoryButton.Click += chooseCategoryButton_Click;
            // 
            // clearCategoryButton
            // 
            clearCategoryButton.Location = new Point(118, 337);
            clearCategoryButton.Name = "clearCategoryButton";
            clearCategoryButton.Size = new Size(110, 46);
            clearCategoryButton.TabIndex = 17;
            clearCategoryButton.Text = "Clear";
            clearCategoryButton.UseVisualStyleBackColor = true;
            clearCategoryButton.Click += clearCategoryButton_Click;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(3, 145);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 18;
            currencyLabel.Text = "Currency";
            // 
            // currencyTextBox
            // 
            currencyTextBox.Location = new Point(3, 180);
            currencyTextBox.Name = "currencyTextBox";
            currencyTextBox.ReadOnly = true;
            currencyTextBox.Size = new Size(432, 39);
            currencyTextBox.TabIndex = 19;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new Point(2, 410);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(60, 32);
            tagsLabel.TabIndex = 20;
            tagsLabel.Text = "Tags";
            // 
            // tagsListView
            // 
            tagsListView.CheckBoxes = true;
            tagsListView.FullRowSelect = true;
            tagsListView.HideSelection = true;
            tagsListView.Location = new Point(3, 445);
            tagsListView.MultiSelect = false;
            tagsListView.Name = "tagsListView";
            tagsListView.Size = new Size(432, 157);
            tagsListView.TabIndex = 21;
            tagsListView.UseCompatibleStateImageBehavior = false;
            tagsListView.View = View.List;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Location = new Point(12, 791);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(440, 107);
            buttonsPanel.TabIndex = 22;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(sumLabel);
            controlsPanel.Controls.Add(tagsListView);
            controlsPanel.Controls.Add(categoryLabel);
            controlsPanel.Controls.Add(tagsLabel);
            controlsPanel.Controls.Add(descriptionLabel);
            controlsPanel.Controls.Add(currencyTextBox);
            controlsPanel.Controls.Add(descriptionRichTextBox);
            controlsPanel.Controls.Add(currencyLabel);
            controlsPanel.Controls.Add(sumTextBox);
            controlsPanel.Controls.Add(clearCategoryButton);
            controlsPanel.Controls.Add(categoryTextBox);
            controlsPanel.Controls.Add(chooseCategoryButton);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(440, 773);
            controlsPanel.TabIndex = 23;
            // 
            // sumErrorProvider
            // 
            sumErrorProvider.ContainerControl = this;
            // 
            // EditItemsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 909);
            Controls.Add(controlsPanel);
            Controls.Add(buttonsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(950, 980);
            Name = "EditItemsForm";
            Text = "Edit Items";
            ResizeEnd += EditItemsForm_ResizeEnd;
            Resize += EditItemsForm_Resize;
            buttonsPanel.ResumeLayout(false);
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sumErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private ListView listView;
        private Label sumLabel;
        private Label categoryLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private Button refreshButton;
        private Button cancelButton;
        private TextBox sumTextBox;
        private TextBox categoryTextBox;
        private Button chooseCategoryButton;
        private Button clearCategoryButton;
        private ColumnHeader sumColumnHeader;
        private ColumnHeader categoryColumnHeader;
        private ColumnHeader descriptionColumnHeader;
        private Label currencyLabel;
        private TextBox currencyTextBox;
        private Label tagsLabel;
        private ListView tagsListView;
        private ColumnHeader tagsColumnHeader;
        private ColumnHeader mainSumColumnHeader;
        private Panel buttonsPanel;
        private Panel controlsPanel;
        private ErrorProvider sumErrorProvider;
    }
}