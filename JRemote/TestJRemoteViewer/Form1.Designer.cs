namespace TestClientViewer
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
            this.btnCOpen = new System.Windows.Forms.Button();
            this.txtCAddr = new System.Windows.Forms.TextBox();
            this.txtCPort = new System.Windows.Forms.TextBox();
            this.btnCClose = new System.Windows.Forms.Button();
            this.rdIPAddr = new System.Windows.Forms.RadioButton();
            this.rdDomain = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jRemoteViewer1 = new JRemoteClient.JRemoteViewer();
            this.SuspendLayout();
            // 
            // btnCOpen
            // 
            this.btnCOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOpen.Location = new System.Drawing.Point(579, 9);
            this.btnCOpen.Name = "btnCOpen";
            this.btnCOpen.Size = new System.Drawing.Size(75, 23);
            this.btnCOpen.TabIndex = 1;
            this.btnCOpen.Text = "접속";
            this.btnCOpen.UseVisualStyleBackColor = true;
            this.btnCOpen.Click += new System.EventHandler(this.btnCOpen_Click);
            // 
            // txtCAddr
            // 
            this.txtCAddr.Location = new System.Drawing.Point(220, 11);
            this.txtCAddr.Name = "txtCAddr";
            this.txtCAddr.Size = new System.Drawing.Size(129, 21);
            this.txtCAddr.TabIndex = 2;
            this.txtCAddr.Text = "192.168.0.5";
            // 
            // txtCPort
            // 
            this.txtCPort.Location = new System.Drawing.Point(446, 11);
            this.txtCPort.Name = "txtCPort";
            this.txtCPort.Size = new System.Drawing.Size(55, 21);
            this.txtCPort.TabIndex = 2;
            this.txtCPort.Text = "9999";
            // 
            // btnCClose
            // 
            this.btnCClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCClose.Location = new System.Drawing.Point(660, 9);
            this.btnCClose.Name = "btnCClose";
            this.btnCClose.Size = new System.Drawing.Size(75, 23);
            this.btnCClose.TabIndex = 1;
            this.btnCClose.Text = "해제";
            this.btnCClose.UseVisualStyleBackColor = true;
            this.btnCClose.Click += new System.EventHandler(this.btnCClose_Click);
            // 
            // rdIPAddr
            // 
            this.rdIPAddr.AutoSize = true;
            this.rdIPAddr.Checked = true;
            this.rdIPAddr.Location = new System.Drawing.Point(12, 12);
            this.rdIPAddr.Name = "rdIPAddr";
            this.rdIPAddr.Size = new System.Drawing.Size(34, 16);
            this.rdIPAddr.TabIndex = 4;
            this.rdIPAddr.TabStop = true;
            this.rdIPAddr.Text = "IP";
            this.rdIPAddr.UseVisualStyleBackColor = true;
            // 
            // rdDomain
            // 
            this.rdDomain.AutoSize = true;
            this.rdDomain.Location = new System.Drawing.Point(52, 12);
            this.rdDomain.Name = "rdDomain";
            this.rdDomain.Size = new System.Drawing.Size(66, 16);
            this.rdDomain.TabIndex = 5;
            this.rdDomain.Text = "Domain";
            this.rdDomain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "서버주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // jRemoteViewer1
            // 
            this.jRemoteViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jRemoteViewer1.Location = new System.Drawing.Point(12, 38);
            this.jRemoteViewer1.Name = "jRemoteViewer1";
            this.jRemoteViewer1.Size = new System.Drawing.Size(720, 464);
            this.jRemoteViewer1.TabIndex = 3;
            this.jRemoteViewer1.JRemoteClientClosed += new System.EventHandler(this.jRemoteViewer1_JRemoteClientClosed);
            this.jRemoteViewer1.JRemoteClientOpen += new System.EventHandler(this.jRemoteViewer1_JRemoteClientOpen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdDomain);
            this.Controls.Add(this.rdIPAddr);
            this.Controls.Add(this.jRemoteViewer1);
            this.Controls.Add(this.txtCPort);
            this.Controls.Add(this.txtCAddr);
            this.Controls.Add(this.btnCClose);
            this.Controls.Add(this.btnCOpen);
            this.Name = "Form1";
            this.Text = "JRemoteViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCOpen;
        private System.Windows.Forms.TextBox txtCAddr;
        private System.Windows.Forms.TextBox txtCPort;
        private System.Windows.Forms.Button btnCClose;
        private JRemoteClient.JRemoteViewer jRemoteViewer1;
        private System.Windows.Forms.RadioButton rdIPAddr;
        private System.Windows.Forms.RadioButton rdDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

