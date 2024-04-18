namespace My_project
{
    public partial class Login : Form
    {
        #region '생성자 초기화 영역'

        public Login()
        {
            InitializeComponent();
        }
        #endregion

        // #region '이벤트핸들러 영역'

        // 아이디 입력 이벤트핸들러
        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        // 비밀번호 입력 이벤트핸들러
        private void Txt_Pwd_TextChanged(object sender, EventArgs e)
        {

        }

        // 로그인 버튼클릭 이벤트핸들러
        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }

        // 입력초기화버튼 이벤트핸들러
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Username.Clear();
            Txt_Password.Clear();

            Txt_Username.Focus();
        }

        // 창닫기버튼 이벤트핸들러
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 창을 닫을시 종료여부 질문창
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }

        // 회원가입버튼
        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            //this.Hide();
        }

        // 창 이동

        bool TagMove;
        int MValX, MValY;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
    }
}
