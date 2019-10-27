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


    }
}
