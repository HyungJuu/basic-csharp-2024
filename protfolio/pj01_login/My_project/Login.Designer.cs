namespace My_project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Txt_Id = new TextBox();
            Txt_Pwd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Btn_Login = new Button();
            Btn_Reset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("나눔고딕 ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 38);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Txt_Id
            // 
            Txt_Id.Location = new Point(36, 309);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new Size(335, 27);
            Txt_Id.TabIndex = 3;
            // 
            // Txt_Pwd
            // 
            Txt_Pwd.Location = new Point(36, 379);
            Txt_Pwd.Name = "Txt_Pwd";
            Txt_Pwd.Size = new Size(335, 27);
            Txt_Pwd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔고딕 ExtraBold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(36, 279);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔고딕 ExtraBold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(36, 349);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Btn_Login
            // 
            Btn_Login.Location = new Point(277, 429);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(94, 29);
            Btn_Login.TabIndex = 7;
            Btn_Login.Text = "로그인";
            Btn_Login.UseVisualStyleBackColor = true;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(277, 479);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(94, 29);
            Btn_Reset.TabIndex = 8;
            Btn_Reset.Text = "초기화";
            Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 260);
            panel1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 534);
            Controls.Add(Btn_Reset);
            Controls.Add(Btn_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Txt_Pwd);
            Controls.Add(Txt_Id);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox Txt_Id;
        private TextBox Txt_Pwd;
        private Label label2;
        private Label label3;
        private Button Btn_Login;
        private Button Btn_Reset;
        private Panel panel1;
    }
}
