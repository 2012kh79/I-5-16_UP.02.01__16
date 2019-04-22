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
    public partial class SupplyForm : Form
    {
        public SupplyForm()
        {
            InitializeComponent();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateSupplyForm = this;
            classDynamicObjects.SupplyFormFill();

            //DataBaseTables tables = new DataBaseTables();
            //tables.dtTovar_na_skladeFill();
            //tables.dependency.OnChange +=
            //dgvVidDocument.DataSource = tables.dtTovar_na_skladeFill();
        }
    }
}
