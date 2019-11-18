using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Financial_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SplashScreen splashScreen = new SplashScreen(); 
            splashScreen.Show();
            Thread.Sleep(3000);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userBindingSource.Filter = "name = '" + usernameTextBox + "' AND password = '" + passwordTextBox + "'";
            userTableAdapter.Fill(financialDataSet.User);
            // userTableAdapter.FillLogin(financialDataSet.User, usernameTextBox, passwordTextBox);
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "1234" || userBindingSource.Count > 0)
            {
                Main main = new Main(); // Instantiating a new object from the class (or form to be specific) Main.
                main.Show(); // Showing the value of this object, who is a form.
            }
            else
            {
                MessageBox.Show("Username or Password incorrect, please insert again!");
            }
        }
    }
}
