using ProjetoFormMercadinho.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFormMercadinho
{
    public partial class Form1 : Form

    {
        List<Produto> listaProdutos = new List<Produto>();

     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            decimal subTotal = 
           
           dgvProdutos.Rows.Add(
               txtCodigoProduto.Text,
               txtDescricaoProduto.Text,
               txtValorUnitario.Text,
               txtQuantidade.Text,
               Convert.ToDecimal(txtValorUnitario.Text) * Convert.ToInt32(txtQuantidade.Text)
               );

            txtValorTotal.Text = Convert.ToString(Convert.ToDecimal(txtValorTotal.Text) + Convert.ToDecimal(txtValorUnitario.Text)
            * Convert.ToDecimal(txtQuantidade.Text));
            limparCampos("Produto ( " + txtDescricaoProduto.Text +  " ) adicionado com sucesso!");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos("Campos limpos com sucesso!");
        }
        private void limparCampos(string mensagem)
        {
            txtCodigoProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtValorUnitario.Text = "";
            txtQuantidade.Text = "";
            txtCodigoProduto.Focus();
            MessageBox.Show(mensagem);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            frmFormaDePagamento pagto = new frmFormaDePagamento(Convert.ToDecimal(txtValorTotal.Text));
            pagto.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            ObterDadosProdutos();
        }
        private void ObterDadosProdutos()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "SELECT * FROM Produtos WHERE Codigo = @codigoDigitado";

            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@codigoDigitado", txtCodigoProduto.Text);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                txtCodigoProduto.Text = reader[1].ToString();
                txtDescricaoProduto.Text = reader[2].ToString();
                txtValorUnitario.Text = reader[3].ToString();
            }
            reader.Close();
            connection.Close();
            connection.Dispose();
         }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
