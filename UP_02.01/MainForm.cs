using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_02._01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {


            DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateMainForm = this;
            switch (AuthorizForm.Role_ID)
            {
                case 1:

                    classDynamicObjects.MainFormFill(false, false, false, false, true, false);
                    break;
                case 2:

                    classDynamicObjects.MainFormFill(false, false, true, false, false, false);
                    break;
                case 3:

                    classDynamicObjects.MainFormFill(true, false, false, false, false, false);
                    break;
                case 4:

                    classDynamicObjects.MainFormFill(false, false,false, true, false, false);
                    break;
                case 5:

                    classDynamicObjects.MainFormFill(true, true, true, true, true, true);
                    break;

                case 6:

                    classDynamicObjects.MainFormFill(false, false, false, false, false, false);
                    break;
            }
            
        }

        private void конфигурацияПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm conFrm = new ConnectionForm();
            conFrm.ShowDialog();

        }
    }
}
