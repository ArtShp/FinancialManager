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
            mainWindowTabControl = new TabControl();
            startTabPage = new TabPage();
            fillDBTabPage = new TabPage();
            editCurrenciesButton = new Button();
            statusStrip1.SuspendLayout();
            mainWindowTabControl.SuspendLayout();
            startTabPage.SuspendLayout();
            fillDBTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // openDBButton
            // 
            openDBButton.Location = new Point(6, 687);
            openDBButton.Name = "openDBButton";
            openDBButton.Size = new Size(150, 46);
            openDBButton.TabIndex = 0;
            openDBButton.Text = "Open DB";
            openDBButton.UseVisualStyleBackColor = true;
            openDBButton.Click += openDBButton_Click;
            // 
            // connectToDBButton
            // 
            connectToDBButton.Location = new Point(1208, 635);
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
            statusStrip1.Location = new Point(0, 810);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1504, 22);
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
            disconnectFromDBButton.Location = new Point(1208, 687);
            disconnectFromDBButton.Name = "disconnectFromDBButton";
            disconnectFromDBButton.Size = new Size(274, 46);
            disconnectFromDBButton.TabIndex = 3;
            disconnectFromDBButton.Text = "Disconnect from DB";
            disconnectFromDBButton.UseVisualStyleBackColor = true;
            disconnectFromDBButton.Click += disconnectFromDBButton_Click;
            // 
            // createDBButton
            // 
            createDBButton.Location = new Point(6, 635);
            createDBButton.Name = "createDBButton";
            createDBButton.Size = new Size(150, 46);
            createDBButton.TabIndex = 4;
            createDBButton.Text = "Create DB";
            createDBButton.UseVisualStyleBackColor = true;
            createDBButton.Click += createDBButton_Click;
            // 
            // mainWindowTabControl
            // 
            mainWindowTabControl.Controls.Add(startTabPage);
            mainWindowTabControl.Controls.Add(fillDBTabPage);
            mainWindowTabControl.Dock = DockStyle.Fill;
            mainWindowTabControl.Location = new Point(0, 0);
            mainWindowTabControl.Name = "mainWindowTabControl";
            mainWindowTabControl.SelectedIndex = 0;
            mainWindowTabControl.Size = new Size(1504, 810);
            mainWindowTabControl.TabIndex = 5;
            // 
            // startTabPage
            // 
            startTabPage.Controls.Add(createDBButton);
            startTabPage.Controls.Add(openDBButton);
            startTabPage.Controls.Add(disconnectFromDBButton);
            startTabPage.Controls.Add(connectToDBButton);
            startTabPage.Location = new Point(8, 46);
            startTabPage.Name = "startTabPage";
            startTabPage.Padding = new Padding(3);
            startTabPage.Size = new Size(1488, 756);
            startTabPage.TabIndex = 0;
            startTabPage.Text = "Start";
            startTabPage.UseVisualStyleBackColor = true;
            // 
            // fillDBTabPage
            // 
            fillDBTabPage.Controls.Add(editCurrenciesButton);
            fillDBTabPage.Location = new Point(8, 46);
            fillDBTabPage.Name = "fillDBTabPage";
            fillDBTabPage.Padding = new Padding(3);
            fillDBTabPage.Size = new Size(1488, 756);
            fillDBTabPage.TabIndex = 1;
            fillDBTabPage.Text = "Fill Data";
            fillDBTabPage.UseVisualStyleBackColor = true;
            // 
            // editCurrenciesButton
            // 
            editCurrenciesButton.Location = new Point(1211, 6);
            editCurrenciesButton.Name = "editCurrenciesButton";
            editCurrenciesButton.Size = new Size(271, 46);
            editCurrenciesButton.TabIndex = 0;
            editCurrenciesButton.Text = "Edit Currencies";
            editCurrenciesButton.UseVisualStyleBackColor = true;
            editCurrenciesButton.Click += editCurrenciesButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 832);
            Controls.Add(mainWindowTabControl);
            Controls.Add(statusStrip1);
            Name = "MainWindow";
            Text = "Financial Manager";
            Load += MainWindow_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainWindowTabControl.ResumeLayout(false);
            startTabPage.ResumeLayout(false);
            fillDBTabPage.ResumeLayout(false);
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
        private TabControl mainWindowTabControl;
        private TabPage startTabPage;
        private TabPage fillDBTabPage;
        private Button editCurrenciesButton;
    }
}
