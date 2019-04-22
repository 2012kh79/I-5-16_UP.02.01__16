using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word = Microsoft.Office.Interop.Word;

namespace UP_02._01
{
    class WordDocument
    {
        public DataTable table = new DataTable();
        public string kadr_uchet_name = "";
        public string check_name = "";
        public string vidanie_medicamenti_name = "";


        public void Kadr_Uchet_Word()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\КУ_" + kadr_uchet_name
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
                range.Text = Registry_Class.OrganizationName;
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
                Name_Doc.Range.Text = "КАДРОВЫЙ УЧЕТ " + kadr_uchet_name;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbKadrUchet = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);
                tbKadrUchet.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbKadrUchet.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbKadrUchet.Cell(1, 1).Range.Text = "Код кадрового учета";
                tbKadrUchet.Cell(1, 2).Range.Text = "Фамилия имя отчество сотрудника";
                tbKadrUchet.Cell(1, 3).Range.Text = "Код табеля заработной платы";
                tbKadrUchet.Cell(1, 4).Range.Text = "Код прибыли и расходов";


                tbKadrUchet.Range.Font.Size = 11;
                tbKadrUchet.Range.Font.Name = "Times New Roman";
                tbKadrUchet.Columns[1].AutoFit();
                for (int i = 2; i <= tbKadrUchet.Rows.Count; i++)
                    for (int j = 1; j <= tbKadrUchet.Columns.Count; j++)
                    {
                        tbKadrUchet.Cell(i, j).Range.Text
                            = table.Rows[i - 2][j - 1].ToString();
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


        public void Vidanie_Medicamenti_Word()
        {

            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\ВМ_" + vidanie_medicamenti_name
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
                range.Text = Registry_Class.OrganizationName;
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
                Name_Doc.Range.Text = "ВЫДАННЫЕ МЕДИКАМЕНТЫ " + vidanie_medicamenti_name;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbMedicamenti = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);
                tbMedicamenti.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbMedicamenti.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbMedicamenti.Cell(1, 1).Range.Text = "Код выданных медикаментов";
                tbMedicamenti.Cell(2, 1).Range.Text = "Количество выданных медикаментов";
                tbMedicamenti.Cell(3, 1).Range.Text = "Код чека";
                tbMedicamenti.Range.Font.Size = 11;
                tbMedicamenti.Range.Font.Name = "Times New Roman";
                tbMedicamenti.Columns[1].AutoFit();
                for (int i = 2; i <= tbMedicamenti.Rows.Count; i++)
                    for (int j = 1; j <= tbMedicamenti.Columns.Count; j++)
                    {
                        tbMedicamenti.Cell(i, j).Range.Text
                            = table.Rows[i - 2][j - 1].ToString();
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

        public void Check_Word()
        {

            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\ЧВМ_" + vidanie_medicamenti_name
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
                range.Text = Registry_Class.OrganizationName;
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
                Name_Doc.Range.Text = "чек " + check_name;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbCheck = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);
                tbCheck.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbCheck.Cell(1, 1).Range.Text = "Код чека выданных медикаментов";
                tbCheck.Cell(2, 1).Range.Text = "Номер чека выданных медикаментов";
                tbCheck.Cell(3, 1).Range.Text = "Название выданных медикаметнов";
                tbCheck.Cell(4, 1).Range.Text = "Код должности";
                tbCheck.Cell(5, 1).Range.Text = "Код сотрудника";
                tbCheck.Range.Font.Size = 11;
                tbCheck.Range.Font.Name = "Times New Roman";
                tbCheck.Columns[1].AutoFit();
                for (int i = 2; i <= tbCheck.Rows.Count; i++)
                    for (int j = 1; j <= tbCheck.Columns.Count; j++)
                    {
                        tbCheck.Cell(i, j).Range.Text
                            = table.Rows[i - 2][j - 1].ToString();
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
