namespace SARuleMaker
{
    partial class FormRM
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
            this.ruleOutput = new System.Windows.Forms.TextBox();
            this.headCheck1 = new System.Windows.Forms.CheckBox();
            this.fromCheck1 = new System.Windows.Forms.CheckBox();
            this.rbCheck1 = new System.Windows.Forms.CheckBox();
            this.subCheck1 = new System.Windows.Forms.CheckBox();
            this.rcCheck1 = new System.Windows.Forms.CheckBox();
            this.ruleNumber = new System.Windows.Forms.TextBox();
            this.rxInput1 = new System.Windows.Forms.TextBox();
            this.metaCheck = new System.Windows.Forms.CheckBox();
            this.rxInput2 = new System.Windows.Forms.TextBox();
            this.meta2Check = new System.Windows.Forms.CheckBox();
            this.rxInput3 = new System.Windows.Forms.TextBox();
            this.meta3Check = new System.Windows.Forms.CheckBox();
            this.rxInput4 = new System.Windows.Forms.TextBox();
            this.meta4Check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.meta1Case = new System.Windows.Forms.CheckBox();
            this.meta2Case = new System.Windows.Forms.CheckBox();
            this.meta3Case = new System.Windows.Forms.CheckBox();
            this.meta4Case = new System.Windows.Forms.CheckBox();
            this.headCheck2 = new System.Windows.Forms.CheckBox();
            this.rbCheck2 = new System.Windows.Forms.CheckBox();
            this.fromCheck2 = new System.Windows.Forms.CheckBox();
            this.subCheck2 = new System.Windows.Forms.CheckBox();
            this.rcCheck2 = new System.Windows.Forms.CheckBox();
            this.headCheck3 = new System.Windows.Forms.CheckBox();
            this.rbCheck3 = new System.Windows.Forms.CheckBox();
            this.fromCheck3 = new System.Windows.Forms.CheckBox();
            this.subCheck3 = new System.Windows.Forms.CheckBox();
            this.rcCheck3 = new System.Windows.Forms.CheckBox();
            this.headCheck4 = new System.Windows.Forms.CheckBox();
            this.rbCheck4 = new System.Windows.Forms.CheckBox();
            this.fromCheck4 = new System.Windows.Forms.CheckBox();
            this.subCheck4 = new System.Windows.Forms.CheckBox();
            this.rcCheck4 = new System.Windows.Forms.CheckBox();
            this.buildBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreNum = new System.Windows.Forms.NumericUpDown();
            this.btn_TopMost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ruleOutput
            // 
            this.ruleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleOutput.Location = new System.Drawing.Point(49, 416);
            this.ruleOutput.Multiline = true;
            this.ruleOutput.Name = "ruleOutput";
            this.ruleOutput.ReadOnly = true;
            this.ruleOutput.Size = new System.Drawing.Size(710, 213);
            this.ruleOutput.TabIndex = 1;
            this.ruleOutput.TextChanged += new System.EventHandler(this.ruleOutput_TextChanged);
            // 
            // headCheck1
            // 
            this.headCheck1.AutoSize = true;
            this.headCheck1.Location = new System.Drawing.Point(293, 87);
            this.headCheck1.Name = "headCheck1";
            this.headCheck1.Size = new System.Drawing.Size(61, 17);
            this.headCheck1.TabIndex = 3;
            this.headCheck1.Text = "Header";
            this.headCheck1.UseVisualStyleBackColor = true;
            this.headCheck1.CheckedChanged += new System.EventHandler(this.headCheck_CheckedChanged);
            // 
            // fromCheck1
            // 
            this.fromCheck1.AutoSize = true;
            this.fromCheck1.Enabled = false;
            this.fromCheck1.Location = new System.Drawing.Point(293, 110);
            this.fromCheck1.Name = "fromCheck1";
            this.fromCheck1.Size = new System.Drawing.Size(49, 17);
            this.fromCheck1.TabIndex = 3;
            this.fromCheck1.Text = "From";
            this.fromCheck1.UseVisualStyleBackColor = true;
            this.fromCheck1.CheckedChanged += new System.EventHandler(this.fromCheck1_CheckedChanged);
            // 
            // rbCheck1
            // 
            this.rbCheck1.AutoSize = true;
            this.rbCheck1.Checked = true;
            this.rbCheck1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbCheck1.Location = new System.Drawing.Point(200, 87);
            this.rbCheck1.Name = "rbCheck1";
            this.rbCheck1.Size = new System.Drawing.Size(71, 17);
            this.rbCheck1.TabIndex = 3;
            this.rbCheck1.Text = "Rawbody";
            this.rbCheck1.UseVisualStyleBackColor = true;
            this.rbCheck1.CheckedChanged += new System.EventHandler(this.rbCheck_CheckedChanged);
            // 
            // subCheck1
            // 
            this.subCheck1.AutoSize = true;
            this.subCheck1.Enabled = false;
            this.subCheck1.Location = new System.Drawing.Point(360, 110);
            this.subCheck1.Name = "subCheck1";
            this.subCheck1.Size = new System.Drawing.Size(62, 17);
            this.subCheck1.TabIndex = 3;
            this.subCheck1.Text = "Subject";
            this.subCheck1.UseVisualStyleBackColor = true;
            this.subCheck1.CheckedChanged += new System.EventHandler(this.subCheck1_CheckedChanged);
            // 
            // rcCheck1
            // 
            this.rcCheck1.AutoSize = true;
            this.rcCheck1.Enabled = false;
            this.rcCheck1.Location = new System.Drawing.Point(431, 110);
            this.rcCheck1.Name = "rcCheck1";
            this.rcCheck1.Size = new System.Drawing.Size(72, 17);
            this.rcCheck1.TabIndex = 3;
            this.rcCheck1.Text = "Received";
            this.rcCheck1.UseVisualStyleBackColor = true;
            this.rcCheck1.CheckedChanged += new System.EventHandler(this.rcCheck1_CheckedChanged);
            // 
            // ruleNumber
            // 
            this.ruleNumber.Location = new System.Drawing.Point(275, 13);
            this.ruleNumber.Name = "ruleNumber";
            this.ruleNumber.Size = new System.Drawing.Size(71, 20);
            this.ruleNumber.TabIndex = 4;
            this.ruleNumber.TextChanged += new System.EventHandler(this.ruleNumber_TextChanged);
            // 
            // rxInput1
            // 
            this.rxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rxInput1.Location = new System.Drawing.Point(198, 61);
            this.rxInput1.Name = "rxInput1";
            this.rxInput1.Size = new System.Drawing.Size(338, 20);
            this.rxInput1.TabIndex = 4;
            // 
            // metaCheck
            // 
            this.metaCheck.AutoSize = true;
            this.metaCheck.Location = new System.Drawing.Point(121, 64);
            this.metaCheck.Name = "metaCheck";
            this.metaCheck.Size = new System.Drawing.Size(50, 17);
            this.metaCheck.TabIndex = 5;
            this.metaCheck.Text = "Meta";
            this.metaCheck.UseVisualStyleBackColor = true;
            this.metaCheck.CheckedChanged += new System.EventHandler(this.metaCheck_CheckedChanged);
            // 
            // rxInput2
            // 
            this.rxInput2.Enabled = false;
            this.rxInput2.Location = new System.Drawing.Point(198, 143);
            this.rxInput2.Name = "rxInput2";
            this.rxInput2.Size = new System.Drawing.Size(338, 20);
            this.rxInput2.TabIndex = 4;
            // 
            // meta2Check
            // 
            this.meta2Check.AutoSize = true;
            this.meta2Check.Enabled = false;
            this.meta2Check.Location = new System.Drawing.Point(121, 146);
            this.meta2Check.Name = "meta2Check";
            this.meta2Check.Size = new System.Drawing.Size(38, 17);
            this.meta2Check.TabIndex = 6;
            this.meta2Check.Text = "02";
            this.meta2Check.UseVisualStyleBackColor = true;
            this.meta2Check.CheckedChanged += new System.EventHandler(this.meta2Check_CheckedChanged);
            // 
            // rxInput3
            // 
            this.rxInput3.Enabled = false;
            this.rxInput3.Location = new System.Drawing.Point(198, 231);
            this.rxInput3.Name = "rxInput3";
            this.rxInput3.Size = new System.Drawing.Size(338, 20);
            this.rxInput3.TabIndex = 4;
            // 
            // meta3Check
            // 
            this.meta3Check.AutoSize = true;
            this.meta3Check.Enabled = false;
            this.meta3Check.Location = new System.Drawing.Point(121, 234);
            this.meta3Check.Name = "meta3Check";
            this.meta3Check.Size = new System.Drawing.Size(38, 17);
            this.meta3Check.TabIndex = 6;
            this.meta3Check.Text = "03";
            this.meta3Check.UseVisualStyleBackColor = true;
            this.meta3Check.CheckedChanged += new System.EventHandler(this.meta3Check_CheckedChanged);
            // 
            // rxInput4
            // 
            this.rxInput4.Enabled = false;
            this.rxInput4.Location = new System.Drawing.Point(198, 319);
            this.rxInput4.Name = "rxInput4";
            this.rxInput4.Size = new System.Drawing.Size(338, 20);
            this.rxInput4.TabIndex = 4;
            // 
            // meta4Check
            // 
            this.meta4Check.AutoSize = true;
            this.meta4Check.Enabled = false;
            this.meta4Check.Location = new System.Drawing.Point(121, 322);
            this.meta4Check.Name = "meta4Check";
            this.meta4Check.Size = new System.Drawing.Size(38, 17);
            this.meta4Check.TabIndex = 6;
            this.meta4Check.Text = "04";
            this.meta4Check.UseVisualStyleBackColor = true;
            this.meta4Check.CheckedChanged += new System.EventHandler(this.meta4Check_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rule Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // meta1Case
            // 
            this.meta1Case.AutoSize = true;
            this.meta1Case.Location = new System.Drawing.Point(543, 63);
            this.meta1Case.Name = "meta1Case";
            this.meta1Case.Size = new System.Drawing.Size(83, 17);
            this.meta1Case.TabIndex = 8;
            this.meta1Case.Text = "Ignore Case";
            this.meta1Case.UseVisualStyleBackColor = true;
            // 
            // meta2Case
            // 
            this.meta2Case.AutoSize = true;
            this.meta2Case.Enabled = false;
            this.meta2Case.Location = new System.Drawing.Point(543, 146);
            this.meta2Case.Name = "meta2Case";
            this.meta2Case.Size = new System.Drawing.Size(83, 17);
            this.meta2Case.TabIndex = 8;
            this.meta2Case.Text = "Ignore Case";
            this.meta2Case.UseVisualStyleBackColor = true;
            this.meta2Case.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // meta3Case
            // 
            this.meta3Case.AutoSize = true;
            this.meta3Case.Enabled = false;
            this.meta3Case.Location = new System.Drawing.Point(543, 231);
            this.meta3Case.Name = "meta3Case";
            this.meta3Case.Size = new System.Drawing.Size(83, 17);
            this.meta3Case.TabIndex = 8;
            this.meta3Case.Text = "Ignore Case";
            this.meta3Case.UseVisualStyleBackColor = true;
            this.meta3Case.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // meta4Case
            // 
            this.meta4Case.AutoSize = true;
            this.meta4Case.Enabled = false;
            this.meta4Case.Location = new System.Drawing.Point(543, 319);
            this.meta4Case.Name = "meta4Case";
            this.meta4Case.Size = new System.Drawing.Size(83, 17);
            this.meta4Case.TabIndex = 8;
            this.meta4Case.Text = "Ignore Case";
            this.meta4Case.UseVisualStyleBackColor = true;
            this.meta4Case.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // headCheck2
            // 
            this.headCheck2.AutoSize = true;
            this.headCheck2.Enabled = false;
            this.headCheck2.Location = new System.Drawing.Point(293, 169);
            this.headCheck2.Name = "headCheck2";
            this.headCheck2.Size = new System.Drawing.Size(61, 17);
            this.headCheck2.TabIndex = 3;
            this.headCheck2.Text = "Header";
            this.headCheck2.UseVisualStyleBackColor = true;
            this.headCheck2.CheckedChanged += new System.EventHandler(this.headCheck2_CheckedChanged);
            // 
            // rbCheck2
            // 
            this.rbCheck2.AutoSize = true;
            this.rbCheck2.Enabled = false;
            this.rbCheck2.Location = new System.Drawing.Point(200, 169);
            this.rbCheck2.Name = "rbCheck2";
            this.rbCheck2.Size = new System.Drawing.Size(71, 17);
            this.rbCheck2.TabIndex = 3;
            this.rbCheck2.Text = "Rawbody";
            this.rbCheck2.UseVisualStyleBackColor = true;
            this.rbCheck2.CheckedChanged += new System.EventHandler(this.rbCheck2_CheckedChanged);
            // 
            // fromCheck2
            // 
            this.fromCheck2.AutoSize = true;
            this.fromCheck2.Enabled = false;
            this.fromCheck2.Location = new System.Drawing.Point(293, 192);
            this.fromCheck2.Name = "fromCheck2";
            this.fromCheck2.Size = new System.Drawing.Size(49, 17);
            this.fromCheck2.TabIndex = 3;
            this.fromCheck2.Text = "From";
            this.fromCheck2.UseVisualStyleBackColor = true;
            this.fromCheck2.CheckedChanged += new System.EventHandler(this.fromCheck2_CheckedChanged);
            // 
            // subCheck2
            // 
            this.subCheck2.AutoSize = true;
            this.subCheck2.Enabled = false;
            this.subCheck2.Location = new System.Drawing.Point(360, 192);
            this.subCheck2.Name = "subCheck2";
            this.subCheck2.Size = new System.Drawing.Size(62, 17);
            this.subCheck2.TabIndex = 3;
            this.subCheck2.Text = "Subject";
            this.subCheck2.UseVisualStyleBackColor = true;
            this.subCheck2.CheckedChanged += new System.EventHandler(this.subCheck2_CheckedChanged);
            // 
            // rcCheck2
            // 
            this.rcCheck2.AutoSize = true;
            this.rcCheck2.Enabled = false;
            this.rcCheck2.Location = new System.Drawing.Point(431, 192);
            this.rcCheck2.Name = "rcCheck2";
            this.rcCheck2.Size = new System.Drawing.Size(72, 17);
            this.rcCheck2.TabIndex = 3;
            this.rcCheck2.Text = "Received";
            this.rcCheck2.UseVisualStyleBackColor = true;
            this.rcCheck2.CheckedChanged += new System.EventHandler(this.rcCheck2_CheckedChanged);
            // 
            // headCheck3
            // 
            this.headCheck3.AutoSize = true;
            this.headCheck3.Enabled = false;
            this.headCheck3.Location = new System.Drawing.Point(293, 261);
            this.headCheck3.Name = "headCheck3";
            this.headCheck3.Size = new System.Drawing.Size(61, 17);
            this.headCheck3.TabIndex = 3;
            this.headCheck3.Text = "Header";
            this.headCheck3.UseVisualStyleBackColor = true;
            this.headCheck3.CheckedChanged += new System.EventHandler(this.headCheck3_CheckedChanged);
            // 
            // rbCheck3
            // 
            this.rbCheck3.AutoSize = true;
            this.rbCheck3.Enabled = false;
            this.rbCheck3.Location = new System.Drawing.Point(200, 261);
            this.rbCheck3.Name = "rbCheck3";
            this.rbCheck3.Size = new System.Drawing.Size(71, 17);
            this.rbCheck3.TabIndex = 3;
            this.rbCheck3.Text = "Rawbody";
            this.rbCheck3.UseVisualStyleBackColor = true;
            this.rbCheck3.CheckedChanged += new System.EventHandler(this.rbCheck3_CheckedChanged);
            // 
            // fromCheck3
            // 
            this.fromCheck3.AutoSize = true;
            this.fromCheck3.Enabled = false;
            this.fromCheck3.Location = new System.Drawing.Point(293, 284);
            this.fromCheck3.Name = "fromCheck3";
            this.fromCheck3.Size = new System.Drawing.Size(49, 17);
            this.fromCheck3.TabIndex = 3;
            this.fromCheck3.Text = "From";
            this.fromCheck3.UseVisualStyleBackColor = true;
            this.fromCheck3.CheckedChanged += new System.EventHandler(this.fromCheck3_CheckedChanged);
            // 
            // subCheck3
            // 
            this.subCheck3.AutoSize = true;
            this.subCheck3.Enabled = false;
            this.subCheck3.Location = new System.Drawing.Point(360, 284);
            this.subCheck3.Name = "subCheck3";
            this.subCheck3.Size = new System.Drawing.Size(62, 17);
            this.subCheck3.TabIndex = 3;
            this.subCheck3.Text = "Subject";
            this.subCheck3.UseVisualStyleBackColor = true;
            this.subCheck3.CheckedChanged += new System.EventHandler(this.subCheck3_CheckedChanged);
            // 
            // rcCheck3
            // 
            this.rcCheck3.AutoSize = true;
            this.rcCheck3.Enabled = false;
            this.rcCheck3.Location = new System.Drawing.Point(431, 284);
            this.rcCheck3.Name = "rcCheck3";
            this.rcCheck3.Size = new System.Drawing.Size(72, 17);
            this.rcCheck3.TabIndex = 3;
            this.rcCheck3.Text = "Received";
            this.rcCheck3.UseVisualStyleBackColor = true;
            this.rcCheck3.CheckedChanged += new System.EventHandler(this.rcCheck3_CheckedChanged);
            // 
            // headCheck4
            // 
            this.headCheck4.AutoSize = true;
            this.headCheck4.Enabled = false;
            this.headCheck4.Location = new System.Drawing.Point(293, 349);
            this.headCheck4.Name = "headCheck4";
            this.headCheck4.Size = new System.Drawing.Size(61, 17);
            this.headCheck4.TabIndex = 3;
            this.headCheck4.Text = "Header";
            this.headCheck4.UseVisualStyleBackColor = true;
            this.headCheck4.CheckedChanged += new System.EventHandler(this.headCheck4_CheckedChanged);
            // 
            // rbCheck4
            // 
            this.rbCheck4.AutoSize = true;
            this.rbCheck4.Enabled = false;
            this.rbCheck4.Location = new System.Drawing.Point(200, 349);
            this.rbCheck4.Name = "rbCheck4";
            this.rbCheck4.Size = new System.Drawing.Size(71, 17);
            this.rbCheck4.TabIndex = 3;
            this.rbCheck4.Text = "Rawbody";
            this.rbCheck4.UseVisualStyleBackColor = true;
            this.rbCheck4.CheckedChanged += new System.EventHandler(this.rbCheck4_CheckedChanged);
            // 
            // fromCheck4
            // 
            this.fromCheck4.AutoSize = true;
            this.fromCheck4.Enabled = false;
            this.fromCheck4.Location = new System.Drawing.Point(293, 372);
            this.fromCheck4.Name = "fromCheck4";
            this.fromCheck4.Size = new System.Drawing.Size(49, 17);
            this.fromCheck4.TabIndex = 3;
            this.fromCheck4.Text = "From";
            this.fromCheck4.UseVisualStyleBackColor = true;
            this.fromCheck4.CheckedChanged += new System.EventHandler(this.fromCheck4_CheckedChanged);
            // 
            // subCheck4
            // 
            this.subCheck4.AutoSize = true;
            this.subCheck4.Enabled = false;
            this.subCheck4.Location = new System.Drawing.Point(360, 372);
            this.subCheck4.Name = "subCheck4";
            this.subCheck4.Size = new System.Drawing.Size(62, 17);
            this.subCheck4.TabIndex = 3;
            this.subCheck4.Text = "Subject";
            this.subCheck4.UseVisualStyleBackColor = true;
            this.subCheck4.CheckedChanged += new System.EventHandler(this.subCheck4_CheckedChanged);
            // 
            // rcCheck4
            // 
            this.rcCheck4.AutoSize = true;
            this.rcCheck4.Enabled = false;
            this.rcCheck4.Location = new System.Drawing.Point(431, 372);
            this.rcCheck4.Name = "rcCheck4";
            this.rcCheck4.Size = new System.Drawing.Size(72, 17);
            this.rcCheck4.TabIndex = 3;
            this.rcCheck4.Text = "Received";
            this.rcCheck4.UseVisualStyleBackColor = true;
            this.rcCheck4.CheckedChanged += new System.EventHandler(this.rcCheck4_CheckedChanged);
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(660, 635);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(75, 23);
            this.buildBtn.TabIndex = 9;
            this.buildBtn.Text = "Build";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // scoreNum
            // 
            this.scoreNum.DecimalPlaces = 1;
            this.scoreNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.scoreNum.Location = new System.Drawing.Point(420, 13);
            this.scoreNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.scoreNum.Name = "scoreNum";
            this.scoreNum.Size = new System.Drawing.Size(64, 20);
            this.scoreNum.TabIndex = 12;
            // 
            // btn_TopMost
            // 
            this.btn_TopMost.Location = new System.Drawing.Point(719, 16);
            this.btn_TopMost.Name = "btn_TopMost";
            this.btn_TopMost.Size = new System.Drawing.Size(75, 23);
            this.btn_TopMost.TabIndex = 13;
            this.btn_TopMost.Text = "Top Most";
            this.btn_TopMost.UseVisualStyleBackColor = true;
            this.btn_TopMost.Click += new System.EventHandler(this.btn_TopMost_Click);
            // 
            // FormRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 664);
            this.Controls.Add(this.btn_TopMost);
            this.Controls.Add(this.scoreNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.meta4Case);
            this.Controls.Add(this.meta3Case);
            this.Controls.Add(this.meta2Case);
            this.Controls.Add(this.meta1Case);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meta4Check);
            this.Controls.Add(this.meta3Check);
            this.Controls.Add(this.meta2Check);
            this.Controls.Add(this.metaCheck);
            this.Controls.Add(this.rxInput4);
            this.Controls.Add(this.rxInput3);
            this.Controls.Add(this.rxInput2);
            this.Controls.Add(this.rxInput1);
            this.Controls.Add(this.ruleNumber);
            this.Controls.Add(this.rcCheck4);
            this.Controls.Add(this.rcCheck3);
            this.Controls.Add(this.subCheck4);
            this.Controls.Add(this.rcCheck2);
            this.Controls.Add(this.subCheck3);
            this.Controls.Add(this.rcCheck1);
            this.Controls.Add(this.fromCheck4);
            this.Controls.Add(this.subCheck2);
            this.Controls.Add(this.fromCheck3);
            this.Controls.Add(this.subCheck1);
            this.Controls.Add(this.rbCheck4);
            this.Controls.Add(this.fromCheck2);
            this.Controls.Add(this.rbCheck3);
            this.Controls.Add(this.headCheck4);
            this.Controls.Add(this.fromCheck1);
            this.Controls.Add(this.headCheck3);
            this.Controls.Add(this.rbCheck2);
            this.Controls.Add(this.headCheck2);
            this.Controls.Add(this.rbCheck1);
            this.Controls.Add(this.headCheck1);
            this.Controls.Add(this.ruleOutput);
            this.Name = "FormRM";
            this.Text = "SA Rules";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ruleNumber_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void rbCheck_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbCheck1.Checked == true)
            {
                headCheck1.Checked = false;
                fromCheck1.Enabled = false;
                subCheck1.Enabled = false;
                rcCheck1.Enabled = false;
            }

            if (rbCheck1.Checked == false)
            {
                headCheck1.Checked = true;
            }
        }

        private void headCheck_CheckedChanged(object sender, System.EventArgs e)
        {
            if (headCheck1.Checked == true)
            {
                rbCheck1.Checked = false;
                fromCheck1.Enabled = true;
                subCheck1.Enabled = true;
                rcCheck1.Enabled = true;
            }
            if (headCheck1.Checked == false)
            {
                fromCheck1.Enabled = false;
                subCheck1.Enabled = false;
                rcCheck1.Enabled = false;
                rbCheck1.Checked = true;
            }
        }

        private void rbCheck2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbCheck2.Checked == true)
            {
                headCheck2.Checked = false;
                fromCheck2.Checked = false;
                fromCheck2.Enabled = false;
                subCheck2.Enabled = false;
                subCheck2.Checked = false;
                rcCheck2.Enabled = false;
                rcCheck2.Checked = false;
            }

            if (rbCheck2.Checked == false)
            {
                headCheck2.Checked = true;
            }

        }

        private void headCheck2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (headCheck2.Checked == true)
            {
                rbCheck2.Checked = false;
                fromCheck2.Enabled = true;
                subCheck2.Enabled = true;
                rcCheck2.Enabled = true;
            }

            if (headCheck2.Checked == false)
            {
                fromCheck2.Enabled = false;
                subCheck2.Enabled = false;
                rcCheck2.Enabled = false;
                rbCheck2.Checked = true;
            }
        }

        private void rbCheck3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbCheck3.Checked == true)
            {
                headCheck3.Checked = false;
                fromCheck3.Enabled = false;
                subCheck3.Enabled = false;
                rcCheck3.Enabled = false;
            }

            if (rbCheck3.Checked == false)
            {
                headCheck3.Checked = true;
            }
        }

        private void headCheck3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (headCheck3.Checked == true)
            {
                rbCheck3.Checked = false;
                fromCheck3.Enabled = true;
                subCheck3.Enabled = true;
                rcCheck3.Enabled = true;
            }

            if (headCheck3.Checked == false)
            {
                fromCheck3.Enabled = false;
                subCheck3.Enabled = false;
                rcCheck3.Enabled = false;
                rbCheck3.Checked = true;
            }

        }

        private void rbCheck4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbCheck4.Checked == true)
            {
                headCheck4.Checked = false;
                fromCheck4.Enabled = false;
                subCheck4.Enabled = false;
                rcCheck4.Enabled = false;
            }

            if (rbCheck4.Checked == false)
            {
                headCheck4.Checked = true;
            }
        }

        private void headCheck4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (headCheck4.Checked == true)
            {
                rbCheck4.Checked = false;
                fromCheck4.Enabled = true;
                subCheck4.Enabled = true;
                rcCheck4.Enabled = true;
            }

            if (headCheck4.Checked == false)
            {
                fromCheck4.Enabled = false;
                subCheck4.Enabled = false;
                rcCheck4.Enabled = false;
                rbCheck4.Checked = true;
            }

        }

        #endregion

        private System.Windows.Forms.TextBox ruleOutput;
        private System.Windows.Forms.CheckBox headCheck1;
        private System.Windows.Forms.CheckBox fromCheck1;
        private System.Windows.Forms.CheckBox rbCheck1;
        private System.Windows.Forms.CheckBox subCheck1;
        private System.Windows.Forms.CheckBox rcCheck1;
        private System.Windows.Forms.TextBox ruleNumber;
        private System.Windows.Forms.TextBox rxInput1;
        private System.Windows.Forms.CheckBox metaCheck;
        private System.Windows.Forms.TextBox rxInput2;
        private System.Windows.Forms.CheckBox meta2Check;
        private System.Windows.Forms.TextBox rxInput3;
        private System.Windows.Forms.CheckBox meta3Check;
        private System.Windows.Forms.TextBox rxInput4;
        private System.Windows.Forms.CheckBox meta4Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox meta1Case;
        private System.Windows.Forms.CheckBox meta2Case;
        private System.Windows.Forms.CheckBox meta3Case;
        private System.Windows.Forms.CheckBox meta4Case;
        private System.Windows.Forms.CheckBox headCheck2;
        private System.Windows.Forms.CheckBox rbCheck2;
        private System.Windows.Forms.CheckBox fromCheck2;
        private System.Windows.Forms.CheckBox subCheck2;
        private System.Windows.Forms.CheckBox rcCheck2;
        private System.Windows.Forms.CheckBox headCheck3;
        private System.Windows.Forms.CheckBox rbCheck3;
        private System.Windows.Forms.CheckBox fromCheck3;
        private System.Windows.Forms.CheckBox subCheck3;
        private System.Windows.Forms.CheckBox rcCheck3;
        private System.Windows.Forms.CheckBox headCheck4;
        private System.Windows.Forms.CheckBox rbCheck4;
        private System.Windows.Forms.CheckBox fromCheck4;
        private System.Windows.Forms.CheckBox subCheck4;
        private System.Windows.Forms.CheckBox rcCheck4;
        private System.Windows.Forms.Button buildBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown scoreNum;
        private System.Windows.Forms.Button btn_TopMost;
    }
}

