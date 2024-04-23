using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        // 각 화면을 초기화
        FrmLoginUser frmLoginUser = null; // 객체를 메서드로 생성
        FrmBookDivision frmBookDivision = null;
        FrmBookInfo frmBookInfo = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        // 폼로드 이벤트핸들러. 로그인창을 먼저 띄워야 함
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true; // 가장위로
            frm.ShowDialog();
        }

        // 관리
        private void MnuLoginUsers_Click(object sender, EventArgs e)
        {
            // 이미 창이 열려있으면 새로 생성할 필요가 없기 때문에
            // 이 작업을 하지 않으면 메뉴를 클릭할 때마다 새 폼이 열림
            frmLoginUser = ShowActiveForm(frmLoginUser,typeof(FrmLoginUser)) as FrmLoginUser;
        }

        // 책장르 관리 메뉴클릭 이벤트핸들러
        private void MnuBookDivision_Click(object sender, EventArgs e)
        {
            frmBookDivision = ShowActiveForm(frmBookDivision,typeof(FrmBookDivision)) as FrmBookDivision;
        }

        // 책정보 관리 메뉴클릭 이벤트핸들러
        private void MnuBookInfo_Click(object sender, EventArgs e)
        {
            // 객체변수, 객체변수, 클래스, 클래스
            frmBookInfo = ShowActiveForm(frmBookInfo,typeof(FrmBookInfo)) as FrmBookInfo;
        }


        Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 화면이 한번도 열리지 않았다면
            {
                form = Activator.CreateInstance(type) as Form; // 타입은 클래스타입
                form.MdiParent = this; // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 창이 한번 닫혔으면
                {
                    form = Activator.CreateInstance(type) as Form;
                    form.MdiParent = this; // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 최소화, 열려있으면
                {
                    form.Activate();
                }
            }
            return form;
        }

    }
}
