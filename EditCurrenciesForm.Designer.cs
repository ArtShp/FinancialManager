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
            buttonsPanel = new Panel();
            controlsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)unitsRateNumericUpDown).BeginInit();
            buttonsPanel.SuspendLayout();
            controlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 121);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(360, 39);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 86);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(3, 182);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(70, 32);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Code";
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(3, 217);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(360, 39);
            codeTextBox.TabIndex = 3;
            // 
            // symbolLabel
            // 
            symbolLabel.AutoSize = true;
            symbolLabel.Location = new Point(3, 286);
            symbolLabel.Name = "symbolLabel";
            symbolLabel.Size = new Size(93, 32);
            symbolLabel.TabIndex = 6;
            symbolLabel.Text = "Symbol";
            // 
            // symbolTextBox
            // 
            symbolTextBox.Location = new Point(3, 321);
            symbolTextBox.Name = "symbolTextBox";
            symbolTextBox.Size = new Size(360, 39);
            symbolTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(116, 46);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(247, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(116, 46);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(116, 46);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(125, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(116, 46);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(247, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 46);
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
            listView.Location = new Point(386, 12);
            listView.MinimumSize = new Size(435, 580);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(635, 680);
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
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(264, 65);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Currencies";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(125, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(116, 46);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // unitsRateLabel
            // 
            unitsRateLabel.AutoSize = true;
            unitsRateLabel.Location = new Point(3, 391);
            unitsRateLabel.Name = "unitsRateLabel";
            unitsRateLabel.Size = new Size(116, 32);
            unitsRateLabel.TabIndex = 15;
            unitsRateLabel.Text = "Units rate";
            // 
            // unitsRateNumericUpDown
            // 
            unitsRateNumericUpDown.Location = new Point(3, 426);
            unitsRateNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            unitsRateNumericUpDown.Name = "unitsRateNumericUpDown";
            unitsRateNumericUpDown.Size = new Size(360, 39);
            unitsRateNumericUpDown.TabIndex = 17;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Location = new Point(12, 591);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(368, 107);
            buttonsPanel.TabIndex = 19;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(nameTextBox);
            controlsPanel.Controls.Add(unitsRateNumericUpDown);
            controlsPanel.Controls.Add(nameLabel);
            controlsPanel.Controls.Add(unitsRateLabel);
            controlsPanel.Controls.Add(codeTextBox);
            controlsPanel.Controls.Add(codeLabel);
            controlsPanel.Controls.Add(symbolTextBox);
            controlsPanel.Controls.Add(symbolLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(368, 473);
            controlsPanel.TabIndex = 20;
            // 
            // EditCurrenciesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 709);
            Controls.Add(controlsPanel);
            Controls.Add(buttonsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(860, 680);
            Name = "EditCurrenciesForm";
            Text = "Edit Currencies";
            ResizeEnd += EditCurrenciesForm_ResizeEnd;
            Resize += EditCurrenciesForm_Resize;
            ((System.ComponentModel.ISupportInitialize)unitsRateNumericUpDown).EndInit();
            buttonsPanel.ResumeLayout(false);
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            ResumeLayout(false);
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
        private Panel buttonsPanel;
        private Panel controlsPanel;
    }
}