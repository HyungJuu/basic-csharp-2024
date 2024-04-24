namespace NewBookRentalShopApp
{
    partial class FrmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtMemberIdx = new MetroFramework.Controls.MetroTextBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtAddr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TxtMobile = new MetroFramework.Controls.MetroTextBox();
            this.CboLevels = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvResult
            // 
            this.DgvResult.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(379, 370);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "회원 번호";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "회원명";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtMemberIdx
            // 
            // 
            // 
            // 
            this.TxtMemberIdx.CustomButton.Image = null;
            this.TxtMemberIdx.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.TxtMemberIdx.CustomButton.Name = "";
            this.TxtMemberIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberIdx.CustomButton.TabIndex = 1;
            this.TxtMemberIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberIdx.CustomButton.UseSelectable = true;
            this.TxtMemberIdx.CustomButton.Visible = false;
            this.TxtMemberIdx.Lines = new string[0];
            this.TxtMemberIdx.Location = new System.Drawing.Point(107, 45);
            this.TxtMemberIdx.MaxLength = 32767;
            this.TxtMemberIdx.Name = "TxtMemberIdx";
            this.TxtMemberIdx.PasswordChar = '\0';
            this.TxtMemberIdx.ReadOnly = true;
            this.TxtMemberIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberIdx.SelectedText = "";
            this.TxtMemberIdx.SelectionLength = 0;
            this.TxtMemberIdx.SelectionStart = 0;
            this.TxtMemberIdx.ShortcutsEnabled = true;
            this.TxtMemberIdx.Size = new System.Drawing.Size(222, 23);
            this.TxtMemberIdx.TabIndex = 1;
            this.TxtMemberIdx.UseSelectable = true;
            this.TxtMemberIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberIdx.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(107, 81);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(222, 23);
            this.TxtNames.TabIndex = 2;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "이름 입력";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(107, 277);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(70, 23);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(183, 277);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(259, 277);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(70, 23);
            this.BtnDel.TabIndex = 9;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "회원등급";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 163);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "회원 주소";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAddr
            // 
            // 
            // 
            // 
            this.TxtAddr.CustomButton.Image = null;
            this.TxtAddr.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.TxtAddr.CustomButton.Name = "";
            this.TxtAddr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddr.CustomButton.TabIndex = 1;
            this.TxtAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddr.CustomButton.UseSelectable = true;
            this.TxtAddr.CustomButton.Visible = false;
            this.TxtAddr.Lines = new string[0];
            this.TxtAddr.Location = new System.Drawing.Point(107, 159);
            this.TxtAddr.MaxLength = 32767;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.PasswordChar = '\0';
            this.TxtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddr.SelectedText = "";
            this.TxtAddr.SelectionLength = 0;
            this.TxtAddr.SelectionStart = 0;
            this.TxtAddr.ShortcutsEnabled = true;
            this.TxtAddr.Size = new System.Drawing.Size(222, 23);
            this.TxtAddr.TabIndex = 4;
            this.TxtAddr.UseSelectable = true;
            this.TxtAddr.WaterMark = "주소 입력";
            this.TxtAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddr.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 199);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "전화번호";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(56, 231);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "EMail";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtMobile
            // 
            // 
            // 
            // 
            this.TxtMobile.CustomButton.Image = null;
            this.TxtMobile.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.TxtMobile.CustomButton.Name = "";
            this.TxtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMobile.CustomButton.TabIndex = 1;
            this.TxtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMobile.CustomButton.UseSelectable = true;
            this.TxtMobile.CustomButton.Visible = false;
            this.TxtMobile.Lines = new string[0];
            this.TxtMobile.Location = new System.Drawing.Point(107, 195);
            this.TxtMobile.MaxLength = 32767;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.PasswordChar = '\0';
            this.TxtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMobile.SelectedText = "";
            this.TxtMobile.SelectionLength = 0;
            this.TxtMobile.SelectionStart = 0;
            this.TxtMobile.ShortcutsEnabled = true;
            this.TxtMobile.Size = new System.Drawing.Size(222, 23);
            this.TxtMobile.TabIndex = 5;
            this.TxtMobile.UseSelectable = true;
            this.TxtMobile.WaterMark = "전화번호 입력";
            this.TxtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMobile.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CboLevels
            // 
            this.CboLevels.FormattingEnabled = true;
            this.CboLevels.ItemHeight = 23;
            this.CboLevels.Location = new System.Drawing.Point(107, 117);
            this.CboLevels.Name = "CboLevels";
            this.CboLevels.PromptText = "-- 회원 등급 선택 --";
            this.CboLevels.Size = new System.Drawing.Size(222, 29);
            this.CboLevels.TabIndex = 3;
            this.CboLevels.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboLevels);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtMobile);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.TxtAddr);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtMemberIdx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서회원 입력항목";
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(107, 231);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(222, 23);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "Email 입력";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 2;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMember";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "도서회원 관리";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvResult;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtMemberIdx;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtAddr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TxtMobile;
        private MetroFramework.Controls.MetroComboBox CboLevels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
    }
}