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
            currenciesListBox = new ListBox();
            SuspendLayout();
            // 
            // currenciesListBox
            // 
            currenciesListBox.FormattingEnabled = true;
            currenciesListBox.Location = new Point(505, 12);
            currenciesListBox.Name = "currenciesListBox";
            currenciesListBox.Size = new Size(657, 772);
            currenciesListBox.TabIndex = 0;
            // 
            // EditCurrenciesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 815);
            Controls.Add(currenciesListBox);
            Name = "EditCurrenciesForm";
            Text = "Edit Currencies";
            ResumeLayout(false);
        }

        #endregion

        private ListBox currenciesListBox;
    }
}