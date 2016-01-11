using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace RobotControllerPC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        ConnectionData cnn;
        RobotController rc;
        bool moveWaiting;
        private void FormMain_Load(object sender, EventArgs e)
        {
            cnn = new ConnectionData();
            rc = new RobotController();
            //
            nowPosition = new Point(pictureBoxField.Width / 2, pictureBoxField.Height / 2);
            previousPosition = new Point(pictureBoxField.Width / 2, pictureBoxField.Height / 2);
            rad = 0;
            moveWaiting = false;
            //
            pictureBoxField.MouseDown += pictureBoxField_MouseDown;
            pictureBoxField.MouseMove += pictureBoxField_MouseMove;
            pictureBoxField.MouseUp += pictureBoxField_MouseUp;
            pictureBoxField.Paint += pictureBoxField_Paint;
        }
       
        private void buttonConn_Click(object sender, EventArgs e)
        {
            if (rc.isOpen)
            {
                rc.close();
                this.buttonConn.Text = "接続";
            }
            else
            {
                rc.open(cnn);
                this.buttonConn.Text = "切断";
                
            }
        }
        ConnectionSetiing cnnDlg;
        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnnDlg = new ConnectionSetiing();
            cnnDlg.data = cnn;
            cnnDlg.ShowDialog();
        }

        private void tabPageCmd_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonModePWM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModePWM.Checked)
            {
                rc.send("@mw");
            }
        }

        private void radioButtonModeSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModeSpeed.Checked)
            {
                rc.send("@ms");
            }
        }

        private void radioButtonModePosition_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModePosition.Checked)
            {
                rc.send("@mp");
            }
        }

        private void buttonLRCmd_Click(object sender, EventArgs e)
        {
            if (radioButtonModePWM.Checked)
            {
                rc.send("@lw" + this.textBoxL.Text);
                rc.send("@rw" + this.textBoxR.Text);
            }
            else if (radioButtonModeSpeed.Checked)
            {
                
            }
            else if (radioButtonModePosition.Checked)
            {
                
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            int param;
            try
            {
                param = int.Parse(this.textBoxPosition.Text);
            }
            catch
            {
                param = 0;
            }
            if (radioButtonModeSpeed.Checked)
            {
                rc.send("@fs"+param.ToString());
            }
            else if (radioButtonModePosition.Checked)
            {
                rc.send("@fp" + param.ToString());
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            int param;
            try
            {
                param = -int.Parse(this.textBoxPosition.Text);
            }
            catch
            {
                param = 0;
            }
            //
            if (radioButtonModeSpeed.Checked)
            {
                rc.send("@fs" + param.ToString());
            }
            else if (radioButtonModePosition.Checked)
            {
                rc.send("@fp" + param.ToString());
            }
            //
        }

        private void buttonLTurn_Click(object sender, EventArgs e)
        {
            int param;
            try
            {
                param = int.Parse(this.textBoxPosition.Text);
            }
            catch
            {
                param = 0;
            }
            if (radioButtonModeSpeed.Checked)
            {
                rc.send("@ts" + param.ToString());
            }
            else if (radioButtonModePosition.Checked)
            {
                rc.send("@tp" + param.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int param;
            try
            {
                param = -int.Parse(this.textBoxPosition.Text);
            }catch{
                param = 0;
            }
            if (radioButtonModeSpeed.Checked)
            {
                rc.send("@ts" + param.ToString());
            }
            else if (radioButtonModePosition.Checked)
            {
                rc.send("@tp" + param.ToString());
            }
        }
        bool relativeModeDragFlag = false;
        private void pictureBoxField_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxAbsMode.Checked)
            {
                if (!moveWaiting)
                {
                    previousPosition = nowPosition;
                    nowPosition = new Point(e.X, e.Y);
                    Point v = new Point(nowPosition.X - previousPosition.X, nowPosition.Y - previousPosition.Y);
                    double r = Math.Atan2(-v.Y, -v.X);
                    int turn = (int)(-(r - rad) * 180 / Math.PI);
                    if (turn > 180)
                    {
                        turn = turn - 360;
                    }
                    if (turn < -180)
                    {
                        turn = 360 + turn;
                    }
                    labelRoll.Text = turn.ToString();
                    rad = r;

                    if (rc.isOpen)
                    {
                        rc.send("@mp");
                        rc.send("@tp" + turn.ToString());
                        //
                        timerMoveWait.Enabled = true;
                        moveWaiting = true;
                        moveState = 0;
                        distance = Math.Sqrt((v.X * v.X) + (v.Y * v.Y));
                    }
                    //
                    pictureBoxField.Invalidate();
                }
            }
            else
            {
                basePosition = new Point(e.X, e.Y);
                if (rc.isOpen)
                {
                    rc.send("@mw");
                }
                timerSendMsg.Enabled = true;
                relativeModeDragFlag = true;
            }
        }
        private void pictureBoxField_MouseMove(object sender, MouseEventArgs e)
        {
            if (!checkBoxAbsMode.Checked && relativeModeDragFlag)
            {
                nowPosition = new Point(e.X, e.Y);
                pictureBoxField.Invalidate();
            }
        }
        private void pictureBoxField_MouseUp(object sender, MouseEventArgs e)
        {
            relativeModeDragFlag = false;
            if (rc.isOpen)
            {
                rc.send("@lw0");
                rc.send("@rw0");
            }
            timerSendMsg.Enabled = false;
            pictureBoxField.Invalidate();
        }
        private void pictureBoxField_Click(object sender, EventArgs e)
        {
            
        }
        int moveState;
        double rad;
        double distance;
        Point nowPosition;
        Point previousPosition;
        //
        Point basePosition;
        //
        //PictureBox1のPaintイベントハンドラ
        private void pictureBoxField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color cl = Color.FromArgb(0xff, 0x00, 0x00, 0xff);
            Pen pen = new Pen(cl);
            {
                Point s = new Point(0, pictureBoxField.Height / 2);
                Point t = new Point(pictureBoxField.Width, pictureBoxField.Height / 2);
                g.DrawLine(pen, s, t);
            }
            {
                Point s = new Point(pictureBoxField.Width/2, 0);
                Point t = new Point(pictureBoxField.Width/2, pictureBoxField.Height);
                g.DrawLine(pen, s, t);
            }
            int r=10;
            g.DrawEllipse(pen,new Rectangle(nowPosition.X-r,nowPosition.Y-r,2*r,2*r));
            if (!checkBoxAbsMode.Checked && relativeModeDragFlag)
            {
                r = 5;
                g.DrawEllipse(pen, new Rectangle(basePosition.X - r, basePosition.Y - r, 2 * r, 2 * r));
                Point s = basePosition;
                Point t = nowPosition;
                g.DrawLine(pen, s, t);
            }
        }
        private void timerSendMsg_Tick(object sender, EventArgs e)
        {
            if (rc.isOpen)
            {
                Point s = basePosition;
                Point t = nowPosition;
                int dx = t.X - s.X;
                int dy = -(t.Y - s.Y);
                int lw = ((dy + dx / 2) / 5);
                int rw = ((dy - dx / 2) / 5);
                rc.send("@lw" + lw.ToString());
                rc.send("@rw" + rw.ToString());
                labelMsg.Text = "send:" + lw.ToString()+","+rw.ToString();
            }
        }
        private void timerMoveWait_Tick(object sender, EventArgs e)
        {
            if (!checkBoxAbsMode.Checked && relativeModeDragFlag)
            {
            }
            rc.send("@st");
            int st;
            try
            {
                st = int.Parse(rc.recv());
            }
            catch
            {
                st = -1;
            }
            labelMsg.Text = "wait:"+st.ToString();
            if (st == 0)
            {
                if (moveState == 0)
                {
                    int d=(int)distance/30;
                    rc.send("@fp" + d.ToString());
                    moveState = 1;
                }
                else
                {
                    timerMoveWait.Enabled = false;
                    moveWaiting = false;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (!moveWaiting)
            {
                nowPosition = new Point(pictureBoxField.Width / 2, pictureBoxField.Height / 2);
                previousPosition = new Point(pictureBoxField.Width / 2, pictureBoxField.Height / 2);
                rad = 0;
            }
        }

        private void buttonFileRef_Click(object sender, EventArgs e)
        {
            this.openFileDialogSendFile.FileName = this.textBoxFileRef.Text;
            this.openFileDialogSendFile.ShowDialog();
            this.textBoxFileRef.Text = this.openFileDialogSendFile.FileName;
            FileStream fs = new FileStream(textBoxFileRef.Text, FileMode.Open, FileAccess.Read);
            int fileSize = (int)fs.Length; // ファイルのサイズ
            fs.Dispose();
            labelFileSize.Text = @"ファイルサイズ：" + fileSize.ToString();
        }

        private void buttonWavFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBoxFileRef.Text, FileMode.Open, FileAccess.Read);
            int fileSize = (int)fs.Length; // ファイルのサイズ
            int size = 200;
            byte[] buf = new byte[size]; // データ格納用配列
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            //文字列をByte型配列に変換
            byte[] sendBytes = enc.GetBytes("@sn");
            byte[] sizeArr = new byte[7];
            sizeArr[0] = sendBytes[0];
            sizeArr[1] = sendBytes[1];
            sizeArr[2] = sendBytes[2];
            sizeArr[3] = (byte)((fileSize >> 24)&0xff);
            sizeArr[4] = (byte)((fileSize >> 16)&0xff);
            sizeArr[5] = (byte)((fileSize >>  8)&0xff);
            sizeArr[6] = (byte)((fileSize >>  0)&0xff);

            rc.send(sizeArr);

            int readSize; // Readメソッドで読み込んだバイト数
            int remain = fileSize; // 読み込むべき残りのバイト数
            int bufPos = 0; // データ格納用配列内の追加位置

            while (remain > 0)
            {
                if (size > remain)
                {
                    buf = new byte[remain];
                }
                // 1024Bytesずつ読み込む
                readSize = fs.Read(buf,0,buf.Length);
                rc.send(buf);
                Thread.Sleep(1500);
                bufPos += readSize;
                remain -= readSize;
            }
            
            fs.Dispose();
        }

        
    }
}
