using storeSystem.Data;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace storeSystem
{
    public partial class LoginForm : Form
    {
        public delegate void LoginFormDelegate();
        public delegate void CloseFormDelegate(bool shouldExitApp);
        public event LoginFormDelegate OnUserLogin;
        public event CloseFormDelegate OnUserClose;

        private bool _shouldExitApp = true;


        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.MouseEnter += TextBoxMouseEnter;
            PasswordTextBox.MouseLeave += TextBoxMouseLeave;
            FormClosed += LoginForm_FormClosed;

        }

        private void TextBoxMouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.PasswordChar = '\0';
        }
        private void TextBoxMouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.PasswordChar = '*';
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //StoreDatabaseContext db = new StoreDatabaseContext();
            //if (UserNameTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            //{
            //    var userExist = db.Users.FirstOrDefault(u => u.UserName.Equals(UserNameTextBox.Text));
            //    if (userExist != null)
            //    {
            //        if (userExist.DoPasswordsMatch(PasswordTextBox.Text))
            //        {
            SetUserNameDisplay.username = UserNameTextBox.Text;
            OnUserLogin.Invoke();
            _shouldExitApp = false;
            this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Blogas slaptažodis");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Blogas prisijungimo vardas");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Prašome suvesti prisijungimo duomenis");
            //    }
            //}
        }
        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ar tikrai norite uždaryti programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnUserClose.Invoke(_shouldExitApp);
        }
    }   
}
