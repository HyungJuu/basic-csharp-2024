namespace ex19_asyncs
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            TxtSource = new TextBox();
            TxtTarget = new TextBox();
            BtnGetSource = new Button();
            BtnSetTarget = new Button();
            BtnSyncCopy = new Button();
            PrgCopy = new ProgressBar();
            BtnAsyncCopy = new Button();
            BtnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PrgCopy);
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnAsyncCopy);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(BtnSetTarget);
            groupBox1.Controls.Add(BtnGetSource);
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "소스 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "타겟 :";
            // 
            // TxtSource
            // 
            TxtSource.Location = new Point(66, 30);
            TxtSource.Name = "TxtSource";
            TxtSource.Size = new Size(291, 23);
            TxtSource.TabIndex = 1;
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(66, 59);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.Size = new Size(291, 23);
            TxtTarget.TabIndex = 1;
            // 
            // BtnGetSource
            // 
            BtnGetSource.Location = new Point(363, 29);
            BtnGetSource.Name = "BtnGetSource";
            BtnGetSource.Size = new Size(31, 23);
            BtnGetSource.TabIndex = 2;
            BtnGetSource.Text = "...";
            BtnGetSource.UseVisualStyleBackColor = true;
            // 
            // BtnSetTarget
            // 
            BtnSetTarget.Location = new Point(363, 58);
            BtnSetTarget.Name = "BtnSetTarget";
            BtnSetTarget.Size = new Size(31, 23);
            BtnSetTarget.TabIndex = 2;
            BtnSetTarget.Text = "...";
            BtnSetTarget.UseVisualStyleBackColor = true;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(22, 88);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(120, 35);
            BtnSyncCopy.TabIndex = 2;
            BtnSyncCopy.Text = "동기화 복사";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            // 
            // PrgCopy
            // 
            PrgCopy.Location = new Point(22, 129);
            PrgCopy.Name = "PrgCopy";
            PrgCopy.Size = new Size(372, 23);
            PrgCopy.TabIndex = 3;
            // 
            // BtnAsyncCopy
            // 
            BtnAsyncCopy.Location = new Point(148, 88);
            BtnAsyncCopy.Name = "BtnAsyncCopy";
            BtnAsyncCopy.Size = new Size(120, 35);
            BtnAsyncCopy.TabIndex = 2;
            BtnAsyncCopy.Text = "비동기화 복사";
            BtnAsyncCopy.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(274, 88);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(120, 35);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 191);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "비동기 파일 복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ProgressBar PrgCopy;
        private Button BtnCancel;
        private Button BtnAsyncCopy;
        private Button BtnSyncCopy;
        private Button BtnSetTarget;
        private Button BtnGetSource;
        private TextBox TxtTarget;
        private TextBox TxtSource;
        private Label label2;
        private Label label1;
    }
}
