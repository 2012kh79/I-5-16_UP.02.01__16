using System;
using System.Windows.Forms;
using System.Drawing;


namespace UP_02._01
{
    class DynamicObjects
    {

        public Label lblHead = new Label();
        public Label lblVidDocument = new Label();
        public Label lblNomberOrder = new Label();
        public Label lblDateOrder = new Label();
        public Label lblSalary = new Label();
        public Label lblDateSignOrder = new Label();
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

            pnlTextBox.Size = new Size(725, 200);
            pnlTextBox.Location = new Point(10, 425);
            aggregateDocumentChangeForm.Controls.Add(pnlTextBox);


            lblVidDocument.Size = new Size(150, 20);
            lblVidDocument.Text = "Вид документа";
            lblVidDocument.Location = new Point(5, 5);
            lblVidDocument.Font = new Font("Times New Roman", 10);

            tbVidDocument.Size = new Size(150, 20);
            tbVidDocument.Location = new Point(5, 25);
            pnlTextBox.Controls.Add(tbVidDocument);
            pnlTextBox.Controls.Add(lblVidDocument);


            lblNomberOrder.Size = new Size(150, 20);
            lblNomberOrder.Text = "Номер приказа";
            lblNomberOrder.Location = new Point(5, 50);
            lblNomberOrder.Font = new Font("Times New Roman", 10);

            tbNomberOrder.Size = new Size(150, 20);
            tbNomberOrder.Location = new Point(5, 75);
            pnlTextBox.Controls.Add(tbNomberOrder);
            pnlTextBox.Controls.Add(lblNomberOrder);


            lblDateOrder.Size = new Size(150, 20);
            lblDateOrder.Text = "Дата составления приказа";
            lblDateOrder.Location = new Point(5, 100);
            lblDateOrder.Font = new Font("Times New Roman", 10);

            tbDateOrder.Size = new Size(150, 20);
            tbDateOrder.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(lblDateOrder);
            pnlTextBox.Controls.Add(tbDateOrder);


            lblSalary.Size = new Size(150, 20);
            lblSalary.Text = "Заработная плата";
            lblSalary.Location = new Point(165, 5);
            lblSalary.Font = new Font("Times New Roman", 10);

            tbSalary.Size = new Size(150, 20);
            tbSalary.Location = new Point(165, 25);
            pnlTextBox.Controls.Add(lblSalary);
            pnlTextBox.Controls.Add(tbSalary);


            lblDateSignOrder.Size = new Size(165, 20);
            lblDateSignOrder.Text = "Дата подписания договора";
            lblDateSignOrder.Location = new Point(165, 50);
            lblDateSignOrder.Font = new Font("Times New Roman", 10);

            tbDateSignOrder.Size = new Size(150, 20);
            tbDateSignOrder.Location = new Point(165, 75);
            pnlTextBox.Controls.Add(lblDateSignOrder);
            pnlTextBox.Controls.Add(tbDateSignOrder);

            btnInsert.Size = new Size(100, 30);
            btnInsert.Text = "Добавить";
            btnInsert.Location = new Point(620, 20);
            btnInsert.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(btnInsert);

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
        }


     
        public Label lblFamSoiskatel = new Label();
        public Label lblNameSoiskatel = new Label();
        public Label lblOtchSoiskatel = new Label();
        public TextBox tbFamSoiskatel = new TextBox();
        public TextBox tbNameSoiskatel = new TextBox();
        public TextBox tbOtchSoiskatel = new TextBox();

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

            tbOtchSoiskatel.Size = new Size(150, 20);
            tbOtchSoiskatel.Location = new Point(5, 125);
            pnlTextBox.Controls.Add(lblOtchSoiskatel);
            pnlTextBox.Controls.Add(tbOtchSoiskatel);


        }
    }
}
