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

        private void userRegisterDeleteButton_Click(object sender, EventArgs e)
        {
            /*if(UserBindingSource.Count > 0)
            {

            }*/
        }

        // This method closes the User Register Form and return to Principal Form.
        private void userRegisterExitButton_Click(object sender, EventArgs e)
        {
            PrincipalForm principal = new PrincipalForm();
            principal.Show();
            Close();
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
            userRegisterNextButton.Enabled = false;
            userRegisterNewButton.Enabled = false;
            userRegisterEditButton.Enabled = false;
            userRegisterDeleteButton.Enabled = false;
            userRegisterSearchButton.Enabled = false;
            userRegisterPrintButton.Enabled = false;
            userRegisterExitButton.Enabled = true;
        }

        private void Disable()
        {
            userRegisterCodeText.Enabled = false;
            userRegisterNameText.Enabled = false;
            userRegisterLevelText.Enabled = false;
            userRegisterLoginText.Enabled = false;
            userRegisterPasswordText.Enabled = false;
            userRegisterSaveButton.Enabled = false;
            userRegisterCancelButton.Enabled = false;
            userRegisterPreviousButton.Enabled = true;
            userRegisterNextButton.Enabled = true;
            userRegisterNewButton.Enabled = true;
            userRegisterEditButton.Enabled = true;
            userRegisterDeleteButton.Enabled = true;
            userRegisterSearchButton.Enabled = true;
            userRegisterPrintButton.Enabled = true;
            userRegisterExitButton.Enabled = true;
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialDataSet);

        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financialDataSet.User'. Você pode movê-la ou removê-la conforme necessário.
            Enable();
            this.userTableAdapter.Fill(this.financialDataSet.User);

        }

        // This method serves to back to previous form (principal form) in user register.
        private void userRegisterBackButton_Click(object sender, EventArgs e)
        {
            PrincipalForm principalForm = new PrincipalForm();
            principalForm.Show();
            Close();
        }
    }
}
