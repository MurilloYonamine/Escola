using Escola.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DAO
{
    public class PessoaLoginDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            throw new NotImplementedException();
        }

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            Pessoa pessoa = (Pessoa)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            string sql = "SELECT * FROM usuarios WHERE aluno_email = @nome_usuario AND aluno_senha = @senha";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                cmd.Parameters.AddWithValue("@nome_usuario", pessoa.Email);
                cmd.Parameters.AddWithValue("@senha", pessoa.Senha);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                if (rdr.Read())
                {
                    pessoa.Email = rdr[0].ToString();
                    pessoa.Senha = rdr[1].ToString();
                    pessoa.Cpf = rdr[2].ToString();
                    pessoa.Nome = rdr[3].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return pessoa;

        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
