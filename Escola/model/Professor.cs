using Escola.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Professor : Pessoa
    {
        private string formacao;
        private string titulacao;

        public string Formacao
        {
            get { return this.formacao; }
            set { formacao = value; }
        }
        public string Titulacao
        {
            get { return this.titulacao; }
            set { this.titulacao = value; }
        }
    }
}