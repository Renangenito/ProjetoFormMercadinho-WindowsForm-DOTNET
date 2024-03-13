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
    public partial class frmPagamento : Form
    {
        public frmPagamento(decimal valorTotal)
        {
            InitializeComponent();
            txtTotalCompra.Text = Convert.ToString(valorTotal);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            if(txtDinheiro.Text != "")
            {
                if (Convert.ToDecimal(txtDinheiro.Text) > Convert.ToDecimal(txtTotalCompra.Text))
                {
                    txtSaldoDevedor.Text = "0,00";
                    txtTroco.Text = Convert.ToString(Convert.ToDecimal(txtDinheiro.Text) - 
                    Convert.ToDecimal(txtTotalCompra.Text));


                }
                else
                {
                    txtTroco.Text = "0,00";
                    txtSaldoDevedor.Text = Convert.ToString(Convert.ToDecimal(txtTotalCompra.Text) -
                        Convert.ToDecimal(txtDinheiro.Text));
                }
            }
            else
            {
                txtSaldoDevedor.Text = "0,00";
                txtTroco.Text = "0,00";
            }
           
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MessageBox.Show("Extrato: " + "\nTotal da Compra: " + txtTotalCompra.Text +
                "\nTotal Pago: " + txtDinheiro.Text + "\nSaldo Devedor: " + txtSaldoDevedor.Text +
                "\nTroco: " + txtTroco.Text
                );

        }
    }
}
