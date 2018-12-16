using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestClientViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //접속
        private void btnCOpen_Click(object sender, EventArgs e)
        {
            jRemoteViewer1.IsDomain = rdDomain.Checked;//서버주소를 도메인으로 입력할건지 ip로 입력할건지
            jRemoteViewer1.SetConnectionString = this.txtCAddr.Text;//서버 주소
            jRemoteViewer1.SetPort = this.txtCPort.Text;//서버 포트
            if (!jRemoteViewer1.IsConnected)//현재 접속상태가 아니면 접속함
            {
                jRemoteViewer1.Connect();
            }
        }

        //해제
        private void btnCClose_Click(object sender, EventArgs e)
        {
            if (jRemoteViewer1.IsConnected)//현재 접속상태면 해제함
            {
                jRemoteViewer1.DisConnect();
            }
        }

        //서버 접속해제 이벤트
        private void jRemoteViewer1_JRemoteClientClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("중지 이벤트");
        }

        //서버 접속 이벤트
        private void jRemoteViewer1_JRemoteClientOpen(object sender, EventArgs e)
        {
            //MessageBox.Show("접속 이벤트");
        }
    }
}
