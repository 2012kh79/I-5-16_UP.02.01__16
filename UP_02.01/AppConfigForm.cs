using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UP_02._01
{
    public partial class AppConfigForm : Form
    {
        decimal TM, RM, BM, LM;

        private void nudRightMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudRightMerg.Value > RM)
                pnText.Width -= (int)nudRightMerg.Value;
            else
                pnText.Width += (int)nudRightMerg.Value;
            RM = nudRightMerg.Value;
        }

        private void nudLeftMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudLeftMerg.Value > LM)
            {
                pnText.Width -= (int)nudLeftMerg.Value;
                pnText.Left += (int)nudLeftMerg.Value;
            }
            else
            {
                pnText.Width += (int)nudLeftMerg.Value;
                pnText.Left -= (int)nudLeftMerg.Value;
            }
            LM = nudLeftMerg.Value;
        }

        private void nudBottomMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudBottomMerg.Value > BM)
                pnText.Height -= (int)nudBottomMerg.Value;
            else
                pnText.Height += (int)nudBottomMerg.Value;
            BM = nudBottomMerg.Value;
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lbPath.Text = folderBrowserDialog1.SelectedPath + "\\Отчёты\\";
        }

        private void AppConfig_Load(object sender, EventArgs e)
        {
            registry.ConfigurationGet();
            lbPath.Text = Registry_Class.DirPath;
            nudTopMerg.Value = (decimal)Registry_Class.DocTM;
            nudRightMerg.Value = (decimal)Registry_Class.DocRM;
            nudBottomMerg.Value = (decimal)Registry_Class.DocBM;
            nudLeftMerg.Value = (decimal)Registry_Class.DocLM;
            TM = nudTopMerg.Value;
            RM = nudRightMerg.Value;
            BM = nudBottomMerg.Value;
            LM = nudLeftMerg.Value;

        }

        Registry_Class registry = new Registry_Class();

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DocumentSave();
        }

        public AppConfigForm()
        {
            InitializeComponent();
        }

        private void nudTopMerg_ValueChanged(object sender, EventArgs e)
        {

            if (nudTopMerg.Value > TM)
            {
                pnText.Height -= (int)nudTopMerg.Value;
                pnText.Top += (int)nudTopMerg.Value;
            }
            else
            {
                pnText.Height += (int)nudTopMerg.Value;
                pnText.Top -= (int)nudTopMerg.Value;
            }
            TM = nudTopMerg.Value;

        }

        private void DocumentSave()
        {
            string document_default_path = "";
            switch (lbPath.Text == "")
            {
                case (true):
                    document_default_path =
                        "C:\\Users\\" + SystemInformation.UserName
                                      + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = lbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            registry.DocumentConfigurationSet(lbPath.Text, nudLeftMerg.Value,
                nudTopMerg.Value,
                nudRightMerg.Value, nudBottomMerg.Value);
        }
    }
}
