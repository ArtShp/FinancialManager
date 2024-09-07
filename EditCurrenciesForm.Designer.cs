namespace FinancialManager
{
    partial class EditCurrenciesForm
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
            nameTextBox = new TextBox();
            nameLabel = new Label();
            codeLabel = new Label();
            codeTextBox = new TextBox();
            symbolLabel = new Label();
            symbolTextBox = new TextBox();
            addButton = new Button();
            refreshButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            cancelButton = new Button();
            listView = new ListView();
            nameColumnHeader = new ColumnHeader();
            codeColumnHeader = new ColumnHeader();
            symbolColumnHeader = new ColumnHeader();
            rateColumnHeader = new ColumnHeader();
            titleLabel = new Label();
            deleteButton = new Button();
            unitsRateLabel = new Label();
            unitsRateNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)unitsRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(47, 159);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(295, 39);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(47, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(47, 247);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(70, 32);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Code";
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(47, 282);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(295, 39);
            codeTextBox.TabIndex = 3;
            // 
            // symbolLabel
            // 
            symbolLabel.AutoSize = true;
            symbolLabel.Location = new Point(47, 382);
            symbolLabel.Name = "symbolLabel";
            symbolLabel.Size = new Size(93, 32);
            symbolLabel.TabIndex = 6;
            symbolLabel.Text = "Symbol";
            // 
            // symbolTextBox
            // 
            symbolTextBox.Location = new Point(47, 417);
            symbolTextBox.Name = "symbolTextBox";
            symbolTextBox.Size = new Size(295, 39);
            symbolTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(47, 738);
            addButton.Name = "addButton";
            addButton.Size = new Size(97, 46);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(344, 738);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(127, 46);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(47, 686);
            editButton.Name = "editButton";
            editButton.Size = new Size(97, 46);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(182, 686);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(130, 46);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(344, 686);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 46);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, codeColumnHeader, symbolColumnHeader, rateColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(505, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(657, 772);
            listView.TabIndex = 12;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 300;
            // 
            // codeColumnHeader
            // 
            codeColumnHeader.Text = "Code";
            codeColumnHeader.Width = 100;
            // 
            // symbolColumnHeader
            // 
            symbolColumnHeader.Text = "Symbol";
            symbolColumnHeader.Width = 120;
            // 
            // rateColumnHeader
            // 
            rateColumnHeader.Text = "Units rate";
            rateColumnHeader.Width = 120;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(47, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(264, 65);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Currencies";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(182, 738);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(129, 46);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // unitsRateLabel
            // 
            unitsRateLabel.AutoSize = true;
            unitsRateLabel.Location = new Point(47, 500);
            unitsRateLabel.Name = "unitsRateLabel";
            unitsRateLabel.Size = new Size(116, 32);
            unitsRateLabel.TabIndex = 15;
            unitsRateLabel.Text = "Units rate";
            // 
            // unitsRateNumericUpDown
            // 
            unitsRateNumericUpDown.Location = new Point(47, 535);
            unitsRateNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            unitsRateNumericUpDown.Name = "unitsRateNumericUpDown";
            unitsRateNumericUpDown.Size = new Size(295, 39);
            unitsRateNumericUpDown.TabIndex = 17;
            // 
            // EditCurrenciesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 815);
            Controls.Add(unitsRateNumericUpDown);
            Controls.Add(unitsRateLabel);
            Controls.Add(deleteButton);
            Controls.Add(titleLabel);
            Controls.Add(listView);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(refreshButton);
            Controls.Add(addButton);
            Controls.Add(symbolLabel);
            Controls.Add(symbolTextBox);
            Controls.Add(codeLabel);
            Controls.Add(codeTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Name = "EditCurrenciesForm";
            Text = "Edit Currencies";
            ((System.ComponentModel.ISupportInitialize)unitsRateNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label codeLabel;
        private TextBox codeTextBox;
        private Label symbolLabel;
        private TextBox symbolTextBox;
        private Button addButton;
        private Button refreshButton;
        private Button editButton;
        private Button saveButton;
        private Button cancelButton;
        private ListView listView;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader codeColumnHeader;
        private ColumnHeader symbolColumnHeader;
        private Label titleLabel;
        private Button deleteButton;
        private ColumnHeader rateColumnHeader;
        private Label unitsRateLabel;
        private NumericUpDown unitsRateNumericUpDown;
    }
}