using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UP_02._01
{
    public partial class AuthorizForm : Form
    {

        public static byte Role_ID;
        

        public static SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public AuthorizForm()
        {
            InitializeComponent();
        }


        private void btReg_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void btVhod_Click(object sender, EventArgs e)
        {
            Registry_Class registry = new Registry_Class();
            registry.Registry_Set("31.31.198.31", "u0695785_TatarBase", "u0695785_TatarBase", "TatarBase123IIL");
            Authoriz(tbLogin.Text, tbPass.Text);
            if (Role_ID != 0)
            {
                switch (Role_ID)
                {
                    case 6:

                        DynamicObjects classDynamicObjects = new DynamicObjects();
                        classDynamicObjects.MainFormFill(false, true, false, false, false, false);
                        break;
                }
                MainForm mainFrm = new MainForm();
                this.Hide();
                mainFrm.Show();
            }
        }

        public static void Authoriz(string User, string Pass)
        {

            command.CommandText = "Select [dbo].[account].[role_id] " +
                                  "from [dbo].[account] " +
                                  "where ([dbo].[account].[login_acc] = '" + User + "')" +
                                  "and ([dbo].[account].[password_acc] = '" + RegistrationForm.Hash(Pass) + "')";
            Registry_Class.sql.Open();
            try
            {
                Role_ID = Convert.ToByte(command.ExecuteScalar().ToString());
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}

