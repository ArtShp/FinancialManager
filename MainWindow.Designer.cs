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
            button1 = new Button();
            openDBDialog = new OpenFileDialog();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            DBStatus = new ToolStripStatusLabel();
            button3 = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 318);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Open DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(514, 266);
            button2.Name = "button2";
            button2.Size = new Size(274, 46);
            button2.TabIndex = 1;
            button2.Text = "Connect to DB";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // button3
            // 
            button3.Location = new Point(514, 318);
            button3.Name = "button3";
            button3.Size = new Size(274, 46);
            button3.TabIndex = 3;
            button3.Text = "Disconnect from DB";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainWindow";
            Text = "Financial Manager";
            Load += MainWindow_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openDBDialog;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel DBStatus;
        private Button button3;
    }
}
