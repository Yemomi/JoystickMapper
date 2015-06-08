namespace JoystickMapper
{
    partial class JoystickMapper
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
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(212, 12);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(235, 224);
            this.rtbReport.TabIndex = 0;
            this.rtbReport.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 212);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(193, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 12;
            this.lbDevices.Location = new System.Drawing.Point(12, 12);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(193, 196);
            this.lbDevices.TabIndex = 3;
            // 
            // JoystickMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 248);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtbReport);
            this.Name = "JoystickMapper";
            this.Text = "JoystickMapper";
            this.Load += new System.EventHandler(this.FrmJoystickMapper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lbDevices;
    }
}

