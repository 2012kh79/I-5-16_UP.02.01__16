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
    public partial class SupplyForm : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects classDynamicObjects = new DynamicObjects();
        public SupplyForm()
        {
            InitializeComponent();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            classDynamicObjects.aggregateSupplyForm = this;
            classDynamicObjects.SupplyFormFill();
            Thread thread = new Thread(dgvTovar_na_skladeFill);
            thread.Start();
            Thread thread1 = new Thread(dgvPost_tovarFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvFirma_postavkiFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvPostavshikiFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvPostavkiFill);
            thread4.Start();
        }

        public void dgvTovar_na_skladeFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtTovar_na_skladeFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvTovar_na_sklade.DataSource = tables.dtTovar_na_sklade;
                    dgvTovar_na_sklade.Columns[0].Visible = false;
                    dgvTovar_na_sklade.Columns[1].HeaderText = "Срок хранения товара на складе";
                    dgvTovar_na_sklade.Columns[2].HeaderText = "Количество товара на складе";
                    dgvTovar_na_sklade.Columns[3].HeaderText = "Номер шкафа";
                    dgvTovar_na_sklade.Columns[4].HeaderText = "Номер полки";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvPost_tovarFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtPost_tovarFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvPost_tovar.DataSource = tables.dtPost_tovar;
                    dgvPost_tovar.Columns[0].Visible = false;
                    dgvPost_tovar.Columns[1].HeaderText = "Наименование поставленного товара";
                    dgvPost_tovar.Columns[2].HeaderText = "Количество поставленного товара";
                    dgvPost_tovar.Columns[3].HeaderText = "Цена поставленного товара";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvFirma_postavkiFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtFirma_postavkiFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvFirma_postavki.DataSource = tables.dtFirma_postavki;
                    dgvFirma_postavki.Columns[0].Visible = false;
                    dgvFirma_postavki.Columns[1].HeaderText = "Название фирмы поставки";
                    dgvFirma_postavki.Columns[2].HeaderText = "Индекс поставки";
                    dgvFirma_postavki.Columns[3].Visible = false;
                    dgvFirma_postavki.Columns[4].Visible = false;
                    dgvFirma_postavki.Columns[5].Visible = false;
                    dgvFirma_postavki.Columns[6].HeaderText = "Адрес поставки";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvPostavshikiFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtPostavshikFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvPostavshiki.DataSource = tables.dtPostavshik;
                    classDynamicObjects.cmbIDPostavshik.DataSource = tables.dtPostavshik;
                    dgvPostavshiki.Columns[0].Visible = false;
                    dgvPostavshiki.Columns[1].HeaderText = "Фамилия поставщика";
                    dgvPostavshiki.Columns[2].HeaderText = "Имя поставщика";
                    dgvPostavshiki.Columns[3].HeaderText = "Отчество поставщика";
                    dgvPostavshiki.Columns[4].HeaderText = "Фирма поставки";
                    dgvPostavshiki.Columns[5].Visible = false;
                    dgvPostavshiki.Columns[6].Visible = false;
                    dgvPostavshiki.Columns[7].Visible = false;
                    dgvPostavshiki.Columns[8].Visible = false;
                    classDynamicObjects.cmbIDPostavshik.DisplayMember = "Postavshik";
                    classDynamicObjects.cmbIDPostavshik.ValueMember = "Postavshik_ID";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvPostavkiFill()
        {
            Action action = () =>
            {
                try
                {
                    tables.dtPostavkaFill();
                    //tables.dependency.OnChange += onchangeVid_document;
                    dgvPostavki.DataSource = tables.dtPostavka;
                    classDynamicObjects.cmbIDPostavshik.DataSource = tables.dtPostavka;
                    classDynamicObjects.cmbIDTovNaSklade.DataSource = tables.dtPostavka;
                    classDynamicObjects.cmbIDPostTovara.DataSource = tables.dtPostavka;
                    dgvPostavki.Columns[0].Visible = false;
                    dgvPostavki.Columns[1].HeaderText = "Поставщик";
                    dgvPostavki.Columns[2].HeaderText = "Товар на складе";
                    dgvPostavki.Columns[3].HeaderText = "Поставленный товар";
                    dgvPostavki.Columns[4].Visible = false;
                    dgvPostavki.Columns[5].Visible = false;
                    dgvPostavki.Columns[6].Visible = false;
                    dgvPostavki.Columns[7].Visible = false;
                    dgvPostavki.Columns[8].Visible = false;
                    dgvPostavki.Columns[9].Visible = false;
                    dgvPostavki.Columns[10].Visible = false;
                    dgvPostavki.Columns[11].Visible = false;
                    dgvPostavki.Columns[12].Visible = false;
                    dgvPostavki.Columns[13].Visible = false;
                    dgvPostavki.Columns[14].Visible = false;
                    classDynamicObjects.cmbIDPostavshik.DisplayMember = "Postavshik";
                    classDynamicObjects.cmbIDPostavshik.ValueMember = "Postavshik_ID";
                    classDynamicObjects.cmbIDTovNaSklade.DisplayMember = "Tovar_na_sklade";
                    classDynamicObjects.cmbIDTovNaSklade.ValueMember = "Tovar_na_sklade_ID";
                    classDynamicObjects.cmbIDPostTovara.DisplayMember = "Post_tovar";
                    classDynamicObjects.cmbIDPostTovara.ValueMember = "Post_tovar_ID";
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
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.SupplyForm_tovar_na_skladeFill();
                    }
                    break;
                case 1:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.SupplyPostavlenny_tovar_FormFill();
                    }
                    break;
                case 2:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Supply_Firma_postavkiFormFill();
                    }
                    break;
                case 3:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Supply_Postavshik_FormFill();
                    }
                    break;
                case 4:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Supply_Postavki_FormFill();
                    }
                    break;
            }
        }

        private void dgvTovar_na_sklade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdTovar_na_sklade = (dgvTovar_na_sklade.CurrentRow.Index + 1).ToString();
            classDynamicObjects.txSrokHran.Text = dgvTovar_na_sklade.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.txKolTovNaSklade.Text = dgvTovar_na_sklade.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.txNomSkafa.Text = dgvTovar_na_sklade.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.txNomPolki.Text = dgvTovar_na_sklade.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvPost_tovar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdPost_tovar = (dgvPost_tovar.CurrentRow.Index + 1).ToString();
            classDynamicObjects.txNaimPostTovar.Text = dgvPost_tovar.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.txKolPostTovar.Text = dgvPost_tovar.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.txTsenaPostTovara.Text = dgvPost_tovar.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvFirma_postavki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdFirma_postavki = (dgvFirma_postavki.CurrentRow.Index + 1).ToString();
            classDynamicObjects.txNazvFirmPost.Text = dgvFirma_postavki.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.txIndex.Text = dgvFirma_postavki.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.txNasPunkt.Text = dgvFirma_postavki.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.txUlitsa.Text = dgvFirma_postavki.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.txDom.Text = dgvFirma_postavki.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvPostavshiki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdPostavshiki = (dgvPostavshiki.CurrentRow.Index + 1).ToString();
            classDynamicObjects.txFamPost.Text = dgvPostavshiki.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.txNamePost.Text = dgvPostavshiki.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.txOtchPost.Text = dgvPostavshiki.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.cmbIDFirmPost.SelectedValue = dgvPostavshiki.CurrentRow.Cells[4].ToString();
        }

        private void dgvPostavki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.NewIdPostavki = (dgvPostavki.CurrentRow.Index + 1).ToString();
            classDynamicObjects.cmbIDPostavshik.SelectedValue = dgvPostavki.CurrentRow.Cells[1].ToString();
            classDynamicObjects.cmbIDTovNaSklade.SelectedValue = dgvPostavki.CurrentRow.Cells[2].ToString();
            classDynamicObjects.cmbIDPostTovara.SelectedValue = dgvPostavki.CurrentRow.Cells[3].ToString();
        }
    }
}
