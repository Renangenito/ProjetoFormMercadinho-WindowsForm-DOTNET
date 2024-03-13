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
    public partial class frmClientes : Form
    {
        bool editar = true;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            ClienteModel clienteModelRetoron = new ClienteDB().ObterDadosClientes(mskCpf.Text);
            if (clienteModelRetoron.Cpf != null)
            {
                mskCpf.Text = clienteModelRetoron.Cpf;
                txtRg.Text = clienteModelRetoron.Rg;
                txtNome.Text = clienteModelRetoron.Nome;
                mskTelefone.Text = clienteModelRetoron.Telefone;
                mskCelular.Text = clienteModelRetoron.Celular;
                txtLogradouro.Text = clienteModelRetoron.Logradouro;
                txtNumero.Text = clienteModelRetoron.Numero;
                txtComplemento.Text = clienteModelRetoron.Complemento;
                txtCidade.Text = clienteModelRetoron.Cidade;
                txtEstado.Text = clienteModelRetoron.Estado;
                mskDataInclusao.Text = clienteModelRetoron.DataInclusao.ToString();
                mskDataAlteracao.Text = clienteModelRetoron.DataAlteracao.ToString();
                // cbbAtivo.Text = fornecedorModelRetorno.Ativo.ToString().ToUpper() == "TRUE" ? "Sim" : "Não";
                cbbAtivo.Text = clienteModelRetoron.Ativo ? "Sim" : "Não";

                editar = true;
            }
            else
            {
                DialogResult xpto = MessageBox.Show("CNPJ não registrado! Deseja cadastrar?", "Manutenção de funcionarios", MessageBoxButtons.YesNo);
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
        /*private void ObterDadosFuncionarios()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "SELECT * FROM Clientes WHERE CPF = @cpfDigitado";


            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@cpfDigitado", mskCpf.Text);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                mskCpf.Text = reader[0].ToString();
                txtRg.Text = reader[1].ToString();
                txtNome.Text = reader[2].ToString();
                mskTelefone.Text = reader[3].ToString();
                mskCelular.Text = reader[4].ToString();
                txtLogradouro.Text = reader[5].ToString();
                txtNumero.Text = reader[6].ToString();
                txtComplemento.Text = reader[7].ToString();
                txtCidade.Text = reader[8].ToString();
                txtEstado.Text = reader[9].ToString();
                mskDataInclusao.Text = reader[10].ToString();
                mskDataAlteracao.Text = reader[11].ToString();

                if (Convert.ToBoolean(reader[12].ToString()))
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
            reader.Close();
            connection.Close();
            connection.Dispose();

        }*/

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ClienteModel modelo = new ClienteModel();

                modelo.Cpf = mskCpf.Text;
                modelo.Rg = txtRg.Text;
                modelo.Nome = txtNome.Text;
                modelo.Telefone = mskTelefone.Text;
                modelo.Celular = mskCelular.Text;
                modelo.Logradouro = txtLogradouro.Text;
                modelo.Numero = txtNumero.Text;
                modelo.Complemento = txtComplemento.Text;
                modelo.Cidade = txtCidade.Text;
                modelo.Estado = txtEstado.Text;
                modelo.Ativo = cbbAtivo.Text.ToUpper() == "SIM" ? true : false;


                if (editar == true)
                {
                    new ClienteDB().Alterar(modelo);
                    MessageBox.Show("Fornecedor alterado com sucesso!");
                }
                else
                {
                    new ClienteDB().Inserir(modelo);
                    MessageBox.Show("Fornecedor cadastrado com sucesso!");

                }
                this.Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a alteração"+""+ ex.Message);
                throw;
            }
        }
    
        /*private void Inserir()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "INSERT INTO Clientes VALUES (@CPF, @RG, @Nome, @Telefone, @Celular, @Logradouro, @Numero, @Complemento, @Cidade, @Estado, @DataInclusao, null, @Ativo)";
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@CPF", mskCpf.Text);
            command.Parameters.AddWithValue("@RG", txtRg.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
            command.Parameters.AddWithValue("@Celular", mskCelular.Text);
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
       /* private void Alterar()
        {
            SqlConnection connection = ConexaoSqlServer.Conectar();

            string queryString = "UPDATE Clientes SET Ativo = @Ativo, RG = @Rg, Nome = @Nome, Telefone = @Telefone, Celular = @Celular, Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Cidade = @Cidade, Estado = @Estado, DataAlteracao = @DataAlteracao WHERE CPF = @Cpf";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Cpf", mskCpf.Text);
            command.Parameters.AddWithValue("@Rg", txtRg.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
            command.Parameters.AddWithValue("@Celular", mskCelular.Text);
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

        private void mskCpf_Leave_1(object sender, EventArgs e)
        {

        }
    }
}
