﻿namespace pj01_myproject
{
    partial class SignUP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Join = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_UserId = new System.Windows.Forms.TextBox();
            this.Txt_UserPwd = new System.Windows.Forms.TextBox();
            this.Txt_userPhone = new System.Windows.Forms.TextBox();
            this.Txt_UserEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Chk_Woman = new System.Windows.Forms.CheckBox();
            this.Chk_None = new System.Windows.Forms.CheckBox();
            this.Chk_Man = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Location = new System.Drawing.Point(23, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 395);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Join
            // 
            this.Btn_Join.Location = new System.Drawing.Point(537, 379);
            this.Btn_Join.Name = "Btn_Join";
            this.Btn_Join.Size = new System.Drawing.Size(95, 35);
            this.Btn_Join.TabIndex = 6;
            this.Btn_Join.Text = "완료";
            this.Btn_Join.UseVisualStyleBackColor = true;
            this.Btn_Join.Click += new System.EventHandler(this.Btn_Join_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(651, 379);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(95, 35);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "취소";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(439, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(424, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(409, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(409, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(382, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일(선택)";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(493, 75);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(241, 25);
            this.Txt_UserName.TabIndex = 1;
            this.Txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserName_KeyPress);
            // 
            // Txt_UserId
            // 
            this.Txt_UserId.Location = new System.Drawing.Point(493, 125);
            this.Txt_UserId.Name = "Txt_UserId";
            this.Txt_UserId.Size = new System.Drawing.Size(241, 25);
            this.Txt_UserId.TabIndex = 2;
            this.Txt_UserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserId_KeyPress);
            // 
            // Txt_UserPwd
            // 
            this.Txt_UserPwd.Location = new System.Drawing.Point(493, 175);
            this.Txt_UserPwd.Name = "Txt_UserPwd";
            this.Txt_UserPwd.Size = new System.Drawing.Size(241, 25);
            this.Txt_UserPwd.TabIndex = 3;
            this.Txt_UserPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserPwd_KeyPress);
            // 
            // Txt_userPhone
            // 
            this.Txt_userPhone.Location = new System.Drawing.Point(493, 225);
            this.Txt_userPhone.Name = "Txt_userPhone";
            this.Txt_userPhone.Size = new System.Drawing.Size(241, 25);
            this.Txt_userPhone.TabIndex = 4;
            this.Txt_userPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_userPhone_KeyPress);
            // 
            // Txt_UserEmail
            // 
            this.Txt_UserEmail.Location = new System.Drawing.Point(493, 275);
            this.Txt_UserEmail.Name = "Txt_UserEmail";
            this.Txt_UserEmail.Size = new System.Drawing.Size(241, 25);
            this.Txt_UserEmail.TabIndex = 5;
            this.Txt_UserEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserEmail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "성별";
            // 
            // Chk_Woman
            // 
            this.Chk_Woman.AutoSize = true;
            this.Chk_Woman.Location = new System.Drawing.Point(493, 335);
            this.Chk_Woman.Name = "Chk_Woman";
            this.Chk_Woman.Size = new System.Drawing.Size(44, 19);
            this.Chk_Woman.TabIndex = 9;
            this.Chk_Woman.Text = "여";
            this.Chk_Woman.UseVisualStyleBackColor = true;
            this.Chk_Woman.CheckedChanged += new System.EventHandler(this.Chk_Woman_CheckedChanged);
            // 
            // Chk_None
            // 
            this.Chk_None.AutoSize = true;
            this.Chk_None.Location = new System.Drawing.Point(645, 335);
            this.Chk_None.Name = "Chk_None";
            this.Chk_None.Size = new System.Drawing.Size(89, 19);
            this.Chk_None.TabIndex = 11;
            this.Chk_None.Text = "선택안함";
            this.Chk_None.UseVisualStyleBackColor = true;
            this.Chk_None.CheckedChanged += new System.EventHandler(this.Chk_None_CheckedChanged);
            // 
            // Chk_Man
            // 
            this.Chk_Man.AutoSize = true;
            this.Chk_Man.Location = new System.Drawing.Point(569, 335);
            this.Chk_Man.Name = "Chk_Man";
            this.Chk_Man.Size = new System.Drawing.Size(44, 19);
            this.Chk_Man.TabIndex = 12;
            this.Chk_Man.Text = "남";
            this.Chk_Man.UseVisualStyleBackColor = true;
            this.Chk_Man.CheckedChanged += new System.EventHandler(this.Chk_Man_CheckedChanged);
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Chk_Man);
            this.Controls.Add(this.Chk_None);
            this.Controls.Add(this.Chk_Woman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_UserEmail);
            this.Controls.Add(this.Txt_userPhone);
            this.Controls.Add(this.Txt_UserPwd);
            this.Controls.Add(this.Txt_UserId);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Join);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUP";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Join;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_UserId;
        private System.Windows.Forms.TextBox Txt_UserPwd;
        private System.Windows.Forms.TextBox Txt_userPhone;
        private System.Windows.Forms.TextBox Txt_UserEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Chk_Woman;
        private System.Windows.Forms.CheckBox Chk_None;
        private System.Windows.Forms.CheckBox Chk_Man;
    }
}