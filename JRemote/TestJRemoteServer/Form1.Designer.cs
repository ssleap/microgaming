namespace TestRemoteServer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSPort = new System.Windows.Forms.TextBox();
            this.btnSOpen = new System.Windows.Forms.Button();
            this.btnSClose = new System.Windows.Forms.Button();
            this.ckSContinue = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.jRemoteServer1 = new JRemoteServer.JRemoteServer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSPort
            // 
            this.txtSPort.Location = new System.Drawing.Point(182, 10);
            this.txtSPort.Name = "txtSPort";
            this.txtSPort.Size = new System.Drawing.Size(100, 21);
            this.txtSPort.TabIndex = 1;
            this.txtSPort.Text = "9999";
            // 
            // btnSOpen
            // 
            this.btnSOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSOpen.Location = new System.Drawing.Point(298, 8);
            this.btnSOpen.Name = "btnSOpen";
            this.btnSOpen.Size = new System.Drawing.Size(83, 23);
            this.btnSOpen.TabIndex = 2;
            this.btnSOpen.Text = "시작";
            this.btnSOpen.UseVisualStyleBackColor = true;
            this.btnSOpen.Click += new System.EventHandler(this.btnSOpen_Click);
            // 
            // btnSClose
            // 
            this.btnSClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSClose.Location = new System.Drawing.Point(391, 8);
            this.btnSClose.Name = "btnSClose";
            this.btnSClose.Size = new System.Drawing.Size(83, 23);
            this.btnSClose.TabIndex = 3;
            this.btnSClose.Text = "중지";
            this.btnSClose.UseVisualStyleBackColor = true;
            this.btnSClose.Click += new System.EventHandler(this.btnSClose_Click);
            // 
            // ckSContinue
            // 
            this.ckSContinue.AutoSize = true;
            this.ckSContinue.Checked = true;
            this.ckSContinue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSContinue.Location = new System.Drawing.Point(14, 12);
            this.ckSContinue.Name = "ckSContinue";
            this.ckSContinue.Size = new System.Drawing.Size(76, 16);
            this.ckSContinue.TabIndex = 5;
            this.ckSContinue.Text = "서버 유지";
            this.ckSContinue.UseVisualStyleBackColor = true;
            this.ckSContinue.CheckedChanged += new System.EventHandler(this.ckSContinue_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 37);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(462, 84);
            this.txtLog.TabIndex = 6;
            // 
            // jRemoteServer1
            // 
            this.jRemoteServer1.Location = new System.Drawing.Point(109, 6);
            this.jRemoteServer1.Name = "jRemoteServer1";
            this.jRemoteServer1.Size = new System.Drawing.Size(23, 25);
            this.jRemoteServer1.TabIndex = 4;
            this.jRemoteServer1.JRemoteServerClosed += new System.EventHandler(this.jRemoteServer1_JRemoteServerClosed);
            this.jRemoteServer1.JRemoteServerOpen += new System.EventHandler(this.jRemoteServer1_JRemoteServerOpen);
            this.jRemoteServer1.JRemoteServerConnected += new JRemoteServer.JRemoteServer.SocketEventHandler(this.jRemoteServer1_JRemoteServerConnected);
            this.jRemoteServer1.JRemoteServerDisConnected += new System.EventHandler(this.jRemoteServer1_JRemoteServerDisConnected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.ckSContinue);
            this.Controls.Add(this.jRemoteServer1);
            this.Controls.Add(this.btnSClose);
            this.Controls.Add(this.btnSOpen);
            this.Controls.Add(this.txtSPort);
            this.Name = "Form1";
            this.Text = "JRemoteServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSPort;
        private System.Windows.Forms.Button btnSOpen;
        private System.Windows.Forms.Button btnSClose;
        private JRemoteServer.JRemoteServer jRemoteServer1;
        private System.Windows.Forms.CheckBox ckSContinue;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
    }
}

