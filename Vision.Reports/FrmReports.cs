using Apteka.DataModels.Reports;
using Apteka.UtilsUI;
using Apteka.UtilsUI.GridFunctions;
using System;
using System.IO;
using System.Windows.Forms;

namespace Apteka.Reports
{
    public partial class FrmReports : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int RepIndex;
      
        private ReportGridForms ReportConfig;
        public FrmReports()
        {
            InitializeComponent();
            dockManager1.ForceInitialize();
        }

        private void FrmKassa_Load(object sender, EventArgs e)
        {
            edDate1.DateTime = DateTime.Now.AddMonths(-1);
            edDate2.DateTime = DateTime.Now; 

            var FileManagerPath = Vars.DockManagerPath + "Report.xml";
            if (File.Exists(FileManagerPath))
                dockManager1.RestoreLayoutFromXml(FileManagerPath);
        } 

        private void FrmKassa_FormClosed(object sender, FormClosedEventArgs e)
        {
            var FileManagerPath = Vars.DockManagerPath + "Report.xml";
            dockManager1.SaveLayoutToXml(FileManagerPath);

            if (gridControl.DataSource != null)
                ReportConfig.Save(gridView);
        } 

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportClass.ExportGrid(gridView);
        }

        private void btnRun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var d1 = $"{edDate1.DateTime:yyyy-MM-dd}";
            var d2 = $"{edDate2.DateTime:yyyy-MM-dd}";
            var sql = "SELECT * FROM dbo.{0}( '{1}', '{2}' )";
            switch (RepIndex)
            {
                case 1:
                    //Приходы
                    gridControl.DataSource = SqlExec.Run(sql, "repPrihod", d1, d2);
                    break;
                case 2:
                    //Списание
                    gridControl.DataSource = SqlExec.Run(sql, "repSpisaniya", d1, d2);
                    break;
                case 3:
                    //Продажа
                    gridControl.DataSource = SqlExec.Run(sql, "repProdaja", d1, d2);
                    break;
                case 4:
                    //Отчет по долгам
                    gridControl.DataSource = SqlExec.Run(sql, "repDolg", d1, d2);
                    break;
                case 5:
                    //Статистика возвратов
                    gridControl.DataSource = SqlExec.Run(sql, "repVozvrat", d1, d2);
                    break;
                case 6:
                    //Дисконт карта
                    gridControl.DataSource = SqlExec.Run(sql, "repDiskontCard", d1, d2);
                    break;
                case 7:
                    //Анализ сотрудников
                    gridControl.DataSource = SqlExec.Run(sql, "repUserAnaliz", d1, d2);
                    break;
                case 8:
                    //Популярный товар
                    gridControl.DataSource = SqlExec.Run(sql, "repPopularProduct", d1, d2);
                    break;
                case 9:
                    //Прибыльный товар
                    gridControl.DataSource = SqlExec.Run(sql, "repPribilniy", d1, d2);
                    break;
                case 10:
                    //Неликвидный товар
                    gridControl.DataSource = SqlExec.Run(sql, "repNelikvidniy", d1, d2);
                    break;
                case 11:
                    //Срок годности 
                    gridControl.DataSource = SqlExec.Run(sql, "repSrokgodnost", d1, d2);
                    break;
                case 12 :
                    //Бронирование
                    gridControl.DataSource = SqlExec.Run(sql, "repBron", d1, d2);
                    break;
                case 13:
                    //Анализ постовшиков
                    gridControl.DataSource = SqlExec.Run(sql, "repDistributors", d1, d2);
                    break;
                case 14:
                    //Средный чек
                    gridControl.DataSource = SqlExec.Run(sql, "repSerdinyChek", d1, d2);
                    break;
                case 15:
                    //Ценовые сегменты
                    gridControl.DataSource = SqlExec.Run(sql, "repSklad", d1, d2);
                    break;
            }

            ReportConfig = new ReportGridForms();
            ReportConfig.Load(gridView, ribbonPage1.Text);
        }
    }
}

/*
    1  Приходы
    2  Списание
    3  Продажа
    4  Отчет по долгам
    5  Отказы статистика
    6  Дисконт карта
    7  Анализ сотрудников
    8  Популярный товар
    9  Прибыльный товар
    10 Неликвидный товар
    11 Срок годности 
    12 Бронирование
    13 Анализ постовшиков
    14 Средный чек
    15 Ценовые сегменты
*/




















