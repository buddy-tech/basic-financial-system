using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Financial_System
{
    public partial class RegisterIndex : Form
    {
        public RegisterIndex()
        {
            InitializeComponent();
        }

        private void userRegisterButton_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
            Close();
        }

        // Returns to Main page.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Close();
        }
    }
}
