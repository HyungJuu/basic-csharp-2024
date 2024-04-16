namespace ex18_winControlApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // ���� OS���� ��ġ�� ��Ʈ�� ��� ������
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }
        }
        // ����ü, ����, ���Ÿ����� �����ϴ� �޼���
        void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0)    // �ƹ��͵� ���þ���
                return;

            FontStyle style = FontStyle.Regular; // �Ϲ� ����(����, ���Ÿ� X)�� �ʱ�ȭ

            if (ChkBold.Checked == true) // ���� üũ�ڽ��� �����ϸ�
                style |= FontStyle.Bold;

            if (ChkItalic.Checked == true)
                style |= FontStyle.Italic; // ���Ÿ� üũ�ڽ��� �����ϸ�

            TxtSampleText.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
