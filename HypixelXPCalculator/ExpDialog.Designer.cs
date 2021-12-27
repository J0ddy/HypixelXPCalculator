namespace HypixelXPCalculator
{
    partial class ExpDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numDailyExp = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTypeDaily = new System.Windows.Forms.Button();
            this.btnTypeBooster = new System.Windows.Forms.Button();
            this.lblOutput_XpNeeded = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyExp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.numDailyExp);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 306);
            this.panel1.TabIndex = 1;
            // 
            // numDailyExp
            // 
            this.numDailyExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numDailyExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDailyExp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDailyExp.Location = new System.Drawing.Point(135, 217);
            this.numDailyExp.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDailyExp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDailyExp.Name = "numDailyExp";
            this.numDailyExp.Size = new System.Drawing.Size(210, 32);
            this.numDailyExp.TabIndex = 2;
            this.numDailyExp.ThousandsSeparator = true;
            this.numDailyExp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDailyExp.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(449, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTypeDaily
            // 
            this.btnTypeDaily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTypeDaily.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeDaily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTypeDaily.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeDaily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnTypeDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeDaily.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTypeDaily.ForeColor = System.Drawing.Color.White;
            this.btnTypeDaily.Image = global::HypixelXPCalculator.Properties.Resources.xp_bottle_24;
            this.btnTypeDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeDaily.Location = new System.Drawing.Point(253, 151);
            this.btnTypeDaily.Name = "btnTypeDaily";
            this.btnTypeDaily.Size = new System.Drawing.Size(213, 46);
            this.btnTypeDaily.TabIndex = 1;
            this.btnTypeDaily.Text = "Daily EXP";
            this.btnTypeDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypeDaily.UseVisualStyleBackColor = false;
            this.btnTypeDaily.Click += new System.EventHandler(this.btnTypeDaily_Click);
            // 
            // btnTypeBooster
            // 
            this.btnTypeBooster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTypeBooster.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeBooster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTypeBooster.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeBooster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeBooster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnTypeBooster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeBooster.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTypeBooster.ForeColor = System.Drawing.Color.White;
            this.btnTypeBooster.Image = global::HypixelXPCalculator.Properties.Resources.xp_bottle_24;
            this.btnTypeBooster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeBooster.Location = new System.Drawing.Point(34, 151);
            this.btnTypeBooster.Name = "btnTypeBooster";
            this.btnTypeBooster.Size = new System.Drawing.Size(213, 46);
            this.btnTypeBooster.TabIndex = 0;
            this.btnTypeBooster.Text = "Network Booster";
            this.btnTypeBooster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypeBooster.UseVisualStyleBackColor = false;
            this.btnTypeBooster.Click += new System.EventHandler(this.btnTypeBooster_Click);
            // 
            // lblOutput_XpNeeded
            // 
            this.lblOutput_XpNeeded.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOutput_XpNeeded.AutoSize = true;
            this.lblOutput_XpNeeded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lblOutput_XpNeeded.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput_XpNeeded.ForeColor = System.Drawing.Color.White;
            this.lblOutput_XpNeeded.Location = new System.Drawing.Point(94, 95);
            this.lblOutput_XpNeeded.Name = "lblOutput_XpNeeded";
            this.lblOutput_XpNeeded.Size = new System.Drawing.Size(313, 29);
            this.lblOutput_XpNeeded.TabIndex = 73;
            this.lblOutput_XpNeeded.Text = "Please select an EXP Type";
            this.lblOutput_XpNeeded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.lblOutput_XpNeeded);
            this.Controls.Add(this.btnTypeDaily);
            this.Controls.Add(this.btnTypeBooster);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 330);
            this.Name = "ExpDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select an EXP Type";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDailyExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnTypeDaily;
        private Button btnTypeBooster;
        private Label lblOutput_XpNeeded;
        private Button btnClose;
        private NumericUpDown numDailyExp;
    }
}