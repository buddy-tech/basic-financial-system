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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void registerIndexButton_Click(object sender, EventArgs e)
        {
            RegisterIndex registerIndex = new RegisterIndex();
            registerIndex.Show();
            Close();
        }
    }
}
