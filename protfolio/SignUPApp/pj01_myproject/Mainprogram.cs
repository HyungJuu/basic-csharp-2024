using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pj01_myproject
{
    public partial class Mainprogram : MetroForm
    {
        public Mainprogram()
        {
            InitializeComponent();
        }

        #region '창닫기'
        // 창닫기 이벤트핸들러
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
