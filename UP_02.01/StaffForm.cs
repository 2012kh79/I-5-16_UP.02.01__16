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
    public partial class StaffForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects classStaffForm = new DynamicObjects();
        DBProcedures procedure = new DBProcedures();
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            classStaffForm.aggregateStaffForm = this;
            classStaffForm.StaffFormFill();
            Thread thread = new Thread(dgvTabel_rab_vremeniFill);
            thread.Start();
            //Thread thread1 = new Thread(dgvOrderFill);
            //thread1.Start();
            //Thread thread2 = new Thread(dgvCheck_vid_medFill);
            //thread2.Start();
            //Thread thread3 = new Thread(dgvMedFill);
            //thread3.Start();
            //Thread thread4 = new Thread(dgvProdaja_tovFill);
            //thread4.Start();
        }

        public void dgvTabel_rab_vremeniFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtTabel_rab_vremeniFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvTabel_rab.DataSource = tables.dtTabel_rab_vremeni;
                    //dgvTabel_tab_vremeni.Columns[0].Visible = false;
                    //dgvOrder.Columns[1].HeaderText = "Прибыль";
                    //dgvOrder.Columns[2].HeaderText = "Расходы";
                    //dgvOrder.Columns[3].HeaderText = "Начало отчета";
                    //dgvOrder.Columns[4].HeaderText = "Конец отчета";
                }
                catch
                {

                }
            };
            Invoke(action);
        }
    }
}
