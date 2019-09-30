﻿using System;
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

        private void UserRegisterLoad(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.Financial.user);
        }

        private void userRegisterPreviousButton_Click(object sender, EventArgs e)
        {
            
        }

        private void userRegisterDeleteButton_Click(object sender, EventArgs e)
        {
            if(UserBindingSource.Count > 0)
            {

            }
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
            userRegisterExitButton.Enabled = false;
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

        
    }
}
