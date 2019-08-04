using Apteka.Utils;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apteka.Reports
{
    public class ExcelApplication
    {
        Excel.Application objApp;
        Excel._Workbook objBook;

        Excel.Workbooks objBooks;
        Excel.Sheets objSheets;
        Excel._Worksheet objSheet;
        Excel.Range range;
        private int ActiveWorksheetsIndex = 0;

        public void Init(string tempalte, string hash)
        {
            try
            {
                objApp = new Excel.Application();

                objBooks = objApp.Workbooks;
                if (tempalte?.Length == 0)
                    objBook = objBooks.Add(Missing.Value);
                else
                {
                    tempalte = AppDomain.CurrentDomain.BaseDirectory + "\\Reports\\" + tempalte;
                    objBook = objBooks.Add(tempalte);
                }
            }
            catch (Exception ee)
            {
                var li = new LogItem
                {
                    App = "Apteka.Reports",
                    Stacktrace = ee.GetStackTrace(5),
                    Message = ee.GetAllMessages(),
                    Method = "Apteka.Reports.Init"
                };
                CLogJson.Write(li);
                throw;
            }
        }

        public void AutoFit()
        {
            range = objSheet.get_Range("A1", "Z2000");
            objSheet.Columns.AutoFit();

            range.Select();

            range = objSheet.get_Range("A1", "A1");
            range.Select();
        }

        public void SelectSheets(int i)
        {
            objSheets = objBook.Worksheets;
            objSheet = (Excel._Worksheet)objSheets.get_Item(i);
        }

        public void SetRangeValue(string rs, string cs, string[,] sv)
        {
            range = objSheet.get_Range(rs, cs);
            range.set_Value(Missing.Value, sv);
        }

        public void Show()
        {
            objApp.Visible = true;
            objApp.UserControl = true;
        }

        public object GetCell(int row, int col, int worksheetsIndex = 0)
        {
            if (ActiveWorksheetsIndex != worksheetsIndex)
                SelectSheets(worksheetsIndex);
            return objSheet.Cells[row, col].Value;
        }

        /// <summary>
        ///  Set Value   
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="v"></param>
        /// <param name="worksheetsIndex"></param>
        /// <param name="format">@ = Text;  "#,###,###" = Number;  "$ #,###,###.00" = Sum;   "mm/dd/yyyy" = Date  </param>
        public void SetCell(int row, int col, object v, int worksheetsIndex = 1, string format = "@", bool IsBold = false)
        {
            if (ActiveWorksheetsIndex != worksheetsIndex)
                SelectSheets(worksheetsIndex);

            if (IsBold)
                objSheet.Cells[row, col].Font.Bold = true;

            //var formatRange = objSheet.get_Range(row, col);
            //formatRange.NumberFormat = format;

            objSheet.Cells[row, col] = v;
        }

        //public object GetCell(string cell, int worksheetsIndex = 0)
        //{
        //    if (ActiveWorksheetsIndex != worksheetsIndex)
        //        SelectSheets(worksheetsIndex);
        //    return objSheet.Cells[cell];
        //}

        //public void SetCell(string cell, object v, int worksheetsIndex = 0)
        //{
        //    if (ActiveWorksheetsIndex != worksheetsIndex)
        //        SelectSheets(worksheetsIndex);
        //    objSheet.Cells[cell] = v;
        //}

        public void AddBorder(int rs, int cs)
        {
            Excel.Range formatRange = objSheet.UsedRange;
            //  Excel.Range cell = formatRange.Cells[rs, cs];
            //  Excel.Borders border = cell.Borders;
            //border.LineStyle = Excel.XlLineStyle.xlContinuous;
            //border.Weight = 2d;
        }

        public void CellFontBold(int rs, int cs)
        {
            // objSheet.Cells[rs, cs].Font.Bold = true;
        }

        public void AddMultiBorder(string rs, string cs)
        {
            Excel.Range formatRange;
            formatRange = objSheet.get_Range(rs, cs);
            formatRange.BorderAround(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
        }

        public void Marge(string rs, string cs)
        {
            objSheet.Range[rs, cs].Merge(false);
        }

        //public void SaveAs()
        //{
        //    Vars.webView.Dispatcher.BeginInvoke((Action)(() =>
        //    {
        //        var savefile = new Microsoft.Win32.SaveFileDialog();
        //        savefile.Filter = "Excel files (*.xls)|*.xls";
        //        var res = savefile.ShowDialog();
        //        if (res == true)
        //        {
        //            objBook.SaveAs(savefile.FileName, Excel.XlFileFormat.xlWorkbookNormal, Missing.Value, Missing.Value,
        //                Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive,
        //                Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
        //        }
        //    }));
        //}

        public void Save(string path)
        {
            objBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
        }

        public void Close()
        {
            objBooks.Close();
            objApp.Quit();

            ReleaseObject(objApp);
            ReleaseObject(objBook);
            ReleaseObject(objSheet);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
