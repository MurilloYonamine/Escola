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
    public class CursoDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            Curso curso = (Curso)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tb_curso" +
                    "(curso_nome, curso_carga, modalidade_id, nivel_id)" +
                    "VALUES(@nome, @carga, @modalidade, @nivel)";

                cmd.Parameters.AddWithValue("@nome", curso.Nome);
                cmd.Parameters.AddWithValue("@carga", curso.Carga);
                cmd.Parameters.AddWithValue("@modalidade", curso.Modalidade.Id);
                cmd.Parameters.AddWithValue("@nivel", curso.Nivel.Id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                curso.Id = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return curso;
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
