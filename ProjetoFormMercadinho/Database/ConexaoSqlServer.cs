using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFormMercadinho.Database
{
    public class ConexaoSqlServer
    {
        public static SqlConnection Conectar()
        {
            string connectionString = "Data Source=localhost,1433;User ID=sa;Password=senha@1234xxxy;Initial Catalog=DevPraticaPDVAtualizado;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
