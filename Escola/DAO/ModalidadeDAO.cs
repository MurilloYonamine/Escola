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
    public class ModalidadeDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Modalidade modalidade = new Modalidade();

            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM tb_modalidade";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    modalidade = new Modalidade();
                    modalidade.Id = int.Parse(rdr[0].ToString());
                    modalidade.Nome = rdr[1].ToString();
                    lista.Add(modalidade);
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
