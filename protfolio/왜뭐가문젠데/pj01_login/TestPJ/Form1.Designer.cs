namespace TestPJ
{
    partial class Login
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkShow = new System.Windows.Forms.CheckBox();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_signup);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 265);
            this.panel1.TabIndex = 0;
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(284, 128);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(233, 21);
            this.Txt_Username.TabIndex = 1;
            this.Txt_Username.TextChanged += new System.EventHandler(this.Txt_Username_TextChanged);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(284, 185);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '●';
            this.Txt_Password.Size = new System.Drawing.Size(233, 21);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Btn_Login.Location = new System.Drawing.Point(381, 269);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(73, 22);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "로그인";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Btn_Reset.Location = new System.Drawing.Point(458, 269);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(73, 22);
            this.Btn_Reset.TabIndex = 5;
            this.Btn_Reset.Text = "초기화";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_signup
            // 
            this.Btn_signup.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Btn_signup.Location = new System.Drawing.Point(87, 232);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(75, 23);
            this.Btn_signup.TabIndex = 6;
            this.Btn_signup.Text = "회원가입";
            this.Btn_signup.UseVisualStyleBackColor = true;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F);
            this.label1.Location = new System.Drawing.Point(71, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "반갑습니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.label2.Location = new System.Drawing.Point(57, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "기존회원이 아니신가요?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(284, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "로그-인";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(284, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "아이디";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(284, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "비밀번호";
            // 
            // ChkShow
            // 
            this.ChkShow.AutoSize = true;
            this.ChkShow.Font = new System.Drawing.Font("나눔고딕", 8.25F);
            this.ChkShow.Location = new System.Drawing.Point(423, 222);
            this.ChkShow.Name = "ChkShow";
            this.ChkShow.Size = new System.Drawing.Size(89, 17);
            this.ChkShow.TabIndex = 3;
            this.ChkShow.Text = "비밀번호 표시";
            this.ChkShow.UseVisualStyleBackColor = true;
            this.ChkShow.CheckedChanged += new System.EventHandler(this.ChkShow_CheckedChanged);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_exit.Location = new System.Drawing.Point(526, 8);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(23, 23);
            this.Btn_exit.TabIndex = 7;
            this.Btn_exit.Text = "X";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 314);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.ChkShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkShow;
        private System.Windows.Forms.Button Btn_exit;
    }
}

