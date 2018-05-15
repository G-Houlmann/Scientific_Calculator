namespace Scientific_Calculator
{
    partial class frmSettings
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
            this.nudDecimalsAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDecimalsAmount = new System.Windows.Forms.Label();
            this.lblHistoryAmount = new System.Windows.Forms.Label();
            this.nudHistoryAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDecimalsAmount
            // 
            this.nudDecimalsAmount.Location = new System.Drawing.Point(15, 41);
            this.nudDecimalsAmount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDecimalsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDecimalsAmount.Name = "nudDecimalsAmount";
            this.nudDecimalsAmount.Size = new System.Drawing.Size(120, 20);
            this.nudDecimalsAmount.TabIndex = 0;
            this.nudDecimalsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDecimalsAmount.ValueChanged += new System.EventHandler(this.nudDecimalsAmount_ValueChanged);
            // 
            // lblDecimalsAmount
            // 
            this.lblDecimalsAmount.AutoSize = true;
            this.lblDecimalsAmount.Location = new System.Drawing.Point(12, 25);
            this.lblDecimalsAmount.Name = "lblDecimalsAmount";
            this.lblDecimalsAmount.Size = new System.Drawing.Size(170, 13);
            this.lblDecimalsAmount.TabIndex = 1;
            this.lblDecimalsAmount.Text = "Nombre de chiffres après la virgule";
            // 
            // lblHistoryAmount
            // 
            this.lblHistoryAmount.AutoSize = true;
            this.lblHistoryAmount.Location = new System.Drawing.Point(12, 104);
            this.lblHistoryAmount.Name = "lblHistoryAmount";
            this.lblHistoryAmount.Size = new System.Drawing.Size(219, 13);
            this.lblHistoryAmount.TabIndex = 3;
            this.lblHistoryAmount.Text = "Nombre d\'opérations visibles dans l\'historique";
            // 
            // nudHistoryAmount
            // 
            this.nudHistoryAmount.Location = new System.Drawing.Point(15, 120);
            this.nudHistoryAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHistoryAmount.Name = "nudHistoryAmount";
            this.nudHistoryAmount.Size = new System.Drawing.Size(120, 20);
            this.nudHistoryAmount.TabIndex = 2;
            this.nudHistoryAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHistoryAmount.ValueChanged += new System.EventHandler(this.nudHistoryAmount_ValueChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 182);
            this.Controls.Add(this.lblHistoryAmount);
            this.Controls.Add(this.nudHistoryAmount);
            this.Controls.Add(this.lblDecimalsAmount);
            this.Controls.Add(this.nudDecimalsAmount);
            this.Name = "frmSettings";
            this.Text = "Paramètres";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDecimalsAmount;
        private System.Windows.Forms.Label lblDecimalsAmount;
        private System.Windows.Forms.Label lblHistoryAmount;
        private System.Windows.Forms.NumericUpDown nudHistoryAmount;
    }
}