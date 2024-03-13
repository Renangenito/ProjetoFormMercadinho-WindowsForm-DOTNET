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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

            command.Parameters.AddWithValue("@codigoDigitado", txtCodigo.Text);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtId.Text = reader[0].ToString();
                txtCodigo.Text = reader[1].ToString();
                txtDescricao.Text = reader[2].ToString();
                txtValorUnitario.Text = reader[3].ToString();
                mskDataInclusao.Text = reader[4].ToString();
                mskDataAlteracao.Text = reader[5].ToString(); 
                
                //if(Convert.ToBoolean(reader[6].ToString()) == true)
                if(Convert.ToBoolean(reader[6].ToString()))
                {
                    cbbAtivo.SelectedIndex = 0;
                }
                else
                {
                    cbbAtivo.SelectedIndex = 1;
                }

                


            }
            reader.Close();
            connection.Close();
            connection.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Alterar();
            
        }
        private void Alterar()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "UPDATE Produtos SET Descricacao = @Descricao, ValorUnitario = @ValorUnitario, DataAlteracao = @DataAlteracao, Ativo = @Ativo WHERE Id = @Id";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            command.Parameters.AddWithValue("@ValorUnitario", Convert.ToDecimal(txtValorUnitario.Text));
            command.Parameters.AddWithValue("@DataAlteracao", DateTime.Now);

            if (cbbAtivo.Text.ToUpper() == "SIM")
            {
                command.Parameters.AddWithValue("@Ativo", true);
            }else
            {
                command.Parameters.AddWithValue("@Ativo", false);
            }

            //command.Parameters.AddWithValue("@Ativo", cbbAtivo.Text.ToUpper() == "SIM" ? true : false);  //Ternário

            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
            connection.Open();
            command.ExecuteNonQuery();

            MessageBox.Show("Registro atualizado com sucesso!!");
            connection.Close();
            connection.Dispose();

            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
