namespace My_project
{
    partial class Signup
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
            Txt_Name = new TextBox();
            Txt_Id = new TextBox();
            Txt_Pwd = new TextBox();
            Btn_Ok = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Txt_phone = new TextBox();
            panel1 = new Panel();
            hidePanel1 = new HidePanel();
            Btn_Cancel = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = SystemColors.Control;
            Txt_Name.Location = new Point(340, 50);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(181, 23);
            Txt_Name.TabIndex = 0;
            Txt_Name.TextChanged += Txt_Name_TextChanged;
            // 
            // Txt_Id
            // 
            Txt_Id.BackColor = SystemColors.Control;
            Txt_Id.Location = new Point(340, 88);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new Size(181, 23);
            Txt_Id.TabIndex = 1;
            Txt_Id.TextChanged += Txt_Id_TextChanged;
            // 
            // Txt_Pwd
            // 
            Txt_Pwd.BackColor = SystemColors.Control;
            Txt_Pwd.Location = new Point(340, 130);
            Txt_Pwd.Name = "Txt_Pwd";
            Txt_Pwd.Size = new Size(181, 23);
            Txt_Pwd.TabIndex = 2;
            // 
            // Btn_Ok
            // 
            Btn_Ok.Location = new Point(377, 269);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(75, 23);
            Btn_Ok.TabIndex = 3;
            Btn_Ok.Text = "완료";
            Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "이름 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "아이디 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "비밀번호 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 172);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "전화번호 :";
            // 
            // Txt_phone
            // 
            Txt_phone.BackColor = SystemColors.Control;
            Txt_phone.Location = new Point(340, 169);
            Txt_phone.Name = "Txt_phone";
            Txt_phone.Size = new Size(181, 23);
            Txt_phone.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(hidePanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 314);
            panel1.TabIndex = 8;
            // 
            // hidePanel1
            // 
            hidePanel1.Location = new Point(0, 0);
            hidePanel1.Name = "hidePanel1";
            hidePanel1.Opacity = 50;
            hidePanel1.Size = new Size(557, 30);
            hidePanel1.TabIndex = 12;
            hidePanel1.MouseDown += hidePanel1_MouseDown;
            hidePanel1.MouseMove += hidePanel1_MouseMove;
            hidePanel1.MouseUp += hidePanel1_MouseUp;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(458, 269);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 23);
            Btn_Cancel.TabIndex = 9;
            Btn_Cancel.Text = "취소";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(340, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 211);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "성별 :";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(557, 314);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(Btn_Cancel);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Ok);
            Controls.Add(Txt_phone);
            Controls.Add(Txt_Pwd);
            Controls.Add(Txt_Id);
            Controls.Add(Txt_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "회원가입";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Name;
        private TextBox Txt_Id;
        private TextBox Txt_Pwd;
        private Button Btn_Ok;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Txt_phone;
        private Panel panel1;
        private Button Btn_Cancel;
        private ComboBox comboBox1;
        private Label label5;
        private HidePanel hidePanel1;
    }
}