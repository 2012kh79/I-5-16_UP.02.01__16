using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word = Microsoft.Office.Interop.Word;

namespace UP_02._01
{
    class WordDocument
    {
        public DataTable table = new DataTable();
       

        public void CheckWord()
        {

            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\ЧВМ_" + 
                 DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "ЧЕК ВЫДАННЫХ МЕДИКАМЕНТОВ";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbCheck = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);

                tbCheck.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Cell(1, 1).Range.Text = "Номер чека";
                tbCheck.Cell(1, 2).Range.Text = "Название медикаментов";
                tbCheck.Cell(1, 3).Range.Text = "Код должности";
                tbCheck.Cell(1, 4).Range.Text = "Код сотрудников";
                tbCheck.Range.Font.Size = 11;
                tbCheck.Range.Font.Name = "Times New Roman";
                tbCheck.Columns[1].AutoFit();
                for (int i = 2; i <= tbCheck.Rows.Count; i++)
                    for (int j = 1; j <= tbCheck.Columns.Count; j++)
                    {
                        tbCheck.Cell(i, j).Range.Text = table.Rows[i-2][j-1].ToString();
                    }

            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }

        public void Kadr_UchetWord()
        {

            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\КУ_" 
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "КАДРОВЫЙ УЧЕТ" ;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbCheck = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);

                tbCheck.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Cell(1, 1).Range.Text = "Код сотрудника";
                tbCheck.Cell(1, 2).Range.Text = "Код табеля ЗП";
                tbCheck.Cell(1, 3).Range.Text = "Код прибыли и расходов";
                tbCheck.Range.Font.Size = 11;
                tbCheck.Range.Font.Name = "Times New Roman";
                tbCheck.Columns[1].AutoFit();
                for (int i = 2; i <= tbCheck.Rows.Count; i++)
                    for (int j = 1; j <= tbCheck.Columns.Count; j++)
                    {
                        tbCheck.Cell(i, j).Range.Text = table.Rows[i - 2][j - 1].ToString();
                    }

            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }


        public void Vih_DocWord()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\ВД_" 
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
               
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "ВЫХОДНЫЕ ДОКУМЕНТЫ";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbCheck = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);

                tbCheck.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Cell(1, 1).Range.Text = "Код продажи товара";
                tbCheck.Cell(1, 2).Range.Text = "Код кадрового учета";
                tbCheck.Cell(1, 3).Range.Text = "Код идентификации товарных партий";
                tbCheck.Range.Font.Size = 11;
                tbCheck.Range.Font.Name = "Times New Roman";
                tbCheck.Columns[1].AutoFit();
                for (int i = 2; i <= tbCheck.Rows.Count; i++)
                    for (int j = 1; j <= tbCheck.Columns.Count; j++)
                    {
                        tbCheck.Cell(i, j).Range.Text = table.Rows[i - 2][j - 1].ToString();
                    }

            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }



    }
}