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
            switch (Registry_Class.DirPath == "Empty")
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
            switch (Registry_Class.DirPath == "Empty")
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
                        cmbFirmaFill();
                    }
                    break;
                case 2:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Zar_plataChangeFormFill();
                        cmbKadr_perestanovkiFill();
                    }
                    break;
                case 3:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Kadr_perestanovkiChangeFormFill();
                        cmbSFill();
                        cmbSoiskatelFill();
                        cmbDocumentFill();
                        cmbDoljnostFill();
                    }
                    break;
                case 4:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_Kadr_uchetChangeFormFill();
                        cmbSotrudnikFill();
                        cmbTabel_zarplataFill();
                        cmbPribil_i_rashodiFill();
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
                        cmbPostavkaiFill();
                    }
                    break;
                case 7:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Document_VihChangeFormFill();
                        cmbProdaja_tovFill();
                        cmbKadr_uchetFill();
                        cmbIdentFill();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainFrm = new MainForm();
            this.Hide();
            mainFrm.Show();
        }

        private void dgvVidDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdVid_doc = (dgvVidDocument.CurrentRow.Index + 1).ToString();
            classDynamicObjects.tbVidDocumentDoc.Text = dgvVidDocument.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvDogovor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdDogovor = (dgvDogovor.CurrentRow.Index + 1).ToString();

                    classDynamicObjects.tbNomberOrderDoc.Text = dgvDogovor.CurrentRow.Cells[1].Value.ToString();
                    classDynamicObjects.tbDateOrdetDoc.Text = dgvDogovor.CurrentRow.Cells[2].Value.ToString();
                    classDynamicObjects.cmbIDFirm.SelectedValue = Convert.ToInt32(dgvDogovor.CurrentRow.Cells[3].Value);
              
        }

        private void dgvTabelSarplaty_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
                    classDynamicObjects.NewIdZar_plata = (dgvTabelSarplaty.CurrentRow.Index + 1).ToString();
                    classDynamicObjects.tbZarplata.Text = dgvTabelSarplaty.CurrentRow.Cells[1].Value.ToString();
                    classDynamicObjects.cmbIDKadrPere.SelectedValue = Convert.ToInt32(dgvTabelSarplaty.CurrentRow.Cells[2].Value);
             

           
        }

        private void dgvKadrPerestanovki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdKadr_perestanovki = (dgvKadrPerestanovki.CurrentRow.Index + 1).ToString();

                    classDynamicObjects.tbDatePodpisiDoc.Text = dgvKadrPerestanovki.CurrentRow.Cells[1].Value.ToString();
                    classDynamicObjects.cmbIDSotrydnik.SelectedValue = Convert.ToInt32(dgvKadrPerestanovki.CurrentRow.Cells[2].Value);
                    classDynamicObjects.cmbIDDoljnosti.SelectedValue = Convert.ToInt32(dgvKadrPerestanovki.CurrentRow.Cells[3].Value);
                    classDynamicObjects.cmbIDDocument.SelectedValue = Convert.ToInt32(dgvKadrPerestanovki.CurrentRow.Cells[4].Value);
                    classDynamicObjects.cmbIDSoiskatel.SelectedValue = Convert.ToInt32(dgvKadrPerestanovki.CurrentRow.Cells[5].Value);

           
        }

        private void dgvKadrUchet_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            classDynamicObjects.NewIdKadr_uchet = (dgvKadrUchet.CurrentRow.Index + 1).ToString();

           
                    classDynamicObjects.cmbIDSotrudnik_KU.SelectedValue = Convert.ToInt32(dgvKadrUchet.CurrentRow.Cells[1].Value);
                    classDynamicObjects.cmbIDTabelZarplata.SelectedValue = Convert.ToInt32(dgvKadrUchet.CurrentRow.Cells[2].Value);
                    classDynamicObjects.cmbIDPribil_i_rashodi.SelectedValue = Convert.ToInt32(dgvKadrUchet.CurrentRow.Cells[3].Value);
           
        }

        private void dgvFirma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdFirma = (dgvFirma.CurrentRow.Index + 1).ToString();

                    classDynamicObjects.tbNazvFirm.Text = dgvFirma.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void dgvIdentTovParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdIdent_tov_party = (dgvIdentTovParty.CurrentRow.Index + 1).ToString();
            classDynamicObjects.tbVidDocIdent.Text = dgvIdentTovParty.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbStatus.Text = dgvIdentTovParty.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.cmbIDPostavka.SelectedValue = Convert.ToInt32(dgvIdentTovParty.CurrentRow.Cells[3].Value);
            
        }

        private void dgvVihCocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                    classDynamicObjects.cmbIDProdajaTov.SelectedValue = Convert.ToInt32(dgvVihCocument.CurrentRow.Cells[1].Value);
                    classDynamicObjects.cmbIDKadrUch.SelectedValue = Convert.ToInt32(dgvVihCocument.CurrentRow.Cells[2].Value);
                    classDynamicObjects.cmbIDIdent.SelectedValue = Convert.ToInt32(dgvVihCocument.CurrentRow.Cells[3].Value);
        }
            

        public void cmbFirmaFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_firma = new DataBaseTables();
                    tables_firma.dtFirmaFill();
                    classDynamicObjects.cmbIDFirm.DataSource = tables_firma.dtFirma;
                    classDynamicObjects.cmbIDFirm.DisplayMember = "firma";
                    classDynamicObjects.cmbIDFirm.ValueMember = "id_firma";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbKadr_perestanovkiFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_kadr_perestanovki = new DataBaseTables();
                    tables_kadr_perestanovki.dtKadr_perestanovkiFill();
                    classDynamicObjects.cmbIDKadrPere.DataSource = tables_kadr_perestanovki.dtKadr_perestanovki;
                    classDynamicObjects.cmbIDKadrPere.DisplayMember = "kdar_perestanovki";
                    classDynamicObjects.cmbIDKadrPere.ValueMember = "id_kadr_perestanovki";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbSotrudnikFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_sotr = new DataBaseTables();
                    tables_sotr.dtSotrudnikFill();
                    classDynamicObjects.cmbIDSotrudnik_KU.DataSource = tables_sotr.dtSotrudnik;
                    classDynamicObjects.cmbIDSotrudnik_KU.DisplayMember = "sotrudnik";
                    classDynamicObjects.cmbIDSotrudnik_KU.ValueMember = "id_sotrudnik";

                }
                catch
                {

                }
            };
            Invoke(action);
        }
        public void cmbTabel_zarplataFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_tabel_zarplata = new DataBaseTables();
                    tables_tabel_zarplata.dtTabel_zarplataFill();
                    classDynamicObjects.cmbIDTabelZarplata.DataSource = tables_tabel_zarplata.dtTabel_zarplata;
                    classDynamicObjects.cmbIDTabelZarplata.DisplayMember = "tabel_zarplata";
                    classDynamicObjects.cmbIDTabelZarplata.ValueMember = "id_tabel_zarplata";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbPribil_i_rashodiFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_pribil = new DataBaseTables();
                    tables_pribil.dtPribil_i_rashodiFill();
                    classDynamicObjects.cmbIDPribil_i_rashodi.DataSource = tables_pribil.dtPribil_i_rashodi;
                    classDynamicObjects.cmbIDPribil_i_rashodi.DisplayMember = "pribil_i_rashodi";
                    classDynamicObjects.cmbIDPribil_i_rashodi.ValueMember = "id_pribil_i_rashodi";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbPostavkaiFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_postavka = new DataBaseTables();
                    tables_postavka.dtPostavkaFill();
                    classDynamicObjects.cmbIDPostavka.DataSource = tables_postavka.dtPostavka;
                    classDynamicObjects.cmbIDPostavka.DisplayMember = "postavka";
                    classDynamicObjects.cmbIDPostavka.ValueMember = "id_postavka";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbProdaja_tovFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_prodaja = new DataBaseTables();
                    tables_prodaja.dtProdaja_tovaraFill();
                    classDynamicObjects.cmbIDProdajaTov.DataSource = tables_prodaja.dtProdaja_tovara;
                    classDynamicObjects.cmbIDProdajaTov.DisplayMember = "prodaja_tovara";
                    classDynamicObjects.cmbIDProdajaTov.ValueMember = "id_prodaja_tovara";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbKadr_uchetFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_uchet = new DataBaseTables();
                    tables_uchet.dtKadr_uchetFill();
                    classDynamicObjects.cmbIDKadrUch.DataSource = tables_uchet.dtKadr_uchet;
                    classDynamicObjects.cmbIDKadrUch.DisplayMember = "kadr_uchet";
                    classDynamicObjects.cmbIDKadrUch.ValueMember = "id_kadr_uchet";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbIdentFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_ident = new DataBaseTables();
                    tables_ident.dtIdent_tov_partyFill();
                    classDynamicObjects.cmbIDIdent.DataSource = tables_ident.dtIdent_tov_party;
                    classDynamicObjects.cmbIDIdent.DisplayMember = "ident_tov_party";
                    classDynamicObjects.cmbIDIdent.ValueMember = "id_ident_tov_party";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbDoljnostFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_dolj = new DataBaseTables();
                    tables_dolj.dtDoljnostFill();
                    classDynamicObjects.cmbIDDoljnosti.DataSource = tables_dolj.dtDoljnost;
                    classDynamicObjects.cmbIDDoljnosti.DisplayMember = "doljnost";
                    classDynamicObjects.cmbIDDoljnosti.ValueMember = "id_doljnost";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbSFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_s = new DataBaseTables();
                    tables_s.dtSotrudnikFill();
                    classDynamicObjects.cmbIDSotrydnik.DataSource = tables_s.dtSotrudnik;
                    classDynamicObjects.cmbIDSotrydnik.DisplayMember = "sotrudnik";
                    classDynamicObjects.cmbIDSotrydnik.ValueMember = "id_sotrudnik";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbDocumentFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_doc = new DataBaseTables();
                    tables_doc.dtDocumentFill();
                    classDynamicObjects.cmbIDDocument.DataSource = tables_doc.dtDocument;
                    classDynamicObjects.cmbIDDocument.DisplayMember = "document";
                    classDynamicObjects.cmbIDDocument.ValueMember = "id_document";

                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbSoiskatelFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_soiskatel = new DataBaseTables();
                    tables_soiskatel.dtSoiskatelFill();
                    classDynamicObjects.cmbIDSoiskatel.DataSource = tables_soiskatel.dtSoiskatel;
                    classDynamicObjects.cmbIDSoiskatel.DisplayMember = "soiskatel";
                    classDynamicObjects.cmbIDSoiskatel.ValueMember = "id_soiskatel";

                }
                catch
                {

                }
            };
            Invoke(action);
        }
    }
}
