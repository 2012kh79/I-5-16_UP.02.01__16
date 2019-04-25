using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;



namespace UP_02._01
{
    public partial class DocumentChangeForm : Form
    {
        DynamicObjects classDynamicObjects = new DynamicObjects();
        DataBaseTables tables = new DataBaseTables();
        public DocumentChangeForm()
        {
            InitializeComponent();
            
        }

        public void DocumentChangeForm_Load(object sender, EventArgs e)
        {
            classDynamicObjects.aggregateDocumentChangeForm = this;
            classDynamicObjects.DocumentChangeFormFill();
            Thread thread = new Thread(dgvVid_documentFill);
            thread.Start();
            Thread thread1 = new Thread(dgvDogovorFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvZar_plataFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvKadr_perestanovkiFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvKadr_uchetFill);
            thread4.Start();
            Thread thread5 = new Thread(dgvFirmaFill);
            thread5.Start();
            Thread thread6 = new Thread(dgvIdent_tov_partyFill);
            thread6.Start();
            Thread thread7 = new Thread(dgvVih_docFill);
            thread7.Start();
        }

        private void btKadr_UchetWord_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty" || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                    Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    AppConfigForm configForm = new AppConfigForm();
                    configForm.ShowDialog();
                    break;

                case (false):
                    btKadr_UchetWord.Enabled = false;
                    DataBaseTables data = new DataBaseTables();
                    data.qrKadr_uchet = "select [sotrudnik_id] as \"Код сотрудника\" ,[tabel_zarplata_id] as \"Код табеля ЗП\", [pribil_i_rashodi_id] as \"Код прибыли и расходов\" from [dbo].[kadr_uchet]";
                    data.dtKadr_uchetFill();
                    WordDocument document = new WordDocument();
                    document.table = data.dtKadr_uchet;

