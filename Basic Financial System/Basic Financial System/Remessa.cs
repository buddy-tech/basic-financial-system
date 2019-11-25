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
    public partial class Remessa : Form
    {
        public Remessa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int remessa = 1, linha = 1;
            string dataInicial, dataAtual;
            dataInicial = dateTimePicker1.Text;
            dataAtual = DateTime.Now.ToShortDateString();
            dataAtual = dataAtual.Substring(0, 2) + dataAtual.Substring(3, 2) + dataAtual.Substring(8,2);

        }
    }
}
