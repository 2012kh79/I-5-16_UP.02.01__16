﻿using System;
using System.Windows.Forms;
using System.Drawing;


namespace UP_02._01
{
    class DynamicObjects
    {
        public DBProcedures procedure = new DBProcedures();
        public DataBaseTables tables = new DataBaseTables();
        public Button btnReturn = new Button();
        public Button btnInsert = new Button();
        public Button btnUpdate = new Button();
        public Button btnDelete = new Button();
         public Panel pnlTextBox = new Panel();
        public TextBox tbVidDocument = new TextBox();
        public TextBox tbNomberOrder = new TextBox();
        public TextBox tbDateOrder = new TextBox();
        public TextBox tbSalary = new TextBox();
        public TextBox tbDateSignOrder = new TextBox();
            public Form aggregateDocumentChangeForm = new Form();

        public Label lblHead = new Label();
        public Label lblVidDocument = new Label();
        public Label lblNomberOrder = new Label();
        public Label lblDateOrder = new Label();
        public Label lblSalary = new Label();
        public Label lblDateSignOrder = new Label();
        public Label lblIDFirm = new Label();
        public Label lblZarplata = new Label();
        public Label lblIDKadrPere = new Label();
        public Label lblIDSotrydnik = new Label();
        public Label lblIDDoljnosti = new Label();
        public Label lblIDDocument = new Label();
        public Label lblIDSoiskatel = new Label();
        public Label lblDatePodpisiDoc = new Label();
        public Label lblIDSoiskatelKU = new Label();
        public Label lblIDTabelZarplata = new Label();
        public Label lblIDOtchet = new Label();
        public Label lblNazvFirm = new Label();
        public Label lblIDProdajaTovara = new Label();
        public Label lblIDKadrUch = new Label();
        public Label lblIDIdent = new Label();
        public Label lblVidDocIdent = new Label();
        public Label lblStatus = new Label();
        public Label lblIDPostavka = new Label();

        public TextBox tbVidDocumentDoc = new TextBox();
        public TextBox tbNomberOrderDoc = new TextBox();
        public TextBox tbDateOrdetDoc = new TextBox();
        public TextBox tbSalaryDoc = new TextBox();
        public TextBox tbDateSignOrderDoc = new TextBox();
        public ComboBox cmbIDFirm = new ComboBox();
        public TextBox tbZarplata = new TextBox();
        public ComboBox cmbIDKadrPere = new ComboBox();
        public ComboBox cmbIDSotrydnik = new ComboBox();
        public ComboBox cmbIDDoljnosti = new ComboBox();
        public ComboBox cmbIDDocument = new ComboBox();
        public ComboBox cmbIDSoiskatel = new ComboBox();
        public TextBox tbDatePodpisiDoc = new TextBox();
        public ComboBox cmbIDSoiskatelKU = new ComboBox();
        public ComboBox cmbIDTabelZarplata = new ComboBox();
        public ComboBox cmbIDOtchet = new ComboBox();
        public TextBox tbNazvFirm = new TextBox();
        public ComboBox cmbIDProdajaTov = new ComboBox();
        public ComboBox cmbIDKadrUch = new ComboBox();
        public ComboBox cmbIDIdent = new ComboBox();
        public TextBox tbVidDocIdent = new TextBox();
        public TextBox tbStatus = new TextBox();
        public ComboBox cmbIDPostavka = new ComboBox();
        public ComboBox cmbIDPribil_i_rashodi = new ComboBox();
        public Label lblIDPribil_i_rashodi = new Label();
        public ComboBox cmbIDSotrudnik_KU= new ComboBox();
        public Label lblIDSotrudnik_KU = new Label();
        public string NewIdVid_doc;
        public string NewIdDogovor;
        public string NewIdZar_plata;
        public string NewIdKadr_perestanovki;
        public string NewIdKadr_uchet;
        public string NewIdFirma;
        public string NewIdIdent_tov_party;
        public string NewIdVih_doc;
        public string NewIdTab_rab_vremeni;
        public string NewIdDolj;
        public string NewIdRole;
        public string NewIdSotr;
        public string NewIdAccount;
        public string NewIdPostavki;
        public string NewIdPostavshiki;
        public string NewIdFirma_postavki;
        public string NewIdPost_tovar;
        public string NewIdTovar_na_sklade;
        public string NewIdProdaja_tovara;
        public string NewIdMed;
        public string NewIdCheck_vid_med;
        public string NewIdPribil_i_rashodi;
        public string NewIdInstruction;

     
        public void btnVidDocInsert_Click(object sender, EventArgs e)
        {
            DocumentChangeForm spl = new DocumentChangeForm();
            procedure.spDocument_Insert(tbVidDocument.Text);
            spl.dgvVidDocument.DataSource = tables.dtDocument;
            tbVidDocument.Clear();
            
        }

        public void btnVidDocUpdate_Click(object sender, EventArgs e)
        {
            procedure.spDocument_Update(Convert.ToInt32(NewIdVid_doc), tbVidDocument.Text);

        }

