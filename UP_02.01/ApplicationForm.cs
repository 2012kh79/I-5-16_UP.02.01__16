using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UP_02._01
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            DynamicObjects classApplicationForm = new DynamicObjects();
            classApplicationForm.aggregateApplicationForm = this;
            classApplicationForm.ApplicationFormFill();
            Thread thread = new Thread(applicationFormFill);
            thread.Start();
        }

        private void applicationFormFill()
        {
            Action action = () =>
            {
                DataBaseTables tables = new DataBaseTables();
                tables.dtSoiskatelFill();
                tables.dependency.OnChange += onchangeEmployee;
                dgvApplicationForm.DataSource = tables.dtSoiskatel;
                //dgvApplicationForm.Columns[0].Visible = false;
                //dgvApplicationForm.Columns[1].HeaderText = "Фамилия соискателя";
                //dgvApplicationForm.Columns[2].HeaderText = "Имя соискателя";
                //dgvApplicationForm.Columns[3].HeaderText = "Отчество соискателя";
                //dgvApplicationForm.Columns[4].Visible = false;
                //dgvApplicationForm.Columns[5].Visible = false;
            };
            Invoke(action);

        }
        private void onchangeEmployee(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                applicationFormFill();
        }
    }
}
