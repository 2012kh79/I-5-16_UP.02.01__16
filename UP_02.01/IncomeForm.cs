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
    public partial class IncomeForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects classIncomeForm = new DynamicObjects();
        DBProcedures procedure = new DBProcedures();
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            classIncomeForm.aggregateIncomeForm = this;
            classIncomeForm.IncomeForm_Fill();
            Thread thread = new Thread(dgvVid_documentFormFill);
            thread.Start();
            Thread thread1 = new Thread(dgvPribil_i_rashodiFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvCheck_vid_medFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvMedFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvProdaja_tovFill);
            thread4.Start();
        }

        public void dgvVid_documentFormFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtInstr_raboty_kassiraFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvVidDocument.DataSource = tables.dtInstr_raboty_kassira;
                    dgvVidDocument.Columns[0].Visible = false;
                    dgvVidDocument.Columns[1].HeaderText = "Инструкция работы кассира";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvPribil_i_rashodiFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtPribil_i_rashodiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvPribil_i_rashodi.DataSource = tables.dtPribil_i_rashodi;
                    dgvPribil_i_rashodi.Columns[0].Visible = false;
                    dgvPribil_i_rashodi.Columns[1].HeaderText = "Прибыль";
                    dgvPribil_i_rashodi.Columns[2].HeaderText = "Расходы";
                    dgvPribil_i_rashodi.Columns[3].HeaderText = "Начало отчета";
                    dgvPribil_i_rashodi.Columns[4].HeaderText = "Конец отчета";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvCheck_vid_medFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtCheck_vid_medFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvCheckVidMed.DataSource = tables.dtCheck_vid_med;
                    dgvCheckVidMed.Columns[0].Visible = false;
                    dgvCheckVidMed.Columns[1].HeaderText = "Номер чека";
                    dgvCheckVidMed.Columns[2].HeaderText = "Название медикамента";
                    dgvCheckVidMed.Columns[3].HeaderText = "Должность";
                    dgvCheckVidMed.Columns[4].HeaderText = "Сотрудник";
                    dgvCheckVidMed.Columns[5].Visible = false;
                    dgvCheckVidMed.Columns[6].Visible = false;
                    dgvCheckVidMed.Columns[7].Visible = false;
                    dgvCheckVidMed.Columns[8].Visible = false;
                    dgvCheckVidMed.Columns[9].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }
        public void dgvMedFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtMedicamentiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvMed.DataSource = tables.dtMedicamenti;
                    dgvMed.Columns[0].Visible = false;
                    dgvMed.Columns[1].HeaderText = "Количество выданных медикаментов";
                    dgvMed.Columns[2].HeaderText = "Чек выданных медикаментов";
                    dgvMed.Columns[4].HeaderText = "Номер чека";
                    dgvMed.Columns[5].HeaderText = "Название медикамента";
                    dgvMed.Columns[3].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvProdaja_tovFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtProdaja_tovaraFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvProdajaTov.DataSource = tables.dtProdaja_tovara;
                    dgvProdajaTov.Columns[0].Visible = false;
                    dgvProdajaTov.Columns[1].HeaderText = "Номер медикамента";
                    dgvProdajaTov.Columns[2].HeaderText = "Номер инструкции";
                    dgvProdajaTov.Columns[4].HeaderText = "Количество выданных медикаментов";
                    dgvProdajaTov.Columns[6].HeaderText = "Инструкция";
                    dgvProdajaTov.Columns[3].Visible = false;
                    dgvProdajaTov.Columns[5].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void tcnTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((TabControl)sender).SelectedIndex;
            switch (index)
            {
                case 0:
                    for (int i = classIncomeForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classIncomeForm.pnlTextBox.Controls[i];
                        classIncomeForm.pnlTextBox.Controls.RemoveAt(i);
                        classIncomeForm.IncomeForm_Instruction_Fill();
                    }
                    break;
                case 1:
                    for (int i = classIncomeForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classIncomeForm.pnlTextBox.Controls[i];
                        classIncomeForm.pnlTextBox.Controls.RemoveAt(i);
                        classIncomeForm.IncomeForm_Pribil_i_rashodi_Fill();
                    }
                    break;
                case 2:
                    for (int i = classIncomeForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classIncomeForm.pnlTextBox.Controls[i];
                        classIncomeForm.pnlTextBox.Controls.RemoveAt(i);
                        classIncomeForm.IncomeForm_Check_vid_med_Fill();
                        cmbComboBox_DoljFill();
                        cmbComboBox_SotrFill();
                    }
                    break;
                case 3:
                    for (int i = classIncomeForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classIncomeForm.pnlTextBox.Controls[i];
                        classIncomeForm.pnlTextBox.Controls.RemoveAt(i);
                        classIncomeForm.IncomeForm_med_Fill();
                    }
                    break;
                case 4:
                    for (int i = classIncomeForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classIncomeForm.pnlTextBox.Controls[i];
                        classIncomeForm.pnlTextBox.Controls.RemoveAt(i);
                        classIncomeForm.IncomeForm_Prodaja_tovara_Fill();
                    }
                    break;
            }
        }

        private void dgvVidDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classIncomeForm.NewIdInstruction = (dgvVidDocument.CurrentRow.Index + 1).ToString();
            classIncomeForm.tbInstrRabKassir.Text = dgvVidDocument.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvPribil_i_rashodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classIncomeForm.NewIdPribil_i_rashodi = (dgvPribil_i_rashodi.CurrentRow.Index + 1).ToString();
            classIncomeForm.tbPribil.Text = dgvPribil_i_rashodi.CurrentRow.Cells[1].Value.ToString();
            classIncomeForm.tbRashody.Text = dgvPribil_i_rashodi.CurrentRow.Cells[2].Value.ToString();
            classIncomeForm.tbNachOtcheta.Text = dgvPribil_i_rashodi.CurrentRow.Cells[3].Value.ToString();
            classIncomeForm.tbKonOtch.Text = dgvPribil_i_rashodi.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvCheckVidMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classIncomeForm.NewIdCheck_vid_med = (dgvCheckVidMed.CurrentRow.Index + 1).ToString();
            classIncomeForm.tbNomberCheckVM.Text = dgvCheckVidMed.CurrentRow.Cells[1].Value.ToString();
            classIncomeForm.tbNazvVidMed.Text = dgvCheckVidMed.CurrentRow.Cells[2].Value.ToString();
            classIncomeForm.cmbIDDoljnost.SelectedValue = Convert.ToInt32(dgvCheckVidMed.CurrentRow.Cells[3].Value);
            classIncomeForm.cmbIDSotrydnik.SelectedValue = Convert.ToInt32(dgvCheckVidMed.CurrentRow.Cells[4].Value);
        }

        private void dgvMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classIncomeForm.NewIdMed = (dgvMed.CurrentRow.Index + 1).ToString();
            classIncomeForm.tbKolVidMed.Text = dgvMed.CurrentRow.Cells[1].Value.ToString();
            classIncomeForm.cmbIDVidCheck.SelectedValue = Convert.ToInt32(dgvMed.CurrentRow.Cells[2].Value);
        }

        private void dgvProdajaTov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classIncomeForm.NewIdProdaja_tovara = (dgvProdajaTov.CurrentRow.Index + 1).ToString();
            classIncomeForm.cmbIDMedicamentov.SelectedValue = Convert.ToInt32(dgvMed.CurrentRow.Cells[1].Value);
            classIncomeForm.cmbIDInstrRabKass.SelectedValue = Convert.ToInt32(dgvMed.CurrentRow.Cells[2].Value);
        }

        public void cmbComboBox_DoljFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_dolj = new DataBaseTables();
                    //tables.dtMedicamentiFill();
                    //tables.dtInstr_raboty_kassiraFill();
                    //tables.dtCheck_vid_medFill();
                    //tables_check.dtSotrudnikFill();
                    tables_dolj.dtDoljnostFill();
                    //tables_check.dtSotrudnikFill();
                    //classIncomeForm.cmbIDSotrydnik.DataSource = tables.dtSotrudnik;
                    classIncomeForm.cmbIDDoljnost.DataSource = tables_dolj.dtDoljnost;

                    //classIncomeForm.cmbIDMedicamentov.DataSource = tables.dtMedicamenti;
                    //classIncomeForm.cmbIDInstrRabKass.DataSource = tables.dtInstr_raboty_kassira;
                    //classIncomeForm.cmbIDVidCheck.DataSource = tables.dtCheck_vid_med;

                    //classIncomeForm.cmbIDMedicamentov.DisplayMember = "Mediacament";
                    //classIncomeForm.cmbIDMedicamentov.ValueMember = "ID_medicament";
                    //classIncomeForm.cmbIDInstrRabKass.DisplayMember = "Instr_raboty_kassira";
                    //classIncomeForm.cmbIDInstrRabKass.ValueMember = "ID_Instr_raboty_kassira";
                    //classIncomeForm.cmbIDVidCheck.DisplayMember = "Check_vid_med";
                    //classIncomeForm.cmbIDVidCheck.ValueMember = "ID_Check_vid_med";
                    classIncomeForm.cmbIDDoljnost.DisplayMember = "doljnost";
                    classIncomeForm.cmbIDDoljnost.ValueMember = "id_doljnost";
                    //classIncomeForm.cmbIDSotrydnik.DisplayMember = "sotrudnik";
                    //classIncomeForm.cmbIDSotrydnik.ValueMember = "id_sotrudnik";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbComboBox_SotrFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_sotr = new DataBaseTables();
                    //tables.dtMedicamentiFill();
                    //tables.dtInstr_raboty_kassiraFill();
                    //tables.dtCheck_vid_medFill();
                    tables_sotr.dtSotrudnikFill();
                    //tables_sotr.dtDoljnostFill();
                    //tables_check.dtSotrudnikFill();
                    classIncomeForm.cmbIDSotrydnik.DataSource = tables_sotr.dtSotrudnik;
                    //classIncomeForm.cmbIDDoljnost.DataSource = tables_sotr.dtDoljnost;

                    //classIncomeForm.cmbIDMedicamentov.DataSource = tables.dtMedicamenti;
                    //classIncomeForm.cmbIDInstrRabKass.DataSource = tables.dtInstr_raboty_kassira;
                    //classIncomeForm.cmbIDVidCheck.DataSource = tables.dtCheck_vid_med;

                    //classIncomeForm.cmbIDMedicamentov.DisplayMember = "Mediacament";
                    //classIncomeForm.cmbIDMedicamentov.ValueMember = "ID_medicament";
                    //classIncomeForm.cmbIDInstrRabKass.DisplayMember = "Instr_raboty_kassira";
                    //classIncomeForm.cmbIDInstrRabKass.ValueMember = "ID_Instr_raboty_kassira";
                    //classIncomeForm.cmbIDVidCheck.DisplayMember = "Check_vid_med";
                    //classIncomeForm.cmbIDVidCheck.ValueMember = "ID_Check_vid_med";
                    //classIncomeForm.cmbIDDoljnost.DisplayMember = "doljnost";
                    //classIncomeForm.cmbIDDoljnost.ValueMember = "id_doljnost";
                    classIncomeForm.cmbIDSotrydnik.DisplayMember = "sotrudnik";
                    classIncomeForm.cmbIDSotrydnik.ValueMember = "id_sotrudnik";
                }
                catch
                {

                }
            };
            Invoke(action);
        }
    }
}
