namespace Scientific_Calculator
{
    partial class frmCalculator
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
            this.cmdGraphDisplayer = new System.Windows.Forms.Button();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.cmdHistory = new System.Windows.Forms.Button();
            this.cmdExponential = new System.Windows.Forms.Button();
            this.cmdSin = new System.Windows.Forms.Button();
            this.cmdCos = new System.Windows.Forms.Button();
            this.cmdReciprocal = new System.Windows.Forms.Button();
            this.cmdLog = new System.Windows.Forms.Button();
            this.cmdNA = new System.Windows.Forms.Button();
            this.cmdTan = new System.Windows.Forms.Button();
            this.cmdPi = new System.Windows.Forms.Button();
            this.cmdExponentiation = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdRoot = new System.Windows.Forms.Button();
            this.cmdMult = new System.Windows.Forms.Button();
            this.cmdInvSin = new System.Windows.Forms.Button();
            this.cmdMinus = new System.Windows.Forms.Button();
            this.cmdInvCos = new System.Windows.Forms.Button();
            this.cmdPlus = new System.Windows.Forms.Button();
            this.cmdInvTan = new System.Windows.Forms.Button();
            this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.cmdSquare = new System.Windows.Forms.Button();
            this.cmdInvert = new System.Windows.Forms.Button();
            this.cmdSqrt = new System.Windows.Forms.Button();
            this.cmdComma = new System.Windows.Forms.Button();
            this.cmdAbsValue = new System.Windows.Forms.Button();
            this.cmdZero = new System.Windows.Forms.Button();
            this.cmdFactorial = new System.Windows.Forms.Button();
            this.cmdThree = new System.Windows.Forms.Button();
            this.cmdLn = new System.Windows.Forms.Button();
            this.cmdTwo = new System.Windows.Forms.Button();
            this.cmdConvDecBin = new System.Windows.Forms.Button();
            this.cmdOne = new System.Windows.Forms.Button();
            this.cmdConvDecOct = new System.Windows.Forms.Button();
            this.cmdSix = new System.Windows.Forms.Button();
            this.cmdConvDecHex = new System.Windows.Forms.Button();
            this.cmdFive = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdFour = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdNine = new System.Windows.Forms.Button();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.cmdEight = new System.Windows.Forms.Button();
            this.cmdRound = new System.Windows.Forms.Button();
            this.cmdSeven = new System.Windows.Forms.Button();
            this.cmdLightSpeed = new System.Windows.Forms.Button();
            this.cmdCloseParenthesis = new System.Windows.Forms.Button();
            this.cmdOpenParenthesis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGraphDisplayer
            // 
            this.cmdGraphDisplayer.Location = new System.Drawing.Point(20, 397);
            this.cmdGraphDisplayer.Name = "cmdGraphDisplayer";
            this.cmdGraphDisplayer.Size = new System.Drawing.Size(116, 50);
            this.cmdGraphDisplayer.TabIndex = 49;
            this.cmdGraphDisplayer.Text = "Ouvrir l\'afficheur de graphe";
            this.cmdGraphDisplayer.UseVisualStyleBackColor = true;
            this.cmdGraphDisplayer.Click += new System.EventHandler(this.cmdGraphDisplayer_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.Location = new System.Drawing.Point(142, 397);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(116, 50);
            this.cmdSettings.TabIndex = 51;
            this.cmdSettings.Text = "Ouvrir les paramètres";
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // cmdHistory
            // 
            this.cmdHistory.Location = new System.Drawing.Point(264, 397);
            this.cmdHistory.Name = "cmdHistory";
            this.cmdHistory.Size = new System.Drawing.Size(116, 50);
            this.cmdHistory.TabIndex = 52;
            this.cmdHistory.Text = "Ouvrir l\'historique des opérations";
            this.cmdHistory.UseVisualStyleBackColor = true;
            this.cmdHistory.Click += new System.EventHandler(this.cmdHistory_Click);
            // 
            // cmdExponential
            // 
            this.cmdExponential.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdExponential.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdExponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdExponential.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdExponential.Location = new System.Drawing.Point(296, 305);
            this.cmdExponential.Name = "cmdExponential";
            this.cmdExponential.Size = new System.Drawing.Size(35, 35);
            this.cmdExponential.TabIndex = 24;
            this.cmdExponential.Text = "e^x";
            this.cmdExponential.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdExponential.UseVisualStyleBackColor = false;
            this.cmdExponential.Click += new System.EventHandler(this.cmdExponential_Click);
            // 
            // cmdSin
            // 
            this.cmdSin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.cmdSin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSin.Location = new System.Drawing.Point(32, 141);
            this.cmdSin.Name = "cmdSin";
            this.cmdSin.Size = new System.Drawing.Size(53, 35);
            this.cmdSin.TabIndex = 23;
            this.cmdSin.Text = "Sin";
            this.cmdSin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdSin.UseVisualStyleBackColor = false;
            this.cmdSin.Click += new System.EventHandler(this.cmdSin_Click);
            // 
            // cmdCos
            // 
            this.cmdCos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.cmdCos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCos.Location = new System.Drawing.Point(91, 141);
            this.cmdCos.Name = "cmdCos";
            this.cmdCos.Size = new System.Drawing.Size(53, 35);
            this.cmdCos.TabIndex = 25;
            this.cmdCos.Text = "Cos";
            this.cmdCos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdCos.UseVisualStyleBackColor = false;
            this.cmdCos.Click += new System.EventHandler(this.cmdCos_Click);
            // 
            // cmdReciprocal
            // 
            this.cmdReciprocal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdReciprocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdReciprocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdReciprocal.Location = new System.Drawing.Point(296, 224);
            this.cmdReciprocal.Name = "cmdReciprocal";
            this.cmdReciprocal.Size = new System.Drawing.Size(35, 35);
            this.cmdReciprocal.TabIndex = 22;
            this.cmdReciprocal.Text = "1/x";
            this.cmdReciprocal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdReciprocal.UseVisualStyleBackColor = false;
            this.cmdReciprocal.Click += new System.EventHandler(this.cmdReciprocal_Click);
            // 
            // cmdLog
            // 
            this.cmdLog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmdLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdLog.Location = new System.Drawing.Point(196, 223);
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(53, 35);
            this.cmdLog.TabIndex = 26;
            this.cmdLog.Text = "log(x)";
            this.cmdLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdLog.UseVisualStyleBackColor = false;
            this.cmdLog.Click += new System.EventHandler(this.cmdLog_Click);
            // 
            // cmdNA
            // 
            this.cmdNA.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNA.Location = new System.Drawing.Point(296, 346);
            this.cmdNA.Name = "cmdNA";
            this.cmdNA.Size = new System.Drawing.Size(35, 35);
            this.cmdNA.TabIndex = 19;
            this.cmdNA.Text = "Na";
            this.cmdNA.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdNA.UseVisualStyleBackColor = false;
            this.cmdNA.Click += new System.EventHandler(this.cmdNA_Click);
            // 
            // cmdTan
            // 
            this.cmdTan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdTan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.cmdTan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdTan.Location = new System.Drawing.Point(150, 141);
            this.cmdTan.Name = "cmdTan";
            this.cmdTan.Size = new System.Drawing.Size(53, 35);
            this.cmdTan.TabIndex = 27;
            this.cmdTan.Text = "Tan";
            this.cmdTan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdTan.UseVisualStyleBackColor = false;
            this.cmdTan.Click += new System.EventHandler(this.cmdTan_Click);
            // 
            // cmdPi
            // 
            this.cmdPi.BackColor = System.Drawing.SystemColors.Info;
            this.cmdPi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPi.Location = new System.Drawing.Point(255, 346);
            this.cmdPi.Name = "cmdPi";
            this.cmdPi.Size = new System.Drawing.Size(35, 35);
            this.cmdPi.TabIndex = 17;
            this.cmdPi.Text = "π";
            this.cmdPi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdPi.UseVisualStyleBackColor = false;
            this.cmdPi.Click += new System.EventHandler(this.cmdPi_Click);
            // 
            // cmdExponentiation
            // 
            this.cmdExponentiation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdExponentiation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdExponentiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdExponentiation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdExponentiation.Location = new System.Drawing.Point(296, 264);
            this.cmdExponentiation.Name = "cmdExponentiation";
            this.cmdExponentiation.Size = new System.Drawing.Size(35, 35);
            this.cmdExponentiation.TabIndex = 29;
            this.cmdExponentiation.Text = "x^y";
            this.cmdExponentiation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdExponentiation.UseVisualStyleBackColor = false;
            this.cmdExponentiation.Click += new System.EventHandler(this.cmdExponentiation_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDiv.Location = new System.Drawing.Point(32, 346);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(35, 35);
            this.cmdDiv.TabIndex = 16;
            this.cmdDiv.Text = "/";
            this.cmdDiv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdDiv.UseVisualStyleBackColor = false;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // cmdRoot
            // 
            this.cmdRoot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdRoot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRoot.Location = new System.Drawing.Point(337, 264);
            this.cmdRoot.Name = "cmdRoot";
            this.cmdRoot.Size = new System.Drawing.Size(35, 35);
            this.cmdRoot.TabIndex = 31;
            this.cmdRoot.Text = "x√y";
            this.cmdRoot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdRoot.UseVisualStyleBackColor = false;
            this.cmdRoot.Click += new System.EventHandler(this.cmdRoot_Click);
            // 
            // cmdMult
            // 
            this.cmdMult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmdMult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdMult.Location = new System.Drawing.Point(32, 305);
            this.cmdMult.Name = "cmdMult";
            this.cmdMult.Size = new System.Drawing.Size(35, 35);
            this.cmdMult.TabIndex = 15;
            this.cmdMult.Text = "X";
            this.cmdMult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdMult.UseVisualStyleBackColor = false;
            this.cmdMult.Click += new System.EventHandler(this.cmdMult_Click);
            // 
            // cmdInvSin
            // 
            this.cmdInvSin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdInvSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdInvSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cmdInvSin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdInvSin.Location = new System.Drawing.Point(32, 182);
            this.cmdInvSin.Name = "cmdInvSin";
            this.cmdInvSin.Size = new System.Drawing.Size(53, 35);
            this.cmdInvSin.TabIndex = 34;
            this.cmdInvSin.Text = "Sin^−1";
            this.cmdInvSin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdInvSin.UseVisualStyleBackColor = false;
            this.cmdInvSin.Click += new System.EventHandler(this.cmdInvSin_Click);
            // 
            // cmdMinus
            // 
            this.cmdMinus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdMinus.Location = new System.Drawing.Point(32, 264);
            this.cmdMinus.Name = "cmdMinus";
            this.cmdMinus.Size = new System.Drawing.Size(35, 35);
            this.cmdMinus.TabIndex = 14;
            this.cmdMinus.Text = "-";
            this.cmdMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdMinus.UseVisualStyleBackColor = false;
            this.cmdMinus.Click += new System.EventHandler(this.cmdMinus_Click);
            // 
            // cmdInvCos
            // 
            this.cmdInvCos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdInvCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdInvCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cmdInvCos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdInvCos.Location = new System.Drawing.Point(91, 182);
            this.cmdInvCos.Name = "cmdInvCos";
            this.cmdInvCos.Size = new System.Drawing.Size(53, 35);
            this.cmdInvCos.TabIndex = 35;
            this.cmdInvCos.Text = "Cos^-1";
            this.cmdInvCos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdInvCos.UseVisualStyleBackColor = false;
            this.cmdInvCos.Click += new System.EventHandler(this.cmdInvCos_Click);
            // 
            // cmdPlus
            // 
            this.cmdPlus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdPlus.Location = new System.Drawing.Point(32, 223);
            this.cmdPlus.Name = "cmdPlus";
            this.cmdPlus.Size = new System.Drawing.Size(35, 35);
            this.cmdPlus.TabIndex = 13;
            this.cmdPlus.Text = "+";
            this.cmdPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdPlus.UseVisualStyleBackColor = false;
            this.cmdPlus.Click += new System.EventHandler(this.cmdPlus_Click);
            // 
            // cmdInvTan
            // 
            this.cmdInvTan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdInvTan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdInvTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cmdInvTan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdInvTan.Location = new System.Drawing.Point(150, 182);
            this.cmdInvTan.Name = "cmdInvTan";
            this.cmdInvTan.Size = new System.Drawing.Size(53, 35);
            this.cmdInvTan.TabIndex = 36;
            this.cmdInvTan.Text = "Tan^-1";
            this.cmdInvTan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdInvTan.UseVisualStyleBackColor = false;
            this.cmdInvTan.Click += new System.EventHandler(this.cmdInvTan_Click);
            // 
            // rtxtDisplay
            // 
            this.rtxtDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtDisplay.Location = new System.Drawing.Point(12, 30);
            this.rtxtDisplay.Name = "rtxtDisplay";
            this.rtxtDisplay.ReadOnly = true;
            this.rtxtDisplay.Size = new System.Drawing.Size(419, 66);
            this.rtxtDisplay.TabIndex = 12;
            this.rtxtDisplay.Text = "";
            // 
            // cmdSquare
            // 
            this.cmdSquare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSquare.Location = new System.Drawing.Point(255, 224);
            this.cmdSquare.Name = "cmdSquare";
            this.cmdSquare.Size = new System.Drawing.Size(35, 35);
            this.cmdSquare.TabIndex = 37;
            this.cmdSquare.Text = "x^2";
            this.cmdSquare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdSquare.UseVisualStyleBackColor = false;
            this.cmdSquare.Click += new System.EventHandler(this.cmdSquare_Click);
            // 
            // cmdInvert
            // 
            this.cmdInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdInvert.Location = new System.Drawing.Point(155, 346);
            this.cmdInvert.Name = "cmdInvert";
            this.cmdInvert.Size = new System.Drawing.Size(35, 35);
            this.cmdInvert.TabIndex = 11;
            this.cmdInvert.Text = "+/-";
            this.cmdInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdInvert.UseVisualStyleBackColor = true;
            this.cmdInvert.Click += new System.EventHandler(this.cmdInvert_Click);
            // 
            // cmdSqrt
            // 
            this.cmdSqrt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdSqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdSqrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSqrt.Location = new System.Drawing.Point(255, 264);
            this.cmdSqrt.Name = "cmdSqrt";
            this.cmdSqrt.Size = new System.Drawing.Size(35, 35);
            this.cmdSqrt.TabIndex = 38;
            this.cmdSqrt.Text = "2√x";
            this.cmdSqrt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdSqrt.UseVisualStyleBackColor = false;
            this.cmdSqrt.Click += new System.EventHandler(this.cmdSqrt_Click);
            // 
            // cmdComma
            // 
            this.cmdComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdComma.Location = new System.Drawing.Point(114, 346);
            this.cmdComma.Name = "cmdComma";
            this.cmdComma.Size = new System.Drawing.Size(35, 35);
            this.cmdComma.TabIndex = 10;
            this.cmdComma.Text = ",";
            this.cmdComma.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdComma.UseVisualStyleBackColor = true;
            this.cmdComma.Click += new System.EventHandler(this.cmdComma_Click);
            // 
            // cmdAbsValue
            // 
            this.cmdAbsValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdAbsValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAbsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdAbsValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAbsValue.Location = new System.Drawing.Point(255, 305);
            this.cmdAbsValue.Name = "cmdAbsValue";
            this.cmdAbsValue.Size = new System.Drawing.Size(35, 35);
            this.cmdAbsValue.TabIndex = 39;
            this.cmdAbsValue.Text = "|x|";
            this.cmdAbsValue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdAbsValue.UseVisualStyleBackColor = false;
            this.cmdAbsValue.Click += new System.EventHandler(this.cmdAbsValue_Click);
            // 
            // cmdZero
            // 
            this.cmdZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdZero.Location = new System.Drawing.Point(73, 346);
            this.cmdZero.Name = "cmdZero";
            this.cmdZero.Size = new System.Drawing.Size(35, 35);
            this.cmdZero.TabIndex = 9;
            this.cmdZero.Text = "0";
            this.cmdZero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdZero.UseVisualStyleBackColor = true;
            this.cmdZero.Click += new System.EventHandler(this.cmdZero_Click);
            // 
            // cmdFactorial
            // 
            this.cmdFactorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdFactorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdFactorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdFactorial.Location = new System.Drawing.Point(337, 224);
            this.cmdFactorial.Name = "cmdFactorial";
            this.cmdFactorial.Size = new System.Drawing.Size(35, 35);
            this.cmdFactorial.TabIndex = 40;
            this.cmdFactorial.Text = "x!";
            this.cmdFactorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdFactorial.UseVisualStyleBackColor = false;
            this.cmdFactorial.Click += new System.EventHandler(this.cmdFactorial_Click);
            // 
            // cmdThree
            // 
            this.cmdThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdThree.Location = new System.Drawing.Point(155, 305);
            this.cmdThree.Name = "cmdThree";
            this.cmdThree.Size = new System.Drawing.Size(35, 35);
            this.cmdThree.TabIndex = 8;
            this.cmdThree.Text = "3";
            this.cmdThree.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdThree.UseVisualStyleBackColor = true;
            this.cmdThree.Click += new System.EventHandler(this.cmdThree_Click);
            // 
            // cmdLn
            // 
            this.cmdLn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdLn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmdLn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdLn.Location = new System.Drawing.Point(196, 264);
            this.cmdLn.Name = "cmdLn";
            this.cmdLn.Size = new System.Drawing.Size(53, 35);
            this.cmdLn.TabIndex = 41;
            this.cmdLn.Text = "ln(x)";
            this.cmdLn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdLn.UseVisualStyleBackColor = false;
            this.cmdLn.Click += new System.EventHandler(this.cmdLn_Click);
            // 
            // cmdTwo
            // 
            this.cmdTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdTwo.Location = new System.Drawing.Point(114, 305);
            this.cmdTwo.Name = "cmdTwo";
            this.cmdTwo.Size = new System.Drawing.Size(35, 35);
            this.cmdTwo.TabIndex = 7;
            this.cmdTwo.Text = "2";
            this.cmdTwo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdTwo.UseVisualStyleBackColor = true;
            this.cmdTwo.Click += new System.EventHandler(this.cmdTwo_Click);
            // 
            // cmdConvDecBin
            // 
            this.cmdConvDecBin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdConvDecBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdConvDecBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdConvDecBin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdConvDecBin.Location = new System.Drawing.Point(250, 143);
            this.cmdConvDecBin.Name = "cmdConvDecBin";
            this.cmdConvDecBin.Size = new System.Drawing.Size(76, 35);
            this.cmdConvDecBin.TabIndex = 42;
            this.cmdConvDecBin.Text = "dec->bin";
            this.cmdConvDecBin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdConvDecBin.UseVisualStyleBackColor = false;
            this.cmdConvDecBin.Click += new System.EventHandler(this.cmdConvDecBin_Click);
            // 
            // cmdOne
            // 
            this.cmdOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdOne.Location = new System.Drawing.Point(73, 305);
            this.cmdOne.Name = "cmdOne";
            this.cmdOne.Size = new System.Drawing.Size(35, 35);
            this.cmdOne.TabIndex = 6;
            this.cmdOne.Text = "1";
            this.cmdOne.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdOne.UseVisualStyleBackColor = true;
            this.cmdOne.Click += new System.EventHandler(this.cmdOne_Click);
            // 
            // cmdConvDecOct
            // 
            this.cmdConvDecOct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdConvDecOct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdConvDecOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdConvDecOct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdConvDecOct.Location = new System.Drawing.Point(250, 184);
            this.cmdConvDecOct.Name = "cmdConvDecOct";
            this.cmdConvDecOct.Size = new System.Drawing.Size(76, 35);
            this.cmdConvDecOct.TabIndex = 43;
            this.cmdConvDecOct.Text = "dec->oct";
            this.cmdConvDecOct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdConvDecOct.UseVisualStyleBackColor = false;
            this.cmdConvDecOct.Click += new System.EventHandler(this.cmdConvDecOct_Click);
            // 
            // cmdSix
            // 
            this.cmdSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdSix.Location = new System.Drawing.Point(155, 264);
            this.cmdSix.Name = "cmdSix";
            this.cmdSix.Size = new System.Drawing.Size(35, 35);
            this.cmdSix.TabIndex = 5;
            this.cmdSix.Text = "6";
            this.cmdSix.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdSix.UseVisualStyleBackColor = true;
            this.cmdSix.Click += new System.EventHandler(this.cmdSix_Click);
            // 
            // cmdConvDecHex
            // 
            this.cmdConvDecHex.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdConvDecHex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdConvDecHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdConvDecHex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdConvDecHex.Location = new System.Drawing.Point(332, 185);
            this.cmdConvDecHex.Name = "cmdConvDecHex";
            this.cmdConvDecHex.Size = new System.Drawing.Size(76, 35);
            this.cmdConvDecHex.TabIndex = 44;
            this.cmdConvDecHex.Text = "dec->hex";
            this.cmdConvDecHex.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdConvDecHex.UseVisualStyleBackColor = false;
            this.cmdConvDecHex.Click += new System.EventHandler(this.cmdConvDecHex_Click);
            // 
            // cmdFive
            // 
            this.cmdFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdFive.Location = new System.Drawing.Point(114, 264);
            this.cmdFive.Name = "cmdFive";
            this.cmdFive.Size = new System.Drawing.Size(35, 35);
            this.cmdFive.TabIndex = 4;
            this.cmdFive.Text = "5";
            this.cmdFive.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdFive.UseVisualStyleBackColor = true;
            this.cmdFive.Click += new System.EventHandler(this.cmdFive_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdDel.Location = new System.Drawing.Point(337, 305);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(35, 35);
            this.cmdDel.TabIndex = 45;
            this.cmdDel.Text = "<--";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdDel.UseVisualStyleBackColor = false;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdFour
            // 
            this.cmdFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdFour.Location = new System.Drawing.Point(73, 264);
            this.cmdFour.Name = "cmdFour";
            this.cmdFour.Size = new System.Drawing.Size(35, 35);
            this.cmdFour.TabIndex = 3;
            this.cmdFour.Text = "4";
            this.cmdFour.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdFour.UseVisualStyleBackColor = true;
            this.cmdFour.Click += new System.EventHandler(this.cmdFour_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClear.Location = new System.Drawing.Point(332, 143);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(76, 35);
            this.cmdClear.TabIndex = 46;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdNine
            // 
            this.cmdNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdNine.Location = new System.Drawing.Point(155, 223);
            this.cmdNine.Name = "cmdNine";
            this.cmdNine.Size = new System.Drawing.Size(35, 35);
            this.cmdNine.TabIndex = 2;
            this.cmdNine.Text = "9";
            this.cmdNine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdNine.UseVisualStyleBackColor = true;
            this.cmdNine.Click += new System.EventHandler(this.cmdNine_Click);
            // 
            // cmdEqual
            // 
            this.cmdEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmdEqual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEqual.Location = new System.Drawing.Point(196, 346);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(53, 35);
            this.cmdEqual.TabIndex = 47;
            this.cmdEqual.Text = "=";
            this.cmdEqual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdEqual.UseVisualStyleBackColor = false;
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // cmdEight
            // 
            this.cmdEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdEight.Location = new System.Drawing.Point(114, 223);
            this.cmdEight.Name = "cmdEight";
            this.cmdEight.Size = new System.Drawing.Size(35, 35);
            this.cmdEight.TabIndex = 1;
            this.cmdEight.Text = "8";
            this.cmdEight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdEight.UseVisualStyleBackColor = true;
            this.cmdEight.Click += new System.EventHandler(this.cmdEight_Click);
            // 
            // cmdRound
            // 
            this.cmdRound.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdRound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRound.Location = new System.Drawing.Point(196, 305);
            this.cmdRound.Name = "cmdRound";
            this.cmdRound.Size = new System.Drawing.Size(53, 35);
            this.cmdRound.TabIndex = 48;
            this.cmdRound.Text = "Round";
            this.cmdRound.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdRound.UseVisualStyleBackColor = false;
            this.cmdRound.Click += new System.EventHandler(this.cmdRound_Click);
            // 
            // cmdSeven
            // 
            this.cmdSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdSeven.Location = new System.Drawing.Point(73, 223);
            this.cmdSeven.Name = "cmdSeven";
            this.cmdSeven.Size = new System.Drawing.Size(35, 35);
            this.cmdSeven.TabIndex = 0;
            this.cmdSeven.Text = "7";
            this.cmdSeven.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdSeven.UseVisualStyleBackColor = true;
            this.cmdSeven.Click += new System.EventHandler(this.cmdSeven_Click);
            // 
            // cmdLightSpeed
            // 
            this.cmdLightSpeed.BackColor = System.Drawing.SystemColors.Info;
            this.cmdLightSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLightSpeed.Location = new System.Drawing.Point(337, 346);
            this.cmdLightSpeed.Name = "cmdLightSpeed";
            this.cmdLightSpeed.Size = new System.Drawing.Size(35, 35);
            this.cmdLightSpeed.TabIndex = 20;
            this.cmdLightSpeed.Text = "C";
            this.cmdLightSpeed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdLightSpeed.UseVisualStyleBackColor = false;
            this.cmdLightSpeed.Click += new System.EventHandler(this.cmdLightSpeed_Click);
            // 
            // cmdCloseParenthesis
            // 
            this.cmdCloseParenthesis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdCloseParenthesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCloseParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdCloseParenthesis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCloseParenthesis.Location = new System.Drawing.Point(209, 182);
            this.cmdCloseParenthesis.Name = "cmdCloseParenthesis";
            this.cmdCloseParenthesis.Size = new System.Drawing.Size(35, 35);
            this.cmdCloseParenthesis.TabIndex = 53;
            this.cmdCloseParenthesis.Text = ")";
            this.cmdCloseParenthesis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdCloseParenthesis.UseVisualStyleBackColor = false;
            this.cmdCloseParenthesis.Click += new System.EventHandler(this.cmdCloseParenthesis_Click);
            // 
            // cmdOpenParenthesis
            // 
            this.cmdOpenParenthesis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdOpenParenthesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpenParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdOpenParenthesis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdOpenParenthesis.Location = new System.Drawing.Point(209, 142);
            this.cmdOpenParenthesis.Name = "cmdOpenParenthesis";
            this.cmdOpenParenthesis.Size = new System.Drawing.Size(35, 35);
            this.cmdOpenParenthesis.TabIndex = 54;
            this.cmdOpenParenthesis.Text = "(";
            this.cmdOpenParenthesis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmdOpenParenthesis.UseVisualStyleBackColor = false;
            this.cmdOpenParenthesis.Click += new System.EventHandler(this.cmdOpenParenthesis_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 482);
            this.Controls.Add(this.cmdCloseParenthesis);
            this.Controls.Add(this.cmdOpenParenthesis);
            this.Controls.Add(this.cmdLightSpeed);
            this.Controls.Add(this.cmdHistory);
            this.Controls.Add(this.cmdSeven);
            this.Controls.Add(this.cmdSettings);
            this.Controls.Add(this.cmdRound);
            this.Controls.Add(this.cmdEight);
            this.Controls.Add(this.cmdGraphDisplayer);
            this.Controls.Add(this.cmdEqual);
            this.Controls.Add(this.rtxtDisplay);
            this.Controls.Add(this.cmdNine);
            this.Controls.Add(this.cmdExponential);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSin);
            this.Controls.Add(this.cmdFour);
            this.Controls.Add(this.cmdCos);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdReciprocal);
            this.Controls.Add(this.cmdFive);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.cmdConvDecHex);
            this.Controls.Add(this.cmdNA);
            this.Controls.Add(this.cmdSix);
            this.Controls.Add(this.cmdTan);
            this.Controls.Add(this.cmdConvDecOct);
            this.Controls.Add(this.cmdPi);
            this.Controls.Add(this.cmdOne);
            this.Controls.Add(this.cmdExponentiation);
            this.Controls.Add(this.cmdConvDecBin);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdTwo);
            this.Controls.Add(this.cmdRoot);
            this.Controls.Add(this.cmdLn);
            this.Controls.Add(this.cmdMult);
            this.Controls.Add(this.cmdThree);
            this.Controls.Add(this.cmdInvSin);
            this.Controls.Add(this.cmdFactorial);
            this.Controls.Add(this.cmdMinus);
            this.Controls.Add(this.cmdZero);
            this.Controls.Add(this.cmdInvCos);
            this.Controls.Add(this.cmdAbsValue);
            this.Controls.Add(this.cmdPlus);
            this.Controls.Add(this.cmdComma);
            this.Controls.Add(this.cmdInvTan);
            this.Controls.Add(this.cmdSqrt);
            this.Controls.Add(this.cmdSquare);
            this.Controls.Add(this.cmdInvert);
            this.Name = "frmCalculator";
            this.Text = "Calculatrice scientifique";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdGraphDisplayer;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.Button cmdHistory;
        private System.Windows.Forms.Button cmdExponential;
        private System.Windows.Forms.Button cmdSin;
        private System.Windows.Forms.Button cmdCos;
        private System.Windows.Forms.Button cmdReciprocal;
        private System.Windows.Forms.Button cmdLog;
        private System.Windows.Forms.Button cmdNA;
        private System.Windows.Forms.Button cmdTan;
        private System.Windows.Forms.Button cmdPi;
        private System.Windows.Forms.Button cmdExponentiation;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdRoot;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdInvSin;
        private System.Windows.Forms.Button cmdMinus;
        private System.Windows.Forms.Button cmdInvCos;
        private System.Windows.Forms.Button cmdPlus;
        private System.Windows.Forms.Button cmdInvTan;
        private System.Windows.Forms.RichTextBox rtxtDisplay;
        private System.Windows.Forms.Button cmdSquare;
        private System.Windows.Forms.Button cmdInvert;
        private System.Windows.Forms.Button cmdSqrt;
        private System.Windows.Forms.Button cmdComma;
        private System.Windows.Forms.Button cmdAbsValue;
        private System.Windows.Forms.Button cmdZero;
        private System.Windows.Forms.Button cmdFactorial;
        private System.Windows.Forms.Button cmdThree;
        private System.Windows.Forms.Button cmdLn;
        private System.Windows.Forms.Button cmdTwo;
        private System.Windows.Forms.Button cmdConvDecBin;
        private System.Windows.Forms.Button cmdOne;
        private System.Windows.Forms.Button cmdConvDecOct;
        private System.Windows.Forms.Button cmdSix;
        private System.Windows.Forms.Button cmdConvDecHex;
        private System.Windows.Forms.Button cmdFive;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdFour;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdNine;
        private System.Windows.Forms.Button cmdEqual;
        private System.Windows.Forms.Button cmdEight;
        private System.Windows.Forms.Button cmdRound;
        private System.Windows.Forms.Button cmdSeven;
        private System.Windows.Forms.Button cmdLightSpeed;
        private System.Windows.Forms.Button cmdCloseParenthesis;
        private System.Windows.Forms.Button cmdOpenParenthesis;
    }
}