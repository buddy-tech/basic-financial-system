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
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialDataSet);

        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financialDataSet.Customer'. Você pode movê-la ou removê-la conforme necessário.
            this.customerTableAdapter.Fill(this.financialDataSet.Customer);

        }
    }
}