                    document.Kadr_UchetWord();
                    btKadr_UchetWord.Enabled = true;
                    break;
            }
        }

        private void btVih_DocWord_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty"|| Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    AppConfigForm configForm = new AppConfigForm();
                    configForm.ShowDialog();
                    break;
                case (false):
                    btVih_DocWord.Enabled = false;
                    DataBaseTables data = new DataBaseTables();
                    data.qrVih_doc = "select [prodaja_tovara_id] as \"Код продажи товара\",[kadr_uchet_id] as \"Код кадрового учета\", [ident_tov_party_id] as \"Код идентификации товарных партий\" from [dbo].[vih_doc]";
                    data.dtVih_docFill();
                    WordDocument document = new WordDocument();
                    document.table = data.dtVih_doc;

                    document.Vih_DocWord();
                    btVih_DocWord.Enabled = true;
                    break;
            }
        }

        private void btKadr_UchetExcel_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty" || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                    Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    AppConfigForm configForm = new AppConfigForm();
                    configForm.ShowDialog();
                    break;

                case (false):
                    btVih_DocWord.Enabled = false;
                    DataBaseTables data = new DataBaseTables();

                    data.qrKadr_uchet = "select [sotrudnik_id] as \"Код сотрудника\" ,[tabel_zarplata_id] as \"Код табеля ЗП\", [pribil_i_rashodi_id] as \"Код прибыли и расходов\" from [dbo].[kadr_uchet]";
                    ExcelDocument document = new ExcelDocument();
                    document.GroupDisciplineCreate();
                    btVih_DocWord.Enabled = true;
                    break;
            }
        }

        public void dgvVid_documentFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtDocumentFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvVidDocument.DataSource = tables.dtDocument;
                    dgvVidDocument.Columns[0].Visible = false;
                    dgvVidDocument.Columns[1].HeaderText = "Вид документа";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvDogovorFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtDogovorFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvDogovor.DataSource = tables.dtDogovor;
                    dgvDogovor.Columns[0].Visible = false;
                    dgvDogovor.Columns[1].HeaderText = "Номер приказа";
                    dgvDogovor.Columns[2].HeaderText = "Дата составления приказа";
                    dgvDogovor.Columns[3].HeaderText = "Фирма";
                    dgvDogovor.Columns[4].Visible = false;
                    dgvDogovor.Columns[5].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvZar_plataFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtTabel_zarplataFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvTabelSarplaty.DataSource = tables.dtTabel_zarplata;
                    dgvTabelSarplaty.Columns[0].Visible = false;
                    dgvTabelSarplaty.Columns[1].HeaderText = "Зарплата";
                    dgvTabelSarplaty.Columns[2].HeaderText = "Кадровые перестановки";
                    dgvTabelSarplaty.Columns[3].Visible = false;
                    dgvTabelSarplaty.Columns[4].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvKadr_perestanovkiFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtKadr_perestanovkiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvKadrPerestanovki.DataSource = tables.dtKadr_perestanovki;
                    dgvKadrPerestanovki.Columns[0].Visible = false;
                    dgvKadrPerestanovki.Columns[1].HeaderText = "Дата подписи документа";
                    dgvKadrPerestanovki.Columns[2].HeaderText = "Сотрудник";
                    dgvKadrPerestanovki.Columns[3].HeaderText = "Должнсть";
                    dgvKadrPerestanovki.Columns[4].HeaderText = "Документ";
                    dgvKadrPerestanovki.Columns[5].HeaderText = "Соискатель";
                    dgvKadrPerestanovki.Columns[6].Visible = false;
                    dgvKadrPerestanovki.Columns[7].Visible = false;
                    dgvKadrPerestanovki.Columns[8].Visible = false;
                    dgvKadrPerestanovki.Columns[9].Visible = false;
                    dgvKadrPerestanovki.Columns[10].Visible = false;
                    dgvKadrPerestanovki.Columns[11].Visible = false;
                    dgvKadrPerestanovki.Columns[12].Visible = false;
                    dgvKadrPerestanovki.Columns[13].Visible = false;
                    dgvKadrPerestanovki.Columns[14].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvKadr_uchetFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtKadr_uchetFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvKadrUchet.DataSource = tables.dtKadr_uchet;
                    dgvKadrUchet.Columns[0].Visible = false;
                    dgvKadrUchet.Columns[1].HeaderText = "Сотрудник";
                    dgvKadrUchet.Columns[2].HeaderText = "Табель зарплаты";
                    dgvKadrUchet.Columns[3].HeaderText = "Прибыль и расходы";
                    dgvKadrUchet.Columns[4].Visible = false;
                    dgvKadrUchet.Columns[5].Visible = false;
                    dgvKadrUchet.Columns[6].Visible = false;
                    dgvKadrUchet.Columns[7].Visible = false;
                    dgvKadrUchet.Columns[8].Visible = false;
                    dgvKadrUchet.Columns[9].Visible = false;
                    dgvKadrUchet.Columns[10].Visible = false;
                    dgvKadrUchet.Columns[11].Visible = false;
                    dgvKadrUchet.Columns[12].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvFirmaFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtFirmaFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvFirma.DataSource = tables.dtFirma;
                    dgvFirma.Columns[0].Visible = false;
                    dgvFirma.Columns[1].HeaderText = "Название фирмы";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvIdent_tov_partyFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtIdent_tov_partyFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvIdentTovParty.DataSource = tables.dtIdent_tov_party;
                    dgvIdentTovParty.Columns[0].Visible = false;
                    dgvIdentTovParty.Columns[1].HeaderText = "Вид документа";
                    dgvIdentTovParty.Columns[2].HeaderText = "Товарный статус";
                    dgvIdentTovParty.Columns[3].HeaderText = "Поставка";
                    dgvIdentTovParty.Columns[4].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvVih_docFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtVih_docFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvVihCocument.DataSource = tables.dtVih_doc;
                    dgvVihCocument.Columns[0].Visible = false;
                    dgvVihCocument.Columns[1].HeaderText = "Продажа товара";
                    dgvVihCocument.Columns[2].HeaderText = "Кадровый учет";
                    dgvVihCocument.Columns[3].HeaderText = "Идентификация товарных партий";
                    dgvVihCocument.Columns[4].Visible = false;
                    dgvVihCocument.Columns[5].Visible = false;
                    dgvVihCocument.Columns[6].Visible = false;
                    dgvVihCocument.Columns[7].Visible = false;
                    dgvVihCocument.Columns[8].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void tcnTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((TabControl)sender).SelectedIndex;
            switch (index)
            {
                case 0:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_VidChangeFormFill();
                    }
                    break;
                case 1:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_DogovoraChangeFormFill();
                    }
                    break;
                case 2:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Zar_plataChangeFormFill();
                    }
                    break;
                case 3:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Kadr_perestanovkiChangeFormFill();
                    }
                    break;
                case 4:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Kadr_uchetChangeFormFill();
                    }
                    break;
                case 5:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_FirmaChangeFormFill();
                    }
                    break;
                case 6:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_IdentChangeFormFill();
                    }
                    break;
                case 7:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_VihChangeFormFill();
                    }
                    break;
            }
        }
    }
}
