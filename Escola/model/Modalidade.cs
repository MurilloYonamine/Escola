using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Modalidade
    {
        private int id_modalidade;
        private string nome_modalidade;

        public int Id
        {
            get { return this.id_modalidade; }
            set { id_modalidade = value; }
        }
        public string Nome
        {
            get { return this.nome_modalidade; }
            set { this.nome_modalidade = value; }
        }
        public override string ToString()
        {
            return Id + "- " + Nome;
        }
    }
}
