namespace Scientific_Calculator
{
    partial class frmHistory
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
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblHistoryAmountTitle = new System.Windows.Forms.Label();
            this.lblHistoryAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(13, 13);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(646, 511);
            this.lstHistory.TabIndex = 0;
            // 
            // lblHistoryAmountTitle
            // 
            this.lblHistoryAmountTitle.AutoSize = true;
            this.lblHistoryAmountTitle.Location = new System.Drawing.Point(13, 531);
            this.lblHistoryAmountTitle.Name = "lblHistoryAmountTitle";
            this.lblHistoryAmountTitle.Size = new System.Drawing.Size(205, 13);
            this.lblHistoryAmountTitle.TabIndex = 1;
            this.lblHistoryAmountTitle.Text = "Nombre d\'opérations maximum affichées : ";
            // 
            // lblHistoryAmount
            // 
            this.lblHistoryAmount.AutoSize = true;
            this.lblHistoryAmount.Location = new System.Drawing.Point(225, 531);
            this.lblHistoryAmount.Name = "lblHistoryAmount";
            this.lblHistoryAmount.Size = new System.Drawing.Size(0, 13);
            this.lblHistoryAmount.TabIndex = 2;
            this.Text = "0";
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 556);
            this.Controls.Add(this.lblHistoryAmount);
            this.Controls.Add(this.lblHistoryAmountTitle);
            this.Controls.Add(this.lstHistory);
            this.Name = "frmHistory";
            this.Text = "Historique des opérations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label lblHistoryAmountTitle;
        private System.Windows.Forms.Label lblHistoryAmount;
    }
}