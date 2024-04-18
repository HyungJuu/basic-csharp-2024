using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        // 이름입력 이벤트핸들러
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        // 아이디입력 이벤트핸들러
        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        // 취소버튼 이벤트핸들러
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Login relogin = new Login();
            relogin.Show();
            this.Close();
        }
    }
}
