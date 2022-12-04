namespace TCPClient
{
    partial class TCPClient
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.cbmConnection = new System.Windows.Forms.ComboBox();
            this.lbConnection = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMonitor
            // 
            this.tbMonitor.BackColor = System.Drawing.Color.Black;
            this.tbMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMonitor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonitor.ForeColor = System.Drawing.Color.Lime;
            this.tbMonitor.Location = new System.Drawing.Point(4, 22);
            this.tbMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMonitor.Size = new System.Drawing.Size(540, 350);
            this.tbMonitor.TabIndex = 1;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.cbmConnection);
            this.gbClient.Controls.Add(this.lbConnection);
            this.gbClient.Controls.Add(this.tbPort);
            this.gbClient.Controls.Add(this.tbIP);
            this.gbClient.Controls.Add(this.lbMessage);
            this.gbClient.Controls.Add(this.lbPort);
            this.gbClient.Controls.Add(this.btnSend);
            this.gbClient.Controls.Add(this.tbMonitor);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbClient.Location = new System.Drawing.Point(0, 0);
            this.gbClient.Margin = new System.Windows.Forms.Padding(4);
            this.gbClient.Name = "gbClient";
            this.gbClient.Padding = new System.Windows.Forms.Padding(4);
            this.gbClient.Size = new System.Drawing.Size(548, 427);
            this.gbClient.TabIndex = 2;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // cbmConnection
            // 
            this.cbmConnection.FormattingEnabled = true;
            this.cbmConnection.Items.AddRange(new object[] {
            "Short",
            "Long"});
            this.cbmConnection.Location = new System.Drawing.Point(336, 391);
            this.cbmConnection.Name = "cbmConnection";
            this.cbmConnection.Size = new System.Drawing.Size(80, 25);
            this.cbmConnection.TabIndex = 10;
            // 
            // lbConnection
            // 
            this.lbConnection.AutoSize = true;
            this.lbConnection.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbConnection.Location = new System.Drawing.Point(259, 395);
            this.lbConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConnection.Name = "lbConnection";
            this.lbConnection.Size = new System.Drawing.Size(78, 17);
            this.lbConnection.TabIndex = 9;
            this.lbConnection.Text = "Connection";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPort.Location = new System.Drawing.Point(168, 391);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(52, 25);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "3405";
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbIP.Location = new System.Drawing.Point(27, 391);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 25);
            this.tbIP.TabIndex = 4;
            this.tbIP.Text = "10.0.2.15";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMessage.Location = new System.Drawing.Point(8, 395);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(20, 17);
            this.lbMessage.TabIndex = 8;
            this.lbMessage.Text = "IP";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPort.Location = new System.Drawing.Point(135, 395);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 7;
            this.lbPort.Text = "Port";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(440, 388);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 427);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPClient";
            this.Text = "TCP Test - Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCPClient_FormClosed);
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbmConnection;
        private System.Windows.Forms.Label lbConnection;
    }
}

