namespace ArborTrellis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudPixelsPerInch = new System.Windows.Forms.NumericUpDown();
            this.nudVerticalSplineWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudInterstitialSplineMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudVerticalSplineCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRowHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxShowInterstitials = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelsPerInch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSplineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterstitialSplineMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSplineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixels Per Inch";
            // 
            // nudPixelsPerInch
            // 
            this.nudPixelsPerInch.Location = new System.Drawing.Point(152, 22);
            this.nudPixelsPerInch.Name = "nudPixelsPerInch";
            this.nudPixelsPerInch.Size = new System.Drawing.Size(120, 22);
            this.nudPixelsPerInch.TabIndex = 1;
            this.nudPixelsPerInch.ValueChanged += new System.EventHandler(this.nudPixelsPerInch_ValueChanged);
            // 
            // nudVerticalSplineWidth
            // 
            this.nudVerticalSplineWidth.DecimalPlaces = 2;
            this.nudVerticalSplineWidth.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.nudVerticalSplineWidth.Location = new System.Drawing.Point(152, 80);
            this.nudVerticalSplineWidth.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVerticalSplineWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudVerticalSplineWidth.Name = "nudVerticalSplineWidth";
            this.nudVerticalSplineWidth.Size = new System.Drawing.Size(120, 22);
            this.nudVerticalSplineWidth.TabIndex = 3;
            this.nudVerticalSplineWidth.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            this.nudVerticalSplineWidth.ValueChanged += new System.EventHandler(this.nudVerticalSplineWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertical Spline Width";
            // 
            // nudInterstitialSplineMultiplier
            // 
            this.nudInterstitialSplineMultiplier.DecimalPlaces = 2;
            this.nudInterstitialSplineMultiplier.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.nudInterstitialSplineMultiplier.Location = new System.Drawing.Point(152, 109);
            this.nudInterstitialSplineMultiplier.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudInterstitialSplineMultiplier.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudInterstitialSplineMultiplier.Name = "nudInterstitialSplineMultiplier";
            this.nudInterstitialSplineMultiplier.Size = new System.Drawing.Size(120, 22);
            this.nudInterstitialSplineMultiplier.TabIndex = 5;
            this.nudInterstitialSplineMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterstitialSplineMultiplier.ValueChanged += new System.EventHandler(this.nudInterstitialSplineMultiplier_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inter. Spline Mult.";
            // 
            // nudVerticalSplineCount
            // 
            this.nudVerticalSplineCount.Location = new System.Drawing.Point(152, 51);
            this.nudVerticalSplineCount.Name = "nudVerticalSplineCount";
            this.nudVerticalSplineCount.Size = new System.Drawing.Size(120, 22);
            this.nudVerticalSplineCount.TabIndex = 7;
            this.nudVerticalSplineCount.ValueChanged += new System.EventHandler(this.nudVerticalSplineCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vertical Spline Count";
            // 
            // nudRowHeight
            // 
            this.nudRowHeight.DecimalPlaces = 2;
            this.nudRowHeight.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.nudRowHeight.Location = new System.Drawing.Point(152, 138);
            this.nudRowHeight.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRowHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRowHeight.Name = "nudRowHeight";
            this.nudRowHeight.Size = new System.Drawing.Size(120, 22);
            this.nudRowHeight.TabIndex = 9;
            this.nudRowHeight.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            this.nudRowHeight.ValueChanged += new System.EventHandler(this.nudRowHeight_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Row Height";
            // 
            // cbxShowInterstitials
            // 
            this.cbxShowInterstitials.AutoSize = true;
            this.cbxShowInterstitials.Location = new System.Drawing.Point(152, 167);
            this.cbxShowInterstitials.Name = "cbxShowInterstitials";
            this.cbxShowInterstitials.Size = new System.Drawing.Size(135, 21);
            this.cbxShowInterstitials.TabIndex = 10;
            this.cbxShowInterstitials.Text = "Show Interstitials";
            this.cbxShowInterstitials.UseVisualStyleBackColor = true;
            this.cbxShowInterstitials.CheckedChanged += new System.EventHandler(this.cbxShowInterstitials_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 748);
            this.Controls.Add(this.cbxShowInterstitials);
            this.Controls.Add(this.nudRowHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudVerticalSplineCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudInterstitialSplineMultiplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudVerticalSplineWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPixelsPerInch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPixelsPerInch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSplineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterstitialSplineMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSplineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPixelsPerInch;
        private System.Windows.Forms.NumericUpDown nudVerticalSplineWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInterstitialSplineMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudVerticalSplineCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRowHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxShowInterstitials;
    }
}

