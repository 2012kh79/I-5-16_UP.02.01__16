using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;



namespace UP_02._01
{
    public partial class DocumentChangeForm : Form
    {
        public DocumentChangeForm()
        {
            InitializeComponent();
            
        }

        public void DocumentChangeForm_Load(object sender, EventArgs e)
        {
           DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateDocumentChangeForm = this;
            classDynamicObjects.DocumentChangeFormFill();
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
    }
}
