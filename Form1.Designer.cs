namespace 转换工具集
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToIP = new System.Windows.Forms.Button();
            this.btnToVersion = new System.Windows.Forms.Button();
            this.btnToLocalTime = new System.Windows.Forms.Button();
            this.btnToUTCTime = new System.Windows.Forms.Button();
            this.btnUTCToInt = new System.Windows.Forms.Button();
            this.btnLocalTimeToInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "待转换";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 21);
            this.textBox1.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(73, 46);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(343, 21);
            this.txtResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结果";
            // 
            // btnToIP
            // 
            this.btnToIP.Location = new System.Drawing.Point(103, 73);
            this.btnToIP.Name = "btnToIP";
            this.btnToIP.Size = new System.Drawing.Size(75, 23);
            this.btnToIP.TabIndex = 4;
            this.btnToIP.Text = "转IP";
            this.btnToIP.UseVisualStyleBackColor = true;
            this.btnToIP.Click += new System.EventHandler(this.btnToIP_Click);
            // 
            // btnToVersion
            // 
            this.btnToVersion.Location = new System.Drawing.Point(184, 73);
            this.btnToVersion.Name = "btnToVersion";
            this.btnToVersion.Size = new System.Drawing.Size(75, 23);
            this.btnToVersion.TabIndex = 5;
            this.btnToVersion.Text = "转版本";
            this.btnToVersion.UseVisualStyleBackColor = true;
            this.btnToVersion.Click += new System.EventHandler(this.btnToVersion_Click);
            // 
            // btnToLocalTime
            // 
            this.btnToLocalTime.Location = new System.Drawing.Point(265, 73);
            this.btnToLocalTime.Name = "btnToLocalTime";
            this.btnToLocalTime.Size = new System.Drawing.Size(75, 23);
            this.btnToLocalTime.TabIndex = 6;
            this.btnToLocalTime.Text = "转本地时间";
            this.btnToLocalTime.UseVisualStyleBackColor = true;
            this.btnToLocalTime.Click += new System.EventHandler(this.btnToTime_Click);
            // 
            // btnToUTCTime
            // 
            this.btnToUTCTime.Location = new System.Drawing.Point(103, 102);
            this.btnToUTCTime.Name = "btnToUTCTime";
            this.btnToUTCTime.Size = new System.Drawing.Size(75, 23);
            this.btnToUTCTime.TabIndex = 7;
            this.btnToUTCTime.Text = "转UTC时间";
            this.btnToUTCTime.UseVisualStyleBackColor = true;
            this.btnToUTCTime.Click += new System.EventHandler(this.btnToUTCTime_Click);
            // 
            // btnUTCToInt
            // 
            this.btnUTCToInt.Location = new System.Drawing.Point(184, 102);
            this.btnUTCToInt.Name = "btnUTCToInt";
            this.btnUTCToInt.Size = new System.Drawing.Size(75, 23);
            this.btnUTCToInt.TabIndex = 8;
            this.btnUTCToInt.Text = "UTC转整数";
            this.btnUTCToInt.UseVisualStyleBackColor = true;
            this.btnUTCToInt.Click += new System.EventHandler(this.btnUTCToInt_Click);
            // 
            // btnLocalTimeToInt
            // 
            this.btnLocalTimeToInt.Location = new System.Drawing.Point(265, 102);
            this.btnLocalTimeToInt.Name = "btnLocalTimeToInt";
            this.btnLocalTimeToInt.Size = new System.Drawing.Size(75, 23);
            this.btnLocalTimeToInt.TabIndex = 9;
            this.btnLocalTimeToInt.Text = "本地转整数";
            this.btnLocalTimeToInt.UseVisualStyleBackColor = true;
            this.btnLocalTimeToInt.Click += new System.EventHandler(this.btnLocalTimeToInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 139);
            this.Controls.Add(this.btnLocalTimeToInt);
            this.Controls.Add(this.btnUTCToInt);
            this.Controls.Add(this.btnToUTCTime);
            this.Controls.Add(this.btnToLocalTime);
            this.Controls.Add(this.btnToVersion);
            this.Controls.Add(this.btnToIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转换工具集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToIP;
        private System.Windows.Forms.Button btnToVersion;
        private System.Windows.Forms.Button btnToLocalTime;
        private System.Windows.Forms.Button btnToUTCTime;
        private System.Windows.Forms.Button btnUTCToInt;
        private System.Windows.Forms.Button btnLocalTimeToInt;
    }
}

