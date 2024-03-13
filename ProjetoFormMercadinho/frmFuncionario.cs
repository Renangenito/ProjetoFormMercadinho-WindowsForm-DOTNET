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
    public partial class frmFuncionario : Form
    {
        bool editar = true;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Cpf_Leave(object sender, EventArgs e)
        {
        }
        /*private void ObterDadosFuncionarios()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "SELECT * FROM Funcionarios WHERE CPF = @cpfDigitado";

           
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@cpfDigitado", mskCpf.Text);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                mskCpf.Text = reader[0].ToString();
                txtRg.Text = reader[1].ToString();
                txtNome.Text = reader[2].ToString();
                mskDataNascimento.Text = reader[3].ToString();
                txtTelefone.Text = reader[4].ToString();
                txtCelular.Text = reader[5].ToString();
                txtLogradouro.Text = reader[6].ToString();
                txtNumero.Text = reader[7].ToString();
                txtComplemento.Text = reader[8].ToString();
                txtCidade.Text = reader[9].ToString();
                txtEstado.Text = reader[10].ToString();
                mskDataInclusao.Text = reader[11].ToString();
                mskDataAlteracao.Text = reader[12].ToString();
                
                if (Convert.ToBoolean(reader[13].ToString()))
                {
                    cbbAtivo.SelectedIndex = 0;
                }
                else
                {
                    cbbAtivo.SelectedIndex = 1;
                }

                mskCpf.Enabled = false;
                editar = true;


            }
            else
            {
              DialogResult xpto =  MessageBox.Show("CPF não registrado! Deseja cadastrar?", "Manutenção de funcionarios", MessageBoxButtons.YesNo);
                if(xpto == DialogResult.Yes)
                {
                    mskCpf.Enabled = false;
                    editar = false;
                }
                else if(xpto == DialogResult.No)
                {
                    mskCpf.Enabled = true;
                    mskCpf.Text = null;
                    mskCpf.Focus();
                }
            
            }
            reader.Close();
            connection.Close();
            connection.Dispose();


        }*/

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioModel modelo = new FuncionarioModel();
            modelo.Cpf = mskCpf.Text;
            modelo.Rg = txtRg.Text;
            modelo.Nome = txtNome.Text;
            modelo.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
            modelo.Telefone = txtTelefone.Text;
            modelo.Celular = txtCelular.Text;
            modelo.Logradouro = txtLogradouro.Text;
            modelo.Numero = txtNumero.Text;
            modelo.Complemento = txtComplemento.Text;
            modelo.Cidade = txtCidade.Text;
            modelo.Estado = txtEstado.Text;
            modelo.Ativo = cbbAtivo.Text.ToUpper() == "SIM" ? true : false;

            if (editar == true)
            {
                new FuncionarioDB().Alterar(modelo);
                MessageBox.Show("Funcionario alterado com sucesso!");
            }
            else
            {
                new FuncionarioDB().Inserir(modelo);
                MessageBox.Show("Funcionario cadastrado com sucesso!");

            }
            this.Controls.Clear();
            InitializeComponent();


        }

        /*private void Inserir()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "INSERT INTO Funcionarios VALUES (@CPF, @RG, @Nome, @DataNascimento, @Telefone, @Celular, @Logradouro, @Numero, @Complemento, @Cidade, @Estado, @DataInclusao, null, @Ativo)";
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@CPF", mskCpf.Text);
            command.Parameters.AddWithValue("@RG", txtRg.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(mskDataNascimento.Text));
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            command.Parameters.AddWithValue("@Celular", txtCelular.Text);
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
            connection.Close();
            connection.Dispose();

            this.Controls.Clear();
            InitializeComponent();
        }*/


        /*private void Alterar()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "UPDATE Funcionarios SET Ativo = @Ativo, RG = @Rg, Nome = @Nome, DataNascimento = @DataNascimento, Telefone = @Telefone, Celular = @Celular, Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Cidade = @Cidade, Estado = @Estado, DataAlteracao = @DataAlteracao WHERE CPF = @Cpf";
            SqlCommand command = new SqlCommand(queryString, connection);
            
            command.Parameters.AddWithValue("@Cpf", mskCpf.Text);
            command.Parameters.AddWithValue("@Rg", txtRg.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@DataNascimento", mskDataNascimento.Text);
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            command.Parameters.AddWithValue("@Celular", txtCelular.Text);
            command.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
            command.Parameters.AddWithValue("@Numero", txtNumero.Text);
            command.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
            command.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            command.Parameters.AddWithValue("@Estado", txtEstado.Text);
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
            connection.Close();
            connection.Dispose();

            this.Controls.Clear();
            InitializeComponent();
        }*/

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            FuncionarioModel funcionarioModelRetorno = new FuncionarioDB().ObterDadosFuncionarios(mskCpf.Text);

            if (funcionarioModelRetorno.Cpf != null)
            {
                txtRg.Text = funcionarioModelRetorno.Rg;
                txtNome.Text = funcionarioModelRetorno.Nome;
                mskDataNascimento.Text = funcionarioModelRetorno.DataNascimento.ToString();
                txtTelefone.Text = funcionarioModelRetorno.Telefone;
                txtCelular.Text = funcionarioModelRetorno.Celular;
                txtLogradouro.Text = funcionarioModelRetorno.Logradouro;
                txtNumero.Text = funcionarioModelRetorno.Numero;
                txtComplemento.Text = funcionarioModelRetorno.Complemento;
                txtCidade.Text = funcionarioModelRetorno.Cidade;
                txtEstado.Text = funcionarioModelRetorno.Estado;
                mskDataInclusao.Text = funcionarioModelRetorno.DataInclusao.ToString();
                mskDataAlteracao.Text = funcionarioModelRetorno.DataAlteracao.ToString();
                // cbbAtivo.Text = fornecedorModelRetorno.Ativo.ToString().ToUpper() == "TRUE" ? "Sim" : "Não";
                cbbAtivo.Text = funcionarioModelRetorno.Ativo ? "Sim" : "Não";

                editar = true;
            }
            else
            {
                DialogResult xpto = MessageBox.Show("CPF não registrado! Deseja cadastrar?", "Manutenção de funcionarios", MessageBoxButtons.YesNo);
                if (xpto == DialogResult.Yes)
                {
                    mskCpf.Enabled = false;
                    editar = false;
                }
                else if (xpto == DialogResult.No)
                {
                    mskCpf.Enabled = true;
                    mskCpf.Text = null;
                    mskCpf.Focus();
                }
            }

        }
    }
}
