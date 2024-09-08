namespace FinancialManager
{
    partial class EditPlacesOfPurchasesForm
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
            refreshButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            addButton = new Button();
            listView = new ListView();
            nameColumnHeader = new ColumnHeader();
            titleLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(345, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(175, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(345, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(175, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(516, 12);
            listView.MinimumSize = new Size(400, 290);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(600, 490);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 120;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(470, 65);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Places Of Purchases";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 125);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(488, 39);
            nameTextBox.TabIndex = 9;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(nameTextBox);
            controlsPanel.Controls.Add(nameLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(498, 173);
            controlsPanel.TabIndex = 10;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Location = new Point(12, 401);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(498, 109);
            buttonsPanel.TabIndex = 11;
            // 
            // EditPlacesOfPurchasesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 519);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(listView);
            MinimumSize = new Size(960, 390);
            Name = "EditPlacesOfPurchasesForm";
            Text = "Edit Places Of Purchases";
            ResizeEnd += EditPlacesOfPurchasesForm_ResizeEnd;
            Resize += EditPlacesOfPurchasesForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button refreshButton;
        private Button deleteButton;
        private Button cancelButton;
        private Button editButton;
        private Button saveButton;
        private Button addButton;
        private ListView listView;
        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private ColumnHeader nameColumnHeader;
        private Panel controlsPanel;
        private Panel buttonsPanel;
    }
}