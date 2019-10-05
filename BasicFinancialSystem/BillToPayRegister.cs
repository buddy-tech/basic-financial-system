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
    public partial class BillToPayRegister : Form
    {
        public BillToPayRegister()
        {
            InitializeComponent();
        }

        private void billToPayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billToPayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialDataSet);

        }

        private void BillToPayRegister_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financialDataSet.BillToPay'. Você pode movê-la ou removê-la conforme necessário.
            this.billToPayTableAdapter.Fill(this.financialDataSet.BillToPay);

        }
    }
}
