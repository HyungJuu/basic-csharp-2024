using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TestPJ
{
    public partial class Login : MetroForm
    {

        private bool isLogin = false;
        private string connString = "Data Source=localhost;" +
                                    "Initial Catalog=BookRentalShop2024;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";
        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        #region '생성자 초기화 영역'
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        // 아이디 입력 이벤트핸들러
        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        // 비밀번호 입력 이벤트핸들러
        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        // 로그인 버튼클릭 이벤트핸들러
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(Txt_Username.Text))
            {
                isFail = true;
                errMsg += "아이디를 입력하세요.\n";
            }

            if (string.IsNullOrEmpty(Txt_Password.Text))
            {
                isFail = true;
                errMsg += "패스워드를 입력하세요.\n";
            }

            if (isFail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // DB연계
            IsLogin = LoginProcess(); // 로그인 성공시 True, 실패시 False 리던
            if (IsLogin) this.Close(); // 현재 로그인창 닫기
        }

        private bool LoginProcess()
        {
            string userId = Txt_Username.Text; // 입력한 아이디를 userId에 저장
            string password = Txt_Password.Text; // 즉 현재 DB로 넘기는 값

            string chkUserId = string.Empty; // DB에서 넘어온 값
            string chkPassword = string.Empty;


            // 연결문자열(ConnectionString)
            // Data Source=localhost;Initial Catalog=BookRentalShop2024;Persist Security Info=True;User ID=sa;Encrypt=False;Password=mssql_p@ss
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT userId
                                      , [password]
                                   FROM usertbl
                                  WHERE userId = @userId
                                    And [password] = @password ";

                SqlCommand cmd = new SqlCommand(query, conn);
                // @userId, @password 파라미터 할당
                SqlParameter prmUserId = new SqlParameter("@userId", userId);
                SqlParameter prmPassword = new SqlParameter("Password", password);
                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chkUserId = reader["userId"] != null ? reader["userId"].ToString() : "-"; // 유저아이디가 null일때 - 변경
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-"; // 패스워드가 null일때 - 변경

                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다.", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

            } // using을 사용하면 conn.Close()가 필요없음
        }




        #region '입력초기화'
        // 입력초기화버튼 이벤트핸들러
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Username.Clear();
            Txt_Password.Clear();

            Txt_Username.Focus();
        }
        #endregion

        #region '창닫기 관련 이벤트핸들러'
        // 창닫기버튼 이벤트핸들러
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit(0);
        }

        // 창을 닫을시 종료여부 질문창
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }
        #endregion

        #region '회원가입'
        // 회원가입버튼
        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.FormClosed += (s, args) => this.Show();
            signup.Show();
            this.Hide();
        }
        #endregion

        #region '비밀번호 표시유무'
        // 비밀번호 표시 이벤트핸들러
        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked)
            {
                Txt_Password.PasswordChar = '\0';
            }
            else
            {
                Txt_Password.PasswordChar = '●';
            }
        }
        #endregion

        #region '엔터키로 이동'
        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 : 엔터키
            {
                Btn_Login_Click(sender, e);
            }
        }

        private void Txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_Password.Focus();
            }
        }
        #endregion







    }
}
