using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;



namespace UP_02._01
{
    public partial class DocumentChangeForm : Form
    {
        public DocumentChangeForm()
        {
            InitializeComponent();
            
        }

        public void DocumentChangeForm_Load(object sender, EventArgs e)
        {
           DynamicObjects classDynamicObjects = new DynamicObjects();
            classDynamicObjects.wqqeq = this;
            classDynamicObjects.DocumentChangeFormFill();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            
        }
    }
}
