namespace RobotControllerPC
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCmd = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLTurn = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonModePosition = new System.Windows.Forms.RadioButton();
            this.radioButtonModePWM = new System.Windows.Forms.RadioButton();
            this.radioButtonModeSpeed = new System.Windows.Forms.RadioButton();
            this.buttonLRCmd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.tabPageCtrl = new System.Windows.Forms.TabPage();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.buttonWavFile = new System.Windows.Forms.Button();
            this.textBoxFileRef = new System.Windows.Forms.TextBox();
            this.buttonFileRef = new System.Windows.Forms.Button();
            this.buttonConn = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMoveWait = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogSendFile = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxAbsMode = new System.Windows.Forms.CheckBox();
            this.timerSendMsg = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageCmd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.tabPageFile.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCmd);
            this.tabControlMain.Controls.Add(this.tabPageCtrl);
            this.tabControlMain.Controls.Add(this.tabPageFile);
            this.tabControlMain.Location = new System.Drawing.Point(12, 84);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(349, 282);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageCmd
            // 
            this.tabPageCmd.Controls.Add(this.label3);
            this.tabPageCmd.Controls.Add(this.textBoxPosition);
            this.tabPageCmd.Controls.Add(this.button1);
            this.tabPageCmd.Controls.Add(this.buttonLTurn);
            this.tabPageCmd.Controls.Add(this.buttonReverse);
            this.tabPageCmd.Controls.Add(this.buttonForward);
            this.tabPageCmd.Controls.Add(this.label4);
            this.tabPageCmd.Controls.Add(this.textBoxSpeed);
            this.tabPageCmd.Controls.Add(this.groupBox1);
            this.tabPageCmd.Controls.Add(this.buttonLRCmd);
            this.tabPageCmd.Controls.Add(this.label2);
            this.tabPageCmd.Controls.Add(this.label1);
            this.tabPageCmd.Controls.Add(this.textBoxR);
            this.tabPageCmd.Controls.Add(this.textBoxL);
            this.tabPageCmd.Location = new System.Drawing.Point(4, 22);
            this.tabPageCmd.Name = "tabPageCmd";
            this.tabPageCmd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCmd.Size = new System.Drawing.Size(341, 256);
            this.tabPageCmd.TabIndex = 0;
            this.tabPageCmd.Text = "コマンド";
            this.tabPageCmd.UseVisualStyleBackColor = true;
            this.tabPageCmd.Click += new System.EventHandler(this.tabPageCmd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "距離";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(64, 175);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(87, 19);
            this.textBoxPosition.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "右回転";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLTurn
            // 
            this.buttonLTurn.Location = new System.Drawing.Point(252, 144);
            this.buttonLTurn.Name = "buttonLTurn";
            this.buttonLTurn.Size = new System.Drawing.Size(75, 23);
            this.buttonLTurn.TabIndex = 18;
            this.buttonLTurn.Text = "左回転";
            this.buttonLTurn.UseVisualStyleBackColor = true;
            this.buttonLTurn.Click += new System.EventHandler(this.buttonLTurn_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(171, 173);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 17;
            this.buttonReverse.Text = "後退";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(171, 144);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 23);
            this.buttonForward.TabIndex = 16;
            this.buttonForward.Text = "前進";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "速度";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(64, 146);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(87, 19);
            this.textBoxSpeed.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonModePosition);
            this.groupBox1.Controls.Add(this.radioButtonModePWM);
            this.groupBox1.Controls.Add(this.radioButtonModeSpeed);
            this.groupBox1.Location = new System.Drawing.Point(8, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 106);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "モード";
            // 
            // radioButtonModePosition
            // 
            this.radioButtonModePosition.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonModePosition.AutoSize = true;
            this.radioButtonModePosition.Location = new System.Drawing.Point(6, 74);
            this.radioButtonModePosition.Name = "radioButtonModePosition";
            this.radioButtonModePosition.Size = new System.Drawing.Size(84, 22);
            this.radioButtonModePosition.TabIndex = 9;
            this.radioButtonModePosition.TabStop = true;
            this.radioButtonModePosition.Text = "Positionモード";
            this.radioButtonModePosition.UseVisualStyleBackColor = true;
            this.radioButtonModePosition.CheckedChanged += new System.EventHandler(this.radioButtonModePosition_CheckedChanged);
            // 
            // radioButtonModePWM
            // 
            this.radioButtonModePWM.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonModePWM.AutoSize = true;
            this.radioButtonModePWM.Location = new System.Drawing.Point(6, 18);
            this.radioButtonModePWM.Name = "radioButtonModePWM";
            this.radioButtonModePWM.Size = new System.Drawing.Size(80, 22);
            this.radioButtonModePWM.TabIndex = 7;
            this.radioButtonModePWM.TabStop = true;
            this.radioButtonModePWM.Text = "PWMモード   ";
            this.radioButtonModePWM.UseVisualStyleBackColor = true;
            this.radioButtonModePWM.CheckedChanged += new System.EventHandler(this.radioButtonModePWM_CheckedChanged);
            // 
            // radioButtonModeSpeed
            // 
            this.radioButtonModeSpeed.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonModeSpeed.AutoSize = true;
            this.radioButtonModeSpeed.Location = new System.Drawing.Point(6, 46);
            this.radioButtonModeSpeed.Name = "radioButtonModeSpeed";
            this.radioButtonModeSpeed.Size = new System.Drawing.Size(82, 22);
            this.radioButtonModeSpeed.TabIndex = 8;
            this.radioButtonModeSpeed.TabStop = true;
            this.radioButtonModeSpeed.Text = "Speedモード  ";
            this.radioButtonModeSpeed.UseVisualStyleBackColor = true;
            this.radioButtonModeSpeed.CheckedChanged += new System.EventHandler(this.radioButtonModeSpeed_CheckedChanged);
            // 
            // buttonLRCmd
            // 
            this.buttonLRCmd.Location = new System.Drawing.Point(196, 93);
            this.buttonLRCmd.Name = "buttonLRCmd";
            this.buttonLRCmd.Size = new System.Drawing.Size(75, 23);
            this.buttonLRCmd.TabIndex = 10;
            this.buttonLRCmd.Text = "コマンド送信";
            this.buttonLRCmd.UseVisualStyleBackColor = true;
            this.buttonLRCmd.Click += new System.EventHandler(this.buttonLRCmd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(171, 68);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 19);
            this.textBoxR.TabIndex = 4;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(171, 39);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(100, 19);
            this.textBoxL.TabIndex = 0;
            // 
            // tabPageCtrl
            // 
            this.tabPageCtrl.Controls.Add(this.checkBoxAbsMode);
            this.tabPageCtrl.Controls.Add(this.labelRoll);
            this.tabPageCtrl.Controls.Add(this.labelMsg);
            this.tabPageCtrl.Controls.Add(this.buttonClear);
            this.tabPageCtrl.Controls.Add(this.pictureBoxField);
            this.tabPageCtrl.Location = new System.Drawing.Point(4, 22);
            this.tabPageCtrl.Name = "tabPageCtrl";
            this.tabPageCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCtrl.Size = new System.Drawing.Size(341, 256);
            this.tabPageCtrl.TabIndex = 1;
            this.tabPageCtrl.Text = "操作";
            this.tabPageCtrl.UseVisualStyleBackColor = true;
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.BackColor = System.Drawing.Color.LightGray;
            this.labelRoll.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRoll.Location = new System.Drawing.Point(242, 12);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelRoll.Size = new System.Drawing.Size(34, 30);
            this.labelRoll.TabIndex = 3;
            this.labelRoll.Text = "roll";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.BackColor = System.Drawing.Color.LightGray;
            this.labelMsg.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMsg.Location = new System.Drawing.Point(136, 12);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelMsg.Size = new System.Drawing.Size(80, 30);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "labelMsg";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(7, 7);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 37);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxField.Location = new System.Drawing.Point(3, 79);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(335, 172);
            this.pictureBoxField.TabIndex = 0;
            this.pictureBoxField.TabStop = false;
            this.pictureBoxField.Click += new System.EventHandler(this.pictureBoxField_Click);
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.labelFileSize);
            this.tabPageFile.Controls.Add(this.buttonWavFile);
            this.tabPageFile.Controls.Add(this.textBoxFileRef);
            this.tabPageFile.Controls.Add(this.buttonFileRef);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(341, 256);
            this.tabPageFile.TabIndex = 2;
            this.tabPageFile.Text = "ファイル送信";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(7, 49);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(80, 12);
            this.labelFileSize.TabIndex = 3;
            this.labelFileSize.Text = "ファイルサイズ：0";
            // 
            // buttonWavFile
            // 
            this.buttonWavFile.Location = new System.Drawing.Point(6, 91);
            this.buttonWavFile.Name = "buttonWavFile";
            this.buttonWavFile.Size = new System.Drawing.Size(109, 29);
            this.buttonWavFile.TabIndex = 2;
            this.buttonWavFile.Text = "wavファイル送信";
            this.buttonWavFile.UseVisualStyleBackColor = true;
            this.buttonWavFile.Click += new System.EventHandler(this.buttonWavFile_Click);
            // 
            // textBoxFileRef
            // 
            this.textBoxFileRef.Location = new System.Drawing.Point(6, 23);
            this.textBoxFileRef.Name = "textBoxFileRef";
            this.textBoxFileRef.Size = new System.Drawing.Size(255, 19);
            this.textBoxFileRef.TabIndex = 1;
            // 
            // buttonFileRef
            // 
            this.buttonFileRef.Location = new System.Drawing.Point(267, 15);
            this.buttonFileRef.Name = "buttonFileRef";
            this.buttonFileRef.Size = new System.Drawing.Size(68, 27);
            this.buttonFileRef.TabIndex = 0;
            this.buttonFileRef.Text = "参照";
            this.buttonFileRef.UseVisualStyleBackColor = true;
            this.buttonFileRef.Click += new System.EventHandler(this.buttonFileRef_Click);
            // 
            // buttonConn
            // 
            this.buttonConn.Location = new System.Drawing.Point(12, 39);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(345, 39);
            this.buttonConn.TabIndex = 1;
            this.buttonConn.Text = "接続";
            this.buttonConn.UseVisualStyleBackColor = true;
            this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(373, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 接続ToolStripMenuItem
            // 
            this.接続ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
            this.接続ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.接続ToolStripMenuItem.Text = "接続";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // timerMoveWait
            // 
            this.timerMoveWait.Interval = 1000;
            this.timerMoveWait.Tick += new System.EventHandler(this.timerMoveWait_Tick);
            // 
            // openFileDialogSendFile
            // 
            this.openFileDialogSendFile.FileName = "openFileDialogSendFile";
            // 
            // checkBoxAbsMode
            // 
            this.checkBoxAbsMode.AutoSize = true;
            this.checkBoxAbsMode.Location = new System.Drawing.Point(7, 51);
            this.checkBoxAbsMode.Name = "checkBoxAbsMode";
            this.checkBoxAbsMode.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAbsMode.TabIndex = 4;
            this.checkBoxAbsMode.Text = "位置指定";
            this.checkBoxAbsMode.UseVisualStyleBackColor = true;
            // 
            // timerSendMsg
            // 
            this.timerSendMsg.Interval = 1000;
            this.timerSendMsg.Tick += new System.EventHandler(this.timerSendMsg_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 378);
            this.Controls.Add(this.buttonConn);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "RobotController PC版";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCmd.ResumeLayout(false);
            this.tabPageCmd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageCtrl.ResumeLayout(false);
            this.tabPageCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCmd;
        private System.Windows.Forms.TabPage tabPageCtrl;
        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.RadioButton radioButtonModePosition;
        private System.Windows.Forms.RadioButton radioButtonModeSpeed;
        private System.Windows.Forms.RadioButton radioButtonModePWM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLRCmd;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLTurn;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.Timer timerMoveWait;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogSendFile;
        private System.Windows.Forms.TextBox textBoxFileRef;
        private System.Windows.Forms.Button buttonFileRef;
        private System.Windows.Forms.Button buttonWavFile;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.CheckBox checkBoxAbsMode;
        private System.Windows.Forms.Timer timerSendMsg;
    }
}

