using System;
using System.Windows.Forms;
using System.Drawing;


namespace UP_02._01
{
    class DynamicObjects
    {
         
            Button btnReturn = new Button();
            Button btnInsert = new Button();
            Button btnUpdate = new Button();
            Button btnDelete = new Button();
            Panel pnlTextBox = new Panel();
            TextBox tbVidDocument = new TextBox();
            TextBox tbNomberOrder = new TextBox();
            TextBox tbDateOrder = new TextBox();
            TextBox tbSalary = new TextBox();
            TextBox tbDateSignOrder = new TextBox();
            public Form aggregateDocumentChangeForm = new Form();

        Label lblHead = new Label();
        Label lblVidDocument = new Label(); 
        Label lblNomberOrder = new Label();
        Label lblDateOrder = new Label();
        Label lblSalary = new Label();
        Label lblDateSignOrder = new Label();
        Label lblIDFirm = new Label();
        Label lblZarplata = new Label();
        Label lblIDKadrPere = new Label();
        Label lblIDSotrydnik = new Label();
        Label lblIDDoljnosti = new Label();
        Label lblIDDocument = new Label();
        Label lblIDSoiskatel = new Label();
        Label lblDatePodpisiDoc = new Label();
        Label lblIDSoiskatelKU = new Label();
        Label lblIDTabelZarplata = new Label();
        Label lblIDOtchet = new Label();
        Label lblNazvFirm = new Label(); 
        Label lblIDProdajaTovara = new Label();
        Label lblIDKadrUch = new Label();
        Label lblIDIdent = new Label();
        Label lblVidDocIdent = new Label();
        Label lblStatus = new Label(); 
        Label lblIDPostavka = new Label();

        TextBox tbVidDocumentDoc = new TextBox();
        TextBox tbNomberOrderDoc = new TextBox();
        TextBox tbDateOrdetDoc = new TextBox();
        TextBox tbSalaryDoc = new TextBox();
        TextBox tbDateSignOrderDoc = new TextBox();
        ComboBox cmbIDFirm = new ComboBox();
        TextBox tbZarplata = new TextBox();
        ComboBox cmbIDKadrPere = new ComboBox();
        ComboBox cmbIDSotrydnik = new ComboBox();
        ComboBox cmbIDDoljnosti = new ComboBox();
        ComboBox cmbIDDocument = new ComboBox();
        ComboBox cmbIDSoiskatel = new ComboBox();
        TextBox tbDatePodpisiDoc = new TextBox();
        ComboBox cmbIDSoiskatelKU = new ComboBox();
        ComboBox cmbIDTabelZarplata = new ComboBox();
        ComboBox cmbIDOtchet = new ComboBox();
        TextBox tbNazvFirm = new TextBox();
        ComboBox cmbIDProdajaTovara = new ComboBox();
        ComboBox cmbIDKadrUch = new ComboBox();
        ComboBox cmbIDIdent = new ComboBox();
        TextBox tbVidDocIdent = new TextBox();
        TextBox tbStatus = new TextBox();
        ComboBox cmbIDPostavka = new ComboBox();
        public void DocumentChangeFormFill()
        {
           
            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Изменение Документов";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateDocumentChangeForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateDocumentChangeForm.Controls.Add(btnReturn);

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

            lblIDSoiskatelKU.Size = new Size(150, 20);
            lblIDSoiskatelKU.Text = "ID Соиск. для КУ";
            lblIDSoiskatelKU.Location = new Point(325, 55);
            lblIDSoiskatelKU.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDSoiskatelKU);

            lblIDTabelZarplata.Size = new Size(150, 20);
            lblIDTabelZarplata.Text = "ID Табель зарплаты";
            lblIDTabelZarplata.Location = new Point(325, 105);
            lblIDTabelZarplata.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDTabelZarplata);

