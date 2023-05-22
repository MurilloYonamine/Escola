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
    public class NivelDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Nivel nivel = new Nivel();

            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM tb_nivel";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    nivel = new Nivel();
                    nivel.Id = int.Parse(rdr[0].ToString());
                    nivel.Nome = rdr[1].ToString();
                    lista.Add(nivel);
                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
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
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
