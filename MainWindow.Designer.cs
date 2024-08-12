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
            statusStrip1 = new StatusStrip();
            DBStatus = new ToolStripStatusLabel();
            disconnectFromDBButton = new Button();
            createDBButton = new Button();
            createDBDialog = new SaveFileDialog();
            statusStrip1.SuspendLayout();
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { DBStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // DBStatus
            // 
            DBStatus.Name = "DBStatus";
            DBStatus.Size = new Size(0, 12);
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
            Controls.Add(statusStrip1);
            Controls.Add(connectToDBButton);
            Controls.Add(openDBButton);
            Name = "MainWindow";
            Text = "Financial Manager";
            Load += MainWindow_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openDBButton;
        private OpenFileDialog openDBDialog;
        private Button connectToDBButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel DBStatus;
        private Button disconnectFromDBButton;
        private Button createDBButton;
        private SaveFileDialog createDBDialog;
    }
}
