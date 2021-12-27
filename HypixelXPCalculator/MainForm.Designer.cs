namespace HypixelXPCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numLevelCurrent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numLevelGoal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numXPtoNext = new System.Windows.Forms.NumericUpDown();
            this.btnTypeEXP = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResult7 = new System.Windows.Forms.Label();
            this.lblResult6 = new System.Windows.Forms.Label();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.panelResult_Icons = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPtoNext)).BeginInit();
            this.panelResult.SuspendLayout();
            this.panelResult_Icons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.AutoSize = true;
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelInput.Controls.Add(this.btnCalculate);
            this.panelInput.Controls.Add(this.numLevelCurrent);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.numLevelGoal);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.numXPtoNext);
            this.panelInput.Controls.Add(this.btnTypeEXP);
            this.panelInput.Location = new System.Drawing.Point(12, 29);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(389, 406);
            this.panelInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalculate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Image = global::HypixelXPCalculator.Properties.Resources.spinner_arrow_24;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.Location = new System.Drawing.Point(80, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(235, 54);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numLevelCurrent
            // 
            this.numLevelCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numLevelCurrent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numLevelCurrent.Location = new System.Drawing.Point(172, 80);
            this.numLevelCurrent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLevelCurrent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevelCurrent.Name = "numLevelCurrent";
            this.numLevelCurrent.Size = new System.Drawing.Size(174, 32);
            this.numLevelCurrent.TabIndex = 0;
            this.numLevelCurrent.ThousandsSeparator = true;
            this.numLevelCurrent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Your Level";
            // 
            // numLevelGoal
            // 
            this.numLevelGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numLevelGoal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numLevelGoal.Location = new System.Drawing.Point(172, 156);
            this.numLevelGoal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLevelGoal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevelGoal.Name = "numLevelGoal";
            this.numLevelGoal.Size = new System.Drawing.Size(174, 32);
            this.numLevelGoal.TabIndex = 2;
            this.numLevelGoal.ThousandsSeparator = true;
            this.numLevelGoal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "XP To Next";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 61;
            this.label6.Text = "Goal Level";
            // 
            // numXPtoNext
            // 
            this.numXPtoNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numXPtoNext.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numXPtoNext.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numXPtoNext.Location = new System.Drawing.Point(172, 118);
            this.numXPtoNext.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numXPtoNext.Name = "numXPtoNext";
            this.numXPtoNext.Size = new System.Drawing.Size(174, 32);
            this.numXPtoNext.TabIndex = 1;
            this.numXPtoNext.ThousandsSeparator = true;
            // 
            // btnTypeEXP
            // 
            this.btnTypeEXP.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeEXP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTypeEXP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeEXP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTypeEXP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnTypeEXP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeEXP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTypeEXP.ForeColor = System.Drawing.Color.White;
            this.btnTypeEXP.Image = global::HypixelXPCalculator.Properties.Resources.xp_bottle_24;
            this.btnTypeEXP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeEXP.Location = new System.Drawing.Point(91, 220);
            this.btnTypeEXP.Name = "btnTypeEXP";
            this.btnTypeEXP.Size = new System.Drawing.Size(213, 46);
            this.btnTypeEXP.TabIndex = 3;
            this.btnTypeEXP.Text = "Select EXP Type";
            this.btnTypeEXP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypeEXP.UseVisualStyleBackColor = false;
            this.btnTypeEXP.Click += new System.EventHandler(this.btnTypeEXP_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelInfo.Location = new System.Drawing.Point(12, 459);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(850, 75);
            this.panelInfo.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResult.AutoSize = true;
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelResult.Controls.Add(this.lblResult7);
            this.panelResult.Controls.Add(this.lblResult6);
            this.panelResult.Controls.Add(this.lblResult5);
            this.panelResult.Controls.Add(this.lblResult4);
            this.panelResult.Controls.Add(this.lblResult3);
            this.panelResult.Controls.Add(this.lblResult2);
            this.panelResult.Controls.Add(this.lblResult1);
            this.panelResult.Controls.Add(this.panelResult_Icons);
            this.panelResult.Location = new System.Drawing.Point(417, 29);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(445, 406);
            this.panelResult.TabIndex = 1;
            // 
            // lblResult7
            // 
            this.lblResult7.BackColor = System.Drawing.Color.Transparent;
            this.lblResult7.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult7.ForeColor = System.Drawing.Color.White;
            this.lblResult7.Location = new System.Drawing.Point(37, 348);
            this.lblResult7.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult7.Name = "lblResult7";
            this.lblResult7.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult7.Size = new System.Drawing.Size(408, 58);
            this.lblResult7.TabIndex = 64;
            this.lblResult7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult6
            // 
            this.lblResult6.BackColor = System.Drawing.Color.Transparent;
            this.lblResult6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult6.ForeColor = System.Drawing.Color.White;
            this.lblResult6.Location = new System.Drawing.Point(37, 290);
            this.lblResult6.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult6.Name = "lblResult6";
            this.lblResult6.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult6.Size = new System.Drawing.Size(408, 58);
            this.lblResult6.TabIndex = 63;
            this.lblResult6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult5
            // 
            this.lblResult5.BackColor = System.Drawing.Color.Transparent;
            this.lblResult5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult5.ForeColor = System.Drawing.Color.White;
            this.lblResult5.Location = new System.Drawing.Point(37, 232);
            this.lblResult5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult5.Size = new System.Drawing.Size(408, 58);
            this.lblResult5.TabIndex = 62;
            this.lblResult5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult4
            // 
            this.lblResult4.BackColor = System.Drawing.Color.Transparent;
            this.lblResult4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult4.ForeColor = System.Drawing.Color.White;
            this.lblResult4.Location = new System.Drawing.Point(37, 174);
            this.lblResult4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult4.Size = new System.Drawing.Size(408, 58);
            this.lblResult4.TabIndex = 61;
            this.lblResult4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult3
            // 
            this.lblResult3.BackColor = System.Drawing.Color.Transparent;
            this.lblResult3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult3.ForeColor = System.Drawing.Color.White;
            this.lblResult3.Location = new System.Drawing.Point(37, 116);
            this.lblResult3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult3.Size = new System.Drawing.Size(408, 58);
            this.lblResult3.TabIndex = 60;
            this.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.Transparent;
            this.lblResult2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult2.ForeColor = System.Drawing.Color.White;
            this.lblResult2.Location = new System.Drawing.Point(37, 58);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult2.Size = new System.Drawing.Size(408, 58);
            this.lblResult2.TabIndex = 59;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult1
            // 
            this.lblResult1.BackColor = System.Drawing.Color.Transparent;
            this.lblResult1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult1.ForeColor = System.Drawing.Color.White;
            this.lblResult1.Location = new System.Drawing.Point(37, 0);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lblResult1.Size = new System.Drawing.Size(408, 58);
            this.lblResult1.TabIndex = 58;
            this.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelResult_Icons
            // 
            this.panelResult_Icons.Controls.Add(this.pictureBox7);
            this.panelResult_Icons.Controls.Add(this.pictureBox6);
            this.panelResult_Icons.Controls.Add(this.pictureBox5);
            this.panelResult_Icons.Controls.Add(this.pictureBox4);
            this.panelResult_Icons.Controls.Add(this.pictureBox3);
            this.panelResult_Icons.Controls.Add(this.pictureBox2);
            this.panelResult_Icons.Controls.Add(this.pictureBox1);
            this.panelResult_Icons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_Icons.Location = new System.Drawing.Point(0, 0);
            this.panelResult_Icons.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.panelResult_Icons.Name = "panelResult_Icons";
            this.panelResult_Icons.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelResult_Icons.Size = new System.Drawing.Size(37, 406);
            this.panelResult_Icons.TabIndex = 0;
            this.panelResult_Icons.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox7.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox7.Location = new System.Drawing.Point(12, 348);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox7.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox7.Size = new System.Drawing.Size(26, 58);
            this.pictureBox7.TabIndex = 83;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox6.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox6.Location = new System.Drawing.Point(12, 290);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox6.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox6.Size = new System.Drawing.Size(26, 58);
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox5.Location = new System.Drawing.Point(12, 232);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox5.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox5.Size = new System.Drawing.Size(26, 58);
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox4.Location = new System.Drawing.Point(12, 174);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox4.Size = new System.Drawing.Size(26, 58);
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox3.Location = new System.Drawing.Point(12, 116);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox3.Size = new System.Drawing.Size(26, 58);
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox2.Size = new System.Drawing.Size(26, 58);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HypixelXPCalculator.Properties.Resources.add_24;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(26, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox1.Size = new System.Drawing.Size(26, 58);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(874, 551);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(890, 590);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hypixel XP Calculator";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPtoNext)).EndInit();
            this.panelResult.ResumeLayout(false);
            this.panelResult_Icons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelInput;
        private Panel panelInfo;
        private NumericUpDown numLevelCurrent;
        private Label label4;
        private Label label5;
        private NumericUpDown numXPtoNext;
        private NumericUpDown numLevelGoal;
        private Label label6;
        private Button btnTypeEXP;
        private Button btnCalculate;
        private Panel panelResult;
        private Label lblResult1;
        private Panel panelResult_Icons;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblResult7;
        private Label lblResult6;
        private Label lblResult5;
        private Label lblResult4;
        private Label lblResult3;
        private Label lblResult2;
    }
}