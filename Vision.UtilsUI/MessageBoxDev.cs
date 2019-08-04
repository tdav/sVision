using System.Windows.Forms;

namespace Apteka.Others
{
    public partial class MessageBoxDev : DevExpress.XtraEditors.XtraForm
    {
        public MessageBoxDev()
        {
            InitializeComponent();
        }

        public static DialogResult ShowInfo(string text, string caption= "Информация")
        {
            var f = new MessageBoxDev();
            f.Text = caption;
            f.labelControl1.Text = text;
            return f.ShowDialog();
        }

        public static DialogResult ShowMess(string text, string caption = "Информация")
        {
            var f = new MessageBoxDev();
            f.btnClose.Text = "Закрыть";
            f.btnClose.Width += 30;
            f.btnClose.Left -= 30;
            f.btnSave.Visible = false;
            f.Text = caption;
            f.labelControl1.Text = text;
            return f.ShowDialog();
        }
    }
}