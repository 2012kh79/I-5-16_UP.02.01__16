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
    public partial class ConnectionForm : Form
    {
        Registry_Class registry = new Registry_Class();
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            tbDataSource.Text = Registry_Class.DS;
            tbLogin.Text = Registry_Class.UI;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
           
            registry.Registry_Set(tbDataSource.Text, tbInitialCatalog.Text, tbLogin.Text, tbPassword.Text);
            Connection_check();
            //((MainForm)Owner).MainForm_Load(sender, e);

          
        }

        public void Connection_check()
        {
            registry.Registry_Get();
            try
            {
                Registry_Class.sql.Open();
                MessageBox.Show("Подключение выполнено");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
