using Apteka.Models.Core;

namespace Apteka.Users
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmUser()
        {
            InitializeComponent();
            Init();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            cbStatus.Properties.DataSource = db.Status.GetSp();
            cbRole.Properties.DataSource = db.Role.GetSp();
        }

        private static void Init()
        {
            //lbUser.Text = GlobalVars.UserInfo;

            //if (GlobalVars.UserAccess.Contains("3000")) lbList.Items.Add("АРМ Тех. Паспорт");
            //if (GlobalVars.UserAccess.Contains("3010")) lbList.Items.Add("АРМ Ишончнома");
            //if (GlobalVars.UserAccess.Contains("3020")) lbList.Items.Add("АРМ Тақиқ");
            //if (GlobalVars.UserAccess.Contains("3030")) lbList.Items.Add("Созлаш");
            //if (GlobalVars.UserAccess.Contains("3040")) lbList.Items.Add("Созлаш чоп этиш формалари");
            //if (GlobalVars.UserAccess.Contains("3050")) lbList.Items.Add("Хисоботлар");
            //if (GlobalVars.UserAccess.Contains("3060")) lbList.Items.Add("Тех. Паспорт (янги)");
            //if (GlobalVars.UserAccess.Contains("3070")) lbList.Items.Add("Тех. Паспорт (ўзгартириш)");
            //if (GlobalVars.UserAccess.Contains("3080")) lbList.Items.Add("Тех. Паспорт (варақа асосида)");
            //if (GlobalVars.UserAccess.Contains("3090")) lbList.Items.Add("Тех. Паспорт (транзит)");
            //if (GlobalVars.UserAccess.Contains("3100")) lbList.Items.Add("Тех. Паспорт (чоп этиш)");
            //if (GlobalVars.UserAccess.Contains("3110")) lbList.Items.Add("Тех. Паспорт (тўла карточкаси)");
            //if (GlobalVars.UserAccess.Contains("3120")) lbList.Items.Add("Тех. Паспорт (хабарнома)");
            //if (GlobalVars.UserAccess.Contains("3130")) lbList.Items.Add("Тех. Паспорт (тасдиқнома)");
            //if (GlobalVars.UserAccess.Contains("3140")) lbList.Items.Add("Тех. Паспорт (экспорт)");
            //if (GlobalVars.UserAccess.Contains("3150")) lbList.Items.Add("Тех. паспорт тизимидан излаш");
            //if (GlobalVars.UserAccess.Contains("3160")) lbList.Items.Add("Паспорт тизимидан расмини кўриш");
            //if (GlobalVars.UserAccess.Contains("3170")) lbList.Items.Add("Ишончнома (янги)");
            //if (GlobalVars.UserAccess.Contains("3180")) lbList.Items.Add("Ишончнома (ўзгартириш)");
            //if (GlobalVars.UserAccess.Contains("3190")) lbList.Items.Add("Ишончнома (излаш)");
            //if (GlobalVars.UserAccess.Contains("3200")) lbList.Items.Add("Ишончнома (экспорт)");
            //if (GlobalVars.UserAccess.Contains("3210")) lbList.Items.Add("Тақиқ (янги)");
            //if (GlobalVars.UserAccess.Contains("3220")) lbList.Items.Add("Тақиқ (узгартириш)");
            //if (GlobalVars.UserAccess.Contains("3240")) lbList.Items.Add("Тақиқ (излаш)");
            //if (GlobalVars.UserAccess.Contains("3250")) lbList.Items.Add("Тақиқ (экспорт)");
        }
    }
}