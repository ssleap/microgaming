using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRemoteServer
{
    public partial class Form1 : Form
    {
        //컨트롤에 접근하기 위한 delegate
        private delegate void UIDelegate(Control aControl,String aStr);
        public Form1()
        {
            InitializeComponent();           
        }

        #region [Event]
        //폼 로드 컨트롤 셋팅
        private void Form1_Load(object sender, EventArgs e)
        {
            ControlSetting(!jRemoteServer1.IsStarted);
        }

        //서버 시작
        private void btnSOpen_Click(object sender, EventArgs e)
        {
            this.jRemoteServer1.ServicePort = this.txtSPort.Text;//서버포트
            this.jRemoteServer1.IsContinue = this.ckSContinue.Checked;//서버 유지
            if (!jRemoteServer1.IsStarted)//서버 중지 상태라면 시작
            {
                this.jRemoteServer1.Start();
            }
            ControlSetting(jRemoteServer1.IsStarted);
        }

        //서버 중지
        private void btnSClose_Click(object sender, EventArgs e)
        {
            if (jRemoteServer1.IsStarted)//서버 시작 상태라면 중지
            {
                this.jRemoteServer1.Stop();
            }
        }

        //폼 닫을시 서버 중지
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (jRemoteServer1.IsStarted)//서버 시작 상태라면 중지
            {
                this.jRemoteServer1.Stop();
            }            
        }

        //서버 유지체크박스
        private void ckSContinue_CheckedChanged(object sender, EventArgs e)
        {
            this.jRemoteServer1.IsContinue = this.ckSContinue.Checked;
        }
        #endregion [~Event]

        #region [JRemoteServerEvent]
        //서버 시작 이벤트
        private void jRemoteServer1_JRemoteServerOpen(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 서버 오픈 이벤트" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 서버 오픈 이벤트");
            }
        }

        //클라이언트 접속해제 이벤트
        private void jRemoteServer1_JRemoteServerDisConnected(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속해제 이벤트" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속해제 이벤트");
            }

        }

        //클라이언트 접속 이벤트
        private void jRemoteServer1_JRemoteServerConnected(object aSender, JRemoteServer.SocketEventArgs aSocketEventArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속 이벤트[" + aSocketEventArgs.fClientInfo + "]" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속 이벤트[" + aSocketEventArgs.fClientInfo + "]");
            }
        }

        //서버중지 이벤트
        private void jRemoteServer1_JRemoteServerClosed(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 서버 중지 이벤트" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 서버 중지 이벤트");
            }
        }
        #endregion [~JRemoteServerEvent]

        #region [Methods]
        //컨트롤에 접근하기 위한 delegate관련
        private void TextSet(Control aControl, String aString)
        {
            (aControl as TextBox).AppendText(aString+ "\r\n");
        }

        //컨트롤 셋팅 (서버상태에 따라 활성/비활성)
        private void ControlSetting(Boolean aServerStatus)
        {
            this.ckSContinue.Enabled = aServerStatus;
            this.txtSPort.Enabled = aServerStatus;
            this.btnSOpen.Enabled = aServerStatus;
            this.btnSClose.Enabled = !aServerStatus;
        }
        #endregion [~Methods]
    }
}
