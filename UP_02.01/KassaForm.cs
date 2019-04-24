using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_02._01
{
    public partial class KassaForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects dynamicClass = new DynamicObjects();
        
        public KassaForm()
        {
            InitializeComponent();
        }

        private void KassaForm_Load(object sender, EventArgs e)
        {
            dynamicClass.aggregateKassaForm = this;
            dynamicClass.KassaFormFill();
            Thread thread = new Thread(dgvSelecionFill);
            thread.Start();

            DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateKassaForm = this;
            classDynamicObjects.KassaFormFill();
        }

        public void dgvSelecionFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables data = new DataBaseTables();
                    
                    //filterDepartment = data.qrDepartment;
                    tables.dtMedicamentiFill();
                    tables.dependency.OnChange += onchangeApplication;
                    dgvSelection.DataSource = tables.dtMedicamenti;
                    dgvSelection.Columns[0].Visible = true;
                    dgvSelection.Columns[1].HeaderText = "Количество выданных медикаментов";
                    dgvSelection.Columns[2].Visible = false;
                    dgvSelection.Columns[3].Visible = false;
                    dgvSelection.Columns[4].HeaderText = "Номер чека";
                    dgvSelection.Columns[5].HeaderText = "Название медикаментов";
                    
                    dgvSelection.Columns[8].Visible = false;
                    dgvSelection.Columns[9].Visible = false;
                    dgvSelection.Columns[10].Visible = false;
                    dgvSelection.Columns[11].Visible = false;
                    dgvSelection.Columns[12].Visible = false;
                    dgvSelection.Columns[13].Visible = false;
                    dgvSelection.Columns[14].Visible = false;
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
                dgvSelecionFill();
        }

        private void btWordCheck_Click(object sender, EventArgs e)
        {
            
            switch (Registry_Class.DirPath == "Empty"|| Registry_Class.OrganizationName == "Empty"
                                                      || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                                                      Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    AppConfigForm configurationForm = new AppConfigForm();
                    configurationForm.ShowDialog();
                    break;
                case (false):
                    btCheckWord.Enabled = false;
                    DataBaseTables data = new DataBaseTables();
                    data.qrCheck_vid_med =
                        "select [nom_check] as \"Номер чека\",[nazv_vid_med] as \"Название медикаментов\", [doljnost_id] as \"Код должности\",[sotrudnik_id] as \"Код сотрудников\" from [dbo].[check_vid_med]";
                    data.dtCheck_vid_medFill();
                    WordDocument document = new WordDocument();
                    document.table = data.dtCheck_vid_med;
                   
                    document.CheckWord();
                    btCheckWord.Enabled = true;
                    break;
            }
        }
    }
}
