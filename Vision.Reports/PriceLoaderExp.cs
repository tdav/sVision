using Apteka.Models.Entity;
using Apteka.Utils;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Apteka.Reports
{
    public static class PriceLoaderExp
    {

        public static void Export(this List<tbPriceListItem> list, string header)
        {
            try
            {
                Workbook wb = new Workbook();
                var ea = wb.Worksheets[0];
                ea.Cells[0, 0].Value = header;

                ea.Cells[2, 0].Value = "Наименование";
                ea.Cells[2, 1].Value = "Наименование (прайс)";
                ea.Cells[2, 2].Value = "Производитель";
                ea.Cells[2, 3].Value = "Производитель (прайс)";
                ea.Cells[2, 4].Value = "Количество";
                ea.Cells[2, 5].Value = "Цена";
                ea.Cells[2, 6].Value = "Базовая цена";
                ea.Cells[2, 7].Value = "Наценка(%)";
                ea.Cells[2, 8].Value = "Форма выпуска";
                ea.Cells[2, 9].Value = "Срок годности";

                int i = 3;
                foreach (var it in list)
                {
                    ea.Cells[i, 0].Value = it.Name;
                    ea.Cells[i, 1].Value = it.VendorDrugName;
                    ea.Cells[i, 2].Value = it.Manufacturer;
                    ea.Cells[i, 3].Value = it.VendorManufacturer;
                    ea.Cells[i, 4].Value = it.Qty;
                    ea.Cells[i, 5].Value = it.Price;
                    ea.Cells[i, 6].Value = it.BasePrice;
                    ea.Cells[i, 7].Value = it.ExtraCharge;
                    ea.Cells[i, 8].Value = it.Unit;
                    ea.Cells[i, 9].Value = it.ExpiryDate;
                    i++;
                }

                var filename = "1.xls";
                ea.Columns.AutoFit(0, 9);
                wb.SaveDocument(filename, DocumentFormat.Xls);
                Process.Start(filename);
            }
            catch (Exception ee)
            {
                var li = new LogItem
                {
                    App = "Apteka.Reports",
                    Stacktrace = ee.GetStackTrace(5),
                    Message = ee.GetAllMessages(),
                    Method = "PriceLoader.Export"
                };
                CLogJson.Write(li);
                throw;
            }
        }
    }
}
