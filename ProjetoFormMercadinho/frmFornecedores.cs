using ProjetoFormMercadinho.Database;
using ProjetoFormMercadinho.Model;
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
    public partial class frmFornecedores : Form
    {
        bool editar = true;
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {

        }

        private void txtId_Leave(object sender, EventArgs e)
        {

        }


        private void mskCnpj_Leave(object sender, EventArgs e)
        {
           FornecedorModel fornecedorModelRetorno = new FornecedorDB().ObterDadosFornecedores(mskCnpj.Text);

            if (fornecedorModelRetorno.CNPJ != null)
            {
                txtId.Text = fornecedorModelRetorno.Id;
                txtNome.Text = fornecedorModelRetorno.Nome;
                mskTelefone.Text = fornecedorModelRetorno.Telefone;
                txtLogradouro.Text = fornecedorModelRetorno.Logradouro;
                txtNumero.Text = fornecedorModelRetorno.Numero;
                txtComplemento.Text = fornecedorModelRetorno.Complemento;
                txtCidade.Text = fornecedorModelRetorno.Cidade;
                txtEstado.Text = fornecedorModelRetorno.Estado;
                mskDataInclusao.Text = fornecedorModelRetorno.DataInclusao.ToString();
                mskDataAlteracao.Text = fornecedorModelRetorno.DataAlteracao.ToString();
                // cbbAtivo.Text = fornecedorModelRetorno.Ativo.ToString().ToUpper() == "TRUE" ? "Sim" : "Não";
                cbbAtivo.Text = fornecedorModelRetorno.Ativo ? "Sim" : "Não";

                editar = true;
            }
            else
            {
                DialogResult xpto = MessageBox.Show("CNPJ não registrado! Deseja cadastrar?", "Manutenção de funcionarios", MessageBoxButtons.YesNo);
                if (xpto == DialogResult.Yes)
                {
                    mskCnpj.Enabled = false;
                    editar = false;
                }
                else if (xpto == DialogResult.No)
                {
                    mskCnpj.Enabled = true;
                    mskCnpj.Text = null;
                    mskCnpj.Focus();
                }
            }

        }







        /*private void ObterDadosFornecedores()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            try
            {
                string queryString = "SELECT * FROM Fornecedores WHERE CNPJ = @cnpjDigitado";

                SqlCommand command = new SqlCommand(queryString, connection);

                _ = command.Parameters.AddWithValue("@cnpjDigitado", mskCnpj.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtId.Text = reader[0].ToString();
                    mskCnpj.Text = reader[1].ToString();
                    txtNome.Text = reader[2].ToString();
                    mskTelefone.Text = reader[3].ToString();
                    txtLogradouro.Text = reader[4].ToString();
                    txtNumero.Text = reader[5].ToString();
                    txtComplemento.Text = reader[6].ToString();
                    txtCidade.Text = reader[7].ToString();
                    txtEstado.Text = reader[8].ToString();
                    mskDataInclusao.Text = reader[9].ToString();
                    mskDataAlteracao.Text = reader[10].ToString();

                    if (Convert.ToBoolean(reader[11].ToString()))
                    {
                        cbbAtivo.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbAtivo.SelectedIndex = 1;
                    }

                    mskCnpj.Enabled = false;
                    editar = true;


                }
                else
                {
                    DialogResult xpto = MessageBox.Show("CNPJ não registrado! Deseja cadastrar?", "Manutenção de funcionarios", MessageBoxButtons.YesNo);
                    if (xpto == DialogResult.Yes)
                    {
                        mskCnpj.Enabled = false;
                        editar = false;
                    }
                    else if (xpto == DialogResult.No)
                    {
                        mskCnpj.Enabled = true;
                        mskCnpj.Text = null;
                        mskCnpj.Focus();
                    }

                }
                reader.Close();
              

            }
            catch (Exception)
            {
                MessageBox.Show("Procure o suporte técnico!");
                *//*throw;*//*
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }


        }*/

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FornecedorModel modelo = new FornecedorModel();
            modelo.Id = txtId.Text;
            modelo.CNPJ = mskCnpj.Text;
            modelo.Nome = txtNome.Text;
            modelo.Telefone = mskTelefone.Text;
            modelo.Logradouro = txtLogradouro.Text;
            modelo.Numero = txtNumero.Text;
            modelo.Complemento = txtComplemento.Text;
            modelo.Cidade = txtCidade.Text;
            modelo.Estado = txtEstado.Text;
            modelo.Ativo = cbbAtivo.Text.ToUpper() == "SIM" ? true : false;

            if (editar == true)
            {
                new FornecedorDB().Alterar(modelo);
                MessageBox.Show("Fornecedor alterado com sucesso!");
            }
            else
            {
                new FornecedorDB().Inserir(modelo);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");

            }
            this.Controls.Clear();
            InitializeComponent();
        }


       /* private void Inserir()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            try
            {
            string queryString = "INSERT INTO Fornecedores VALUES (@CNPJ, @Nome, @Telefone, @Logradouro, @Numero, @Complemento, @Cidade, @Estado, @DataInclusao, null, @Ativo)";
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@CNPJ", mskCnpj.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
            command.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
            command.Parameters.AddWithValue("@Numero", txtNumero.Text);
            command.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
            command.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            command.Parameters.AddWithValue("@Estado", txtEstado.Text);
            command.Parameters.AddWithValue("@DataInclusao", DateTime.Now);
            command.Parameters.AddWithValue("@Ativo", cbbAtivo.Text.ToUpper() == "SIM" ? true : false);

            connection.Open();
            command.ExecuteNonQuery();
            *//*connection.Close();
            connection.Dispose();*//*

            MessageBox.Show("Funcionário cadastrado com sucesso!");

            
            this.Controls.Clear();
            InitializeComponent();

            }
            catch (Exception)
            {
                *//*throw;*//*
                MessageBox.Show("Erro ao inserir um novo fornecedor!");
                
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }*/
        /*private void Alterar()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();
            try
            {
                

                string queryString = "UPDATE Fornecedores SET CNPJ = @Cnpj, Ativo = @Ativo, Nome = @Nome, Telefone = @Telefone, Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Cidade = @Cidade, Estado = @Estado, DataInclusao = @DataInclusao, DataAlteracao = @DataAlteracao WHERE Id = @Id";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Id", txtId.Text);
                command.Parameters.AddWithValue("@Cnpj", mskCnpj.Text);
                command.Parameters.AddWithValue("@Nome", txtNome.Text);
                command.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
                command.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
                command.Parameters.AddWithValue("@Numero", txtNumero.Text);
                command.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
                command.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                command.Parameters.AddWithValue("@Estado", txtEstado.Text);
                command.Parameters.AddWithValue("@DataInclusao", Convert.ToDateTime(mskDataInclusao.Text));
                command.Parameters.AddWithValue("@DataAlteracao", DateTime.Now);

                if (cbbAtivo.Text.ToUpper() == "SIM")
                {
                    command.Parameters.AddWithValue("@Ativo", true);
                }
                else
                {
                    command.Parameters.AddWithValue("@Ativo", false);
                }

                //command.Parameters.AddWithValue("@Ativo", cbbAtivo.Text.ToUpper() == "SIM" ? true : false);  //Ternário
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado com sucesso!!");
                

                this.Controls.Clear();
                InitializeComponent();
            }
            catch (Exception)
            {
                MessageBox.Show("Ao tentar alterar o fornecedor tivemos um erro, tente novamente");
                *//*throw;*//*
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }*/
    }
}
