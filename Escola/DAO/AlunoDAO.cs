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
    public class AlunoDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            Aluno aluno = (Aluno)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tb_aluno" +
                    "(aluno_email, aluno_senha, aluno_nome, aluno_nascimento, aluno_idade, aluno_cpf, aluno_nome_social, aluno_genero)" +
                    "VALUES(@email, @senha, @nome, @nascimento, @idade, @cpf, @nome_Social, @genero)";

                cmd.Parameters.AddWithValue("@email", aluno.Email);
                cmd.Parameters.AddWithValue("@senha", aluno.Senha);
                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@nascimento", aluno.Nascimento);
                cmd.Parameters.AddWithValue("@idade", aluno.Idade());
                cmd.Parameters.AddWithValue("@cpf", aluno.Cpf);
                cmd.Parameters.AddWithValue("@nome_social", aluno.Nome_social);
                cmd.Parameters.AddWithValue("@genero", aluno.Genero);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                aluno.Id = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return aluno;
        }

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
