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
    public partial class BillsToReceiveRegister : Form
    {
        public BillsToReceiveRegister()
        {
            InitializeComponent();
        }

        private void billToReceiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billToReceiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialDataSet);

        }

        private void BillsToReceiveRegister_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financialDataSet.BillToReceive'. Você pode movê-la ou removê-la conforme necessário.
            this.billToReceiveTableAdapter.Fill(this.financialDataSet.BillToReceive);

        }
    }
}
