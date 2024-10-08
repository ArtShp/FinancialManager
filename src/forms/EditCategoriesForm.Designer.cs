﻿namespace FinancialManager
{
    partial class EditCategoriesForm
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
            treeView = new TreeView();
            titleLabel = new Label();
            nameLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            nameTextBox = new TextBox();
            categoryLabel = new Label();
            categoryTextBox = new TextBox();
            loadButton = new Button();
            clearButton = new Button();
            controlsPanel = new Panel();
            buttonsPanel = new Panel();
            controlsPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.FullRowSelect = true;
            treeView.Location = new Point(459, 12);
            treeView.MinimumSize = new Size(360, 430);
            treeView.Name = "treeView";
            treeView.Size = new Size(560, 630);
            treeView.TabIndex = 0;
            treeView.AfterCollapse += treeView_AfterCollapse;
            treeView.BeforeExpand += treeView_BeforeExpand;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(268, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Categories";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 46);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 46);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(149, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 46);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(149, 55);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 46);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(295, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 46);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(295, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(140, 46);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 119);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(432, 39);
            nameTextBox.TabIndex = 9;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(3, 189);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(184, 32);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "Parent Category";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(3, 224);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(432, 39);
            categoryTextBox.TabIndex = 11;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(3, 269);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(101, 46);
            loadButton.TabIndex = 12;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(110, 269);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(101, 46);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(titleLabel);
            controlsPanel.Controls.Add(clearButton);
            controlsPanel.Controls.Add(nameLabel);
            controlsPanel.Controls.Add(loadButton);
            controlsPanel.Controls.Add(nameTextBox);
            controlsPanel.Controls.Add(categoryTextBox);
            controlsPanel.Controls.Add(categoryLabel);
            controlsPanel.Location = new Point(12, 12);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(441, 323);
            controlsPanel.TabIndex = 14;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Controls.Add(addButton);
            buttonsPanel.Controls.Add(refreshButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Location = new Point(12, 541);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(441, 107);
            buttonsPanel.TabIndex = 15;
            // 
            // EditCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 659);
            Controls.Add(buttonsPanel);
            Controls.Add(controlsPanel);
            Controls.Add(treeView);
            MinimumSize = new Size(860, 530);
            Name = "EditCategoriesForm";
            Text = "Edit Categories";
            Resize += EditCategoriesForm_Resize;
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Label titleLabel;
        private Label nameLabel;
        private Button addButton;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private Button cancelButton;
        private Button refreshButton;
        private TextBox nameTextBox;
        private Label categoryLabel;
        private TextBox categoryTextBox;
        private Button loadButton;
        private Button clearButton;
        private Panel controlsPanel;
        private Panel buttonsPanel;
    }
}