        public void btnVidDocDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление поставленного товара на складе " +
                                    "?", "Удалить поставленный товар со склада ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSoiskatel_Delete(Convert.ToInt32(
                        NewIdVid_doc));
                    break;
                case DialogResult.No:
                    break;

            }
        }

        public void Document_VidChangeFormFill()
        {
            lblVidDocument.Size = new Size(150, 20);
            lblVidDocument.Text = "Вид документа";
            lblVidDocument.Location = new Point(5, 5);
            lblVidDocument.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblVidDocument);

            tbVidDocumentDoc.Size = new Size(150, 20);
            tbVidDocumentDoc.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbVidDocumentDoc);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnVidDocInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);
          

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnVidDocUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);
            

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnVidDocDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
           
        }

        public void Document_DogovoraChangeFormFill()
        {
            lblNomberOrder.Size = new Size(150, 20);
            lblNomberOrder.Text = "Номер приказа";
            lblNomberOrder.Location = new Point(5, 55);
            lblNomberOrder.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomberOrder);

            lblDateOrder.Size = new Size(150, 20);
            lblDateOrder.Text = "Дата сост. приказа";
            lblDateOrder.Location = new Point(5, 105);
            lblDateOrder.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblDateOrder);

            lblIDFirm.Size = new Size(150, 20);
            lblIDFirm.Text = "ID Фирмы";
            lblIDFirm.Location = new Point(5, 155);
            lblIDFirm.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDFirm);

            tbNomberOrderDoc.Size = new Size(150, 20);
            tbNomberOrderDoc.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbNomberOrderDoc);

            tbDateOrdetDoc.Size = new Size(150, 20);
            tbDateOrdetDoc.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbDateOrdetDoc);

            cmbIDFirm.Size = new Size(150, 20);
            cmbIDFirm.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(cmbIDFirm);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_Zar_plataChangeFormFill()
        {
            lblZarplata.Size = new Size(150, 20);
            lblZarplata.Text = "Зарплата";
            lblZarplata.Location = new Point(5, 205);
            lblZarplata.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblZarplata);

            lblIDKadrPere.Size = new Size(150, 20);
            lblIDKadrPere.Text = "ID Кадр перест.";
            lblIDKadrPere.Location = new Point(165, 5);
            lblIDKadrPere.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDKadrPere);

            tbZarplata.Size = new Size(150, 20);
            tbZarplata.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(tbZarplata);

            cmbIDKadrPere.Size = new Size(150, 20);
            cmbIDKadrPere.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(cmbIDKadrPere);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_Kadr_perestanovkiChangeFormFill()
        {
            lblDatePodpisiDoc.Size = new Size(150, 20);
            lblDatePodpisiDoc.Text = "Дата подписи док.";
            lblDatePodpisiDoc.Location = new Point(165, 55);
            lblDatePodpisiDoc.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblDatePodpisiDoc);

            lblIDSotrydnik.Size = new Size(150, 20);
            lblIDSotrydnik.Text = "ID Сотрудников";
            lblIDSotrydnik.Location = new Point(165, 105);
            lblIDSotrydnik.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDSotrydnik);

            lblIDDoljnosti.Size = new Size(150, 20);
            lblIDDoljnosti.Text = "ID Должности";
            lblIDDoljnosti.Location = new Point(165, 155);
            lblIDDoljnosti.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDDoljnosti);

            lblIDDocument.Size = new Size(150, 20);
            lblIDDocument.Text = "ID Документа";
            lblIDDocument.Location = new Point(165, 205);
            lblIDDocument.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDDocument);

            lblIDSoiskatel.Size = new Size(150, 20);
            lblIDSoiskatel.Text = "ID Соискателей";
            lblIDSoiskatel.Location = new Point(325, 5);
            lblIDSoiskatel.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDSoiskatel);

            //lblIDSoiskatelKU.Size = new Size(150, 20);
            //lblIDSoiskatelKU.Text = "ID Соиск. для КУ";
            //lblIDSoiskatelKU.Location = new Point(325, 55);
            //lblIDSoiskatelKU.Font = new Font("Times New Roman", 10);
            //pnlTextBox.Controls.Add(lblIDSoiskatelKU);

            tbDatePodpisiDoc.Size = new Size(150, 20);
            tbDatePodpisiDoc.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(tbDatePodpisiDoc);

            cmbIDSotrydnik.Size = new Size(150, 20);
            cmbIDSotrydnik.Location = new Point(165, 125);
            pnlTextBox.Controls.Add(cmbIDSotrydnik);

            cmbIDDoljnosti.Size = new Size(150, 20);
            cmbIDDoljnosti.Location = new Point(165, 175);
            pnlTextBox.Controls.Add(cmbIDDoljnosti);

            cmbIDDocument.Size = new Size(150, 20);
            cmbIDDocument.Location = new Point(165, 225);
            pnlTextBox.Controls.Add(cmbIDDocument);

            cmbIDSoiskatel.Size = new Size(150, 20);
            cmbIDSoiskatel.Location = new Point(325, 25);
            pnlTextBox.Controls.Add(cmbIDSoiskatel);

            //cmbIDSoiskatelKU.Size = new Size(150, 20);
            //cmbIDSoiskatelKU.Location = new Point(325, 75);
            //pnlTextBox.Controls.Add(cmbIDSoiskatelKU);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_Kadr_uchetChangeFormFill()
        {
            lblIDTabelZarplata.Size = new Size(150, 20);
            lblIDTabelZarplata.Text = "ID Табель зарплаты";
            lblIDTabelZarplata.Location = new Point(325, 105);
            lblIDTabelZarplata.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDTabelZarplata);

            cmbIDTabelZarplata.Size = new Size(150, 20);
            cmbIDTabelZarplata.Location = new Point(325, 125);
            pnlTextBox.Controls.Add(cmbIDTabelZarplata);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            lblIDFirm.Size = new Size(150, 20);
            lblIDFirm.Text = "ID Прибыль и расходов";
            lblIDFirm.Location = new Point(145, 15);
            lblIDFirm.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDFirm);

            lblIDSotrudnik_KU.Size = new Size(150, 20);
            lblIDSotrudnik_KU.Text = "ID Сотрудника";
            lblIDSotrudnik_KU.Location = new Point(145, 85);
            lblIDSotrudnik_KU.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDSotrudnik_KU);

            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            cmbIDPribil_i_rashodi.Size = new Size(150, 20);
            cmbIDPribil_i_rashodi.Location = new Point(145, 45);
            pnlTextBox.Controls.Add(cmbIDPribil_i_rashodi);

            cmbIDSotrudnik_KU.Size = new Size(150, 20);
            cmbIDSotrudnik_KU.Location = new Point(145, 105);
            pnlTextBox.Controls.Add(cmbIDSotrudnik_KU);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_FirmaChangeFormFill()
        {
            lblNazvFirm.Size = new Size(150, 20);
            lblNazvFirm.Text = "Название фирмы";
            lblNazvFirm.Location = new Point(325, 205);
            lblNazvFirm.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNazvFirm);

            tbNazvFirm.Size = new Size(150, 20);
            tbNazvFirm.Location = new Point(325, 225);
            pnlTextBox.Controls.Add(tbNazvFirm);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_IdentChangeFormFill()
        {
            lblVidDocIdent.Size = new Size(150, 20);
            lblVidDocIdent.Text = "Вид док. идент.";
            lblVidDocIdent.Location = new Point(485, 5);
            lblVidDocIdent.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblVidDocIdent);

            lblStatus.Size = new Size(150, 20);
            lblStatus.Text = "Статус";
            lblStatus.Location = new Point(485, 55);
            lblStatus.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblStatus);

            lblIDPostavka.Size = new Size(150, 20);
            lblIDPostavka.Text = "ID поставки";
            lblIDPostavka.Location = new Point(485, 105);
            lblIDPostavka.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDPostavka);

            tbVidDocIdent.Size = new Size(150, 20);
            tbVidDocIdent.Location = new Point(485, 25);
            pnlTextBox.Controls.Add(tbVidDocIdent);

            tbStatus.Size = new Size(150, 20);
            tbStatus.Location = new Point(485, 75);
            pnlTextBox.Controls.Add(tbStatus);

            cmbIDPostavka.Size = new Size(150, 20);
            cmbIDPostavka.Location = new Point(485, 125);
            pnlTextBox.Controls.Add(cmbIDPostavka);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Document_VihChangeFormFill()
        {
            lblIDProdajaTovara.Size = new Size(150, 20);
            lblIDProdajaTovara.Text = "ID Продажи тов.";
            lblIDProdajaTovara.Location = new Point(485, 155);
            lblIDProdajaTovara.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDProdajaTovara);

            lblIDKadrUch.Size = new Size(150, 20);
            lblIDKadrUch.Text = "ID Кадрового учёта";
            lblIDKadrUch.Location = new Point(485, 205);
            lblIDKadrUch.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDKadrUch);

            lblIDIdent.Size = new Size(150, 20);
            lblIDIdent.Text = "ID Идентифик.";
            lblIDIdent.Location = new Point(485, 95);
            lblIDIdent.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDIdent);

            cmbIDProdajaTov.Size = new Size(150, 20);
            cmbIDProdajaTov.Location = new Point(485, 175);
            pnlTextBox.Controls.Add(cmbIDProdajaTov);

            //cmbIDPostTovara.Size = new Size(150, 20);
            //cmbIDPostTovara.Location = new Point(485, 175);
            //pnlTextBox.Controls.Add(cmbIDPostTovara);

            cmbIDKadrUch.Size = new Size(150, 20);
            cmbIDKadrUch.Location = new Point(485, 225);
            pnlTextBox.Controls.Add(cmbIDKadrUch);

            cmbIDIdent.Size = new Size(150, 20);
            cmbIDIdent.Location = new Point(485, 125);
            pnlTextBox.Controls.Add(cmbIDIdent);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);;
        }

        public void DocumentChangeFormFill()
        {         
            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);
            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);

            lblVidDocument.Size = new Size(150, 20);
            lblVidDocument.Text = "Вид документа";
            lblVidDocument.Location = new Point(5, 5);
            lblVidDocument.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblVidDocument);

            tbVidDocumentDoc.Size = new Size(150, 20);
            tbVidDocumentDoc.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbVidDocumentDoc);

            //lblIDOtchet.Size = new Size(150, 20);
            //lblIDOtchet.Text = "ID Отчёта";
            //lblIDOtchet.Location = new Point(325, 155);
            //lblIDOtchet.Font = new Font("Times New Roman", 10);
            //pnlTextBox.Controls.Add(lblIDOtchet);

            //cmbIDOtchet.Size = new Size(150, 20);
            //cmbIDOtchet.Location = new Point(325, 175);
            //pnlTextBox.Controls.Add(cmbIDOtchet);
        }


        public string NewIdSoiskatel;
        Label lblFamSoiskatel = new Label();
        Label lblNameSoiskatel = new Label();
        Label lblOtchSoiskatel = new Label();
        Label lblTabel_rab_vremeni_ID = new Label();
        Label lblDogovor_ID = new Label();
        public TextBox tbFamSoiskatel = new TextBox();
        public TextBox tbNameSoiskatel = new TextBox();
        public TextBox tbOtchSoiskatel = new TextBox();
        public ComboBox cmbTabel_rab_vremeni_ID = new ComboBox();
        public ComboBox cmbDogovor_ID = new ComboBox();

        public Form aggregateApplicationForm = new Form();

        public void ApplicationFormFill()
        {
            //lbNewIdSoiskatel.Text = "ID";
            //lbNewIdSoiskatel.Location = new Point(20, 20);
            //lbNewIdSoiskatel.Font = new Font("Times New Roman", 25);
            //aggregateApplicationForm.Controls.Add(lbNewIdSoiskatel);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Анкета соискателя";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateApplicationForm.Controls.Add(lblHead);

            
            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(620, 20);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnSoiskatelInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            pnlTextBox.Size = new Size(725, 325);
            pnlTextBox.Location = new Point(10, 425);
            aggregateApplicationForm.Controls.Add(pnlTextBox);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(620, 70);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnSoiskatelUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(620, 120);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnSoiskatelDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);

            lblFamSoiskatel.Size = new Size(150, 20);
            lblFamSoiskatel.Text = "Фамилия соискателя";
            lblFamSoiskatel.Location = new Point(5, 5);
            lblFamSoiskatel.Font = new Font("Times New Roman", 10);

            tbFamSoiskatel.Size = new Size(150, 20);
            tbFamSoiskatel.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(lblFamSoiskatel);
            pnlTextBox.Controls.Add(tbFamSoiskatel);


            lblNameSoiskatel.Size = new Size(150, 20);
            lblNameSoiskatel.Text = "Имя соискателя";
            lblNameSoiskatel.Location = new Point(5, 50);
            lblNameSoiskatel.Font = new Font("Times New Roman", 10);

            tbNameSoiskatel.Size = new Size(150, 20);
            tbNameSoiskatel.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbNameSoiskatel);
            pnlTextBox.Controls.Add(lblNameSoiskatel);


            lblOtchSoiskatel.Size = new Size(150, 20);
            lblOtchSoiskatel.Text = "Отчество соискателя";
            lblOtchSoiskatel.Location = new Point(5, 100);
            lblOtchSoiskatel.Font = new Font("Times New Roman", 10);

            lblTabel_rab_vremeni_ID.Size = new Size(150, 20);
            lblTabel_rab_vremeni_ID.Text = "Табель рабочего времени";
            lblTabel_rab_vremeni_ID.Location = new Point(345, 05);
            lblTabel_rab_vremeni_ID.Font = new Font("Times New Roman", 10);

            lblDogovor_ID.Size = new Size(150, 20);
            lblDogovor_ID.Text = "Договор";
            lblDogovor_ID.Location = new Point(345, 70);
            lblDogovor_ID.Font = new Font("Times New Roman", 10);

            cmbTabel_rab_vremeni_ID.Size = new Size(150, 20);
            cmbTabel_rab_vremeni_ID.Location = new Point(345, 25);
            pnlTextBox.Controls.Add(lblTabel_rab_vremeni_ID);
            pnlTextBox.Controls.Add(cmbTabel_rab_vremeni_ID);

            cmbDogovor_ID.Size = new Size(150, 20);
            cmbDogovor_ID.Location = new Point(345, 90);
            pnlTextBox.Controls.Add(lblDogovor_ID);
            pnlTextBox.Controls.Add(cmbDogovor_ID);

            tbOtchSoiskatel.Size = new Size(150, 20);
            tbOtchSoiskatel.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbOtchSoiskatel);
            pnlTextBox.Controls.Add(lblOtchSoiskatel);
        }

        Label lblNomberCheck = new Label();
        Label lblNameMedicament = new Label();
        Label lblInstruction = new Label();
        Label lblQuantityMedicaments = new Label();

        TextBox tbNomberCheck = new TextBox();
        ComboBox cmbNameMedicament = new ComboBox();
        ComboBox cmbInstruction = new ComboBox();
        TextBox tbQuantityMedicaments = new TextBox();

        public Form aggregateKassaForm = new Form();

        public void KassaFormFill()
        {
            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Продажа товара";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateKassaForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(600, 125);
            pnlTextBox.Location = new Point(10, 525);
            aggregateKassaForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(5, 75);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(115, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(225, 75);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);

            lblNomberCheck.Size = new Size(150, 20);
            lblNomberCheck.Text = "Номер чека";
            lblNomberCheck.Location = new Point(5, 5);
            lblNomberCheck.Font = new Font("Times New Roman", 10);

            tbNomberCheck.Size = new Size(150, 20);
            tbNomberCheck.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(lblNomberCheck);
            pnlTextBox.Controls.Add(tbNomberCheck);


            lblQuantityMedicaments.Size = new Size(150, 20);
            lblQuantityMedicaments.Text = "Колличество медикаментов";
            lblQuantityMedicaments.Location = new Point(175, 5);
            lblQuantityMedicaments.Font = new Font("Times New Roman", 10);

            tbQuantityMedicaments.Size = new Size(150, 20);
            tbQuantityMedicaments.Location = new Point(175, 25);
            pnlTextBox.Controls.Add(lblQuantityMedicaments);
            pnlTextBox.Controls.Add(tbQuantityMedicaments);

            lblInstruction.Size = new Size(150, 20);
            lblInstruction.Text = "Инструкция";
            lblInstruction.Location = new Point(345, 5);
            lblInstruction.Font = new Font("Times New Roman", 10);

            cmbInstruction.Size = new Size(150, 20);
            cmbInstruction.Location = new Point(345, 25);
            pnlTextBox.Controls.Add(lblInstruction);
            pnlTextBox.Controls.Add(cmbInstruction);
        }

        public Form aggregateSupplyForm = new Form();
        public Label lblNazvFirmPost = new Label();
        public Label lblIndex = new Label();
        public Label lblNasPunkt = new Label();
        public Label lblUlitsa = new Label();
        public Label lblDom = new Label();
        public Label lblSrokHran = new Label();
        public Label lblKolTovNaSklade = new Label();
        public Label lblNomSkafa = new Label();
        public Label lblNomPolki = new Label();
        public Label lblNaimPostTovar = new Label();
        public Label lblKolPostTovar = new Label();
        public Label lblTsenaPostTovara = new Label();
        public Label lblNamePost = new Label();
        public Label lblFamPost = new Label();
        public Label lblOtchPost = new Label();
        public Label lblIDFirmPost = new Label();
        public Label lblIDPostavshik = new Label();
        public Label lblIDTovNaSklade = new Label();
        public Label lblIDPostTovara = new Label();

        public TextBox txNazvFirmPost = new TextBox();
        public TextBox txIndex = new TextBox();
        public TextBox txNasPunkt = new TextBox();
        public TextBox txUlitsa = new TextBox();
        public TextBox txDom = new TextBox();

        public TextBox txSrokHran = new TextBox();
        public TextBox txKolTovNaSklade = new TextBox();
        public TextBox txNomSkafa = new TextBox();
        public TextBox txNomPolki = new TextBox();
        public TextBox txNaimPostTovar = new TextBox();

        public TextBox txKolPostTovar = new TextBox();
        public TextBox txTsenaPostTovara = new TextBox();
        public TextBox txNamePost = new TextBox();
        public TextBox txFamPost = new TextBox();
        public TextBox txOtchPost = new TextBox();

        public ComboBox cmbIDFirmPost = new ComboBox();
        public ComboBox cmbIDPostavshik = new ComboBox();
        public ComboBox cmbIDTovNaSklade = new ComboBox();
        public ComboBox cmbIDPostTovara = new ComboBox();

        public void SupplyForm_tovar_na_skladeFill()
        {
            lblSrokHran.Size = new Size(150, 20);
            lblSrokHran.Text = "Срок хранения";
            lblSrokHran.Location = new Point(165, 5);
            lblSrokHran.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblSrokHran);

            lblKolTovNaSklade.Size = new Size(150, 20);
            lblKolTovNaSklade.Text = "Товара на складе";
            lblKolTovNaSklade.Location = new Point(165, 55);
            lblKolTovNaSklade.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKolTovNaSklade);

            lblNomSkafa.Size = new Size(150, 20);
            lblNomSkafa.Text = "Номер шкафа";
            lblNomSkafa.Location = new Point(165, 105);
            lblNomSkafa.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomSkafa);

            lblNomPolki.Size = new Size(150, 20);
            lblNomPolki.Text = "Номер полки";
            lblNomPolki.Location = new Point(165, 155);
            lblNomPolki.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomPolki);

            txSrokHran.Size = new Size(150, 20);
            txSrokHran.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(txSrokHran);

            txKolTovNaSklade.Size = new Size(150, 20);
            txKolTovNaSklade.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(txKolTovNaSklade);

            txNomSkafa.Size = new Size(150, 20);
            txNomSkafa.Location = new Point(165, 125);
            pnlTextBox.Controls.Add(txNomSkafa);

            txNomPolki.Size = new Size(150, 20);
            txNomPolki.Location = new Point(165, 175);
            pnlTextBox.Controls.Add(txNomPolki);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnTovar_na_skladeInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnTovar_na_skladeUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnTovar_na_skladeDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void SupplyPostavlenny_tovar_FormFill()
        {
            lblNaimPostTovar.Size = new Size(150, 20);
            lblNaimPostTovar.Text = "Поставляемый товар";
            lblNaimPostTovar.Location = new Point(165, 205);
            lblNaimPostTovar.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNaimPostTovar);

            lblKolPostTovar.Size = new Size(170, 20);
            lblKolPostTovar.Text = "Количество пост. товара";
            lblKolPostTovar.Location = new Point(325, 5);
            lblKolPostTovar.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKolPostTovar);

            lblTsenaPostTovara.Size = new Size(150, 20);
            lblTsenaPostTovara.Text = "Цена пост. товара";
            lblTsenaPostTovara.Location = new Point(325, 55);
            lblTsenaPostTovara.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblTsenaPostTovara);

            txNaimPostTovar.Size = new Size(150, 20);
            txNaimPostTovar.Location = new Point(165, 225);
            pnlTextBox.Controls.Add(txNaimPostTovar);

            txKolPostTovar.Size = new Size(150, 20);
            txKolPostTovar.Location = new Point(325, 25);
            pnlTextBox.Controls.Add(txKolPostTovar);

            txTsenaPostTovara.Size = new Size(150, 20);
            txTsenaPostTovara.Location = new Point(325, 75);
            pnlTextBox.Controls.Add(txTsenaPostTovara);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnPost_tovarInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnPost_tovarUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnPost_tovarDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Supply_Firma_postavkiFormFill()
        {
            lblNazvFirmPost.Size = new Size(150, 20);
            lblNazvFirmPost.Text = "Название фирмы";
            lblNazvFirmPost.Location = new Point(5, 5);
            lblNazvFirmPost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNazvFirmPost);

            lblIndex.Size = new Size(150, 20);
            lblIndex.Text = "Индекс";
            lblIndex.Location = new Point(5, 55);
            lblIndex.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIndex);

            lblNasPunkt.Size = new Size(150, 20);
            lblNasPunkt.Text = "Населённый пункт";
            lblNasPunkt.Location = new Point(5, 105);
            lblNasPunkt.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNasPunkt);

            lblUlitsa.Size = new Size(150, 20);
            lblUlitsa.Text = "Улица";
            lblUlitsa.Location = new Point(5, 155);
            lblUlitsa.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblUlitsa);

            lblDom.Size = new Size(150, 20);
            lblDom.Text = "Дом";
            lblDom.Location = new Point(5, 205);
            lblDom.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblDom);

            txNazvFirmPost.Size = new Size(150, 20);
            txNazvFirmPost.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(txNazvFirmPost);

            txIndex.Size = new Size(150, 20);
            txIndex.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(txIndex);

            txNasPunkt.Size = new Size(150, 20);
            txNasPunkt.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(txNasPunkt);

            txUlitsa.Size = new Size(150, 20);
            txUlitsa.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(txUlitsa);

            txDom.Size = new Size(150, 20);
            txDom.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(txDom);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnFirma_postavkiInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnFirma_postavkiUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnFirma_postavkiDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Supply_Postavshik_FormFill()
        {
            lblNamePost.Size = new Size(150, 20);
            lblNamePost.Text = "Имя поставщика";
            lblNamePost.Location = new Point(325, 105);
            lblNamePost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNamePost);

            lblFamPost.Size = new Size(150, 20);
            lblFamPost.Text = "Фамилия поставщика";
            lblFamPost.Location = new Point(325, 155);
            lblFamPost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblFamPost);

            lblOtchPost.Size = new Size(150, 20);
            lblOtchPost.Text = "Отчество поставщика";
            lblOtchPost.Location = new Point(325, 205);
            lblOtchPost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtchPost);

            lblIDFirmPost.Size = new Size(150, 20);
            lblIDFirmPost.Text = "ID фирмы поставки";
            lblIDFirmPost.Location = new Point(485, 5);
            lblIDFirmPost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDFirmPost);

            txNamePost.Size = new Size(150, 20);
            txNamePost.Location = new Point(325, 125);
            pnlTextBox.Controls.Add(txNamePost);

            txFamPost.Size = new Size(150, 20);
            txFamPost.Location = new Point(325, 175);
            pnlTextBox.Controls.Add(txFamPost);

            txOtchPost.Size = new Size(150, 20);
            txOtchPost.Location = new Point(325, 225);
            pnlTextBox.Controls.Add(txOtchPost);

            cmbIDFirmPost.Size = new Size(150, 20);
            cmbIDFirmPost.Location = new Point(485, 25);
            pnlTextBox.Controls.Add(cmbIDFirmPost);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnPostavshikiInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnPostavshikiUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnPostavshikiDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Supply_Postavki_FormFill()
        {
            lblIDPostavshik.Size = new Size(150, 20);
            lblIDPostavshik.Text = "ID поставщика";
            lblIDPostavshik.Location = new Point(485, 55);
            lblIDPostavshik.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDPostavshik);

            lblIDTovNaSklade.Size = new Size(150, 20);
            lblIDTovNaSklade.Text = "ID Товара на складе";
            lblIDTovNaSklade.Location = new Point(485, 105);
            lblIDTovNaSklade.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDTovNaSklade);

            lblIDPostTovara.Size = new Size(170, 20);
            lblIDPostTovara.Text = "ID поставляемого товара";
            lblIDPostTovara.Location = new Point(485, 155);
            lblIDPostTovara.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDPostTovara);

            cmbIDPostavshik.Size = new Size(150, 20);
            cmbIDPostavshik.Location = new Point(485, 75);
            pnlTextBox.Controls.Add(cmbIDPostavshik);

            cmbIDTovNaSklade.Size = new Size(150, 20);
            cmbIDTovNaSklade.Location = new Point(485, 125);
            pnlTextBox.Controls.Add(cmbIDTovNaSklade);

            cmbIDPostTovara.Size = new Size(150, 20);
            cmbIDPostTovara.Location = new Point(485, 175);
            pnlTextBox.Controls.Add(cmbIDPostTovara);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnPostavkiInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnPostavkiUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnPostavkiDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }
        public void SupplyFormFill()
        {
            lblSrokHran.Size = new Size(150, 20);
            lblSrokHran.Text = "Срок хранения";
            lblSrokHran.Location = new Point(165, 5);
            lblSrokHran.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblSrokHran);

            lblKolTovNaSklade.Size = new Size(150, 20);
            lblKolTovNaSklade.Text = "Товара на складе";
            lblKolTovNaSklade.Location = new Point(165, 55);
            lblKolTovNaSklade.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKolTovNaSklade);

            lblNomSkafa.Size = new Size(150, 20);
            lblNomSkafa.Text = "Номер шкафа";
            lblNomSkafa.Location = new Point(165, 105);
            lblNomSkafa.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomSkafa);

            lblNomPolki.Size = new Size(150, 20);
            lblNomPolki.Text = "Номер полки";
            lblNomPolki.Location = new Point(165, 155);
            lblNomPolki.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomPolki);

            txSrokHran.Size = new Size(150, 20);
            txSrokHran.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(txSrokHran);

            txKolTovNaSklade.Size = new Size(150, 20);
            txKolTovNaSklade.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(txKolTovNaSklade);

            txNomSkafa.Size = new Size(150, 20);
            txNomSkafa.Location = new Point(165, 125);
            pnlTextBox.Controls.Add(txNomSkafa);

            txNomPolki.Size = new Size(150, 20);
            txNomPolki.Location = new Point(165, 175);
            pnlTextBox.Controls.Add(txNomPolki);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateSupplyForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(655, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(655, 105);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(655, 160);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public Form aggregateStaffForm = new Form();


       public  Label lblOtrDays = new Label();
        public Label lblVixDays = new Label();
        public Label lblKomandirivki = new Label();
        public Label lblOtpuska = new Label();
        public Label lblDoljnost = new Label();
        public Label lblRole = new Label();
        public Label lblNomberSotr = new Label();
        public Label lblFamSotr = new Label();
        public Label lblNameSotr = new Label();
        public Label lblOtchSotr = new Label();
        public Label lblIDTabVremya = new Label();
        public Label lblIDDogovor = new Label();
        public Label lblLogin = new Label();
        public Label lblParol = new Label();
        public Label lblTypeAccount = new Label();
        public Label lblIDRole = new Label();

        public TextBox tbOtrDays = new TextBox();
        public TextBox tbVixDays = new TextBox();
        public TextBox tbKomandirivki = new TextBox();
        public TextBox tbOtpuska = new TextBox();
        public TextBox tbDoljnost = new TextBox();
        public TextBox tbRole = new TextBox();
        public TextBox tbNomberSotr = new TextBox();
        public TextBox tbFamSotr = new TextBox();
        public TextBox tbNamehSotr = new TextBox();
        public TextBox tbOtchSotr = new TextBox();
        public TextBox tbLogin = new TextBox();
        public TextBox tbParol = new TextBox();
        public ComboBox cmbTypeAccount = new ComboBox();
        public ComboBox cmbIDRole = new ComboBox();
        public ComboBox cmbIDTabVremya = new ComboBox();
        public ComboBox cmbIDDogovor = new ComboBox();

        public void Staff_Tab_rab_vremeniFormFill()
        {
            lblOtrDays.Size = new Size(150, 20);
            lblOtrDays.Text = "Отработанные дни";
            lblOtrDays.Location = new Point(5, 5);
            lblOtrDays.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtrDays);

            lblVixDays.Size = new Size(150, 20);
            lblVixDays.Text = "Выходные дни";
            lblVixDays.Location = new Point(5, 55);
            lblVixDays.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblVixDays);

            lblKomandirivki.Size = new Size(150, 20);
            lblKomandirivki.Text = "Командировки";
            lblKomandirivki.Location = new Point(5, 105);
            lblKomandirivki.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKomandirivki);

            lblOtpuska.Size = new Size(150, 20);
            lblOtpuska.Text = "Отпуска";
            lblOtpuska.Location = new Point(5, 155);
            lblOtpuska.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtpuska);

            tbOtrDays.Size = new Size(150, 20);
            tbOtrDays.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbOtrDays);

            tbVixDays.Size = new Size(150, 20);
            tbVixDays.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbVixDays);

            tbKomandirivki.Size = new Size(150, 20);
            tbKomandirivki.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbKomandirivki);

            tbOtpuska.Size = new Size(150, 20);
            tbOtpuska.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(tbOtpuska);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnTabel_rab_vremeniInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnTabel_rab_vremeniUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnTabel_rab_vremeniiDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void StaffDolj_FormFill()
        {
            lblDoljnost.Size = new Size(150, 20);
            lblDoljnost.Text = "Должность";
            lblDoljnost.Location = new Point(5, 205);
            lblDoljnost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblDoljnost);

            tbDoljnost.Size = new Size(150, 20);
            tbDoljnost.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(tbDoljnost);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnDoljnostiInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnDoljnostUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnDoljnostDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Staff_RoleFormFill()
        {
            lblRole.Size = new Size(150, 20);
            lblRole.Text = "Роль";
            lblRole.Location = new Point(165, 5);
            lblRole.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblRole);

            tbRole.Size = new Size(150, 20);
            tbRole.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(tbRole);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnRoleInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnRoleUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnRoleDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Staff_SotrFormFill()
        {
            lblNomberSotr.Size = new Size(150, 20);
            lblNomberSotr.Text = "Номер сотрудника.";
            lblNomberSotr.Location = new Point(165, 55);
            lblNomberSotr.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomberSotr);

            lblFamSotr.Size = new Size(150, 20);
            lblFamSotr.Text = "Фамилия сотрудника";
            lblFamSotr.Location = new Point(165, 105);
            lblFamSotr.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblFamSotr);

            lblNameSotr.Size = new Size(150, 20);
            lblNameSotr.Text = "Имя сотрудника";
            lblNameSotr.Location = new Point(165, 155);
            lblNameSotr.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNameSotr);

            lblOtchSotr.Size = new Size(150, 20);
            lblOtchSotr.Text = "Отчество сотрудника";
            lblOtchSotr.Location = new Point(165, 205);
            lblOtchSotr.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtchSotr);

            lblIDTabVremya.Size = new Size(150, 20);
            lblIDTabVremya.Text = "ID табеля времени";
            lblIDTabVremya.Location = new Point(325, 5);
            lblIDTabVremya.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDTabVremya);

            lblIDDogovor.Size = new Size(150, 20);
            lblIDDogovor.Text = "ID Договора";
            lblIDDogovor.Location = new Point(325, 55);
            lblIDDogovor.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDDogovor);

            tbNomberSotr.Size = new Size(150, 20);
            tbNomberSotr.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(tbNomberSotr);

            tbFamSotr.Size = new Size(150, 20);
            tbFamSotr.Location = new Point(165, 125);
            pnlTextBox.Controls.Add(tbFamSotr);

            tbNamehSotr.Size = new Size(150, 20);
            tbNamehSotr.Location = new Point(165, 175);
            pnlTextBox.Controls.Add(tbNamehSotr);

            tbOtchSotr.Size = new Size(150, 20);
            tbOtchSotr.Location = new Point(165, 225);
            pnlTextBox.Controls.Add(tbOtchSotr);

            cmbIDTabVremya.Size = new Size(150, 20);
            cmbIDTabVremya.Location = new Point(325, 25);
            pnlTextBox.Controls.Add(cmbIDTabVremya);

            cmbIDDogovor.Size = new Size(150, 20);
            cmbIDDogovor.Location = new Point(325, 75);
            pnlTextBox.Controls.Add(cmbIDDogovor);

            lblTypeAccount.Size = new Size(150, 20);
            lblTypeAccount.Text = "Тип аккаунта";
            lblTypeAccount.Location = new Point(325, 205);
            lblTypeAccount.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblTypeAccount);

            cmbTypeAccount.Size = new Size(150, 20);
            cmbTypeAccount.Location = new Point(325, 225);
            pnlTextBox.Controls.Add(cmbTypeAccount);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnSotrInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnSotrUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnSotrDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void Staff_AccountFormFill()
        {
            lblLogin.Size = new Size(150, 20);
            lblLogin.Text = "Логин";
            lblLogin.Location = new Point(325, 105);
            lblLogin.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblLogin);

            lblParol.Size = new Size(150, 20);
            lblParol.Text = "Пароль";
            lblParol.Location = new Point(325, 155);
            lblParol.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblParol);

            lblIDRole.Size = new Size(150, 20);
            lblIDRole.Text = "ID Role";
            lblIDRole.Location = new Point(485, 5);
            lblIDRole.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDRole);

            tbLogin.Size = new Size(150, 20);
            tbLogin.Location = new Point(325, 125);
            pnlTextBox.Controls.Add(tbLogin);

            tbParol.Size = new Size(150, 20);
            tbParol.Location = new Point(325, 175);
            pnlTextBox.Controls.Add(tbParol);

            cmbIDRole.Size = new Size(150, 20);
            cmbIDRole.Location = new Point(485, 25);
            pnlTextBox.Controls.Add(cmbIDRole);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnAccountInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnAccountUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnAccountDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void StaffFormFill()
        {
            lblOtrDays.Size = new Size(150, 20);
            lblOtrDays.Text = "Отработанные дни";
            lblOtrDays.Location = new Point(5, 5);
            lblOtrDays.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtrDays);

            lblVixDays.Size = new Size(150, 20);
            lblVixDays.Text = "Выходные дни";
            lblVixDays.Location = new Point(5, 55);
            lblVixDays.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblVixDays);

            lblKomandirivki.Size = new Size(150, 20);
            lblKomandirivki.Text = "Командировки";
            lblKomandirivki.Location = new Point(5, 105);
            lblKomandirivki.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKomandirivki);

            lblOtpuska.Size = new Size(150, 20);
            lblOtpuska.Text = "Отпуска";
            lblOtpuska.Location = new Point(5, 155);
            lblOtpuska.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblOtpuska);

            tbOtrDays.Size = new Size(150, 20);
            tbOtrDays.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbOtrDays);

            tbVixDays.Size = new Size(150, 20);
            tbVixDays.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbVixDays);

            tbKomandirivki.Size = new Size(150, 20);
            tbKomandirivki.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbKomandirivki);

            tbOtpuska.Size = new Size(150, 20);
            tbOtpuska.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(tbOtpuska);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            pnlTextBox.Size = new Size(860, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateStaffForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(645, 55);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(755, 55);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(645, 105);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public Form aggregateIncomeForm = new Form();

      public Label lblInstrRabKassir = new Label();
        public Label lblPribil = new Label();
        public Label lblRashody = new Label();
        public Label lblNachOtcheta = new Label();
        public Label lblKonOtch = new Label();

        public Label lblNomberCheckVM = new Label();
        public Label lblNazvVidMed = new Label();
        public Label lblIDDoljnost = new Label();
        public Label lblIDSotrydnikC = new Label();
        public Label lblKolVidMed = new Label();
        public Label lblIDVidCheck = new Label();
        public Label lblIDMedicamentov = new Label();
        public Label lblIDInstrRabKass = new Label();

        public TextBox tbNomberCheckVM = new TextBox();
        public TextBox tbNazvVidMed = new TextBox();
        public ComboBox cmbIDDoljnost = new ComboBox();
        public ComboBox cmbIDSotrydnikC = new ComboBox();
        public TextBox tbKolVidMed = new TextBox();
        public ComboBox cmbIDVidCheck = new ComboBox();
        public ComboBox cmbIDMedicamentov = new ComboBox();
        public ComboBox cmbIDInstrRabKass = new ComboBox();

        public TextBox tbInstrRabKassir = new TextBox();
        public TextBox tbPribil = new TextBox();
        public TextBox tbRashody = new TextBox();
        public TextBox tbNachOtcheta = new TextBox();
        public TextBox tbKonOtch = new TextBox();

        public void IncomeForm_Instruction_Fill()
        {
            lblInstrRabKassir.Size = new Size(150, 20);
            lblInstrRabKassir.Text = "Вид инструкции";
            lblInstrRabKassir.Location = new Point(5, 5);
            lblInstrRabKassir.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblInstrRabKassir);

            tbInstrRabKassir.Size = new Size(150, 20);
            tbInstrRabKassir.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbInstrRabKassir);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnInstructionsInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnInstructionsUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnInstructionsDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void IncomeForm_Pribil_i_rashodi_Fill()
        {
            lblPribil.Size = new Size(150, 20);
            lblPribil.Text = "Прибыль";
            lblPribil.Location = new Point(5, 55);
            lblPribil.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblPribil);

            lblRashody.Size = new Size(150, 20);
            lblRashody.Text = "Расходы";
            lblRashody.Location = new Point(5, 105);
            lblRashody.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblRashody);

            lblNachOtcheta.Size = new Size(150, 20);
            lblNachOtcheta.Text = "Начало отчёта";
            lblNachOtcheta.Location = new Point(5, 155);
            lblNachOtcheta.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNachOtcheta);

            lblKonOtch.Size = new Size(150, 20);
            lblKonOtch.Text = "Конец отчёта";
            lblKonOtch.Location = new Point(5, 205);
            lblKonOtch.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKonOtch);

            tbPribil.Size = new Size(150, 20);
            tbPribil.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbPribil);

            tbRashody.Size = new Size(150, 20);
            tbRashody.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbRashody);

            tbNachOtcheta.Size = new Size(150, 20);
            tbNachOtcheta.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(tbNachOtcheta);

            tbKonOtch.Size = new Size(150, 20);
            tbKonOtch.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(tbKonOtch);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnPribil_i_rashodiInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnPribil_i_rashodiUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnPribil_i_rashodiDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void IncomeForm_Check_vid_med_Fill()
        {
            lblNomberCheckVM.Size = new Size(150, 20);
            lblNomberCheckVM.Text = "Номер чека";
            lblNomberCheckVM.Location = new Point(165, 5);
            lblNomberCheckVM.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomberCheckVM);

            lblNazvVidMed.Size = new Size(150, 20);
            lblNazvVidMed.Text = "Выданный медикамент";
            lblNazvVidMed.Location = new Point(165, 55);
            lblNazvVidMed.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNazvVidMed);

            lblIDDoljnost.Size = new Size(150, 20);
            lblIDDoljnost.Text = "ID Должность";
            lblIDDoljnost.Location = new Point(165, 105);
            lblIDDoljnost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDDoljnost);

            lblIDSotrydnikC.Size = new Size(150, 20);
            lblIDSotrydnikC.Text = "ID Сотрудник";
            lblIDSotrydnikC.Location = new Point(165, 155);
            lblIDSotrydnikC.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDSotrydnikC);

            tbNomberCheckVM.Size = new Size(150, 20);
            tbNomberCheckVM.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(tbNomberCheckVM);

            tbNazvVidMed.Size = new Size(150, 20);
            tbNazvVidMed.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(tbNazvVidMed);

            cmbIDDoljnost.Size = new Size(150, 20);
            cmbIDDoljnost.Location = new Point(165, 125);
            pnlTextBox.Controls.Add(cmbIDDoljnost);

            cmbIDSotrydnikC.Size = new Size(150, 20);
            cmbIDSotrydnikC.Location = new Point(165, 175);
            pnlTextBox.Controls.Add(cmbIDSotrydnikC);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnCheck_vid_medInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnCheck_vid_medUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnCheck_vid_medDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void IncomeForm_med_Fill()
        {
            lblKolVidMed.Size = new Size(150, 20);
            lblKolVidMed.Text = "Колличество медикаментов";
            lblKolVidMed.Location = new Point(165, 205);
            lblKolVidMed.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblKolVidMed);

            lblIDVidCheck.Size = new Size(150, 20);
            lblIDVidCheck.Text = "ID чека";
            lblIDVidCheck.Location = new Point(325, 5);
            lblIDVidCheck.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDVidCheck);

            tbKolVidMed.Size = new Size(150, 20);
            tbKolVidMed.Location = new Point(165, 225);
            pnlTextBox.Controls.Add(tbKolVidMed);

            cmbIDVidCheck.Size = new Size(150, 20);
            cmbIDVidCheck.Location = new Point(325, 25);
            pnlTextBox.Controls.Add(cmbIDVidCheck);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnMedInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnMedUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnMedDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void IncomeForm_Prodaja_tovara_Fill()
        {
            lblIDMedicamentov.Size = new Size(150, 20);
            lblIDMedicamentov.Text = "ID медикаментов";
            lblIDMedicamentov.Location = new Point(325, 55);
            lblIDMedicamentov.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDMedicamentov);

            lblIDInstrRabKass.Size = new Size(150, 20);
            lblIDInstrRabKass.Text = "ID инструкции кассира";
            lblIDInstrRabKass.Location = new Point(325, 105);
            lblIDInstrRabKass.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDInstrRabKass);

            cmbIDMedicamentov.Size = new Size(150, 20);
            cmbIDMedicamentov.Location = new Point(325, 75);
            pnlTextBox.Controls.Add(cmbIDMedicamentov);

            cmbIDInstrRabKass.Size = new Size(150, 20);
            cmbIDInstrRabKass.Location = new Point(325, 125);
            pnlTextBox.Controls.Add(cmbIDInstrRabKass);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            btnInsert.Click += new EventHandler(btnProdajaInsert_Click);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            btnUpdate.Click += new EventHandler(btnProdajaUpdate_Click);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            btnDelete.Click += new EventHandler(btnProdajaDelete_Click);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public void IncomeForm_Fill()
        {
            lblInstrRabKassir.Size = new Size(150, 20);
            lblInstrRabKassir.Text = "Вид инструкции";
            lblInstrRabKassir.Location = new Point(5, 5);
            lblInstrRabKassir.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblInstrRabKassir);

            tbInstrRabKassir.Size = new Size(150, 20);
            tbInstrRabKassir.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbInstrRabKassir);

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            
            pnlTextBox.Size = new Size(780, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(485, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(485, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(485, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);
        }

        public Form aggregateMainForm = new Form();

        public Button btnDocument = new Button();
        public Button btnStaff = new Button();
        Button btnSupply = new Button();
        Button btnIncome = new Button();
        Button btnKassa = new Button();
        Button btnApplication = new Button();

        public void MainFormFill(bool btDoc, bool btStaff, bool btSupply, bool btIncome, bool btKassa, bool btApp)
        {

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Меню";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateMainForm.Controls.Add(lblHead);

            

            pnlTextBox.Size = new Size(300, 500);
            pnlTextBox.Location = new Point(300, 100);
            aggregateMainForm.Controls.Add(pnlTextBox);

            btnDocument.Visible = btDoc;
            btnDocument.Size = new Size(100, 50);
            btnDocument.Text = "Документы";
            btnDocument.Location = new Point(100, 25);
            btnDocument.Font = new Font("Times New Roman", 10);
            btnDocument.Click += new EventHandler(btnDocument_Click);
            pnlTextBox.Controls.Add(btnDocument);

            btnStaff.Visible = btStaff;
            btnStaff.Size = new Size(100, 50);
            btnStaff.Text = "Персонал";
            btnStaff.Location = new Point(100, 100);
            btnStaff.Font = new Font("Times New Roman", 10);
            btnStaff.Click += new EventHandler(btnStaff_Click);
            pnlTextBox.Controls.Add(btnStaff);

            btnSupply.Visible = btSupply;
            btnSupply.Size = new Size(100, 50);
            btnSupply.Text = "Поставка";
            btnSupply.Location = new Point(100, 175);
            btnSupply.Font = new Font("Times New Roman", 10);
            btnSupply.Click += new EventHandler(btnSupply_Click);
            pnlTextBox.Controls.Add(btnSupply);

            btnIncome.Visible = btIncome;
            btnIncome.Size = new Size(100, 50);
            btnIncome.Text = "Прибыль и расходы";
            btnIncome.Location = new Point(100, 250);
            btnIncome.Font = new Font("Times New Roman", 10);
            btnIncome.Click += new EventHandler(btnIncome_Click);
            pnlTextBox.Controls.Add(btnIncome);

            btnKassa.Visible = btKassa;
            btnKassa.Size = new Size(100, 50);
            btnKassa.Text = "Касса";
            btnKassa.Location = new Point(100, 325);
            btnKassa.Font = new Font("Times New Roman", 10);
            btnKassa.Click += new EventHandler(btnKassa_Click);
            pnlTextBox.Controls.Add(btnKassa);

            btnApplication.Visible = btApp;
            btnApplication.Size = new Size(100, 50);
            btnApplication.Text = "Анкета";
            btnApplication.Location = new Point(100, 400);
            btnApplication.Font = new Font("Times New Roman", 10);
            btnApplication.Click += new EventHandler(bbtnApplication_Click);
            pnlTextBox.Controls.Add(btnApplication);


        }
        
            protected void btnDocument_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DocumentChangeForm DCF = new DocumentChangeForm();
            DCF.Show();
            aggregateMainForm.Hide();
        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StaffForm SF = new StaffForm();
            SF.Show();
            aggregateMainForm.Hide();
        }

        protected void btnSupply_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SupplyForm SUF = new SupplyForm();
            SUF.Show();
            aggregateMainForm.Hide();
        }

        protected void btnIncome_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            IncomeForm INCF = new IncomeForm();
            INCF.Show();
            aggregateMainForm.Hide();
        }

        protected void btnKassa_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            KassaForm KF = new KassaForm();
            KF.Show();
            aggregateMainForm.Hide();
        }

        protected void bbtnApplication_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ApplicationForm AF = new ApplicationForm();
            AF.Show();
            aggregateMainForm.Hide();
        }

        protected void btnSoiskatelInsert_Click(object sender, EventArgs e)
        {
            ApplicationForm frm1 = new ApplicationForm();
            procedure.spSoiskatel_Insert(tbNameSoiskatel.Text,
                tbFamSoiskatel.Text, tbOtchSoiskatel.Text, Convert.ToInt32(cmbTabel_rab_vremeni_ID.SelectedValue.ToString()), Convert.ToInt32(cmbDogovor_ID.SelectedValue.ToString()));
            frm1.dgvApplicationForm.DataSource = tables.dtSoiskatel;
            tbNameSoiskatel.Clear();
            tbFamSoiskatel.Clear();
            tbOtchSoiskatel.Clear();
        }

        protected void btnSoiskatelUpdate_Click(object sender, EventArgs e)
        {
            ApplicationForm frm1 = new ApplicationForm();
           procedure.spSoiskatel_Update(Convert.ToInt32(NewIdSoiskatel),
                tbFamSoiskatel.Text, tbNameSoiskatel.Text, tbOtchSoiskatel.Text, Convert.ToInt32(cmbTabel_rab_vremeni_ID.SelectedValue.ToString()), Convert.ToInt32(cmbDogovor_ID.SelectedValue.ToString()));
        }

        protected void btnSoiskatelDelete_Click(object sender, EventArgs e)
        {
            ApplicationForm frm1 = new ApplicationForm();
            switch (MessageBox.Show("Удаление соискателя " +
                tbFamSoiskatel.Text + " " + tbNameSoiskatel.Text + " " + tbOtchSoiskatel.Text + "?", "Удалить соискателя ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                     procedure.spSoiskatel_Delete(Convert.ToInt32(
                         NewIdSoiskatel));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void bbtCancel_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            DocumentChangeForm DF = new DocumentChangeForm();
            MF.Show();
            DF.Hide();
        }

        protected void bbtCancel_ApplicationFormClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            ApplicationForm AF = new ApplicationForm();
            MF.Show();
            AF.Hide();
        }

        protected void bbtCancel_KassaFormClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            KassaForm KF = new KassaForm();
            MF.Show();
            KF.Hide();
        }

        protected void bbtCancel_StaffFormClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            StaffForm SF = new StaffForm();
            MF.Show();
            SF.Hide();
        }

        protected void bbtCancel_SupplyFormClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            SupplyForm SF = new SupplyForm();
            SF.Hide();
            MF.Show();
        }

        protected void bbtCancel_IncomeFormClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MainForm MF = new MainForm();
            IncomeForm IF = new IncomeForm();
            IF.Hide();
            MF.Show();
        }

        protected void btnTovar_na_skladeInsert_Click(object sender, EventArgs e)
        {
            SupplyForm spl = new SupplyForm();
            procedure.spTovar_na_sklade_Insert(Convert.ToInt32(txSrokHran.Text),
                Convert.ToInt32(txKolTovNaSklade.Text), Convert.ToInt32(txNomSkafa.Text), Convert.ToInt32(txNomPolki.Text));
            spl.dgvTovar_na_sklade.DataSource = tables.dtTovar_na_sklade;
            txSrokHran.Clear();
            txKolTovNaSklade.Clear();
            txNomSkafa.Clear();
            txNomPolki.Clear();
        }

        protected void btnTovar_na_skladeUpdate_Click(object sender, EventArgs e)
        {
            procedure.spTovar_na_sklade_Update(Convert.ToInt32(NewIdTovar_na_sklade),
                 Convert.ToInt32(txSrokHran.Text.ToString()),
                Convert.ToInt32(txKolTovNaSklade.Text.ToString()), Convert.ToInt32(txNomSkafa.Text.ToString()), Convert.ToInt32(txNomPolki.Text.ToString()));
        }

        protected void btnTovar_na_skladeDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление товара на складе " +
                 "?", "Удалить товар со склада ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSoiskatel_Delete(Convert.ToInt32(
                        NewIdTovar_na_sklade));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnPost_tovarInsert_Click(object sender, EventArgs e)
        {
            SupplyForm spl = new SupplyForm();
            procedure.spPost_tovar_Insert(txNaimPostTovar.Text, Convert.ToInt32(txKolPostTovar.Text), Convert.ToByte(txTsenaPostTovara.Text));
            spl.dgvPost_tovar.DataSource = tables.dtPost_tovar;
            txNaimPostTovar.Clear();
            txKolPostTovar.Clear();
            txTsenaPostTovara.Clear();
        }

        protected void btnPost_tovarUpdate_Click(object sender, EventArgs e)
        {
            procedure.spPost_tovar_Update(Convert.ToInt32(NewIdPost_tovar),
                 txNaimPostTovar.Text, Convert.ToInt32(txKolPostTovar.Text), Convert.ToByte(txTsenaPostTovara.Text));
        }

        protected void btnPost_tovarDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление поставленного товара на складе " +
                 "?", "Удалить поставленный товар со склада ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSoiskatel_Delete(Convert.ToInt32(
                        NewIdPost_tovar));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnFirma_postavkiInsert_Click(object sender, EventArgs e)
        {
            SupplyForm spl = new SupplyForm();
            procedure.spFirma_postavki_Insert(txNazvFirmPost.Text, Convert.ToInt32(txIndex.Text), txNasPunkt.Text, txUlitsa.Text, Convert.ToByte(txDom.Text));
            spl.dgvFirma_postavki.DataSource = tables.dtFirma_postavki;
            txNazvFirmPost.Clear();
            txIndex.Clear();
            txUlitsa.Clear();
            txDom.Clear();
        }

        protected void btnFirma_postavkiUpdate_Click(object sender, EventArgs e)
        {
            procedure.spFirma_postavki_Update(Convert.ToInt32(NewIdFirma_postavki),
                 txNazvFirmPost.Text, Convert.ToInt32(txIndex.Text), txNasPunkt.Text, txUlitsa.Text, Convert.ToByte(txDom.Text));
        }

        protected void btnFirma_postavkiDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о фирме поставки " +
                 "?", "Удалить информацию о фирме ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSoiskatel_Delete(Convert.ToInt32(
                        NewIdFirma_postavki));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnPostavshikiInsert_Click(object sender, EventArgs e)
        {
            SupplyForm spl = new SupplyForm();
            procedure.spPostavshik_Insert(txFamPost.Text, txNamePost.Text, txOtchPost.Text,  Convert.ToInt32(cmbIDFirmPost.SelectedValue.ToString()));
            spl.dgvPostavshiki.DataSource = tables.dtFirma_postavki;
            txFamPost.Clear();
            txNamePost.Clear();
            txOtchPost.Clear();
        }

        protected void btnPostavshikiUpdate_Click(object sender, EventArgs e)
        {
            procedure.spPostavshik_Update(Convert.ToInt32(NewIdPostavshiki),
                 txFamPost.Text, txNamePost.Text, txOtchPost.Text, Convert.ToInt32(cmbIDFirmPost.SelectedValue.ToString()));
        }

        protected void btnPostavshikiDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о поставщике " + txFamPost.Text + " " + txNamePost.Text + " " + txOtchPost.Text +
                 "?", "Удалить информацию о поставщике ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPostavshik_Delete(Convert.ToInt32(
                        NewIdPostavshiki));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnPostavkiInsert_Click(object sender, EventArgs e)
        {
            SupplyForm spl = new SupplyForm();
            procedure.spPostavka_Insert(Convert.ToInt32(cmbIDPostavshik.SelectedValue.ToString()), Convert.ToInt32(cmbIDTovNaSklade.SelectedValue.ToString()), Convert.ToInt32(cmbIDPostTovara.SelectedValue.ToString()));
            spl.dgvPostavki.DataSource = tables.dtPostavka;
        }

        protected void btnPostavkiUpdate_Click(object sender, EventArgs e)
        {
            procedure.spPostavka_Update(Convert.ToInt32(NewIdPostavki),
                 Convert.ToInt32(cmbIDPostavshik.SelectedValue.ToString()), Convert.ToInt32(cmbIDTovNaSklade.SelectedValue.ToString()), Convert.ToInt32(cmbIDPostTovara.SelectedValue.ToString()));
        }

        protected void btnPostavkiDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о поставке " + txFamPost.Text + " " + txNamePost.Text + " " + txOtchPost.Text +
                 "?", "Удалить информацию о поставке ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPostavshik_Delete(Convert.ToInt32(
                        NewIdPostavki));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnTabel_rab_vremeniInsert_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            procedure.spTabel_rab_vremeni_Insert(Convert.ToInt32(tbOtrDays.Text.ToString()),
                Convert.ToInt32(tbVixDays.Text.ToString()), Convert.ToInt32(tbKomandirivki.Text.ToString()), Convert.ToInt32(tbOtpuska.Text.ToString()));
            staff.dgvTabel_rab.DataSource = tables.dtTabel_rab_vremeni;
            tbOtrDays.Clear();
            tbVixDays.Clear();
            tbKomandirivki.Clear();
            tbOtpuska.Clear();
        }

        protected void btnTabel_rab_vremeniUpdate_Click(object sender, EventArgs e)
        {
            procedure.spTabel_rab_vremeni_Update(Convert.ToInt32(NewIdTab_rab_vremeni),
                 Convert.ToInt32(tbOtrDays.Text.ToString()),
                Convert.ToInt32(tbVixDays.Text.ToString()), Convert.ToInt32(tbKomandirivki.Text.ToString()), Convert.ToInt32(tbOtpuska.Text.ToString()));
        }

        protected void btnTabel_rab_vremeniiDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о табеле рабочего времени " + 
                 "?", "Удалить информацию о табеле ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPostavshik_Delete(Convert.ToInt32(
                        NewIdPostavki));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnDoljnostiInsert_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            procedure.spDoljnost_Insert(tbDoljnost.Text);
            staff.dgvOrder.DataSource = tables.dtDoljnost;
            tbDoljnost.Clear();
        }

        protected void btnDoljnostUpdate_Click(object sender, EventArgs e)
        {
            procedure.spDoljnost_Update(Convert.ToInt32(NewIdDolj),
                 tbDoljnost.Text);
        }

        protected void btnDoljnostDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о занимаемой должности " +
                 "?", "Удалить информацию о должности ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPostavshik_Delete(Convert.ToInt32(
                        NewIdDolj));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnRoleInsert_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            procedure.spRole_Insert(tbRole.Text);
            staff.dgvRole.DataSource = tables.dtRole;
            tbRole.Clear();
        }

        protected void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            procedure.spDoljnost_Update(Convert.ToInt32(NewIdRole),
                 tbRole.Text);
        }

        protected void btnRoleDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о роли " +
                 "?", "Удалить информацию о роли ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPostavshik_Delete(Convert.ToInt32(
                        NewIdRole));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnSotrInsert_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            procedure.spSotrudnik_Insert(Convert.ToInt32(tbNomberSotr.Text),tbFamSotr.Text,tbNamehSotr.Text,tbOtchSotr.Text, Convert.ToInt32(cmbIDDogovor.SelectedValue.ToString()), Convert.ToInt32(cmbTypeAccount.SelectedValue.ToString()));
            staff.dgvSotr.DataSource = tables.dtSotrudnik;
            tbNomberSotr.Clear();
            tbFamSotr.Clear();
            tbNamehSotr.Clear();
            tbOtchSotr.Clear();
        }

        protected void btnSotrUpdate_Click(object sender, EventArgs e)
        {
            procedure.spSotrudnik_Update(Convert.ToInt32(NewIdSotr),
                 Convert.ToInt32(tbNomberSotr.Text), tbFamSotr.Text, tbNamehSotr.Text, tbOtchSotr.Text, Convert.ToInt32(cmbIDDogovor.SelectedValue.ToString()), Convert.ToInt32(cmbTypeAccount.SelectedValue.ToString()));
        }

        protected void btnSotrDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о сотрудниках " + tbFamSotr.Text + " " + tbNamehSotr.Text + " " + tbOtchSotr.Text +
                 "?", "Удалить информацию о сотруднтиках ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSotrudnik_Delete(Convert.ToInt32(
                        NewIdSotr));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnAccountInsert_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            procedure.spAccount_Insert(tbLogin.Text, tbParol.Text, Convert.ToInt32(cmbIDRole.SelectedValue.ToString()));
            staff.dgvAccount.DataSource = tables.dtAccount;
            tbLogin.Clear();
            tbParol.Clear();
        }

        protected void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            procedure.spAccount_Update(Convert.ToInt32(NewIdAccount),
                 tbLogin.Text, tbParol.Text, Convert.ToInt32(cmbIDRole.SelectedValue.ToString()));
        }

        protected void btnAccountDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации об аккаунтах " +
                 "?", "Удалить информацию об аккаунтах ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spAccount_Delete(Convert.ToInt32(
                        NewIdSotr));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnInstructionsInsert_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            procedure.spInstr_raboty_kassira_insert(tbInstrRabKassir.Text);
            income.dgvVidDocument.DataSource = tables.dtInstr_raboty_kassira;
            tbInstrRabKassir.Clear();
        }

        protected void btnInstructionsUpdate_Click(object sender, EventArgs e)
        {
            procedure.spInstr_raboty_kassira_update(Convert.ToInt32(NewIdInstruction),
                 tbInstrRabKassir.Text);
        }

        protected void btnInstructionsDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о инструкции " + tbInstrRabKassir.Text +
                 "?", "Удалить информацию о инструкции ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spInstr_rabory_kassira_delete(Convert.ToInt32(
                        NewIdInstruction));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnPribil_i_rashodiInsert_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            procedure.spPribil_i_rashodi_Insert(Convert.ToSingle(tbPribil.Text), Convert.ToSingle(tbRashody.Text), tbNachOtcheta.Text, tbKonOtch.Text);
            income.dgvPribil_i_rashodi.DataSource = tables.dtPribil_i_rashodi;
            tbPribil.Clear();
            tbRashody.Clear();
            tbNachOtcheta.Clear();
            tbKonOtch.Clear();
        }

        protected void btnPribil_i_rashodiUpdate_Click(object sender, EventArgs e)
        {
            procedure.spPribil_i_rashodi_Update(Convert.ToInt32(NewIdPribil_i_rashodi),
                 Convert.ToByte(tbPribil.Text), Convert.ToByte(tbRashody.Text), tbNachOtcheta.Text, tbKonOtch.Text);
        }

        protected void btnPribil_i_rashodiDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о прибыли и расходах " + 
                 "?", "Удалить информацию о прибылях и инструкциях ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPribil_i_rashodi_Delete(Convert.ToInt32(
                        NewIdPribil_i_rashodi));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnCheck_vid_medInsert_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            procedure.spCheck_vid_med_Insert(Convert.ToInt32(tbNomberCheck.Text),tbNazvVidMed.Text, Convert.ToInt32(cmbIDDoljnost.SelectedValue.ToString()),
                Convert.ToInt32(cmbIDSotrydnikC.SelectedValue.ToString()));
            income.dgvCheckVidMed.DataSource = tables.dtCheck_vid_med;
            tbNomberCheck.Clear();
            tbNazvVidMed.Clear();
        }

        protected void btnCheck_vid_medUpdate_Click(object sender, EventArgs e)
        {
            procedure.spCheck_vid_med_Update(Convert.ToInt32(NewIdCheck_vid_med),
                 Convert.ToInt32(tbNomberCheck.Text), tbNazvVidMed.Text, Convert.ToInt32(cmbIDDoljnost.SelectedValue.ToString()),
                Convert.ToInt32(cmbIDSotrydnikC.SelectedValue.ToString()));
        }

        protected void btnCheck_vid_medDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о чеке выданных медикаментах " + tbNomberCheck.Text +
                 "?", "Удалить информацию о чеке выданных медикаментах ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spCheck_vid_med_Delete(Convert.ToInt32(
                        NewIdCheck_vid_med));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnMedInsert_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            procedure.spMedicamenti_Insert(Convert.ToInt32(tbKolVidMed.Text), Convert.ToInt32(cmbIDVidCheck.SelectedValue.ToString()));
            income.dgvMed.DataSource = tables.dtMedicamenti;
            tbKolVidMed.Clear();
        }

        protected void btnMedUpdate_Click(object sender, EventArgs e)
        {
            procedure.spMedicamenti_Update(Convert.ToInt32(NewIdMed),
                 Convert.ToInt32(tbKolVidMed.Text), Convert.ToInt32(cmbIDVidCheck.SelectedValue.ToString()));
        }

        protected void btnMedDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о медикаментах " + tbNomberCheck.Text +
                 "?", "Удалить информацию о медикаментах ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spMedicamenti_Delete(Convert.ToInt32(
                        NewIdMed));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected void btnProdajaInsert_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            procedure.spProdaja_tovara_Insert(Convert.ToInt32(cmbIDMedicamentov.SelectedValue.ToString()), Convert.ToInt32(cmbIDInstrRabKass.SelectedValue.ToString()));
            income.dgvProdajaTov.DataSource = tables.dtProdaja_tovara;
        }

        protected void btnProdajaUpdate_Click(object sender, EventArgs e)
        {
            procedure.spProdaja_tovara_Update(Convert.ToInt32(NewIdProdaja_tovara),
                 Convert.ToInt32(cmbIDMedicamentov.SelectedValue.ToString()), Convert.ToInt32(cmbIDInstrRabKass.SelectedValue.ToString()));
        }

        protected void btnProdajaDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удаление информации о продажах " + tbNomberCheck.Text +
                 "?", "Удалить информацию о продажах ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spProdaja_tovara_Delete(Convert.ToInt32(
                        NewIdProdaja_tovara));
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
