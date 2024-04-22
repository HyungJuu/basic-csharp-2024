using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmLoginUser : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        private string connString = "Data Source=localhost;" +
                                    "Initial Catalog=BookRentalShop2024;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";
        public FrmLoginUser()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); // 한번 이상 반복되는 부분을 메서드로 만들어서 호출
        }

        // 신규 클릭 이벤트핸들러
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            TxtUserIdx.ReadOnly = true;
            TxtUserId.Focus(); // 사용자번호는 자동증가 -> 입력불가
        }

        // 저장버튼 이벤트핸들러
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5Hash = MD5.Create(); // MD5 암호화용 객체 생성

            //입력검증(Validation Check) : 아이디, 패스워드를 입력하지 않으면
            if(string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("아이디를 입력하세요.");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO usertbl
                                        ( userId
                                        , [password]
					                    )
                                   VALUES
                                        ( @userId
                                        , @password
					                    )";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE usertbl
                                 SET userId = @userId
                                   , [password] = @password
                               WHERE userIdx = @userIdx";

                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isNew == false) // UPDATE 시에는 @userIdx 파라미터 필요
                    {
                        SqlParameter prmUserIdx = new SqlParameter("@userIdx", TxtUserIdx.Text);
                        cmd.Parameters.Add(prmUserIdx);

                    }

                    SqlParameter prmUserId = new SqlParameter("@userId", TxtUserId.Text);
                    SqlParameter prmPassword = new SqlParameter("@password", GetMd5Hash(md5Hash, TxtPassword.Text)); // 암호화 끝
                    // Command에 Parameter를 연결해줘야 한다
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmPassword);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this : 메세지박스의 부모창 = FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지움
            RefreshData();
        }


        // 삭제버튼 이벤트핸들러
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtUserIdx.Text)) // 사용자번호가 없으면
            {
                MetroMessageBox.Show(this, ",삭제할 사용자를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var query = @"DELETE FROM usertbl WHERE userIdx = @userIdx ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@userIdx", TxtUserIdx.Text);
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("저장성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지움

            RefreshData(); // 데이터그리드 재조회
        }

        // 반복되는 부분을 메서드로 만듦
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT userIdx
                                   , userId
                                   , [password]
                                   , lastLoginDateTime
                                FROM usertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "usertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "사용자번호";
                DgvResult.Columns[1].HeaderText = "아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막로그인날짜";

            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // MD5 해시 알고리즘 암호화
        // 1234 -> 01011011 -> 1011001010110011 -> x65xAEx11..
        string GetMd5Hash(MD5 md5Hash, string input)
        {
            // 입력 문자열을 byte 배열로 변환한 뒤 MD5 해시 처리
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder(); // 문자열을 좀더 쉽게 쓸수 있도록 만들어주는 클래스
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // 16진수 문자로 각 글자를 전부 변환
            }
            return builder.ToString();
        }
    }
}
