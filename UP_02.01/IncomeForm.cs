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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.aggregateIncomeForm = this;
            classDynamicObjects.IncomeFormFill();
        }
    }
}
