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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
