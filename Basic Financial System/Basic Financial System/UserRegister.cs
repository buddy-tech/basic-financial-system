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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financialDataSet.User'. Você pode movê-la ou removê-la conforme necessário.
            this.userTableAdapter.Fill(this.financialDataSet.User);

        }

        private void Enable()
        {
            // Editing the enabled inputs in register process.
            idTextBox.Enabled = false;
            nameTextBox.Enabled = true;
            levelTextBox.Enabled = true;
            loginTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            // Editing the enabled buttons in register process.
            previousButton.Enabled = false;
            nextButton.Enabled = false;
            newButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
            searchButton.Enabled = false;
            exitButton.Enabled = false;
            printButton.Enabled = false;

        }


    }
}
