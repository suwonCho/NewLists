namespace NewLists
{
	partial class frmNewLists
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstNew = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lstLog = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.pnlHead = new System.Windows.Forms.Panel();
			this.inpHeadNext = new Function.form.usrInputBox();
			this.inpHeadChkTime = new Function.form.usrInputBox();
			this.inpHeadStartTime = new Function.form.usrInputBox();
			this.btnHPReConn = new System.Windows.Forms.Button();
			this.btnAuth = new System.Windows.Forms.Button();
			this.btnHPTest = new System.Windows.Forms.Button();
			this.lblHPMsg = new System.Windows.Forms.Label();
			this.btnHPConn = new System.Windows.Forms.Button();
			this.inpHP = new Function.form.usrInputBox();
			this.pnlHead.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstNew
			// 
			this.lstNew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lstNew.Dock = System.Windows.Forms.DockStyle.Left;
			this.lstNew.FullRowSelect = true;
			this.lstNew.GridLines = true;
			this.lstNew.Location = new System.Drawing.Point(0, 55);
			this.lstNew.MultiSelect = false;
			this.lstNew.Name = "lstNew";
			this.lstNew.Size = new System.Drawing.Size(358, 419);
			this.lstNew.TabIndex = 1;
			this.lstNew.UseCompatibleStateImageBehavior = false;
			this.lstNew.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cnt";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 30;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "LastChk";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 180;
			// 
			// lstLog
			// 
			this.lstLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
			this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstLog.FullRowSelect = true;
			this.lstLog.GridLines = true;
			this.lstLog.Location = new System.Drawing.Point(358, 55);
			this.lstLog.MultiSelect = false;
			this.lstLog.Name = "lstLog";
			this.lstLog.Size = new System.Drawing.Size(589, 419);
			this.lstLog.TabIndex = 2;
			this.lstLog.UseCompatibleStateImageBehavior = false;
			this.lstLog.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "ㅊㅊㅊ";
			this.columnHeader5.Width = 0;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "시 간";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Log";
			this.columnHeader6.Width = 600;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(833, 445);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pnlHead
			// 
			this.pnlHead.Controls.Add(this.inpHeadNext);
			this.pnlHead.Controls.Add(this.inpHeadChkTime);
			this.pnlHead.Controls.Add(this.inpHeadStartTime);
			this.pnlHead.Controls.Add(this.btnHPReConn);
			this.pnlHead.Controls.Add(this.btnAuth);
			this.pnlHead.Controls.Add(this.btnHPTest);
			this.pnlHead.Controls.Add(this.lblHPMsg);
			this.pnlHead.Controls.Add(this.btnHPConn);
			this.pnlHead.Controls.Add(this.inpHP);
			this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHead.Location = new System.Drawing.Point(0, 0);
			this.pnlHead.Name = "pnlHead";
			this.pnlHead.Size = new System.Drawing.Size(947, 55);
			this.pnlHead.TabIndex = 4;
			// 
			// inpHeadNext
			// 
			this.inpHeadNext.BackColor = System.Drawing.SystemColors.Control;
			this.inpHeadNext.ChangeMark_Visable = false;
			this.inpHeadNext.ComboBoxDataSource = null;
			this.inpHeadNext.ComboBoxDisplayMember = "";
			this.inpHeadNext.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpHeadNext.ComboBoxSelectedValue = null;
			this.inpHeadNext.ComboBoxSelectIndex = -1;
			this.inpHeadNext.ComboBoxSelectItem = null;
			this.inpHeadNext.ComboBoxValueMember = "";
			this.inpHeadNext.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadNext.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpHeadNext.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpHeadNext.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadNext.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadNext.DLabel_FontAutoSize = false;
			this.inpHeadNext.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadNext.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadNext.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpHeadNext.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadNext.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadNext.Label_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadNext.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadNext.Label_Text = "Next";
			this.inpHeadNext.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpHeadNext.Label_Visable = true;
			this.inpHeadNext.LabelWidth = 55;
			this.inpHeadNext.Location = new System.Drawing.Point(417, 3);
			this.inpHeadNext.Multiline = false;
			this.inpHeadNext.Name = "inpHeadNext";
			this.inpHeadNext.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpHeadNext.Size = new System.Drawing.Size(250, 23);
			this.inpHeadNext.TabIndex = 10;
			this.inpHeadNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadNext.TextBox_AcceptsTab = false;
			this.inpHeadNext.TextBox_MaxLength = 32767;
			this.inpHeadNext.TextBox_PasswordChar = '\0';
			this.inpHeadNext.TextBox_TabStopsLength = 8;
			this.inpHeadNext.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpHeadNext.Value = "";
			// 
			// inpHeadChkTime
			// 
			this.inpHeadChkTime.BackColor = System.Drawing.SystemColors.Control;
			this.inpHeadChkTime.ChangeMark_Visable = false;
			this.inpHeadChkTime.ComboBoxDataSource = null;
			this.inpHeadChkTime.ComboBoxDisplayMember = "";
			this.inpHeadChkTime.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpHeadChkTime.ComboBoxSelectedValue = null;
			this.inpHeadChkTime.ComboBoxSelectIndex = -1;
			this.inpHeadChkTime.ComboBoxSelectItem = null;
			this.inpHeadChkTime.ComboBoxValueMember = "";
			this.inpHeadChkTime.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadChkTime.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpHeadChkTime.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpHeadChkTime.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadChkTime.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadChkTime.DLabel_FontAutoSize = false;
			this.inpHeadChkTime.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadChkTime.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadChkTime.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpHeadChkTime.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadChkTime.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadChkTime.Label_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadChkTime.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadChkTime.Label_Text = "체크센드";
			this.inpHeadChkTime.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpHeadChkTime.Label_Visable = true;
			this.inpHeadChkTime.LabelWidth = 55;
			this.inpHeadChkTime.Location = new System.Drawing.Point(207, 3);
			this.inpHeadChkTime.Multiline = false;
			this.inpHeadChkTime.Name = "inpHeadChkTime";
			this.inpHeadChkTime.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpHeadChkTime.Size = new System.Drawing.Size(204, 23);
			this.inpHeadChkTime.TabIndex = 9;
			this.inpHeadChkTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadChkTime.TextBox_AcceptsTab = false;
			this.inpHeadChkTime.TextBox_MaxLength = 32767;
			this.inpHeadChkTime.TextBox_PasswordChar = '\0';
			this.inpHeadChkTime.TextBox_TabStopsLength = 8;
			this.inpHeadChkTime.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpHeadChkTime.Value = "";
			// 
			// inpHeadStartTime
			// 
			this.inpHeadStartTime.BackColor = System.Drawing.SystemColors.Control;
			this.inpHeadStartTime.ChangeMark_Visable = false;
			this.inpHeadStartTime.ComboBoxDataSource = null;
			this.inpHeadStartTime.ComboBoxDisplayMember = "";
			this.inpHeadStartTime.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpHeadStartTime.ComboBoxSelectedValue = null;
			this.inpHeadStartTime.ComboBoxSelectIndex = -1;
			this.inpHeadStartTime.ComboBoxSelectItem = null;
			this.inpHeadStartTime.ComboBoxValueMember = "";
			this.inpHeadStartTime.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadStartTime.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpHeadStartTime.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpHeadStartTime.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadStartTime.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadStartTime.DLabel_FontAutoSize = false;
			this.inpHeadStartTime.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadStartTime.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadStartTime.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpHeadStartTime.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpHeadStartTime.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHeadStartTime.Label_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHeadStartTime.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHeadStartTime.Label_Text = "시작시간";
			this.inpHeadStartTime.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpHeadStartTime.Label_Visable = true;
			this.inpHeadStartTime.LabelWidth = 55;
			this.inpHeadStartTime.Location = new System.Drawing.Point(3, 3);
			this.inpHeadStartTime.Multiline = false;
			this.inpHeadStartTime.Name = "inpHeadStartTime";
			this.inpHeadStartTime.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpHeadStartTime.Size = new System.Drawing.Size(198, 23);
			this.inpHeadStartTime.TabIndex = 8;
			this.inpHeadStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHeadStartTime.TextBox_AcceptsTab = false;
			this.inpHeadStartTime.TextBox_MaxLength = 32767;
			this.inpHeadStartTime.TextBox_PasswordChar = '\0';
			this.inpHeadStartTime.TextBox_TabStopsLength = 8;
			this.inpHeadStartTime.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpHeadStartTime.Value = "";
			// 
			// btnHPReConn
			// 
			this.btnHPReConn.Location = new System.Drawing.Point(305, 30);
			this.btnHPReConn.Name = "btnHPReConn";
			this.btnHPReConn.Size = new System.Drawing.Size(53, 22);
			this.btnHPReConn.TabIndex = 7;
			this.btnHPReConn.Text = "재연결";
			this.btnHPReConn.UseVisualStyleBackColor = true;
			this.btnHPReConn.Click += new System.EventHandler(this.btnHPReConn_Click);
			// 
			// btnAuth
			// 
			this.btnAuth.Location = new System.Drawing.Point(364, 30);
			this.btnAuth.Name = "btnAuth";
			this.btnAuth.Size = new System.Drawing.Size(47, 22);
			this.btnAuth.TabIndex = 6;
			this.btnAuth.Text = "인증";
			this.btnAuth.UseVisualStyleBackColor = true;
			this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
			// 
			// btnHPTest
			// 
			this.btnHPTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHPTest.Location = new System.Drawing.Point(854, 30);
			this.btnHPTest.Name = "btnHPTest";
			this.btnHPTest.Size = new System.Drawing.Size(88, 22);
			this.btnHPTest.TabIndex = 5;
			this.btnHPTest.Text = "문자 테스트";
			this.btnHPTest.UseVisualStyleBackColor = true;
			this.btnHPTest.Click += new System.EventHandler(this.btnHPTest_Click);
			// 
			// lblHPMsg
			// 
			this.lblHPMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHPMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHPMsg.Location = new System.Drawing.Point(417, 31);
			this.lblHPMsg.Name = "lblHPMsg";
			this.lblHPMsg.Size = new System.Drawing.Size(431, 22);
			this.lblHPMsg.TabIndex = 2;
			this.lblHPMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHPConn
			// 
			this.btnHPConn.Location = new System.Drawing.Point(257, 30);
			this.btnHPConn.Name = "btnHPConn";
			this.btnHPConn.Size = new System.Drawing.Size(42, 22);
			this.btnHPConn.TabIndex = 1;
			this.btnHPConn.Text = "연결";
			this.btnHPConn.UseVisualStyleBackColor = true;
			this.btnHPConn.Click += new System.EventHandler(this.btnHPConn_Click);
			// 
			// inpHP
			// 
			this.inpHP.BackColor = System.Drawing.SystemColors.Control;
			this.inpHP.ChangeMark_Visable = true;
			this.inpHP.ComboBoxDataSource = null;
			this.inpHP.ComboBoxDisplayMember = "";
			this.inpHP.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpHP.ComboBoxSelectedValue = null;
			this.inpHP.ComboBoxSelectIndex = -1;
			this.inpHP.ComboBoxSelectItem = null;
			this.inpHP.ComboBoxValueMember = "";
			this.inpHP.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpHP.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpHP.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpHP.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHP.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHP.DLabel_FontAutoSize = false;
			this.inpHP.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHP.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHP.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpHP.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpHP.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpHP.Label_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpHP.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpHP.Label_Text = "전화번호";
			this.inpHP.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpHP.Label_Visable = true;
			this.inpHP.LabelWidth = 55;
			this.inpHP.Location = new System.Drawing.Point(3, 30);
			this.inpHP.Multiline = false;
			this.inpHP.Name = "inpHP";
			this.inpHP.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpHP.Size = new System.Drawing.Size(248, 23);
			this.inpHP.TabIndex = 0;
			this.inpHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpHP.TextBox_AcceptsTab = false;
			this.inpHP.TextBox_MaxLength = 32767;
			this.inpHP.TextBox_PasswordChar = '\0';
			this.inpHP.TextBox_TabStopsLength = 8;
			this.inpHP.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpHP.Value = "";
			this.inpHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inpHP_KeyDown);
			// 
			// frmNewLists
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 496);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lstLog);
			this.Controls.Add(this.lstNew);
			this.Controls.Add(this.pnlHead);
			this.Name = "frmNewLists";
			this.Text = "NewLists";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewLists_FormClosing);
			this.Load += new System.EventHandler(this.frmNewLists_Load);
			this.Controls.SetChildIndex(this.pnlHead, 0);
			this.Controls.SetChildIndex(this.lstNew, 0);
			this.Controls.SetChildIndex(this.lstLog, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.pnlHead.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstNew;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView lstLog;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel pnlHead;
        private Function.form.usrInputBox inpHP;
        private System.Windows.Forms.Button btnHPTest;
        private System.Windows.Forms.Label lblHPMsg;
        private System.Windows.Forms.Button btnHPConn;
        private System.Windows.Forms.Button btnAuth;
		private System.Windows.Forms.Button btnHPReConn;
		private Function.form.usrInputBox inpHeadStartTime;
		private Function.form.usrInputBox inpHeadNext;
		private Function.form.usrInputBox inpHeadChkTime;
	}
}