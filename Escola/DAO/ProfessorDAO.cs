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
    public class ProfessorDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            Professor professor = (Professor)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tb_professor" + 
                    "(prof_email, prof_senha, prof_nome, prof_formacao, prof_titulacao, " +
                    "prof_nascimento, prof_idade, prof_cpf, prof_nome_social, prof_genero)" +
                    "VALUES(@email, @senha, @nome, @formacao, @titulacao, @nascimento, @idade, @cpf, @nome_Social, @genero)";

                cmd.Parameters.AddWithValue("@email", professor.Email);
                cmd.Parameters.AddWithValue("@senha", professor.Senha);
                cmd.Parameters.AddWithValue("@nome", professor.Nome);
                cmd.Parameters.AddWithValue("@formacao", professor.Formacao);
                cmd.Parameters.AddWithValue("@titulacao", professor.Titulacao);
                cmd.Parameters.AddWithValue("@nascimento", professor.Nascimento);
                cmd.Parameters.AddWithValue("@idade", professor.Idade());
                cmd.Parameters.AddWithValue("@cpf", professor.Cpf);
                cmd.Parameters.AddWithValue("@nome_social", professor.Nome_social);
                cmd.Parameters.AddWithValue("@genero", professor.Genero);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                professor.Id = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return professor;
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
