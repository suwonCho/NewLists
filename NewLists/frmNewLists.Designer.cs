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
			this.lstNew.Location = new System.Drawing.Point(0, 28);
			this.lstNew.MultiSelect = false;
			this.lstNew.Name = "lstNew";
			this.lstNew.Size = new System.Drawing.Size(358, 446);
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
			this.lstLog.Location = new System.Drawing.Point(358, 28);
			this.lstLog.MultiSelect = false;
			this.lstLog.Name = "lstLog";
			this.lstLog.Size = new System.Drawing.Size(589, 446);
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
			this.pnlHead.Controls.Add(this.btnHPReConn);
			this.pnlHead.Controls.Add(this.btnAuth);
			this.pnlHead.Controls.Add(this.btnHPTest);
			this.pnlHead.Controls.Add(this.lblHPMsg);
			this.pnlHead.Controls.Add(this.btnHPConn);
			this.pnlHead.Controls.Add(this.inpHP);
			this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHead.Location = new System.Drawing.Point(0, 0);
			this.pnlHead.Name = "pnlHead";
			this.pnlHead.Size = new System.Drawing.Size(947, 28);
			this.pnlHead.TabIndex = 4;
			// 
			// btnHPReConn
			// 
			this.btnHPReConn.Location = new System.Drawing.Point(305, 3);
			this.btnHPReConn.Name = "btnHPReConn";
			this.btnHPReConn.Size = new System.Drawing.Size(53, 22);
			this.btnHPReConn.TabIndex = 7;
			this.btnHPReConn.Text = "재연결";
			this.btnHPReConn.UseVisualStyleBackColor = true;
			this.btnHPReConn.Click += new System.EventHandler(this.btnHPReConn_Click);
			// 
			// btnAuth
			// 
			this.btnAuth.Location = new System.Drawing.Point(364, 3);
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
			this.btnHPTest.Location = new System.Drawing.Point(854, 3);
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
			this.lblHPMsg.Location = new System.Drawing.Point(417, 4);
			this.lblHPMsg.Name = "lblHPMsg";
			this.lblHPMsg.Size = new System.Drawing.Size(431, 22);
			this.lblHPMsg.TabIndex = 2;
			this.lblHPMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHPConn
			// 
			this.btnHPConn.Location = new System.Drawing.Point(257, 3);
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
			this.inpHP.Location = new System.Drawing.Point(3, 3);
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
	}
}