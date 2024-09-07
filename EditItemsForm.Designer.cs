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
            titleLabel = new Label();
            listView = new ListView();
            categoryColumnHeader = new ColumnHeader();
            sumColumnHeader = new ColumnHeader();
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
            mainSumColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(31, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(251, 65);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Items";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { categoryColumnHeader, sumColumnHeader, mainSumColumnHeader, tagsColumnHeader, descriptionColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(643, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(615, 908);
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
            sumLabel.Location = new Point(31, 101);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(62, 32);
            sumLabel.TabIndex = 2;
            sumLabel.Text = "Sum";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(30, 290);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(30, 653);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(135, 32);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(31, 688);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(446, 102);
            descriptionRichTextBox.TabIndex = 7;
            descriptionRichTextBox.Text = "";
            // 
            // addButton
            // 
            addButton.Location = new Point(31, 874);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(31, 822);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(245, 874);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(245, 822);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(461, 874);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(461, 822);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // sumTextBox
            // 
            sumTextBox.Location = new Point(31, 136);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(446, 39);
            sumTextBox.TabIndex = 14;
            sumTextBox.Text = "0";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(30, 325);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(446, 39);
            categoryTextBox.TabIndex = 15;
            // 
            // chooseCategoryButton
            // 
            chooseCategoryButton.Location = new Point(30, 370);
            chooseCategoryButton.Name = "chooseCategoryButton";
            chooseCategoryButton.Size = new Size(110, 46);
            chooseCategoryButton.TabIndex = 16;
            chooseCategoryButton.Text = "Choose";
            chooseCategoryButton.UseVisualStyleBackColor = true;
            chooseCategoryButton.Click += chooseCategoryButton_Click;
            // 
            // clearCategoryButton
            // 
            clearCategoryButton.Location = new Point(146, 370);
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
            currencyLabel.Location = new Point(31, 178);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(109, 32);
            currencyLabel.TabIndex = 18;
            currencyLabel.Text = "Currency";
            // 
            // currencyTextBox
            // 
            currencyTextBox.Location = new Point(31, 213);
            currencyTextBox.Name = "currencyTextBox";
            currencyTextBox.ReadOnly = true;
            currencyTextBox.Size = new Size(446, 39);
            currencyTextBox.TabIndex = 19;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new Point(30, 443);
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
            tagsListView.Location = new Point(31, 478);
            tagsListView.MultiSelect = false;
            tagsListView.Name = "tagsListView";
            tagsListView.Size = new Size(446, 157);
            tagsListView.TabIndex = 21;
            tagsListView.UseCompatibleStateImageBehavior = false;
            tagsListView.View = View.List;
            // 
            // mainSumColumnHeader
            // 
            mainSumColumnHeader.Text = "Sum (Main)";
            mainSumColumnHeader.Width = 100;
            // 
            // EditItemsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 950);
            Controls.Add(tagsListView);
            Controls.Add(tagsLabel);
            Controls.Add(currencyTextBox);
            Controls.Add(currencyLabel);
            Controls.Add(clearCategoryButton);
            Controls.Add(chooseCategoryButton);
            Controls.Add(categoryTextBox);
            Controls.Add(sumTextBox);
            Controls.Add(cancelButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(categoryLabel);
            Controls.Add(sumLabel);
            Controls.Add(listView);
            Controls.Add(titleLabel);
            Name = "EditItemsForm";
            Text = "EditItemsForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}