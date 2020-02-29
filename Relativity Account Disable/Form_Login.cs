using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace Relativity_Account_Disable
{
    public partial class frmLogin : Form
    {
        PrincipalContext directory = Program.directory;

        public frmLogin()
        {
            InitializeComponent();
        }

        // Login: Calls login() method
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            Login();
        }

        // Login: Calls login() if enter key is hit on the password textbox
        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Login();
        }

        // Takes textbox username, password, and authenticates against AD
        // 1) Passes credentials to OnAuthenticate() to Program.cs
        // 2) Disposese of this form
        private void Login()
        {
            // Verify the credential boxes aren't empty.
            if (string.IsNullOrWhiteSpace(txtLoginUserName.Text) || string.IsNullOrWhiteSpace(txtLoginPassword.Text))
            {
                MessageBox.Show("Username and password are required.", "Invalid Credentials");
                return;
            }

            // Validate credentials using Kerberos Encryption (ContextOptions.Sealing)
            bool validateCredentials = directory.ValidateCredentials(txtLoginUserName.Text, txtLoginPassword.Text, ContextOptions.Sealing);

            if (validateCredentials == false)
            {
                MessageBox.Show("You have typed incorrect credentials, please verify and resubmit.", "Invalid Credentials");
                return;
            }

            string username = txtLoginUserName.Text;
            string password = txtLoginPassword.Text;

            Program.OnAuthenticate(username, password);

            Dispose();
        }

        // Closing: If the user closese the login form before submitting.
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
