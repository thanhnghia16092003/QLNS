using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using ms = Microsoft.Office.Interop.Excel;

namespace QLKNCSDL
{
    class clthaotac
    {
        public static void ExportExcel(DataGridView dgr)
        {
            System.Globalization.CultureInfo old = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //ms.ApplicationClass exa = new ms.ApplicationClass();
            ms.Application exa = new ms.Application();
            ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
            ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
            exa.Visible = true;
            int colum = dgr.Columns.Count;
            int row = dgr.Rows.Count;
            for (int i = 0; i < colum; i++)
            {
                ws.Cells[1, i + 1] = dgr.Columns[i].HeaderText;
            }
            ms.Range ran1 = ws.get_Range("A1", "J1");
            ran1.Font.Bold = true;
            ran1.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < colum; j++)
                {
                    try
                    {
                        if (dgr[j, i].Value.ToString().Trim() != "")
                            //ws.Cells[i + 2, j + 1] = "=\"" + dgr[j, i].Value + "\"";
                            ws.Cells[i + 2, j + 1] = dgr[j, i].Value;
                    }
                    catch { }
                }
            }
            ws.PageSetup.FitToPagesWide = 1;
            ws.Columns.AutoFit();

            ms.Range ran = ws.get_Range("A1", "J" + (row + 1));
            ran.Font.Name = "Times New Roman";
            ran.Borders.Value = 1;
            ws.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            ws.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;

            System.Threading.Thread.CurrentThread.CurrentCulture = old;
        }
    }
}
