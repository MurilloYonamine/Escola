using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.classes
{
    public class BancoDeDados
    {
        static string conexao = "server=localhost;port=3306;" +
            "database=teste;uid=root;password=";
        static MySqlConnection connection;
        public MySqlConnection conectar()
        {
            connection = new MySqlConnection(conexao);
            if(!connection.State.HasFlag(System.Data.ConnectionState.Open))
            {
                connection.Close();
                connection.Open();
            }
            return connection;
        }
    }
}
