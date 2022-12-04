namespace TCPServer
{
    partial class TCPServer
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
            this.components = new System.ComponentModel.Container();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHeartBeatRate = new System.Windows.Forms.TextBox();
            this.lbPerSec = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.cbHeartBeat = new System.Windows.Forms.CheckBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.timerHeartBeat = new System.Windows.Forms.Timer(this.components);
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tbPort);
            this.gbServer.Controls.Add(this.tbHeartBeatRate);
            this.gbServer.Controls.Add(this.lbPerSec);
            this.gbServer.Controls.Add(this.lbPort);
            this.gbServer.Controls.Add(this.cbHeartBeat);
            this.gbServer.Controls.Add(this.btnListen);
            this.gbServer.Controls.Add(this.tbMonitor);
            this.gbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServer.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbServer.Location = new System.Drawing.Point(0, 0);
            this.gbServer.Margin = new System.Windows.Forms.Padding(4);
            this.gbServer.Name = "gbServer";
            this.gbServer.Padding = new System.Windows.Forms.Padding(4);
            this.gbServer.Size = new System.Drawing.Size(548, 427);
            this.gbServer.TabIndex = 1;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPort.Location = new System.Drawing.Point(41, 391);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(52, 25);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "3405";
            // 
            // tbHeartBeatRate
            // 
            this.tbHeartBeatRate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbHeartBeatRate.Location = new System.Drawing.Point(210, 391);
            this.tbHeartBeatRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeartBeatRate.Name = "tbHeartBeatRate";
            this.tbHeartBeatRate.Size = new System.Drawing.Size(32, 25);
            this.tbHeartBeatRate.TabIndex = 4;
            this.tbHeartBeatRate.Text = "30";
            // 
            // lbPerSec
            // 
            this.lbPerSec.AutoSize = true;
            this.lbPerSec.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPerSec.Location = new System.Drawing.Point(241, 395);
            this.lbPerSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPerSec.Name = "lbPerSec";
            this.lbPerSec.Size = new System.Drawing.Size(52, 17);
            this.lbPerSec.TabIndex = 8;
            this.lbPerSec.Text = "per/sec";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPort.Location = new System.Drawing.Point(8, 395);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 7;
            this.lbPort.Text = "Port";
            // 
            // cbHeartBeat
            // 
            this.cbHeartBeat.AutoSize = true;
            this.cbHeartBeat.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbHeartBeat.Location = new System.Drawing.Point(126, 393);
            this.cbHeartBeat.Margin = new System.Windows.Forms.Padding(4);
            this.cbHeartBeat.Name = "cbHeartBeat";
            this.cbHeartBeat.Size = new System.Drawing.Size(88, 21);
            this.cbHeartBeat.TabIndex = 5;
            this.cbHeartBeat.Text = "HeartBeat";
            this.cbHeartBeat.UseVisualStyleBackColor = true;
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListen.Location = new System.Drawing.Point(435, 388);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 30);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
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
            // timerHeartBeat
            // 
            this.timerHeartBeat.Tick += new System.EventHandler(this.timerHeartBeat_Tick);
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 427);
            this.Controls.Add(this.gbServer);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPServer";
            this.Text = "TCP Test - Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCPServer_FormClosed);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label lbPerSec;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.CheckBox cbHeartBeat;
        private System.Windows.Forms.TextBox tbHeartBeatRate;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.Timer timerHeartBeat;
    }
}

