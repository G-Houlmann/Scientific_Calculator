namespace Scientific_Calculator
{
    partial class frmFunctionPlot
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.linYAxis = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linXAxis = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.RctGraphBorders = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.rtxtFunctionRules = new System.Windows.Forms.RichTextBox();
            this.cmdFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.linYAxis,
            this.linXAxis,
            this.RctGraphBorders});
            this.shapeContainer1.Size = new System.Drawing.Size(732, 414);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // linYAxis
            // 
            this.linYAxis.Name = "linYAxis";
            this.linYAxis.X1 = 200;
            this.linYAxis.X2 = 200;
            this.linYAxis.Y1 = 0;
            this.linYAxis.Y2 = 400;
            // 
            // linXAxis
            // 
            this.linXAxis.Name = "linXAxis";
            this.linXAxis.X1 = 0;
            this.linXAxis.X2 = 400;
            this.linXAxis.Y1 = 200;
            this.linXAxis.Y2 = 200;
            // 
            // RctGraphBorders
            // 
            this.RctGraphBorders.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.RctGraphBorders.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.RctGraphBorders.Location = new System.Drawing.Point(0, 0);
            this.RctGraphBorders.Name = "RctGraphBorders";
            this.RctGraphBorders.Size = new System.Drawing.Size(400, 400);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(453, 62);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(200, 20);
            this.txtFunction.TabIndex = 1;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(453, 43);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(54, 13);
            this.lblFunction.TabIndex = 2;
            this.lblFunction.Text = "Fonction :";
            // 
            // rtxtFunctionRules
            // 
            this.rtxtFunctionRules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxtFunctionRules.Location = new System.Drawing.Point(456, 89);
            this.rtxtFunctionRules.Name = "rtxtFunctionRules";
            this.rtxtFunctionRules.ReadOnly = true;
            this.rtxtFunctionRules.Size = new System.Drawing.Size(197, 231);
            this.rtxtFunctionRules.TabIndex = 3;
            this.rtxtFunctionRules.Text = "Comment écrire une fonction :";
            // 
            // cmdFunction
            // 
            this.cmdFunction.Location = new System.Drawing.Point(659, 59);
            this.cmdFunction.Name = "cmdFunction";
            this.cmdFunction.Size = new System.Drawing.Size(51, 23);
            this.cmdFunction.TabIndex = 4;
            this.cmdFunction.Text = "OK";
            this.cmdFunction.UseVisualStyleBackColor = true;
            this.cmdFunction.Click += new System.EventHandler(this.cmdFunction_Click);
            // 
            // frmFunctionPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 414);
            this.Controls.Add(this.cmdFunction);
            this.Controls.Add(this.rtxtFunctionRules);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmFunctionPlot";
            this.Text = "Affichage de graphe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RctGraphBorders;
        private Microsoft.VisualBasic.PowerPacks.LineShape linYAxis;
        private Microsoft.VisualBasic.PowerPacks.LineShape linXAxis;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.RichTextBox rtxtFunctionRules;
        private System.Windows.Forms.Button cmdFunction;
    }
}