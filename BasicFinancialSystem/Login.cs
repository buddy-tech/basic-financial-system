using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFinancialSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginSignInButton_Click(object sender, EventArgs e)
        {
            if(loginUsernameText.Text == "admin" && loginPasswordText.Text == "kblpt25")
            {
                PrincipalForm PrincipalForm = new PrincipalForm();
                PrincipalForm.Show();
            }
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
