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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFunctionPlot));
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.rtxtFunctionRules = new System.Windows.Forms.RichTextBox();
            this.cmdFunction = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trbScaleY = new System.Windows.Forms.TrackBar();
            this.lblScaleY = new System.Windows.Forms.Label();
            this.lblScaleX = new System.Windows.Forms.Label();
            this.trbScaleX = new System.Windows.Forms.TrackBar();
            this.cmdReload = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.trbAccuracy = new System.Windows.Forms.TrackBar();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.linY = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linX = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rctGraphBorders = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblFx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFunction
            // 
            this.txtFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFunction.Location = new System.Drawing.Point(453, 95);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(200, 23);
            this.txtFunction.TabIndex = 1;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(453, 76);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(54, 13);
            this.lblFunction.TabIndex = 2;
            this.lblFunction.Text = "Fonction :";
            // 
            // rtxtFunctionRules
            // 
            this.rtxtFunctionRules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxtFunctionRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtxtFunctionRules.Location = new System.Drawing.Point(453, 169);
            this.rtxtFunctionRules.Name = "rtxtFunctionRules";
            this.rtxtFunctionRules.ReadOnly = true;
            this.rtxtFunctionRules.Size = new System.Drawing.Size(316, 173);
            this.rtxtFunctionRules.TabIndex = 3;
            this.rtxtFunctionRules.Text = resources.GetString("rtxtFunctionRules.Text");
            this.rtxtFunctionRules.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtFunctionRules_LinkClicked);
            // 
            // cmdFunction
            // 
            this.cmdFunction.Location = new System.Drawing.Point(659, 93);
            this.cmdFunction.Name = "cmdFunction";
            this.cmdFunction.Size = new System.Drawing.Size(51, 23);
            this.cmdFunction.TabIndex = 4;
            this.cmdFunction.Text = "OK";
            this.cmdFunction.UseVisualStyleBackColor = true;
            this.cmdFunction.Click += new System.EventHandler(this.cmdFunction_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trbScaleY
            // 
            this.trbScaleY.Location = new System.Drawing.Point(7, 491);
            this.trbScaleY.Maximum = 50;
            this.trbScaleY.Minimum = 1;
            this.trbScaleY.Name = "trbScaleY";
            this.trbScaleY.Size = new System.Drawing.Size(465, 45);
            this.trbScaleY.SmallChange = 2;
            this.trbScaleY.TabIndex = 7;
            this.trbScaleY.Value = 10;
            // 
            // lblScaleY
            // 
            this.lblScaleY.AutoSize = true;
            this.lblScaleY.Location = new System.Drawing.Point(4, 475);
            this.lblScaleY.Name = "lblScaleY";
            this.lblScaleY.Size = new System.Drawing.Size(52, 13);
            this.lblScaleY.TabIndex = 9;
            this.lblScaleY.Text = "Echelle Y";
            // 
            // lblScaleX
            // 
            this.lblScaleX.AutoSize = true;
            this.lblScaleX.Location = new System.Drawing.Point(4, 410);
            this.lblScaleX.Name = "lblScaleX";
            this.lblScaleX.Size = new System.Drawing.Size(52, 13);
            this.lblScaleX.TabIndex = 11;
            this.lblScaleX.Text = "Echelle X";
            // 
            // trbScaleX
            // 
            this.trbScaleX.Location = new System.Drawing.Point(7, 426);
            this.trbScaleX.Maximum = 50;
            this.trbScaleX.Minimum = 1;
            this.trbScaleX.Name = "trbScaleX";
            this.trbScaleX.Size = new System.Drawing.Size(465, 45);
            this.trbScaleX.SmallChange = 2;
            this.trbScaleX.TabIndex = 10;
            this.trbScaleX.Value = 10;
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(483, 435);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(141, 30);
            this.cmdReload.TabIndex = 12;
            this.cmdReload.Text = "Recharger";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdScale_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblLoading.Location = new System.Drawing.Point(450, 120);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(187, 17);
            this.lblLoading.TabIndex = 13;
            this.lblLoading.Text = "Graphe en cours de calcul...";
            this.lblLoading.Visible = false;
            // 
            // trbAccuracy
            // 
            this.trbAccuracy.Location = new System.Drawing.Point(483, 491);
            this.trbAccuracy.Maximum = 20;
            this.trbAccuracy.Minimum = 1;
            this.trbAccuracy.Name = "trbAccuracy";
            this.trbAccuracy.Size = new System.Drawing.Size(161, 45);
            this.trbAccuracy.TabIndex = 14;
            this.trbAccuracy.Value = 3;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(480, 475);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(140, 13);
            this.lblAccuracy.TabIndex = 15;
            this.lblAccuracy.Text = "Précision (nombre de points)";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.linY,
            this.linX,
            this.rctGraphBorders});
            this.shapeContainer1.Size = new System.Drawing.Size(804, 548);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // linY
            // 
            this.linY.Name = "linY";
            this.linY.X1 = 200;
            this.linY.X2 = 200;
            this.linY.Y1 = 0;
            this.linY.Y2 = 400;
            // 
            // linX
            // 
            this.linX.Name = "linX";
            this.linX.X1 = 0;
            this.linX.X2 = 400;
            this.linX.Y1 = 200;
            this.linX.Y2 = 200;
            // 
            // rctGraphBorders
            // 
            this.rctGraphBorders.BackColor = System.Drawing.Color.White;
            this.rctGraphBorders.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.rctGraphBorders.FillGradientColor = System.Drawing.SystemColors.ControlLightLight;
            this.rctGraphBorders.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctGraphBorders.Location = new System.Drawing.Point(0, 0);
            this.rctGraphBorders.Name = "rctGraphBorders";
            this.rctGraphBorders.Size = new System.Drawing.Size(400, 400);
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFx.Location = new System.Drawing.Point(411, 98);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(40, 17);
            this.lblFx.TabIndex = 17;
            this.lblFx.Text = "f(x) =";
            // 
            // frmFunctionPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 548);
            this.Controls.Add(this.lblFx);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.trbAccuracy);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.cmdReload);
            this.Controls.Add(this.lblScaleX);
            this.Controls.Add(this.trbScaleX);
            this.Controls.Add(this.lblScaleY);
            this.Controls.Add(this.trbScaleY);
            this.Controls.Add(this.cmdFunction);
            this.Controls.Add(this.rtxtFunctionRules);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmFunctionPlot";
            this.Text = "Affichage de graphe";
            this.Load += new System.EventHandler(this.frmFunctionPlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.RichTextBox rtxtFunctionRules;
        private System.Windows.Forms.Button cmdFunction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar trbScaleY;
        private System.Windows.Forms.Label lblScaleY;
        private System.Windows.Forms.Label lblScaleX;
        private System.Windows.Forms.TrackBar trbScaleX;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TrackBar trbAccuracy;
        private System.Windows.Forms.Label lblAccuracy;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctGraphBorders;
        private Microsoft.VisualBasic.PowerPacks.LineShape linY;
        private Microsoft.VisualBasic.PowerPacks.LineShape linX;
        private System.Windows.Forms.Label lblFx;
    }
}