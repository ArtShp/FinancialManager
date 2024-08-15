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
            titleLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            nameColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(460, 831);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 46);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(249, 831);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(460, 779);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(32, 779);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(249, 779);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(32, 831);
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
            listView.Location = new Point(667, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(469, 865);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(32, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(470, 65);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Places Of Purchases";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(32, 177);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(204, 32);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Place Of Purchase";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(32, 226);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(488, 39);
            nameTextBox.TabIndex = 9;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 120;
            // 
            // EditPlacesOfPurchasesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 906);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Controls.Add(listView);
            Controls.Add(addButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(refreshButton);
            Name = "EditPlacesOfPurchasesForm";
            Text = "EditPlacesOfPurchasesForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}