            lblIDOtchet.Size = new Size(150, 20);
            lblIDOtchet.Text = "ID Отчёта";
            lblIDOtchet.Location = new Point(325, 155);
            lblIDOtchet.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDOtchet);

            lblNazvFirm.Size = new Size(150, 20);
            lblNazvFirm.Text = "Название фирмы";
            lblNazvFirm.Location = new Point(325, 205);
            lblNazvFirm.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNazvFirm);

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
            lblIDIdent.Location = new Point(645, 5);
            lblIDIdent.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblIDIdent);

            tbVidDocumentDoc.Size = new Size(150, 20);
            tbVidDocumentDoc.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbVidDocumentDoc);

            tbNomberOrderDoc.Size = new Size(150, 20);
            tbNomberOrderDoc.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbNomberOrderDoc);

            tbDateOrdetDoc.Size = new Size(150, 20);
            tbDateOrdetDoc.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(tbDateOrdetDoc);

            cmbIDFirm.Size = new Size(150, 20);
            cmbIDFirm.Location = new Point(5, 175);
            pnlTextBox.Controls.Add(cmbIDFirm);

            tbZarplata.Size = new Size(150, 20);
            tbZarplata.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(tbZarplata);

            cmbIDKadrPere.Size = new Size(150, 20);
            cmbIDKadrPere.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(cmbIDKadrPere);

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

            cmbIDSoiskatelKU.Size = new Size(150, 20);
            cmbIDSoiskatelKU.Location = new Point(325, 75);
            pnlTextBox.Controls.Add(cmbIDSoiskatelKU);

            cmbIDTabelZarplata.Size = new Size(150, 20);
            cmbIDTabelZarplata.Location = new Point(325, 125);
            pnlTextBox.Controls.Add(cmbIDTabelZarplata);

            cmbIDOtchet.Size = new Size(150, 20);
            cmbIDOtchet.Location = new Point(325, 175);
            pnlTextBox.Controls.Add(cmbIDOtchet);

            tbNazvFirm.Size = new Size(150, 20);
            tbNazvFirm.Location = new Point(325, 225);
            pnlTextBox.Controls.Add(tbNazvFirm);

            tbVidDocIdent.Size = new Size(150, 20);
            tbVidDocIdent.Location = new Point(485, 25);
            pnlTextBox.Controls.Add(tbVidDocIdent);

            tbStatus.Size = new Size(150, 20);
            tbStatus.Location = new Point(485, 75);
            pnlTextBox.Controls.Add(tbStatus);

            cmbIDPostavka.Size = new Size(150, 20);
            cmbIDPostavka.Location = new Point(485, 125);
            pnlTextBox.Controls.Add(cmbIDPostavka);

            cmbIDPostTovara.Size = new Size(150, 20);
            cmbIDPostTovara.Location = new Point(485, 175);
            pnlTextBox.Controls.Add(cmbIDPostTovara);

            cmbIDKadrUch.Size = new Size(150, 20);
            cmbIDKadrUch.Location = new Point(485, 225);
            pnlTextBox.Controls.Add(cmbIDKadrUch);

            cmbIDIdent.Size = new Size(150, 20);
            cmbIDIdent.Location = new Point(645, 25);
            pnlTextBox.Controls.Add(cmbIDIdent);
        }


     
        Label lblFamSoiskatel = new Label();
        Label lblNameSoiskatel = new Label();
        Label lblOtchSoiskatel = new Label();
        TextBox tbFamSoiskatel = new TextBox();
        TextBox tbNameSoiskatel = new TextBox();
        TextBox tbOtchSoiskatelr = new TextBox();

        public Form aggregateApplicationForm = new Form();

        public void ApplicationFormFill()
        {
            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Анкета соискателя";
            lblHead.Location = new Point(280, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateApplicationForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateApplicationForm.Controls.Add(btnReturn);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(620, 20);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            pnlTextBox.Size = new Size(725, 325);
            pnlTextBox.Location = new Point(10, 425);
            aggregateApplicationForm.Controls.Add(pnlTextBox);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(620, 70);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(620, 120);
            btnDelete.Font = new Font("Times New Roman", 10);
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

            tbOtchSoiskatelr.Size = new Size(150, 20);
            tbOtchSoiskatelr.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(lblOtchSoiskatel);
            pnlTextBox.Controls.Add(tbOtchSoiskatelr);
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

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateKassaForm.Controls.Add(btnReturn);

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
        Label lblNazvFirmPost = new Label();
        Label lblIndex = new Label();
        Label lblNasPunkt = new Label();
        Label lblUlitsa = new Label();
        Label lblDom = new Label();
        Label lblSrokHran = new Label();
        Label lblKolTovNaSklade = new Label();
        Label lblNomSkafa = new Label();
        Label lblNomPolki = new Label();
        Label lblNaimPostTovar = new Label();
        Label lblKolPostTovar = new Label();
        Label lblTsenaPostTovara = new Label();
        Label lblNamePost = new Label();
        Label lblFamPost = new Label();
        Label lblOtchPost = new Label();
        Label lblIDFirmPost = new Label();
        Label lblIDPostavshik = new Label();
        Label lblIDTovNaSklade = new Label();
        Label lblIDPostTovara = new Label();

        TextBox txNazvFirmPost = new TextBox();
        TextBox txIndex = new TextBox();
        TextBox txNasPunkt = new TextBox();
        TextBox txUlitsa = new TextBox();
        TextBox txDom = new TextBox();

        TextBox txSrokHran = new TextBox();
        TextBox txKolTovNaSklade = new TextBox();
        TextBox txNomSkafa = new TextBox();
        TextBox txNomPolki = new TextBox();
        TextBox txNaimPostTovar = new TextBox();

        TextBox txKolPostTovar = new TextBox();
        TextBox txTsenaPostTovara = new TextBox();
        TextBox txNamePost = new TextBox();
        TextBox txFamPost = new TextBox();
        TextBox txOtchPost = new TextBox();

        ComboBox cmbIDFirmPost = new ComboBox();
        ComboBox cmbIDPostavshik = new ComboBox();
        ComboBox cmbIDTovNaSklade = new ComboBox();
        ComboBox cmbIDPostTovara = new ComboBox();

        public void SupplyFormFill()
        {
            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Поставки";
            lblHead.Location = new Point(350, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateSupplyForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateSupplyForm.Controls.Add(btnReturn);

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

            txNaimPostTovar.Size = new Size(150, 20);
            txNaimPostTovar.Location = new Point(165, 225);
            pnlTextBox.Controls.Add(txNaimPostTovar);

            txKolPostTovar.Size = new Size(150, 20);
            txKolPostTovar.Location = new Point(325, 25);
            pnlTextBox.Controls.Add(txKolPostTovar);

            txTsenaPostTovara.Size = new Size(150, 20);
            txTsenaPostTovara.Location = new Point(325, 75);
            pnlTextBox.Controls.Add(txTsenaPostTovara);

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

            cmbIDPostavshik.Size = new Size(150, 20);
            cmbIDPostavshik.Location = new Point(485, 75);
            pnlTextBox.Controls.Add(cmbIDPostavshik);

            cmbIDTovNaSklade.Size = new Size(150, 20);
            cmbIDTovNaSklade.Location = new Point(485, 125);
            pnlTextBox.Controls.Add(cmbIDTovNaSklade);

            cmbIDPostTovara.Size = new Size(150, 20);
            cmbIDPostTovara.Location = new Point(485, 175);
            pnlTextBox.Controls.Add(cmbIDPostTovara);
        }

        public Form aggregateStaffForm = new Form();


        Label lblOtrDays = new Label();
        Label lblVixDays = new Label();
        Label lblKomandirivki = new Label();
        Label lblOtpuska = new Label();
        Label lblDoljnost = new Label();
        Label lblRole = new Label();
        Label lblNomberSotr = new Label();
        Label lblFamSotr = new Label();
        Label lblNameSotr = new Label();
        Label lblOtchSotr = new Label();
        Label lblIDTabVremya = new Label();
        Label lblIDDogovor = new Label();

        TextBox tbOtrDays = new TextBox();
        TextBox tbVixDays = new TextBox();
        TextBox tbKomandirivki = new TextBox();
        TextBox tbOtpuska = new TextBox();
        TextBox tbDoljnost = new TextBox();
        TextBox tbRole = new TextBox();
        TextBox tbNomberSotr = new TextBox();
        TextBox tbFamSotr = new TextBox();
        TextBox tbNamehSotr = new TextBox();
        TextBox tbOtchSotr = new TextBox();
        ComboBox cmbIDTabVremya = new ComboBox();
        ComboBox cmbIDDogovor = new ComboBox();
       
        public void StaffFormFill()
        {

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Персонал";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateStaffForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateStaffForm.Controls.Add(btnReturn);

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

            lblDoljnost.Size = new Size(150, 20);
            lblDoljnost.Text = "Должность";
            lblDoljnost.Location = new Point(5, 205);
            lblDoljnost.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblDoljnost);

            lblRole.Size = new Size(150, 20);
            lblRole.Text = "Роль";
            lblRole.Location = new Point(165, 5);
            lblRole.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblRole);

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

            tbDoljnost.Size = new Size(150, 20);
            tbDoljnost.Location = new Point(5, 225);
            pnlTextBox.Controls.Add(tbDoljnost);

            tbRole.Size = new Size(150, 20);
            tbRole.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(tbRole);

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
        }

        public Form aggregateIncomeForm = new Form();


        Label lblInstrRabKassir = new Label();
        Label lblPribil = new Label();
        Label lblRashody = new Label();
        Label lblNachOtcheta = new Label();
        Label lblKonOtch = new Label();

        TextBox tbInstrRabKassir = new TextBox();
        TextBox tbPribil = new TextBox();
        TextBox tbRashody = new TextBox();
        TextBox tbNachOtcheta = new TextBox();
        TextBox tbKonOtch = new TextBox();

        public void IncomeFormFill()
        {

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Прибыль и расходы";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateIncomeForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateIncomeForm.Controls.Add(btnReturn);

            pnlTextBox.Size = new Size(400, 250);
            pnlTextBox.Location = new Point(10, 405);
            aggregateIncomeForm.Controls.Add(pnlTextBox);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(250, 25);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Text = "Изменить";
            btnUpdate.Location = new Point(250, 75);
            btnUpdate.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnUpdate);

            btnDelete.Size = new Size(100, 30);
            btnDelete.Text = "Удалить";
            btnDelete.Location = new Point(250, 125);
            btnDelete.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnDelete);

            lblInstrRabKassir.Size = new Size(150, 20);
            lblInstrRabKassir.Text = "Вид инструкции";
            lblInstrRabKassir.Location = new Point(5, 5);
            lblInstrRabKassir.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblInstrRabKassir);

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

            tbInstrRabKassir.Size = new Size(150, 20);
            tbInstrRabKassir.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbInstrRabKassir);

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
        }

        public Form aggregateMainForm = new Form();

        Button btnDocument = new Button();
        Button btnStaff = new Button();
        Button btnSupply = new Button();
        Button btnIncome = new Button();
        Button btnKassa = new Button();
        Button btnApplication = new Button();

        public void MainFormFill()
        {

            lblHead.Size = new Size(400, 50);
            lblHead.Text = "Меню";
            lblHead.Location = new Point(400, 10);
            lblHead.Font = new Font("Times New Roman", 25);
            aggregateMainForm.Controls.Add(lblHead);

            btnReturn.Size = new Size(100, 30);
            btnReturn.Text = "Вернуться";
            btnReturn.Location = new Point(35, 35);
            btnReturn.Font = new Font("Times New Roman", 10);
            aggregateMainForm.Controls.Add(btnReturn);

            pnlTextBox.Size = new Size(300, 500);
            pnlTextBox.Location = new Point(300, 100);
            aggregateMainForm.Controls.Add(pnlTextBox);

            btnDocument.Size = new Size(100, 50);
            btnDocument.Text = "Документы";
            btnDocument.Location = new Point(100, 25);
            btnDocument.Font = new Font("Times New Roman", 10);
            btnDocument.Click += new EventHandler(btnDocument_Click);
            pnlTextBox.Controls.Add(btnDocument);

            btnStaff.Size = new Size(100, 50);
            btnStaff.Text = "Персонал";
            btnStaff.Location = new Point(100, 100);
            btnStaff.Font = new Font("Times New Roman", 10);
            btnStaff.Click += new EventHandler(btnStaff_Click);
            pnlTextBox.Controls.Add(btnStaff);

            btnSupply.Size = new Size(100, 50);
            btnSupply.Text = "Поставка";
            btnSupply.Location = new Point(100, 175);
            btnSupply.Font = new Font("Times New Roman", 10);
            btnSupply.Click += new EventHandler(btnSupply_Click);
            pnlTextBox.Controls.Add(btnSupply);

            btnIncome.Size = new Size(100, 50);
            btnIncome.Text = "Прибыль и расходы";
            btnIncome.Location = new Point(100, 250);
            btnIncome.Font = new Font("Times New Roman", 10);
            btnIncome.Click += new EventHandler(btnIncome_Click);
            pnlTextBox.Controls.Add(btnIncome);

            btnKassa.Size = new Size(100, 50);
            btnKassa.Text = "Касса";
            btnKassa.Location = new Point(100, 325);
            btnKassa.Font = new Font("Times New Roman", 10);
            btnKassa.Click += new EventHandler(btnKassa_Click);
            pnlTextBox.Controls.Add(btnKassa);

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
    }
}
