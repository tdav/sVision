using System.Windows.Forms;

namespace Apteka.Others
{
    public partial class ImputBoxDev : DevExpress.XtraEditors.XtraForm
    {
        public ImputBoxDev()
        {
            InitializeComponent();
        }

        public static string Show(string text, string caption = "Информация")
        {
            var f = new ImputBoxDev();
            f.Text = caption;
            f.labelControl1.Text = text;
            return f.edTxt.Text;
        }
    }
}