using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            if (tbLogin.Text.Length >= 4 & tbPass.Text.Length >= 4)
            {
                
                    if (tbPass.Text == tbRepeatPass.Text)
                    {
                        Registry_Class registry = new Registry_Class();
                        registry.Registry_Set("31.31.198.31", "u0695785_TatarBase", "u0695785_TatarBase",
                            "TatarBase123IIL");
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
            else
            {
                MessageBox.Show("Длина логина и пароля должна быть больше трех символов");
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
            AuthorizForm authForm = new AuthorizForm();
            authForm.Show();
            this.Hide();
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
