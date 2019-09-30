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
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void userRegisterPreviousButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Enable()
        {
            userRegisterCodeText.Enabled = false;
            userRegisterNameText.Enabled = true;
            userRegisterLevelText.Enabled = true;
            userRegisterLoginText.Enabled = true;
            userRegisterPasswordText.Enabled = true;
            userRegisterSaveButton.Enabled = true;
            userRegisterCancelButton.Enabled = true;
            userRegisterPreviousButton.Enabled = false;

        }
    }
}
