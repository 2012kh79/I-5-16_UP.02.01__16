using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace UP_02._01
{
   
    public partial class ApplicationForm : Form
    {
        
        DynamicObjects classApplicationForm = new DynamicObjects();
        DataBaseTables tables = new DataBaseTables();
        DBProcedures procedure = new DBProcedures();
        public ApplicationForm()
        {
            InitializeComponent();
        }

        public void ApplicationForm_Load(object sender, EventArgs e)
        {
            classApplicationForm.aggregateApplicationForm = this;
            classApplicationForm.ApplicationFormFill();
            Thread thread = new Thread(dgvApplicationFormFill);
            thread.Start();
            Thread thread1 = new Thread(cmbComboBoxFill);
            thread1.Start();
            //Thread thread2 = new Thread(tables.dependency.OnChange onchangeApplication);
            //thread1.Start();
        }

        public void dgvApplicationFormFill()
        {
            Action action = () =>
            {
                try
                {

                    //filterDepartment = data.qrDepartment;
                    tables.dtSoiskatelFill();
                    tables.dependency.OnChange += onchangeApplication;
                    dgvApplicationForm.DataSource = tables.dtSoiskatel;
                    dgvApplicationForm.Columns[0].Visible = true;
                    dgvApplicationForm.Columns[1].HeaderText = "Фамилия соискателя";
                    dgvApplicationForm.Columns[2].HeaderText = "Имя соискателя";
                    dgvApplicationForm.Columns[3].HeaderText = "Отчество соискателя";
                    dgvApplicationForm.Columns[4].HeaderText = "Табель рабочего времени";
                    dgvApplicationForm.Columns[5].HeaderText = "Договор";
                    dgvApplicationForm.Columns[6].Visible = false;
                    dgvApplicationForm.Columns[7].Visible = false;
                    dgvApplicationForm.Columns[8].Visible = false;
                    dgvApplicationForm.Columns[9].Visible = false;
                    dgvApplicationForm.Columns[10].Visible = false;
                    dgvApplicationForm.Columns[11].Visible = false;
                    dgvApplicationForm.Columns[12].Visible = false;
                    dgvApplicationForm.Columns[13].Visible = false;
                    dgvApplicationForm.Columns[14].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbComboBoxFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtTabel_rab_vremeniFill();
                    tables.dtDogovorFill();
                    classApplicationForm.cmbTabel_rab_vremeni_ID.DataSource = tables.dtTabel_rab_vremeni;
                    classApplicationForm.cmbDogovor_ID.DataSource = tables.dtDogovor;
                    classApplicationForm.cmbTabel_rab_vremeni_ID.DisplayMember = "Tabel_rab_vremeni";
                    classApplicationForm.cmbTabel_rab_vremeni_ID.ValueMember = "ID_Tabel_rab_vremeni";
                    classApplicationForm.cmbDogovor_ID.DisplayMember = "Dogovor";
                    classApplicationForm.cmbDogovor_ID.ValueMember = "ID_Dogovor";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void onchangeApplication(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dgvApplicationFormFill();
        }

        private void dgvApplicationForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            classApplicationForm.NewIdSoiskatel = (dgvApplicationForm.CurrentRow.Index + 1).ToString();
            classApplicationForm.tbFamSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[1].Value.ToString();
            classApplicationForm.tbNameSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[2].Value.ToString();
            classApplicationForm.tbOtchSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[3].Value.ToString();
            classApplicationForm.cmbTabel_rab_vremeni_ID.SelectedValue = Convert.ToInt32(dgvApplicationForm.CurrentRow.Cells[4].Value);
            classApplicationForm.cmbDogovor_ID.SelectedValue = Convert.ToInt32(dgvApplicationForm.CurrentRow.Cells[5].Value);

            //  classApplicationForm.cmbDogovor_ID.SelectedValue = 
        }

        private void dgvApplicationForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
