using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;

namespace UP_02._01
{
    class ExcelDocument
    {
        public string Group_name = "";
        public DataTable dtDiscipline = new DataTable();
        public DataTable dtStudents = new DataTable();
        public void GroupDisciplineCreate()
        {
            string name = Registry_Class.DirPath + Group_name
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".xlsx";
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet =
                (excel.Worksheet)workbook.ActiveSheet;
            try
            {
                worksheet.Name = Group_name;
                worksheet.Cells[4, 1] = "Код сотрудника";
                worksheet.Cells[4, 2] = "Код табеля ЗП";
                worksheet.Cells[4, 3] = "Код прибыли и расходов";

                for (int i = 0; i < dtStudents.Rows.Count; i++)
                {
                   
                    worksheet.Cells[i + 5, 2] = dtStudents.Rows[i][0].ToString();
                    worksheet.Columns[2].AutoFit();
                }
                for (int i = 0; i < dtDiscipline.Rows.Count; i++)
                {
                    worksheet.Cells[4, i + 3] = dtDiscipline.Rows[i][0].ToString();
                    excel.Range range = worksheet.Cells[4, i + 3];
                    range.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                    range.Font.Size = 10;
                    range.Orientation = excel.XlOrientation.xlUpward;
                    range.WrapText = true;
                }
                
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                workbook.SaveAs(name, application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}
