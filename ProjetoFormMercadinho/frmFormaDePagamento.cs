using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFormMercadinho
{
    public partial class frmFormaDePagamento : Form
    {
        decimal valorTotalGlobal;
        public frmFormaDePagamento(decimal valorTotal)
        {
            valorTotalGlobal = valorTotal;
            InitializeComponent();
        }

        private void cbbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento(valorTotalGlobal);
            pagamento.ShowDialog();
            this.Hide();
            this.Close();

        }
    }
}
