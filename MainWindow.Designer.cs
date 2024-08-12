namespace FinancialManager
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openDBButton = new Button();
            openDBDialog = new OpenFileDialog();
            connectToDBButton = new Button();
            dbStatusStrip = new StatusStrip();
            DBStatus = new ToolStripStatusLabel();
            disconnectFromDBButton = new Button();
            createDBButton = new Button();
            createDBDialog = new SaveFileDialog();
            dbStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // openDBButton
            // 
            openDBButton.Location = new Point(12, 318);
            openDBButton.Name = "openDBButton";
            openDBButton.Size = new Size(150, 46);
            openDBButton.TabIndex = 0;
            openDBButton.Text = "Open DB";
            openDBButton.UseVisualStyleBackColor = true;
            openDBButton.Click += openDBButton_Click;
            // 
            // connectToDBButton
            // 
            connectToDBButton.Location = new Point(514, 266);
            connectToDBButton.Name = "connectToDBButton";
            connectToDBButton.Size = new Size(274, 46);
            connectToDBButton.TabIndex = 1;
            connectToDBButton.Text = "Connect to DB";
            connectToDBButton.UseVisualStyleBackColor = true;
            connectToDBButton.Click += connectToDBButton_Click;
            // 
            // dbStatusStrip
            // 
            dbStatusStrip.ImageScalingSize = new Size(32, 32);
            dbStatusStrip.Items.AddRange(new ToolStripItem[] { DBStatus });
            dbStatusStrip.Location = new Point(0, 412);
            dbStatusStrip.Name = "dbStatusStrip";
            dbStatusStrip.Size = new Size(800, 38);
            dbStatusStrip.TabIndex = 2;
            // 
            // DBStatus
            // 
            DBStatus.Name = "DBStatus";
            DBStatus.Size = new Size(0, 28);
            // 
            // disconnectFromDBButton
            // 
            disconnectFromDBButton.Location = new Point(514, 318);
            disconnectFromDBButton.Name = "disconnectFromDBButton";
            disconnectFromDBButton.Size = new Size(274, 46);
            disconnectFromDBButton.TabIndex = 3;
            disconnectFromDBButton.Text = "Disconnect from DB";
            disconnectFromDBButton.UseVisualStyleBackColor = true;
            disconnectFromDBButton.Click += disconnectFromDBButton_Click;
            // 
            // createDBButton
            // 
            createDBButton.Location = new Point(12, 266);
            createDBButton.Name = "createDBButton";
            createDBButton.Size = new Size(150, 46);
            createDBButton.TabIndex = 4;
            createDBButton.Text = "Create DB";
            createDBButton.UseVisualStyleBackColor = true;
            createDBButton.Click += createDBButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createDBButton);
            Controls.Add(disconnectFromDBButton);
            Controls.Add(dbStatusStrip);
            Controls.Add(connectToDBButton);
            Controls.Add(openDBButton);
            Name = "MainWindow";
            Text = "Financial Manager";
            Load += MainWindow_Load;
            dbStatusStrip.ResumeLayout(false);
            dbStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openDBButton;
        private OpenFileDialog openDBDialog;
        private Button connectToDBButton;
        private StatusStrip dbStatusStrip;
        private ToolStripStatusLabel DBStatus;
        private Button disconnectFromDBButton;
        private Button createDBButton;
        private SaveFileDialog createDBDialog;
    }
}
