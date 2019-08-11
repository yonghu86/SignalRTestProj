namespace SignalRSelfHostWinFormClient
{
    partial class SignalRSelfHostWinFormClientTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.msgContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接收Signal服务端推送的消息：";
            // 
            // msgContent
            // 
            this.msgContent.Location = new System.Drawing.Point(14, 35);
            this.msgContent.Name = "msgContent";
            this.msgContent.Size = new System.Drawing.Size(605, 391);
            this.msgContent.TabIndex = 1;
            this.msgContent.Text = "";
            // 
            // SignalRSelfHostWinFormClientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.msgContent);
            this.Controls.Add(this.label1);
            this.Name = "SignalRSelfHostWinFormClientTest";
            this.Text = "SignalRSelfHost的WinForm客户端测试";
            this.Load += new System.EventHandler(this.SignalRSelfHostWinFormClientTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox msgContent;
    }
}

