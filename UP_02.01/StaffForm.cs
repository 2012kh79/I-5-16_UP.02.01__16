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
            Thread thread = new Thread(dgvOrderFill);
            thread.Start();
            Thread thread1 = new Thread(dgvTabel_rabFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvRoleFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvSotrudnikFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvAccountFill);
            thread4.Start();
        }

        public void dgvTabel_rabFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtTabel_rab_vremeniFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvTabel_rab.DataSource = tables.dtTabel_rab_vremeni;
                    dgvTabel_rab.Columns[0].Visible = false;
                    dgvTabel_rab.Columns[1].HeaderText = "Количество отработанных дней";
                    dgvTabel_rab.Columns[2].HeaderText = "Количество выходных дней";
                    dgvTabel_rab.Columns[3].HeaderText = "Командировки";
                    dgvTabel_rab.Columns[4].HeaderText = "Отпуска";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvOrderFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtDoljnostFill();
                    dgvOrder.DataSource = tables.dtDoljnost;
                    dgvOrder.Columns[0].Visible = false;
                    dgvOrder.Columns[1].HeaderText = "Занимаемая должность";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvRoleFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtRoleFill();
                    dgvRole.DataSource = tables.dtRole;
                    dgvRole.Columns[0].Visible = false;
                    dgvRole.Columns[1].HeaderText = "Занимаемая роль";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvSotrudnikFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtSotrudnikFill();
                    dgvSotr.DataSource = tables.dtSotrudnik;
                    classStaffForm.cmbIDPostavshik.DataSource = tables.dtSotrudnik;
                    classStaffForm.cmbIDDogovor.DataSource = tables.dtDogovor;
                    dgvSotr.Columns[0].Visible = false;
                    dgvSotr.Columns[1].HeaderText = "Табельный номер сотрудника";
                    dgvSotr.Columns[2].Visible = false;
                    dgvSotr.Columns[3].Visible = false;
                    dgvSotr.Columns[4].Visible = false;
                    dgvSotr.Columns[5].HeaderText = "Табель рабочего времени";
                    dgvSotr.Columns[6].HeaderText = "Договор";
                    dgvSotr.Columns[7].HeaderText = "Аккаунт";
                    dgvSotr.Columns[8].HeaderText = "Полное имя сотрудника";
                    dgvSotr.Columns[9].Visible = false;
                    dgvSotr.Columns[10].Visible = false;
                    dgvSotr.Columns[11].Visible = false;
                    dgvSotr.Columns[12].Visible = false;
                    dgvSotr.Columns[13].Visible = false;
                    dgvSotr.Columns[14].Visible = false;
                    dgvSotr.Columns[15].Visible = false;
                    dgvSotr.Columns[16].Visible = false;
                    dgvSotr.Columns[17].Visible = false;
                    dgvSotr.Columns[18].Visible = false;
                    dgvSotr.Columns[19].Visible = false;
                    //classStaffForm.cmbIDTabel_rab_vremeni.DisplayMember = "Tabel_rab_vremeni";
                    //classStaffForm.cmbIDTabel_rab_vremeni.ValueMember = "Tab_rab_vremeni_ID";
                    classStaffForm.cmbIDDogovor.DisplayMember = "Dogovor";
                    classStaffForm.cmbIDDogovor.ValueMember = "Dogovor_ID";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvAccountFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtAccountFill();
                    dgvAccount.DataSource = tables.dtAccount;
                    classStaffForm.cmbIDRole.DataSource = tables.dtAccount;
                    dgvAccount.Columns[0].Visible = false;
                    dgvAccount.Columns[1].HeaderText = "Логин";
                    dgvAccount.Columns[2].HeaderText = "Пароль";
                    dgvAccount.Columns[3].HeaderText = "Роль";
                    classStaffForm.cmbIDRole.DisplayMember = "Role";
                    classStaffForm.cmbIDRole.ValueMember = "Role_ID";
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
                    for (int i = classStaffForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classStaffForm.pnlTextBox.Controls[i];
                        classStaffForm.pnlTextBox.Controls.RemoveAt(i);
                        classStaffForm.Staff_Tab_rab_vremeniFormFill();
                    }
                    break;
                case 1:
                    for (int i = classStaffForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classStaffForm.pnlTextBox.Controls[i];
                        classStaffForm.pnlTextBox.Controls.RemoveAt(i);
                        classStaffForm.StaffDolj_FormFill();
                    }
                    break;
                case 2:
                    for (int i = classStaffForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classStaffForm.pnlTextBox.Controls[i];
                        classStaffForm.pnlTextBox.Controls.RemoveAt(i);
                        classStaffForm.Staff_RoleFormFill();
                    }
                    break;
                case 3:
                    for (int i = classStaffForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classStaffForm.pnlTextBox.Controls[i];
                        classStaffForm.pnlTextBox.Controls.RemoveAt(i);
                        classStaffForm.Staff_SotrFormFill();
                    }
                    break;
                case 4:
                    for (int i = classStaffForm.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classStaffForm.pnlTextBox.Controls[i];
                        classStaffForm.pnlTextBox.Controls.RemoveAt(i);
                        classStaffForm.Staff_RoleFormFill();
                    }
                    break;
            }
        }

        private void dgvTabel_rab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classStaffForm.NewIdTovar_na_sklade = (dgvTabel_rab.CurrentRow.Index + 1).ToString();
            classStaffForm.tbOtrDays.Text = dgvTabel_rab.CurrentRow.Cells[1].Value.ToString();
            classStaffForm.tbVixDays.Text = dgvTabel_rab.CurrentRow.Cells[2].Value.ToString();
            classStaffForm.tbKomandirivki.Text = dgvTabel_rab.CurrentRow.Cells[3].Value.ToString();
            classStaffForm.tbOtpuska.Text = dgvTabel_rab.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classStaffForm.NewIdDolj = (dgvOrder.CurrentRow.Index + 1).ToString();
            classStaffForm.tbDoljnost.Text = dgvOrder.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classStaffForm.NewIdRole = (dgvRole.CurrentRow.Index + 1).ToString();
            classStaffForm.tbRole.Text = dgvRole.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvSotr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classStaffForm.NewIdSotr = (dgvSotr.CurrentRow.Index + 1).ToString();
            classStaffForm.tbNomberSotr.Text = dgvSotr.CurrentRow.Cells[1].Value.ToString();
            //classStaffForm.cmbIDPostTovara.SelectedValue = dgvSotr.CurrentRow.Cells[1].ToString();
            classStaffForm.cmbIDDogovor.SelectedValue = dgvSotr.CurrentRow.Cells[2].ToString();
            classStaffForm.tbTypeAccount.Text = dgvSotr.CurrentRow.Cells[3].Value.ToString();
            classStaffForm.tbFamSotr.Text = dgvSotr.CurrentRow.Cells[4].Value.ToString();
            classStaffForm.tbNamehSotr.Text = dgvSotr.CurrentRow.Cells[4].Value.ToString();
            classStaffForm.tbOtchSotr.Text = dgvSotr.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classStaffForm.NewIdAccount = (dgvAccount.CurrentRow.Index + 1).ToString();
            classStaffForm.tbLogin.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            classStaffForm.tbParol.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            classStaffForm.cmbIDRole.SelectedValue = dgvAccount.CurrentRow.Cells[3].ToString();
        }
    }
}
