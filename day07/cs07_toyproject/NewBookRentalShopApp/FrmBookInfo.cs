﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
    public partial class FrmBookInfo : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmBookInfo()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
        }

        private void InitInputData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = @"SELECT Division, Names FROM divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // SqlDataReader = 개발자가 하나씩 처리할때
                    // SqlDataAdapter, DataSet = 한번에 데이터그리드뷰 등에 뿌릴 때
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();

                    while (reader.Read())
                    {
                        // Key, Value
                        // Boo1, 공포/스릴러
                        // reader[0] = Division컬럼, reader[1] = Names컬럼
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }

                    Debug.WriteLine(temp.Count);
                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value"; // 공포/스릴러
                    CboDivision.ValueMember = "Key"; // B001
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

            }
        }


        // 신규 클릭 이벤트핸들러
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            TxtBookIdx.ReadOnly = false; // 최초 입력할 때는 PK값을 입력해줘야 함
            TxtBookIdx.Focus(); // 사용자번호는 자동증가 -> 입력불가
        }

        // 저장버튼 이벤트핸들러
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //입력검증(Validation Check) : 저자명, 구분명, 책제목
            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("저자명을 입력하세요.");
                return;
            }

            // 콤보박스는 SelectIndex가 -1이 되면 안됨
            if (CboDivision.SelectedIndex < 0)
            {
                MessageBox.Show("구분명을 선택하세요");
                return;
            }

            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("책제목을 입력하세요.");
                return;
            }

            // 출판일은 기본으로 오늘날짜가 들어감
            // ISBN은 null이 들어가도 상관없음
            // 책가격읁 기본이 0원

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO divtbl
                                            ( Division
                                            , Names)
                                       VALUES
                                            (@Division
                                            ,@Names)";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [bookstbl]
                                     SET [Author] = @Author
                                       , [Division] = @Division
                                       , [Names] = @Names
                                       , [ReleaseDate] = @ReleaseDate
                                       , [ISBN] = @ISBN
                                       , [Price] = @Price
                                   WHERE bookIdx = @bookIdx";

                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    SqlParameter prmAuthor = new SqlParameter("@Author", TxtAuthor.Text);
                    cmd.Parameters.Add(prmAuthor);
                    SqlParameter prmDivision = new SqlParameter("@Division", CboDivision.SelectedValue);
                    cmd.Parameters.Add(prmDivision);
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    cmd.Parameters.Add(prmNames);
                    SqlParameter prmReleaseDate = new SqlParameter("@ReleaseDate", DtpReleaseDate.Value);
                    cmd.Parameters.Add(prmReleaseDate);
                    SqlParameter prmISBN = new SqlParameter("@ISBN", TxtISBN.Text);
                    cmd.Parameters.Add(prmISBN);
                    SqlParameter prmPrice = new SqlParameter("@Price", NudPrice.Value);
                    cmd.Parameters.Add(prmPrice);

                    if (!isNew)
                    {
                        SqlParameter prmBookIdx = new SqlParameter("@bookIdx", TxtBookIdx.Text);
                        cmd.Parameters.Add(prmBookIdx);
                    }

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

            RefreshData();
        }


        // 삭제버튼 이벤트핸들러
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtBookIdx.Text)) // 구분코드가 없으면
            {
                MetroMessageBox.Show(this, "삭제할 구분코드를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM divtbl WHERE Division = @Division ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@Division", TxtBookIdx.Text);
                cmd.Parameters.Add(prmDivision);

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


            RefreshData(); // 데이터그리드 재조회
        }

        // 데이터그리드에 데이터를 새로 부르기
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT b.[bookIdx]
                                   , b.[Author]
                                   , b.[Division]
		                           , d.Names AS DivNames
                                   , b.[Names]
                                   , b.[ReleaseDate]
                                   , b.[ISBN]
		                           , b.[Price]
                                FROM [bookstbl] AS b
	                            JOIN divtbl AS d
	                              ON b.Division = d.Division;"; // 화면에 필요한 테이블쿼리로 변경

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookstbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "책번호";
                DgvResult.Columns[1].HeaderText = "저자명";
                DgvResult.Columns[2].HeaderText = "구분코드";
                DgvResult.Columns[3].HeaderText = "구분명"; // 구분명 새로추가
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "출판일";
                DgvResult.Columns[6].HeaderText = "ISBN";
                DgvResult.Columns[7].HeaderText = "책가격";
                // 각 컬럼 넓이 지정
                DgvResult.Columns[0].Width = 68;
                DgvResult.Columns[1].Width = 145;
                DgvResult.Columns[2].Visible = false; // 구분코드를 숨김
                DgvResult.Columns[4].Width = 195;
                DgvResult.Columns[5].Width = 73;
                DgvResult.Columns[7].Width = 68;
            }
        }


        // 셀 값 선택 수정 이벤트 핸들러 
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스의 값
                TxtBookIdx.Text = selData.Cells[0].Value.ToString(); // 책번호
                TxtAuthor.Text = selData.Cells[1].Value.ToString(); // 저자명
                TxtNames.Text = selData.Cells[4].Value.ToString(); // 책제목
                // "2019-03-09" 문자열을 DateTime.Parse() 로 DateTime형으로 변경
                DtpReleaseDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());
                TxtISBN.Text = selData.Cells[6].Value.ToString();
                // "20000" 가격을 숫자형으로 형변환
                // 거의 모든 타입에 *.Parse(string) 메서드가 존재
                NudPrice.Value = Decimal.Parse(selData.Cells[7].Value.ToString());

                TxtBookIdx.ReadOnly = true; // UPDATE 시 PK 인 Division은 변경하면 안됨

                // 콤보박스는 맨 마지막에
                CboDivision.SelectedValue = selData.Cells[2].Value; // 구분코드로 선택 ★★★

                isNew = false; // UPDATE
            }
        }
    }
}