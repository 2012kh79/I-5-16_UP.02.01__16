using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UP_02._01
{

    public partial class RegistrationForm : Form
    {
      
        public RegistrationForm()
        {
            InitializeComponent();
            
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == tbRepeatPass.Text)
            {
                DBProcedures procedure = new DBProcedures();
                procedure.spAccount_Insert(tbLogin.Text, Hash(tbPass.Text), 1);
                MainForm mainFrm = new MainForm();
                mainFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
          
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
        
        private void btBackAuthoriz_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
            this.Hide();
        }
    }
}
