namespace RandomNumber
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumOfNums = new System.Windows.Forms.NumericUpDown();
            this.MaxNumber = new System.Windows.Forms.NumericUpDown();
            this.MinNumber = new System.Windows.Forms.NumericUpDown();
            this.NumOfNumLabel = new System.Windows.Forms.Label();
            this.MinNumLabel = new System.Windows.Forms.Label();
            this.MaxNumlabel = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.OutNumber = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // NumOfNums
            // 
            this.NumOfNums.Location = new System.Drawing.Point(303, 38);
            this.NumOfNums.Name = "NumOfNums";
            this.NumOfNums.Size = new System.Drawing.Size(71, 21);
            this.NumOfNums.TabIndex = 10;
            this.NumOfNums.ValueChanged += new System.EventHandler(this.NumOfNums_ValueChanged);
            // 
            // MaxNumber
            // 
            this.MaxNumber.Location = new System.Drawing.Point(303, 78);
            this.MaxNumber.Name = "MaxNumber";
            this.MaxNumber.Size = new System.Drawing.Size(71, 21);
            this.MaxNumber.TabIndex = 11;
            this.MaxNumber.ValueChanged += new System.EventHandler(this.MaxNumber_ValueChanged);
            // 
            // MinNumber
            // 
            this.MinNumber.Location = new System.Drawing.Point(303, 118);
            this.MinNumber.Name = "MinNumber";
            this.MinNumber.Size = new System.Drawing.Size(71, 21);
            this.MinNumber.TabIndex = 12;
            this.MinNumber.ValueChanged += new System.EventHandler(this.MinNumber_ValueChanged);
            // 
            // NumOfNumLabel
            // 
            this.NumOfNumLabel.AutoSize = true;
            this.NumOfNumLabel.Location = new System.Drawing.Point(86, 40);
            this.NumOfNumLabel.Name = "NumOfNumLabel";
            this.NumOfNumLabel.Size = new System.Drawing.Size(143, 12);
            this.NumOfNumLabel.TabIndex = 13;
            this.NumOfNumLabel.Text = "Number Of Numbers(1-10)";
            this.NumOfNumLabel.Click += new System.EventHandler(this.NumOfNumLabel_Click);
            // 
            // MinNumLabel
            // 
            this.MinNumLabel.AutoSize = true;
            this.MinNumLabel.Location = new System.Drawing.Point(86, 120);
            this.MinNumLabel.Name = "MinNumLabel";
            this.MinNumLabel.Size = new System.Drawing.Size(131, 12);
            this.MinNumLabel.TabIndex = 14;
            this.MinNumLabel.Text = "MinNumber(-1000-1000)";
            this.MinNumLabel.Click += new System.EventHandler(this.MinNumLabel_Click);
            // 
            // MaxNumlabel
            // 
            this.MaxNumlabel.AutoSize = true;
            this.MaxNumlabel.Location = new System.Drawing.Point(86, 80);
            this.MaxNumlabel.Name = "MaxNumlabel";
            this.MaxNumlabel.Size = new System.Drawing.Size(131, 12);
            this.MaxNumlabel.TabIndex = 15;
            this.MaxNumlabel.Text = "MaxNumber(-1000-1000)";
            this.MaxNumlabel.Click += new System.EventHandler(this.MaxNumlabel_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(86, 160);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 16;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(299, 160);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // OutNumber
            // 
            this.OutNumber.FormattingEnabled = true;
            this.OutNumber.ItemHeight = 12;
            this.OutNumber.Location = new System.Drawing.Point(86, 240);
            this.OutNumber.Name = "OutNumber";
            this.OutNumber.Size = new System.Drawing.Size(292, 16);
            this.OutNumber.TabIndex = 18;
            this.OutNumber.SelectedIndexChanged += new System.EventHandler(this.OutNumber_SelectedIndexChanged);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(86, 200);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 23);
            this.Info.TabIndex = 24;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Infor_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close.Location = new System.Drawing.Point(299, 200);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 25;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 296);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.OutNumber);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.MaxNumlabel);
            this.Controls.Add(this.MinNumLabel);
            this.Controls.Add(this.NumOfNumLabel);
            this.Controls.Add(this.MinNumber);
            this.Controls.Add(this.MaxNumber);
            this.Controls.Add(this.NumOfNums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RandomNumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.NumOfNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumOfNums;
        private System.Windows.Forms.NumericUpDown MaxNumber;
        private System.Windows.Forms.NumericUpDown MinNumber;
        private System.Windows.Forms.Label NumOfNumLabel;
        private System.Windows.Forms.Label MinNumLabel;
        private System.Windows.Forms.Label MaxNumlabel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ListBox OutNumber;
        private System.Windows.Forms.Button Close;
        public System.Windows.Forms.Button Info;
    }
}

