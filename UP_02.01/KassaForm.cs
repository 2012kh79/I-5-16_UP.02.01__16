using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_02._01
{
    public partial class KassaForm : Form
    {
        public KassaForm()
        {
            InitializeComponent();
        }

        private void KassaForm_Load(object sender, EventArgs e)
        {
            DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateKassaForm = this;
            classDynamicObjects.KassaFormFill();
        }

        private void btWordCheck_Click(object sender, EventArgs e)
        {
            Registry_Class.DirPath = @"C:\Users\1\Desktop\МПТ\Практика\Щаников";
            switch (Registry_Class.DirPath == "Empty") //|| Registry_Class.OrganizationName == "Empty"
                                                      //|| Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                                                      //Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    //ApplicationConfigurationForm configurationForm = new ApplicationConfigurationForm();
                    //configurationForm.ShowDialog();
                    break;
                case (false):
                    btWordCheck.Enabled = false;
                    DataBaseTables data = new DataBaseTables();
                    //data.qrCheck_vid_med =("SELECT [id_check_vid_med] as \"Код чека выданных медикаментов\", [nom_check] as \"Номер чека выданных медикаментов\", [nazv_vid_med] as \"Название выданных медикаментов\", [doljnost_id] as \"Код должности\", [sotrudnik_id] as \"Код сотрудника\" FROM [dbo].[check_vid_med]");
                    data.dtCheck_vid_medFill();
                    WordDocument document = new WordDocument();
                    document.table = data.dtCheck_vid_med;
                    ////document.check_name = cbCheck.Text;
                    document.Check_Word();
                    btWordCheck.Enabled = true;
                    break;
            }
        }
    }
}
