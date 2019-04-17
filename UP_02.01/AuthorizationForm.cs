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
    public partial class Form1 : Form
    {

        public static byte ID_User;
        public static SqlConnection sql = new SqlConnection("Data Source = 31.31.198.31;" +
                                                            "Initial Catalog = u0695785_TatarBase;" +
                                                            "Persist Security Info=True; User ID = u0695785_TatarBase; Password=\"TatarBase123IIL\"");

        public static SqlCommand command = new SqlCommand("", sql);
        public Form1()
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
            Authoriz(tbLogin.Text, tbPass.Text);
            if (ID_User != 0)
            {
                MainForm mainFrm = new MainForm();
                mainFrm.Show();
                this.Hide();
            }
        }

        public static void Authoriz(string User, string Pass)
        {

            command.CommandText = "Select [dbo].[account].[id_account] " +
                                  "from [dbo].[account] " +
                                  "where ([dbo].[account].[login_acc] = '" + User + "')" +
                                  "and ([dbo].[account].[password_acc] = '" + RegistrationForm.Hash(Pass)+ "')";
            sql.Open();
            try
            {
                ID_User = Convert.ToByte(command.ExecuteScalar().ToString());
            }
            catch
            {

            }
            finally
            {
                sql.Close();
            }
        }
    }
}

