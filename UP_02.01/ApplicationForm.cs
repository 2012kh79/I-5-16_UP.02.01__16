using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections.Generic;

namespace UP_02._01
{
    public partial class ApplicationForm : Form
    {
        DynamicObjects classApplicationForm = new DynamicObjects();
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            classApplicationForm.aggregateApplicationForm = this;
            classApplicationForm.ApplicationFormFill();
            Thread thread = new Thread(dgvApplicationFormFill);
            thread.Start();
        }

        private void dgvApplicationFormFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables = new DataBaseTables();
                    //filterDepartment = data.qrDepartment;
                    tables.dtSoiskatelFill();
                    tables.dependency.OnChange += onchangeApplication;
                    dgvApplicationForm.DataSource = tables.dtSoiskatel;
                    dgvApplicationForm.Columns[0].Visible = false;
                    dgvApplicationForm.Columns[1].HeaderText = "Фамилия соискателя";
                    dgvApplicationForm.Columns[2].HeaderText = "Имя соискателя";
                    dgvApplicationForm.Columns[3].HeaderText = "Отчество соискателя";
                    dgvApplicationForm.Columns[4].Visible = false;
                    dgvApplicationForm.Columns[5].Visible = false;
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
        private void onchangeApplication(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dgvApplicationFormFill();
        }

        private void dgvApplicationForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classApplicationForm.tbFamSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[1].Value.ToString();
            classApplicationForm.tbNameSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[2].Value.ToString();
            classApplicationForm.tbOtchSoiskatel.Text = dgvApplicationForm.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
