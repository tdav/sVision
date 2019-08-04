using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace Apteka.Reports
{
    public class WordApp
    {
        public  Word._Application application;
        public  Word._Document document;
        private object missingObj = System.Reflection.Missing.Value;
        private object trueObj = true;
        private object falseObj = false;


        public void Init(string templateParh="", string hash="")
        {
            application = new Word.Application();
            object templatePathObj = templateParh;

            try
            {
                if (templateParh == String.Empty)
                    document = application.Documents.Add(ref missingObj, ref missingObj, ref missingObj, ref missingObj);
                else
                {
                    templatePathObj = AppDomain.CurrentDomain.BaseDirectory + "\\reports\\" + templatePathObj;
                    document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                }
            }
            catch (Exception)
            {
                document.Close(ref falseObj, ref missingObj, ref missingObj);
                application.Quit(ref missingObj, ref missingObj, ref missingObj);
                document = null;
                application = null;
                throw;
            }
            
        }

        public void Show()
        {
            application.Visible = true;
        }

        public void InsPicture(string path)
        {
            if (!File.Exists(path)) return;
            var shape = document.InlineShapes.AddPicture(path, false, true);

            shape.Width = 87;
            shape.Height = 112;
            var sh = shape.ConvertToShape();
            sh.Top = 77;
            sh.Left = 455;
        }

        public void InsText(string val)
        {
            application.Selection.TypeText(val);
        }

        public void Replace(string oldText, string newText)
        {
            object strToFindObj = oldText;
            object replaceStrObj = newText;

            Word.Range wordRange;
            object replaceTypeObj;
            replaceTypeObj = Word.WdReplace.wdReplaceAll;

            for (int i = 1; i <= document.Sections.Count; i++)
            {
                wordRange = document.Sections[i].Range;

                /*
                Обходим редкий глюк в Find, ПРИЗНАННЫЙ MICROSOFT, метод Execute на некоторых машинах вылетает с ошибкой "Заглушке переданы неправильные данные / Stub received bad data"  Подробности: http://support.microsoft.com/default.aspx?scid=kb;en-us;313104
                // выполняем метод поиска и  замены обьекта диапазона ворд
                wordRange.Find.Execute(ref strToFindObj, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref replaceStrObj, ref replaceTypeObj, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing);
                */

                Word.Find wordFindObj = wordRange.Find;
                object[] wordFindParameters = new object[15] { strToFindObj, missingObj,
                    missingObj, missingObj, missingObj, missingObj,
                    missingObj, missingObj, missingObj, replaceStrObj, replaceTypeObj,
                    missingObj, missingObj, missingObj, missingObj };

                wordFindObj.GetType().
                    InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
            }

        }

        /*
        private void SearchReplace()
        {
            Word.Find findObject = Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = "find me";
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = "Found";

            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }
        */

        public void TableNewRow(int tableNumber)
        {
            Word.Table _table = document.Tables[tableNumber];
            _table.Rows.Add(ref missingObj);
        }

        public void TableMarge(int tableNumber, int cellOneRowIndex, int cellOneColIndex,
           int cellTwoRowIndex, int cellTwoColIndex)
        {
            Word.Table _table = document.Tables[tableNumber];
            _table.Rows[cellOneRowIndex].Cells[cellOneColIndex].Merge(
                _table.Rows[cellTwoRowIndex].Cells[cellTwoColIndex]);
        }

        public void TableCell(int tableNumber, int rowIndex, int columnIndex, string val, int b)
        {
            Word.Table _table = document.Tables[tableNumber];
            _table.Cell(rowIndex, columnIndex).Range.Font.Bold = b;
            _table.Cell(rowIndex, columnIndex).Range.InsertAfter(val);



        }

        public void TypeParagraph()
        {
            application.Selection.TypeParagraph();

        }

        public void TableDelRow(int i, int r)
        {
            Word.Table _table = document.Tables[i];
            _table.Rows[r].Delete();
        }


        public void Close()
        {
            document.Close();
            application.Quit();

            ReleaseObject(document);
            ReleaseObject(application);
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
