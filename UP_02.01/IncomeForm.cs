using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UP_02._01
{
    public partial class IncomeForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects classIncomeForm = new DynamicObjects();
        DBProcedures procedure = new DBProcedures();
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            classIncomeForm.aggregateIncomeForm = this;
            classIncomeForm.IncomeFormFill();
            Thread thread = new Thread(dgvVid_documentFormFill);
            thread.Start();
            Thread thread1 = new Thread(dgvOrderFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvCheck_vid_medFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvMedFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvProdaja_tovFill);
            thread4.Start();
        }

        public void dgvVid_documentFormFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtInstr_raboty_kassiraFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvVidDocument.DataSource = tables.dtInstr_raboty_kassira;
                    dgvVidDocument.Columns[0].Visible = false;
                    dgvVidDocument.Columns[1].HeaderText = "Инструкция работы кассира";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvOrderFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtPribil_i_rashodiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvOrder.DataSource = tables.dtPribil_i_rashodi;
                    dgvOrder.Columns[0].Visible = false;
                    dgvOrder.Columns[1].HeaderText = "Прибыль";
                    dgvOrder.Columns[2].HeaderText = "Расходы";
                    dgvOrder.Columns[3].HeaderText = "Начало отчета";
                    dgvOrder.Columns[4].HeaderText = "Конец отчета";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvCheck_vid_medFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtCheck_vid_medFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvCheckVidMed.DataSource = tables.dtCheck_vid_med;
                    dgvCheckVidMed.Columns[0].Visible = false;
                    dgvCheckVidMed.Columns[1].HeaderText = "Номер чека";
                    dgvCheckVidMed.Columns[2].HeaderText = "Название медикамента";
                    dgvCheckVidMed.Columns[3].HeaderText = "Должность";
                    dgvCheckVidMed.Columns[4].HeaderText = "Сотрудник";
                    dgvCheckVidMed.Columns[5].Visible = false;
                    dgvCheckVidMed.Columns[6].HeaderText = "Обслуживающий персонал";
                    dgvCheckVidMed.Columns[7].Visible = false;
                    dgvCheckVidMed.Columns[8].HeaderText = "Табельный номер сотрудника";
                    dgvCheckVidMed.Columns[9].HeaderText = "ФИО сотрудника";
                }
                catch
                {

                }
            };
            Invoke(action);
        }
        public void dgvMedFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtMedicamentiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvMed.DataSource = tables.dtMedicamenti;
                    dgvMed.Columns[0].Visible = false;
                    dgvMed.Columns[1].HeaderText = "Количество выданных медикаментов";
                    dgvMed.Columns[2].HeaderText = "Чек выданных медикаментов";
                    dgvMed.Columns[4].HeaderText = "Номер чека";
                    dgvMed.Columns[5].HeaderText = "Название медикамента";
                    dgvMed.Columns[3].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvProdaja_tovFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtProdaja_tovaraFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvProdajaTov.DataSource = tables.dtProdaja_tovara;
                    dgvProdajaTov.Columns[0].Visible = false;
                    dgvProdajaTov.Columns[1].HeaderText = "Номер медикамента";
                    dgvProdajaTov.Columns[2].HeaderText = "Номер инструкции";
                    dgvProdajaTov.Columns[4].HeaderText = "Количество выданных медикаментов";
                    dgvProdajaTov.Columns[6].HeaderText = "Инструкция";
                    dgvProdajaTov.Columns[3].Visible = false;
                    dgvProdajaTov.Columns[5].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }
    }
}
