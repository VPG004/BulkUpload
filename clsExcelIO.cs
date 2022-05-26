using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BulkUpload
{
    static class clsExcelIO
    {
        public static void ExportDataToExcel(System.Data.DataTable dtData, Microsoft.Office.Interop.Excel.Worksheet worksheet, int StartRow, int StartCol)
        {
            try
            {
                int rows = dtData.Rows.Count;
                int columns = dtData.Columns.Count;

                var data = new object[rows, columns];

                for (int row = 0; row <= rows - 1; row++)
                {
                    for (int column = 0; column <= columns - 1; column++)
                    {
                        data[row, column] = dtData.Rows[row][column].ToString();
                    }
                }

                int SR = StartRow;
                int SC = StartCol;
                int ER = rows + 1;
                int EC = columns;

                var startCell = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[SR, SC];
                var endCell = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[ER, EC];
                var writeRange = worksheet.get_Range(startCell, endCell);

                writeRange.Value2 = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ExportDataToExcel(System.Data.DataTable dtData, Excel.Workbook xlWorkBook, String xlWorkSheetName)
        {
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            try
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[xlWorkSheetName];
            }
            catch
            {
                xlWorkSheet = new Excel.Worksheet();
                xlWorkSheet.Name = xlWorkSheetName;
                xlWorkBook.Worksheets.Add(xlWorkSheet, misValue, misValue, misValue);
            }
        }

        public static void GenerateReports(string[] Query)
        {

            Array.Reverse(Query);
            System.Data.DataTable dt = null;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet = null;
            Excel.Sheets xlSheets = null;

            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;

            try
            {
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                string[] Patches;

                for (int i = 0; i < Query.Length; i++)
                {
                    Patches = Query[i].ToString().Split('@');
                    dt = ExcecuteQueryGetDatatable(Patches[0].ToString());
                    xlSheets = xlWorkBook.Sheets as Excel.Sheets;
                    xlWorkSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                    xlWorkSheet.Name = Patches[1].ToString();

                    xlApp.Visible = true;
                    Excel.Style style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add(Patches[1].ToString(), misValue);
                    style.Font.Bold = true;
                    style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);

                    for (int x = 1; x <= dt.Columns.Count; x++)
                    {
                        xlWorkSheet.Cells[1, x] = dt.Columns[x - 1].ColumnName;
                    }
                    xlWorkSheet.get_Range("A1", "A1").EntireColumn.NumberFormat = "@";

                    xlWorkSheet.get_Range("A1", "BR1").Style = Patches[1].ToString();

                    clsExcelIO.ExportDataToExcel(dt, xlWorkSheet, 2, 1);

                    xlWorkSheet.Cells.EntireColumn.AutoFit();

                    releaseObject(xlApp);
                    releaseObject(xlWorkBook);
                    releaseObject(xlWorkSheet);
                }

                MessageBox.Show("Data Exported Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public static System.Data.DataTable ExcecuteQueryGetDatatable(string Query)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataAdapter dap = null;

            System.Data.DataTable dt = null;
            try
            {

                con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Quotes_ConnectionString"].ConnectionString);
                con.Open();
                cmd = new SqlCommand(Query, con);
                dap = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                dap.Fill(dt);

                return dt;
            }
            catch
            {
                return dt;
            }
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
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
