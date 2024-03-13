using ProjetoFormMercadinho.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFormMercadinho.Database
{
    internal class ClienteDB
    {
        private SqlConnection connection;
        public ClienteDB()
        {
            connection = ConexaoSqlServer.Conectar();
        }

        internal void Inserir(ClienteModel clienteModelo)
        {

            try
            {
                string queryString = "INSERT INTO Clientes VALUES (@CPF, @RG, @Nome, @Telefone, @Celular, @Logradouro, @Numero, @Complemento, @Cidade, @Estado, @DataInclusao, null, @Ativo)";
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.AddWithValue("@CPF", clienteModelo.Cpf);
                command.Parameters.AddWithValue("@RG", clienteModelo.Rg);
                command.Parameters.AddWithValue("@Nome", clienteModelo.Nome);
                command.Parameters.AddWithValue("@Telefone", clienteModelo.Telefone);
                command.Parameters.AddWithValue("@Celular", clienteModelo.Celular);
                command.Parameters.AddWithValue("@Logradouro", clienteModelo.Logradouro);
                command.Parameters.AddWithValue("@Numero", clienteModelo.Numero);
                command.Parameters.AddWithValue("@Complemento", clienteModelo.Complemento);
                command.Parameters.AddWithValue("@Cidade", clienteModelo.Cidade);
                command.Parameters.AddWithValue("@Estado", clienteModelo.Estado);
                command.Parameters.AddWithValue("@DataInclusao", DateTime.Now);
                command.Parameters.AddWithValue("@Ativo", clienteModelo.Ativo);

                connection.Open();
                command.ExecuteNonQuery();
               
            }
            catch (Exception)
            {

                /*throw;*/
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

        }

        internal ClienteModel ObterDadosClientes(string cpfDigitado)
        {

            ClienteModel modelo = new ClienteModel();

            try
            {
                string queryString = "SELECT * FROM Clientes WHERE CPF = @cpfDigitado";


                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.AddWithValue("@cpfDigitado", cpfDigitado);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    modelo.Cpf = reader["CPF"].ToString();
                    modelo.Rg = reader["RG"].ToString();
                    modelo.Nome = reader["Nome"].ToString();
                    modelo.Telefone = reader["Telefone"].ToString();
                    modelo.Celular = reader["Celular"].ToString();
                    modelo.Logradouro = reader["Logradouro"].ToString();
                    modelo.Numero = reader["Numero"].ToString();
                    modelo.Complemento = reader["Complemento"].ToString();
                    modelo.Cidade = reader["Cidade"].ToString();
                    modelo.Estado = reader["Estado"].ToString();
                    modelo.DataInclusao = Convert.ToDateTime(reader["DataInclusao"].ToString());
                    modelo.DataAlteracao = Convert.ToDateTime(reader["DataAlteracao"].ToString());


                }
                else
                {
                }
                reader.Close();
            }

            catch (Exception)
            {

                /*throw;*/
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return modelo;
        }

        internal void Alterar(ClienteModel clienteModelo)
        {
            try
            {
                string queryString = "UPDATE Clientes SET Ativo = @Ativo, RG = @Rg, Nome = @Nome, Telefone = @Telefone, Celular = @Celular, Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Cidade = @Cidade, Estado = @Estado, DataAlteracao = @DataAlteracao WHERE CPF = @Cpf";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Cpf", clienteModelo.Cpf);
                command.Parameters.AddWithValue("@Rg", clienteModelo.Rg);
                command.Parameters.AddWithValue("@Nome", clienteModelo.Nome);
                command.Parameters.AddWithValue("@Telefone", clienteModelo.Telefone);
                command.Parameters.AddWithValue("@Celular", clienteModelo.Celular);
                command.Parameters.AddWithValue("@Logradouro", clienteModelo.Logradouro);
                command.Parameters.AddWithValue("@Numero", clienteModelo.Numero);
                command.Parameters.AddWithValue("@Complemento", clienteModelo.Complemento);
                command.Parameters.AddWithValue("@Cidade", clienteModelo.Cidade);
                command.Parameters.AddWithValue("@Estado", clienteModelo.Estado);
                command.Parameters.AddWithValue("@DataAlteracao", DateTime.Now);
                command.Parameters.AddWithValue("@Ativo", clienteModelo.Ativo);


                //command.Parameters.AddWithValue("@Ativo", cbbAtivo.Text.ToUpper() == "SIM" ? true : false);  //Ternário
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                /*throw;*/
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
           

        }

   
    }
}
