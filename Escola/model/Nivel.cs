using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Nivel
    {
        private int nivel_id;
        private string nivel_nome;
        public int Id
        {
            get { return this.nivel_id; }
            set { nivel_id = value; }
        }
        public string Nome
        {
            get { return this.nivel_nome; }
            set { this.nivel_nome = value; }
        }

        public override string ToString()
        {
            return Id + "- " + Nome;
        }
    }
}